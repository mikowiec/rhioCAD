#region Usings

using System.Drawing;
using MetaActions;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;
using OccCode;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Shapes
{
    internal class ArcStartEndRadiusAction : DrawingLiveShape
    {
        public ArcStartEndRadiusAction() : base(ModifierNames.ArcStartEndRadius)
        {
        }
        private gpAx1 normalOnPlane;
        private Node sketchNode;

        public override void OnActivate()
        {
            base.OnActivate();
            var mouseCursorInput = ActionsGraph[InputNames.MouseCursorInput];

            mouseCursorInput.Send(NotificationNames.SetResourceManager, MetaActionResource.ResourceManager);
            mouseCursorInput.Send(NotificationNames.SetCursorName, "arcRSE.cur");

            var sketchBuilder = new SketchCreator(Document, false);
            sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode == null)
            {
                ActionsGraph.SwitchAction(ModifierNames.StartSketch, ModifierNames.ArcStartEndRadius);
                return;
            }
            normalOnPlane = sketchBuilder.NormalOnSketch.Value.GpAxis;
            sketchNode = sketchBuilder.CurrentSketch;
            // Block drawing plane
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Suspend);

            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.Unknown);

            Reset();
        }

        private void Reset()
        {
            Points.Clear();
            AddNewEmptyPoint();
            ShowHint(ModelingResources.ArcSERStep1);
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
                    ShowHint(ModelingResources.ArcSERStep2);
                    break;
                case 3:
                    ShowHint(ModelingResources.ArcSERStep3);
                    break;
            }
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString());
            SetCoordinate(mouseData.Point);
            if (Points.Count < 2) return;
            if (Points.Count == 2)
                PreviewLine();
            else if (Points.Count == 3)
                PreviewArc();
            UpdateView();
        }

        private void PreviewLine()
        {
            InitAnimateSession();
            BuildLineInDocument(AnimationDocument, false, normalOnPlane);
        }

        private void PreviewArc()
        {
            InitAnimateSession();
            BuildArc3PInDocument(AnimationDocument);
        }

        private NodeBuilder BuildArc3PInDocument(Document document)
        {
            var nodeBuilder = new NodeBuilder(sketchNode);

            var firstPointBuilder = GetSketchNode(document, Points[0], sketchNode);
            var secondPointBuilder = GetSketchNode(document, Points[1], sketchNode);
            var thirdPointBuilder =  new NodeBuilder(document, FunctionNames.Point);
            thirdPointBuilder[0].Reference = nodeBuilder.Node;
            thirdPointBuilder[1].TransformedPoint3D = Points[2];
            thirdPointBuilder.Color = Color.Orange;
            thirdPointBuilder.ExecuteFunction();

            var builder = new NodeBuilder(document, FunctionNames.Arc3P);
            builder[0].Reference = firstPointBuilder.Node;
            builder[1].Reference = secondPointBuilder.Node;
            builder[2].Reference = thirdPointBuilder.Node;
            builder.ExecuteFunction();
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, builder.Node);
            return builder;
        }

        private NodeBuilder BuildArcInDocument(Document document)
        {
            var firstPointBuilder = GetSketchProjectedNode(document, Points[0]);
            var secondPointBuilder = GetSketchProjectedNode(document, Points[1]);
            var thirdPointBuilder = GetSketchProjectedNode(document, Points[2]);

            var gceCirc = new gceMakeCirc(firstPointBuilder[1].TransformedPoint3D.GpPnt,
                                             secondPointBuilder[1].TransformedPoint3D.GpPnt,
                                             thirdPointBuilder[1].TransformedPoint3D.GpPnt);
            var circle = gceCirc.Value;
            var circleCenterBuilder = GetSketchProjectedNode(document, new Point3D(circle.Axis.Location));
            var arc = GeomUtils.BuildArc(circle.Axis, Points[0], Points[1], true);
            var reversedArc = true;
            if (arc != null)
            {
                var firstU = arc.FirstParameter;
                var lastU = arc.LastParameter;
                var arcEdge = new BRepBuilderAPIMakeEdge(arc).Edge;
                var arcAdaptor = new BRepAdaptorCurve(arcEdge);
                var thirdPointU = GeomUtils.UParameter(arcAdaptor, arcEdge.Location(), Points[3]);
                if ((firstU <= thirdPointU) && (thirdPointU <= lastU))
                    reversedArc = false;
            }

            var builder = new NodeBuilder(document, FunctionNames.Arc);
            builder[0].Reference = circleCenterBuilder.Node;
            builder[1].Reference = reversedArc ? secondPointBuilder.Node : firstPointBuilder.Node;
            builder[2].Reference = reversedArc ? firstPointBuilder.Node : secondPointBuilder.Node;
            builder.ExecuteFunction();
            return builder;
        }

        private NodeBuilder BuildArc()
        {
            InitSession();
            return BuildArc3PInDocument(Document);
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
            var builder = BuildArc();
            AddNodeToTree(builder.Node);
            CommitFinal("Added arc to scene");
            UpdateView();
            Reset();
        }

        private void SetCoordinate(Point3D coordinate)
        {
            Points[Points.Count - 1] = coordinate;
        }
    }
}