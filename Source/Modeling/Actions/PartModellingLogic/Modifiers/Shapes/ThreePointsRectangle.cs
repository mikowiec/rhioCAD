#region Usings

using System;
using System.Collections.Generic;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAPI;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NaroPipes.Constants;
using NaroSketchAdapter;
using NaroSketchAdapter.Views;
using OccCode;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingLogic.Inputs.Naro.Pipes;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Shapes
{
    internal class ThreePointsRectangle : DrawingLiveShape
    {

        public ThreePointsRectangle(): base(ModifierNames.ThreePointsRectangle)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.CoordinateParser, OnCoordinateParser);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            var sketchBuilder = new SketchCreator(Document, false);
            var sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode == null)
            {
                ActionsGraph.SwitchAction(ModifierNames.StartSketch, ModifierNames.ThreePointsRectangle);
                return;
            }
            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.Unknown);
             sketchNode = new SketchCreator(Document).CurrentSketch;
            _sketchNode = sketchNode;
            var nodeBuilder = new NodeBuilder(_sketchNode);
            _sketchCoordinateTranslator = new Sketch3DTo2DTranslator(new Axis(nodeBuilder[0].TransformedAxis3D));
            Reset();
            
        }

        private List<NodeBuilder> PreviewRectangle(Document document, Node sketchNode)
        {
            //var axis1 = new gpAx2();
            //axis1.Axis = (sketchNode.Children[1].Get<Axis3DInterpreter>().Axis.GpAxis);
            //var location = axis1.Axis.Location.Transformed(sketchNode.Get<TransformationInterpreter>().CurrTransform);
            //var direction = axis1.Axis.Direction.Transformed(sketchNode.Get<TransformationInterpreter>().CurrTransform);
            //var axis = new gpAx2(location, direction);

            var axisAll = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(sketchNode));
            var axis = new gpAx2(axisAll.Location, axisAll.Direction);
            var vec = new gpVec(Points[0].GpPnt, Points[1].GpPnt);
            gpVec v2 = vec.Normalized;
            v2.Rotate(axis.Axis, Math.PI / 2.0);

            var parallelLine = new gceMakeLin(Points[1].GpPnt, new gpDir(v2)).Value;
            var geomLine = new GeomLine(parallelLine);
            var projectionPoint = new GeomAPIProjectPointOnCurve(Points[2].GpPnt, geomLine);

            var thirdPoint = new Point3D(projectionPoint.NearestPoint);

            var firstPoint2D = Points[0].ToPoint2D(axis);
            var secondPoint2D = Points[1].ToPoint2D(axis);
            var thirdPoint2D = thirdPoint.ToPoint2D(axis);

            var parallelLine2 = new gceMakeLin(Points[2].GpPnt, new gpDir(vec)).Value;
            var geomLine2 = new GeomLine(parallelLine2);
            var projectionPoint2 = new GeomAPIProjectPointOnCurve(Points[0].GpPnt, geomLine2);

            var fourthPoint = new Point3D(projectionPoint2.NearestPoint);
            var fourthPoint2D = fourthPoint.ToPoint2D(axis);

            var point3Ds = new List<Point3D>();
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, firstPoint2D.X, firstPoint2D.Y));
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, secondPoint2D.X, secondPoint2D.Y));
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, thirdPoint2D.X, thirdPoint2D.Y));
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, fourthPoint2D.X, fourthPoint2D.Y));
            var pointLinker = new SketchCreator(document).PointLinker;

            var lines = new List<NodeBuilder>
                    {
                        BuildLine(Document, pointLinker, point3Ds[0], point3Ds[1]),
                        BuildLine(Document, pointLinker, point3Ds[1], point3Ds[2]),
                        BuildLine(Document, pointLinker, point3Ds[2], point3Ds[3]),
                        BuildLine(Document, pointLinker, point3Ds[3], point3Ds[0])
                    };
            return lines;
        }

        private void PreviewRectangleLines(Document document, Node sketchNode)
        {
            _firstPoint = Points[0];
            _secondPoint = Points[1];
            if (_firstPoint.IsEqual(_secondPoint)) return;
            if(Points.Count ==2)
            {
              //  var axis1 = new gpAx2();
               // axis1.Axis = (sketchNode.Children[1].Get<Axis3DInterpreter>().Axis.GpAxis);
                //var location = axis1.Axis.Location.Transformed(sketchNode.Get<TransformationInterpreter>().CurrTransform);
                //var direction = axis1.Axis.Direction.Transformed(sketchNode.Get<TransformationInterpreter>().CurrTransform);
                var axisAll = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(sketchNode));
            //    var axis = new gpAx2(location, direction);
                var axis = new gpAx2(axisAll.Location, axisAll.Direction);
                var point3Ds = new List<Point3D>();
                var firstPoint2D = _firstPoint.ToPoint2D(axis);
                var secondPoint2D = _secondPoint.ToPoint2D(axis);

                var x1 = firstPoint2D.X;
                var y1 = firstPoint2D.Y;
                var x2 = secondPoint2D.X;
                var y2 = secondPoint2D.Y;

                point3Ds.Add(GeomUtils.Point2DTo3D(axis, x1, y1));
                point3Ds.Add(GeomUtils.Point2DTo3D(axis, x2, y2));
                var pointLinker = new SketchCreator(Document).PointLinker;
                BuildLine(document, pointLinker, point3Ds[0], point3Ds[1]);
            }
            if (Points.Count == 3)
            {
                PreviewRectangle(Document, _sketchNode);
            }
        }

        private static void ApplyLinesConstraint(ConstraintDocumentHelper mapper, NodeBuilder firstLine,
                                                 NodeBuilder secondLine, string constraint)
        {
            mapper.ApplyConstraint(firstLine.Node, secondLine.Node, constraint);
        }

        private static NodeBuilder BuildLine(Document document, DocumentPointLinker documentPointLinker,
                                            Point3D firstCoordinate, Point3D secondCoordinate)
        {
            var firstPoint = documentPointLinker.GetPoint(firstCoordinate);
            var secondPoint = documentPointLinker.GetPoint(secondCoordinate);
            var line = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            line[0].Reference = firstPoint.Node;
            line[1].Reference = secondPoint.Node;
            line.ExecuteFunction();
            return line;
        }

        private void Reset()
        {
            Points.Clear();
            AddNewEmptyPoint();
            ShowHint(ModelingResources.RectangleStep1Direction);
        }

        private void OnCoordinateParser(DataPackage data)
        {
            var text = (string) data.Data;
            if (text.Contains(","))
            {
                _coordinate = CoordinateParser.ParsePointValue(text, _coordinate);
                AddNewPoint(_coordinate);
                return;
            }
            if (Points.Count == 1) return;
            _firstPoint = Points[0];
            _secondPoint = Points[1];
            var newLenght = CoordinateParser.ParseDoubleArgument(0, text);
            var distanceRatio = newLenght/_firstPoint.Distance(_secondPoint);
            if (Math.Abs(distanceRatio) < 1e-6)
                return;

            AddNewPoint(GeomUtils.BetweenValue(_firstPoint, _secondPoint, distanceRatio));
        }

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            base.OnMouseUpAction(mouseData);
            switch (Points.Count)
            {
                case 1:
                    ActionsGraph[InputNames.GeometricSolverPipe].Send(NotificationNames.ResetPreviousPoint);
                    break;
                case 2:
                    ShowHint(ModelingResources.RectangleStep2);
                    break;
            }
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString());
            SetCoordinate(mouseData.Point);
            if (Points.Count < 2) return;
            InitSession();
            PreviewRectangleLines(Document, _sketchNode);
            UpdateView();
        }

        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            InitSession();
            AddNewPoint(mouseData.Point);
        }

        public override void OnDeactivate()
        {
            InitSession();
            Reset();
            base.OnDeactivate();
        }

        private void AddNewPoint(Point3D coordinate)
        {
            SetCoordinate(coordinate);
            AddNewEmptyPoint();
            if(Points.Count ==3)
            {   
                ShowHint(ModelingResources.RectangleStep3);
                return;
            }
            if (Points.Count != 4)
                return;
            var lines = PreviewRectangle(Document, _sketchNode);
          
            var constraintMapper = new ConstraintDocumentHelper(Document, _sketchNode);
            ApplyLinesConstraint(constraintMapper, lines[0], lines[2], Constraint2DNames.ParallelFunction);
            ApplyLinesConstraint(constraintMapper, lines[1], lines[3], Constraint2DNames.ParallelFunction);
            ApplyLinesConstraint(constraintMapper, lines[0], lines[1], Constraint2DNames.PerpendicularFunction);


            CommitFinal("Added rectangle to scene");
            UpdateView();
            RebuildTreeView();
            Reset();
            
        }

        private void SetCoordinate(Point3D coordinate)
        {
            _coordinate = coordinate;
            Points[Points.Count - 1] = coordinate;
        }

        #region Fields
        private Point3D _coordinate;

        private Point3D _firstPoint;
        private Point3D _secondPoint;
        private Sketch3DTo2DTranslator _sketchCoordinateTranslator;
        private Node _sketchNode;
        #endregion
    }
}