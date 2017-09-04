#region Usings

using System;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NaroPipes.Constants;
using OccCode;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingLogic.Inputs.Naro.Pipes;
using Resources.PartModelling;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Shapes
{
    public class EllipseAction : DrawingLiveShape
    {
        private Point3D _coordinate;
        private gpAx1 normalOnPlane;
        public EllipseAction() : base(ModifierNames.Ellipse)
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
            var  sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode == null)
            {
                ActionsGraph.SwitchAction(ModifierNames.StartSketch, ModifierNames.Ellipse);
                return;
            }
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Disable);
            normalOnPlane = sketchBuilder.NormalOnSketch.Value.GpAxis;
            // Block drawing plane
            //Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
            //Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane,
            //                                          new gpPln(sketchPlane.GpAxis.Location(),
            //                                                       sketchPlane.GpAxis.Direction()));
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Suspend);
            var nodeBuilder = new NodeBuilder(sketchBuilder.CurrentSketch);
            nodeBuilder[0].TransformedAxis3D = normalOnPlane;
            var currentSketchNode = Document.Root[Document.Root.Get<DocumentContextInterpreter>().ActiveSketch];
            sketchNode = currentSketchNode;
            var firstPointBuilder = GetSketchNode(Document, new Point3D(), sketchNode); 
            var secondPointBuilder = GetSketchNode(Document, new Point3D(), sketchNode);
            var thirdPointBuilder = GetSketchNode(Document, new Point3D(), sketchNode);
            firstPointBuilder.Visibility = ObjectVisibility.Hidden;
            secondPointBuilder.Visibility = ObjectVisibility.Hidden;
            thirdPointBuilder.Visibility = ObjectVisibility.Hidden;
            var builder = new NodeBuilder(Document, FunctionNames.Ellipse);
            builder[0].Reference = firstPointBuilder.Node;
            builder[1].Reference = secondPointBuilder.Node;
            builder[2].Reference = thirdPointBuilder.Node;
            builder.ExecuteFunction();
            builder.Visibility = ObjectVisibility.Hidden;
            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.Unknown);
            Reset();
        }

        private void Reset()
        {
            Points.Clear();
            AddNewEmptyPoint();
            ShowHint(ModelingResources.EllipseStep1);
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
                    ShowHint(ModelingResources.EllipseStep2);
                    break;
                case 3:
                    ShowHint(ModelingResources.EllipseStep3);
                    break;
            }
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            SetCoordinate(mouseData.Point);
            if (Points.Count < 2) return;
            if (Points.Count == 2)
                PreviewLine();
            else if (Points.Count == 3)
                PreviewEllipse();
            UpdateView();
        }

        private void PreviewLine()
        {
            InitAnimateSession();
            BuildSymmetricLineInDocument(AnimationDocument);
        }

        private void PreviewEllipse()
        {
            InitAnimateSession();
            BuildEllipseInDocument(AnimationDocument);
        }

        private NodeBuilder BuildSymmetricLineInDocument(Document previewDocument)
        {
            var sketchBuilder = new SketchCreator(previewDocument);

            var nodeBuilder = new NodeBuilder(sketchBuilder.CurrentSketch);
            nodeBuilder[0].TransformedAxis3D = normalOnPlane;

            var firstPointBuilder = GetSketchProjectedNode(previewDocument, Points[0]);
            var secondPointBuilderNode = GetSketchProjectedNode(previewDocument, Points[1]);

            var builder = new NodeBuilder(previewDocument, FunctionNames.LineTwoPoints);
            builder[0].Reference = firstPointBuilder.Node;
            builder[1].Reference = secondPointBuilderNode.Node;
            builder.EnableSelection = false;
            builder.ExecuteFunction();
            return builder;
        }

        private NodeBuilder BuildEllipseInDocument(Document document)
        {
            var sketchBuilder = new SketchCreator(document);

            var nodeBuilder = new NodeBuilder(sketchBuilder.CurrentSketch);
            nodeBuilder[0].TransformedAxis3D = normalOnPlane;

            var firstPointBuilder = GetSketchProjectedNode(document, Points[0]);
            var secondPointBuilder = GetSketchProjectedNode(document, Points[1]);
            var thirdPointBuilder = GetSketchProjectedNode(document, Points[2]);

            var builder = new NodeBuilder(document, FunctionNames.Ellipse);
            builder[0].Reference = firstPointBuilder.Node;
            builder[1].Reference = secondPointBuilder.Node;
            builder[2].Reference = thirdPointBuilder.Node;
            builder.ExecuteFunction();
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, builder.Node);
            return builder;
        }

        private NodeBuilder BuildFinalEllipse()
        {
            InitSession();
            return BuildEllipseInDocument(Document);
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
            if (Points.Count <= 3) return;
            var builder = BuildFinalEllipse();
            AddNodeToTree(builder.Node);
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