#region Usings

using System;
using System.Drawing;
using MetaActions;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;
using OccCode;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Shapes
{
    internal class ArcCenterStartEndAction : DrawingLiveShape
    {
        public ArcCenterStartEndAction() : base(ModifierNames.ArcCenterStartEnd)
        {
        }
        private gpAx1 normalOnPlane;
        private Node sketchNode;

        public override void OnActivate()
        {
            base.OnActivate();

            var sketchBuilder = new SketchCreator(Document, false);
            sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode == null)
            {
                ActionsGraph.SwitchAction(ModifierNames.StartSketch, ModifierNames.ArcCenterStartEnd);
                return;
            }
            normalOnPlane = sketchBuilder.NormalOnSketch.Value.GpAxis;
            sketchNode = sketchBuilder.CurrentSketch;
            // Block drawing plane
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Suspend);

            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.Unknown);
            var pointBuilder = GetSketchNode(Document, new Point3D(), sketchNode);
            var pointBuilder2 = GetSketchNode(Document, new Point3D(0.0,0,0), sketchNode);
            var pointBuilder3 = GetSketchNode(Document, new Point3D(0,0.0,0), sketchNode);
            var builder = new NodeBuilder(Document, FunctionNames.Arc);
            builder[0].Reference = pointBuilder.Node;
            builder[1].Reference = pointBuilder2.Node;
            builder[2].Reference = pointBuilder3.Node;
            builder.ExecuteFunction();
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, builder.Node);
            Reset();
        }

        private void Reset()
        {
            Points.Clear();
            AddNewEmptyPoint();
            ShowHint(ModelingResources.ArcRSEStep1);
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
                    ShowHint(ModelingResources.ArcRSEStep2);
                    break;
            }
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString()+"\nRadius: "+"\nStartAngle: "+"\nEnd Angle: "+"\nInternal Angle: ");
            SetCoordinate(mouseData.Point);
            if (Points.Count < 2) return;
            if (Points.Count == 2)
            {
                WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString() + "\nRadius: " + Points[1].Distance(Points[0]).ToString("{0.##}") +
                    "\nStartAngle: " + (NodeBuilderUtils.GetArcAngle(Points[0], mouseData.Point, new NodeBuilder(sketchNode)) * 180 / Math.PI).ToString("{0.##}") + "\nEnd Angle: " + "\nInternal Angle: ");
                PreviewCircle();
            }
            else if (Points.Count == 3)
            {
                PreviewArc();
                WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString() + "\nRadius: " + Points[1].Distance(Points[0]).ToString("{0.##}") + 
                    "\nStartAngle: " +(NodeBuilderUtils.GetArcAngle(Points[0], Points[1], new NodeBuilder(sketchNode))*180/Math.PI).ToString("{0.##}")+
                    "\nEnd Angle: " + (NodeBuilderUtils.GetArcAngle(Points[0], Points[2], new NodeBuilder(sketchNode))*180/Math.PI).ToString("{0.##}")+
                    "\nInternal Angle: " + NodeBuilderUtils.GetInternalAngle(Points[0], Points[1], Points[2], sketchNode).ToString("{0.##}"));
            }
            UpdateView();
        }

        private void PreviewCircle()
        {
            InitAnimateSession();
           
            BuildCircleInDocument(AnimationDocument);
        }

        private void PreviewArc()
        {
            InitAnimateSession();
            ShowHint(ModelingResources.ArcRSEStep3);
            BuildArcInDocument(AnimationDocument, false);
        }

        private NodeBuilder BuildCircleInDocument(Document previewDocument)
        {
            var circleCenterPoint = Points[0];
            Ensure.IsNotNull(circleCenterPoint);
            var firstPointBuilder = GetSketchNode(previewDocument, circleCenterPoint, sketchNode);

            var builder = new NodeBuilder(previewDocument, FunctionNames.Circle);
            builder[0].Reference = firstPointBuilder.Node;
            builder[1].Real = Points[1].Distance(Points[0]);
            builder.EnableSelection = false;
            builder.ExecuteFunction();

            var pointBuilder2 = GetSketchNode(Document, Points[1], sketchNode);
            pointBuilder2.Visibility = ObjectVisibility.Hidden;
            var arcBuilder = new NodeBuilder(Document, FunctionNames.Arc);
            arcBuilder[0].Reference = firstPointBuilder.Node;
            arcBuilder[1].Reference = pointBuilder2.Node;
            arcBuilder[2].Reference = pointBuilder2.Node;
            arcBuilder.ExecuteFunction();
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, arcBuilder.Node);
            return builder;
        }

        private NodeBuilder BuildArcInDocument(Document document, bool animation)
        {
            var nodeBuilder = new NodeBuilder(sketchNode);
            var firstPointBuilder = GetSketchNode(document, Points[0], sketchNode);
            if (animation)
            {
                var builder1 = new NodeBuilder(document, FunctionNames.DottedLine);
                builder1[0].TransformedPoint3D = firstPointBuilder[1].TransformedPoint3D;
                builder1[1].TransformedPoint3D = Points[1];
                builder1.EnableSelection = false;
                builder1.Color = Color.Black;
                builder1.ExecuteFunction();

                var builder2 = new NodeBuilder(document, FunctionNames.DottedLine);
                builder2[0].TransformedPoint3D = firstPointBuilder[1].TransformedPoint3D;
                builder2[1].TransformedPoint3D = Points[2];
                builder2.EnableSelection = false;
                builder2.Color = Color.Black;
                builder2.ExecuteFunction();
            }

            var arcStartPointBuilder = new NodeBuilder(document, FunctionNames.Point);
            arcStartPointBuilder[0].Reference = nodeBuilder.Node;
            arcStartPointBuilder[1].TransformedPoint3D = Points[1];
            arcStartPointBuilder.Color = Color.Orange;
            arcStartPointBuilder.ExecuteFunction();
            var arcEndPointBuilder = new NodeBuilder(document, FunctionNames.Point);
            arcEndPointBuilder[0].Reference = nodeBuilder.Node;
            arcEndPointBuilder[1].TransformedPoint3D = CalculateEndPointOnArc(Points[0], Points[1], Points[2]);
            arcEndPointBuilder.Color = Color.Orange;
            arcEndPointBuilder.ExecuteFunction();
            var builder = new NodeBuilder(document, FunctionNames.Arc);
            builder[0].Reference = firstPointBuilder.Node;
            builder[1].Reference = arcStartPointBuilder.Node;
            builder[2].Reference = arcEndPointBuilder.Node;
            builder.ExecuteFunction();
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, builder.Node);
            return builder;
        }

        private NodeBuilder BuildArc()
        {
            InitSession();
            return BuildArcInDocument(Document, false);
        }

        private static Point3D CalculateEndPointOnArc(Point3D center, Point3D startPoint, Point3D currentEndPoint)
        {
            var radius = center.Distance(startPoint);
            Ensure.IsTrue(radius > 0);
            var endPointVector = new gpVec(center.GpPnt, currentEndPoint.GpPnt);
            endPointVector.Normalize();
            endPointVector.Multiply(radius);
            return GeomUtils.BuildTranslation(center, endPointVector);
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