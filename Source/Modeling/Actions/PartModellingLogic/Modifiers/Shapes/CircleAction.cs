#region Usings

using System;
using System.Drawing;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NaroPipes.Constants;
using OccCode;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingLogic.Inputs.Naro.Pipes;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Shapes
{
    internal class CircleAction : DrawingLiveShape
    {
        private Point3D _coordinate;
        private gpAx1 normalOnPlane;
        private Node sketchNode;
        public CircleAction() : base(ModifierNames.DrawCircle)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.CoordinateParser, OnCoordinateParser);
        }

        private NodeBuilder builder;
        public override void OnActivate()
        {
            base.OnActivate();
           
            var sketchBuilder = new SketchCreator(Document, false);
            sketchNode = sketchBuilder.CurrentSketch;
            if(sketchNode == null)
            {
                ActionsGraph.SwitchAction(ModifierNames.StartSketch, ModifierNames.DrawCircle);
                return;
            }
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Disable);
            normalOnPlane = sketchBuilder.NormalOnSketch.Value.GpAxis;
            var trsf = sketchBuilder.CurrentSketch.Get<TransformationInterpreter>().CurrTransform;
            normalOnPlane = normalOnPlane.Transformed(trsf);
            sketchNode = sketchBuilder.CurrentSketch;
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Suspend);
            var pointBuilder = GetSketchNode(Document, new Point3D(), sketchNode);
            pointBuilder.Visibility = ObjectVisibility.Hidden;
            builder = new NodeBuilder(Document, FunctionNames.Circle);
            builder[0].Reference = pointBuilder.Node;
            builder[1].Real = 0.0;
            builder.Visibility = ObjectVisibility.Hidden;
            builder.ExecuteFunction();
            AddNodeToTree(builder.Node);
            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.Unknown);
            Reset();
        }

        private void Reset()
        {
            radiusChecked = false;
            Points.Clear();
            AddNewEmptyPoint();
            ShowHint(ModelingResources.CircleStep1);
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
            var firstPoint = Points[0];
            var secondPoint = Points[1];
            var newLenght = CoordinateParser.ParseDoubleArgument(0, text);
            var distanceRatio = newLenght/firstPoint.Distance(secondPoint);
            if (Math.Abs(distanceRatio) < 1e-6)
                return;

            AddNewPoint(GeomUtils.BetweenValue(firstPoint, secondPoint, distanceRatio));
        }

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            base.OnMouseUpAction(mouseData);

            AddNewPoint(mouseData.Point);

            switch (Points.Count)
            {
                case 1:
                    ActionsGraph[InputNames.GeometricSolverPipe].Send(NotificationNames.ResetPreviousPoint);
                    break;
                case 2:
                    ShowHint(ModelingResources.CircleStep2);
                    break;
            }
        }

        private bool radiusChecked = false;

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (!radiusChecked && builder.Node.Children.Count > 0)
            {
                circleRadius = builder[1].Real;
                if(Points.Count == 2)
                    radiusChecked = true;
            }
            SetCoordinate(mouseData.Point);
            if (Points.Count < 2)
            {
                WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString() + "\nRadius: ");
                return;
            }
            PreviewCircle();
            if (Points.Count < 2)
                return;
            WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy,
                            mouseData.Point.ToString() + "\nRadius: " + Points[1].Distance(Points[0]).ToString());
            UpdateView();
            RebuildTreeView();
        }

        private double circleRadius = 0; 

        private void PreviewCircle()
        {
            if (circleRadius > 0.0)
            {
                builder = BuildFinalCircle();
                AddNodeToTree(builder.Node);
                CommitFinal("Added line to scene");
                UpdateView();
                Reset();
                builder = new NodeBuilder(Document, FunctionNames.Circle);
                builder[1].Real = 0.0;
            }
            else
            {
                InitAnimateSession();
                PreviewCircle(AnimationDocument, true);
            }
        }

        private NodeBuilder PreviewCircle(Document previewDocument, bool animation)
        {
            //set correct sketch normal
            
            var circleCenterPoint = Points[0];
            Ensure.IsNotNull(circleCenterPoint);
            var pointBuilder = GetSketchNode(previewDocument, circleCenterPoint, sketchNode);
            builder = new NodeBuilder(previewDocument, FunctionNames.Circle);
            builder[0].Reference = pointBuilder.Node;
            builder[1].Real = circleRadius > 0.0 ? circleRadius : Points[1].Distance(Points[0]);
            if (animation)
                builder.EnableSelection = false;
            builder.ExecuteFunction();
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, builder.Node);
            return builder;
        }

        private NodeBuilder BuildCircleInDocument(Document previewDocument, bool animation)
        {
            var sketchBuilder = new SketchCreator(previewDocument);

            //var nodeBuilder = new NodeBuilder(sketchBuilder.CurrentSketch);
            //nodeBuilder[0].TransformedAxis3D = normalOnPlane;

            ////Document.Root.Get<ShapeFunctionsInterface.Interpreters.DocumentContextInterpreter>().ActiveSketch
            var circleCenterPoint = Points[0];
            Ensure.IsNotNull(circleCenterPoint);
            var firstPointBuilder = sketchBuilder.GetPoint(circleCenterPoint).Node;

            var builder = new NodeBuilder(previewDocument, FunctionNames.Circle);
            builder[0].Reference = firstPointBuilder;
            builder[1].Real = circleRadius > 0.0 ? circleRadius : Points[1].Distance(Points[0]);
            if (animation)
                builder.EnableSelection = false;
            builder.ExecuteFunction();
            return builder;
        }

        private NodeBuilder BuildFinalCircle()
        {
            InitSession();
            return BuildCircleInDocument(Document, false);
        }

        public override void OnDeactivate()
        {
            InitAnimateSession();
            Reset();

            // Unblock drawing plane
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
            
            base.OnDeactivate();
        }

        private void AddNewPoint(Point3D coordinate)
        {
            if (Points.Count == 2 && Points[0].IsEqual(coordinate))
                return;
            SetCoordinate(coordinate);
            AddNewEmptyPoint();
            if (Points.Count <= 2) return;
            var builderCircle = BuildFinalCircle();
            AddNodeToTree(builderCircle.Node);
            CommitFinal("Added line to scene");
            UpdateView();
            Reset();
        }

        private void SetCoordinate(Point3D coordinate)
        {
            _coordinate = coordinate;
            Points[Points.Count - 1] = coordinate;
        }
    }
}