#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using ConstraintsModule;
using ConstraintsModule.Common;
using ConstraintsModule.Helpers;
using ConstraintsModule.Mappings.Shapes;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCAD.SolverModule;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;
using OccCode;
using ShapeFunctionsInterface.Utils;
using NaroCAD.SolverModule;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
#endregion

namespace NaroSketchAdapter
{
    public class NaroSketchSolveBuilder
    {
        public readonly ConstraintMappingList ConstraintMappingList;

        public readonly Dictionary<string, ISolverObjectMapping> ShapeSolverObjectMapping;
        private readonly Document _document;
        private IEnumerable<int> _constraints;
        private IEnumerable<int> _shapeList;
        public int FreePointsCount;
       // public List<int> softConstraints = new List<int>(); 
        public NaroSketchSolveBuilder(Document document, Node sketchNode)
        {
            _document = document;
            ShapeSolverObjectMapping = new Dictionary<string, ISolverObjectMapping>();

            ConstraintList = new ConstraintRefContainer();

            MapShapes();

            ConstraintMappingList = new ConstraintMappingList();
            DefaultConstraintsMapping.SetupFunctions(ConstraintMappingList);
        }

        private ConstraintRefContainer ConstraintList { get; set; }

        // constraints defined by the user and soft constraints
        private ConstraintRefContainer SoftConstraintsList { get; set; }

        // only user defined constraints
        private ConstraintRefContainer SetConstraintsList { get; set; }
        private Dictionary<int, int> ShapeToParamIndex { get; set; }
        private Vector Parameters;// { get; set; }

        private void MapShapes()
        {
            ShapeMapperRegister(FunctionNames.Point, new PointSolverObjectMapper());
            ShapeMapperRegister(FunctionNames.LineTwoPoints, new LineSolverObjectMapper());
            ShapeMapperRegister(FunctionNames.Circle, new CircleSolverObjectMapper());
            ShapeMapperRegister(FunctionNames.Arc, new ArcSolverObjectMapper());
        }

        public void PopulateData(IEnumerable<int> shapeList, IEnumerable<int> constraints)
        {
            _shapeList = shapeList;
            _constraints = constraints;
        }

        private void ShapeMapperRegister(string functionName, ISolverObjectMapping mapper)
        {
            ShapeSolverObjectMapping[functionName] = mapper;
        }

        private void LoadParameters(gpAx2 sketchAx2)
        {
            var shapeList = _shapeList.ToList();
            var parameters = new List<double>();
            int currentParamIndex = 0;
            var shapeIndexToParamIndex = new Dictionary<int, int>();
            var processedPoints = new List<int>();

            foreach (var shape in shapeList.Except(processedPoints))
            {
                if (NodeIsPoint(shape))
                {
                    var nodeBuilder = new NodeBuilder(_document.Root[shape]);
                    shapeIndexToParamIndex.Add(shape, currentParamIndex);
                    var point2D = GeomUtils.Point3DTo2D(sketchAx2, nodeBuilder.Dependency[1].TransformedPoint3D);
                    parameters.Add(point2D.X);
                    parameters.Add(point2D.Y);

                    currentParamIndex += 2;
                }
                if (NodeIsCircle(shape))
                {
                   // var centerIndex = currentParamIndex - 2;
                    var nodeBuilder = new NodeBuilder(_document.Root[shape]);
                    var centerPoint = nodeBuilder.Dependency[0].Reference.Index;
                    var centerIndex = shapeIndexToParamIndex[centerPoint];
                    shapeIndexToParamIndex.Add(shape, centerIndex);
                    parameters.Add(nodeBuilder.Dependency[1].Real);
                    currentParamIndex ++;
                }
            }
            
            ShapeToParamIndex = shapeIndexToParamIndex;
            Parameters = new Vector(parameters);
            //for (int i = 0; i < parameters.Count;i++ )
            //    Parameters.Add(parameters[i]);
        }

