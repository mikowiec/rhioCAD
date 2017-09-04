#region Usings

using System;
using log4net;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepFilletAPI;
using NaroCppCore.Occ.ChFi3d;
using NaroCppCore.Occ.ChFiDS;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopExp;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopTools;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    /// <summary>
    ///   Generates a fillet/chamfer on the selected edge or on all edges.
    /// </summary>
    public class FilletFunction : FunctionBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (FilletFunction));

        public FilletFunction() : base(FunctionNames.Fillet)
        {
            // Reference shape
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Edge number 1 based value, if value is 0 it means all edges found
            Dependency.AddAttributeType(InterpreterNames.Integer);
            // Radius
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Operation type: 0 fillet or 1 chamfer
            Dependency.AddAttributeType(InterpreterNames.Integer);
        }

        public override bool Execute()
        {
            var originalShape = Dependency[0].ReferedShape;
            var edgeNumber = Dependency[1].Integer;
            var height = Dependency[2].Real;
            var operationType = Dependency[3].Integer;

            // Try applying a Fillet/Chamfer
            Shape = ApplyFillet(height, originalShape, edgeNumber, operationType);
            if(Shape != null)
                NodeUtils.Hide(Dependency[0].Reference);

            return Shape != null;
        }

        private static TopoDSShape ApplyFillet(double thickness, TopoDSShape body, int edgeNumber, int operationType)
        {
            try
            {
                // Create fillet
                var aEdgeExplorer = new TopExpExplorer(body, TopAbsShapeEnum.TopAbs_EDGE,
                                                          TopAbsShapeEnum.TopAbs_SHAPE);

                var number = 1;
                TopoDSShape shape = null;
                while (aEdgeExplorer.More)
                {
                    if ((edgeNumber == 0) || (edgeNumber == number))
                    {
                        var anEdge = TopoDS.Edge(aEdgeExplorer.Current);

                        if (operationType == (int)FilletChamferTypes.SimpleFillet)
                        {
                            var fillet = new BRepFilletAPIMakeFillet(body, ChFi3dFilletShape.ChFi3d_Rational);
                            // Add edge to fillet algorithm
                            fillet.Add(thickness, anEdge);
                            // Check if valid contour
                            try
                            {
                                if (fillet.StripeStatus(fillet.Contour(anEdge)) != ChFiDSErrorStatus.ChFiDS_Ok)
                                    return null;
                            }
                            catch (Exception)
                            {
                                Log.Info("Exception on applying fillet");
                            }
                            shape = fillet.Shape;
                        }
                        else
                        {
                            var chamfer = new BRepFilletAPIMakeChamfer(body);
                            var aMap = new TopToolsIndexedDataMapOfShapeListOfShape(1);
                            TopExp.MapShapesAndAncestors(body, TopAbsShapeEnum.TopAbs_EDGE, TopAbsShapeEnum.TopAbs_FACE,
                                                           aMap);
                            // Locate an ancestor face
                            for (var i = 1; i < aMap.Extent; i++)
                            {
                                var localEdge = TopoDS.Edge(aMap.FindKey(i));
                                if (!anEdge.IsSame(localEdge)) continue;
                                // We found an ancestor face
                                var face = TopoDS.Face(aMap.FindFromIndex(i).First);
                                // Add the edge and face on the chmafer algorithm
                                chamfer.Add(thickness, thickness, anEdge, face);
                            }
                            shape = chamfer.Shape;
                        }
                    }

                    aEdgeExplorer.Next();
                    number++;
                }

                // Check the shape validity
                
                if ((shape == null) || (shape.IsNull))
                    return null;

                return shape;
            }
            catch (Exception ex)
            {
                Log.Info("Apply fillet error: " + ex.Message);
            }
            return null;
        }
    }
}