        private void GetSoftConstraints()
        {
            softConstraints.Clear();
            var lines = new List<int>();
            var arcs = new List<int>();
            var circles = new List<int>();
            foreach (var child in _document.Root.Children)
            {
                var nb = new NodeBuilder(child.Value);
                if (nb.FunctionName == FunctionNames.LineTwoPoints && _shapeList.Contains(nb.Node.Index))
                {
                    var lengthConstraintExists = false;
                    // check if current line already has a user set length constraint
                    foreach (var constraint in _constraints)
                    {
                        if (_document.Root[constraint].Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == Constraint2DNames.LineLengthFunction)
                        {
                            var linePoints = new List<int> { nb.Dependency[0].Reference.Index, nb.Dependency[1].Reference.Index };

                            var constraintPoints = new List<int>
                                                       {
                                                           _document.Root[constraint].Children[1].Get<ReferenceInterpreter>().Node.Index,
                                                           _document.Root[constraint].Children[2].Get<ReferenceInterpreter>().Node.Index
                                                       };
                            if (!constraintPoints.Except(linePoints).Any())
                            {
                                lengthConstraintExists = true;
                                break;
                            }
                        }
                    }
                    if (!lengthConstraintExists)
                        lines.Add(child.Key);
                }
                else
                    if (nb.FunctionName == FunctionNames.Arc && _shapeList.Contains(nb.Node.Index))
                    {
                        arcs.Add(child.Key);
                    }
                    else
                         if (nb.FunctionName == FunctionNames.Circle && _shapeList.Contains(nb.Dependency[0].Reference.Index))
                         {
                             circles.Add(child.Key);
                         }
            }

            //foreach (var child in lines)
            //{
            //    var nb = new NodeBuilder(_document.Root[child]);
            //    var currentLength = nb[0].RefTransformedPoint3D.Distance(nb[1].RefTransformedPoint3D);

            //    var builder = new NodeBuilder(_document, Constraint2DNames.LineLengthFunction);
            //    builder[0].Reference = nb.Dependency[0].Reference;
            //    builder[1].Reference = nb.Dependency[1].Reference;
            //    builder[2].Real = currentLength;
            //    builder.ExecuteFunction();
            //    softConstraints.Add(builder.Node.Index);
            //}

            //foreach (var child in arcs)
            //{
            //    var nb = new NodeBuilder(_document.Root[child]);
            //    var currentLength = nb[0].RefTransformedPoint3D.Distance(nb[1].RefTransformedPoint3D);
            //    var lengthConstraint = NodeBuilderUtils.AddConstraintToOneField(_document, nb.Node, Constraint2DNames.ArcRadiusFunction,
            //                                              currentLength);
            //    softConstraints.Add(lengthConstraint.Node.Index);

            //    var startAngle = Math.Atan2(nb.Dependency[1].RefTransformedPoint3D.Y - nb.Dependency[0].RefTransformedPoint3D.Y,
            //                            nb.Dependency[1].RefTransformedPoint3D.X - nb.Dependency[0].RefTransformedPoint3D.X);

            //    var endAngle = Math.Atan2(nb.Dependency[2].RefTransformedPoint3D.Y - nb.Dependency[0].RefTransformedPoint3D.Y,
            //                            nb.Dependency[2].RefTransformedPoint3D.X - nb.Dependency[0].RefTransformedPoint3D.X);
            //    var builder = new NodeBuilder(_document, Constraint2DNames.ArcAnglesFunction);
            //    builder[0].Reference = nb.Node;
            //    builder[1].Real = startAngle;
            //    builder[2].Real = endAngle;
            //    builder.ExecuteFunction();
            //    softConstraints.Add(builder.Node.Index);
            //}

            ////foreach(var node in circles)
            ////{
            ////    var nb = new NodeBuilder(_document.Root[node]);
            ////    var radius = nb.Dependency[1].Real;
            ////    var builder = new NodeBuilder(_document, Constraint2DNames.PositiveParameterFunction);
            ////    builder[0].Reference = nb.Node;
            ////    builder.ExecuteFunction();
            ////    softConstraints.Add(builder.Node.Index);
            ////}
        }

        private void LoadConstraints()
        {
            var constraintsList = new List<ConstraintRefBase>();
            var allConstraints = new List<int>();
            allConstraints.AddRange(_constraints);
           //ConstraintList = new ConstraintRefContainer();
            foreach(var shape in allConstraints)
            {
                var builder = new NodeBuilder(_document.Root[shape]);
                ISolverConstraintMapping objectMapper;
                if (ConstraintMappingList.ShapeConstraintObjectMapping.TryGetValue(builder.FunctionName,
                                                                                   out objectMapper))
                {
                    var constr = objectMapper.MapRef(_document, builder, ShapeToParamIndex);
                    //only do this for the new constraints
                    if (constr != null)
                    {
                        constraintsList.AddRange(constr);
                    }
                }
            }
            SetConstraintsList = new ConstraintRefContainer();
            SetConstraintsList.AddRange(constraintsList);
            ConstraintList.AddRange(constraintsList);
           // GetSoftConstraints();

            allConstraints.Clear();
            allConstraints.AddRange(softConstraints);
            constraintsList.Clear();
            SoftConstraintsList = new ConstraintRefContainer();

            foreach (var shape in allConstraints)
            {
                var builder = new NodeBuilder(_document.Root[shape]);
                ISolverConstraintMapping objectMapper;
                if (ConstraintMappingList.ShapeConstraintObjectMapping.TryGetValue(builder.FunctionName,
                                                                                   out objectMapper))
                {
                    var constr = objectMapper.MapRef(_document, builder, ShapeToParamIndex);
                    //only do this for the new constraints
                    if (constr != null)
                    {
                        constraintsList.AddRange(constr);
                    }
                }
            }
            SoftConstraintsList.AddRange(constraintsList);
            ConstraintList.AddRange(constraintsList);
        }

        private bool NodeIsPoint(int nodeIndex)
        {
            var nodeBuilder = new NodeBuilder(_document.Root[nodeIndex]);
            if (nodeBuilder.FunctionName == FunctionNames.Point)
                return true;
            return false;
        }

        private bool NodeIsCircle(int nodeIndex)
        {
            var nodeBuilder = new NodeBuilder(_document.Root[nodeIndex]);
            if (nodeBuilder.FunctionName == FunctionNames.Circle)
                return true;
            return false;
        }

        private readonly List<int> softConstraints = new List<int>();

        public int Solve()
        {
            if (!_shapeList.Any() || !_constraints.Any())
                return 0;
            // transform parameters
            var sketchNode = AutoGroupLogic.FindSketchNode(_document.Root[_shapeList.First()]);
            var axisAll = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(sketchNode));
            var sketchAx2 = new gpAx2(axisAll.Location, axisAll.Direction);
            LoadParameters(sketchAx2);
            LoadConstraints();

            if (SetConstraintsList.Size == 0)
                return 0;
            var freeParametersCount = 1;
            var maxFreeParametersCount = Parameters.Count - 2;
      
            var error = 1;
            var dfpSolver = new DFPSolver();
            while (error == 1 && freeParametersCount <= maxFreeParametersCount)
            {
                error = dfpSolver.SolveRef(ref Parameters, freeParametersCount, ConstraintList, 1);
                freeParametersCount++;
            }
            Sketch2DSolver solver;
            if(error == 1)
            {
               var bfgsSolver = new BFGSSolver();
                freeParametersCount = 1;
                while (error == 1 && freeParametersCount <= maxFreeParametersCount)
                {
                    error = bfgsSolver.SolveRef(ref Parameters, freeParametersCount, ConstraintList, 1);
                    freeParametersCount++;
                }
                solver = bfgsSolver;
            }
            else
            {
                solver = dfpSolver;
            }

            if(error == 0)
            {
                // update point position with the values returned by the solver
                int index = 0;
                foreach (var shape in ShapeToParamIndex.Keys)
                {
                    //if (index > maxFreeParametersCount)
                    //    break;
                    var nodeBuilder = new NodeBuilder(_document.Root[shape]);
                    if (nodeBuilder.FunctionName == FunctionNames.Point)
                    {
                        nodeBuilder[1].TransformedPoint3D = GeomUtils.Point2DTo3D(sketchAx2,
                                                                                  Parameters[ShapeToParamIndex[shape]],
                                                                                  Parameters[
                                                                                      ShapeToParamIndex[shape] + 1]);
                        index += 2;
                    }
                    if (nodeBuilder.FunctionName == FunctionNames.Circle)
                    {
                        nodeBuilder[0].RefTransformedPoint3D = GeomUtils.Point2DTo3D(sketchAx2, Parameters[ShapeToParamIndex[shape]], Parameters[ShapeToParamIndex[shape] + 1]);
                        nodeBuilder[1].Real = Parameters[ShapeToParamIndex[shape] + 2];
                        index += 3;
                    }
                }
                foreach (var shape in _document.Root.Children)
                {
                    //if (index > maxFreeParametersCount)
                    //    break;
                    var nodeBuilder = new NodeBuilder(shape.Value);
                    if (nodeBuilder.FunctionName == FunctionNames.Arc)
                    {
                        if (ShapeToParamIndex.Keys.Contains(nodeBuilder.Dependency[0].Reference.Index))
                        {
                            var centre = nodeBuilder.Dependency[0].RefTransformedPoint3D;
                            var start = nodeBuilder.Dependency[1].RefTransformedPoint3D;
                            var currentEnd = nodeBuilder.Dependency[2].RefTransformedPoint3D;
                            var newEnd = GeomUtils.ProjectPointOnCircle(centre, start, currentEnd);
                            if (newEnd != null)
                            {
                                var End = new Point3D(newEnd);
                                nodeBuilder[2].RefTransformedPoint3D = new Point3D(End.X, End.Y, End.Z);
                            }
                        }
                        error = 1;
                        freeParametersCount = 0;
                        while (error == 1 && freeParametersCount <= maxFreeParametersCount)
                        {
                            error = solver.SolveRef(ref Parameters, freeParametersCount, SetConstraintsList, 1);
                            freeParametersCount += 2;
                        }
                    }
                }
            } 
            foreach(var constr in softConstraints)
            {
                _document.Root.Remove(constr);
            }
            return error;
        }
    }
}