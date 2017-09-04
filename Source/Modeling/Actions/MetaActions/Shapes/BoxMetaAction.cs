#region Usings

using System.Drawing;
using MetaActions.Tools;
using MetaActionsInterface;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.gp;
using OccCode;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActions.Shapes
{
    public class BoxMetaAction : MetaActionBase
    {
        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            dependency.FunctionName = FunctionNames.Box;
            dependency.Steps[1].OnCandidateUpdateHandler += BoxBaseDrawing;
            dependency.Steps[2].OnCandidateUpdateHandler += BoxHeight;
            dependency.OnStepsCompletedHandler += AnimationFinished;

            dependency.AutoReset = true;

            Dependency.Steps[0].HintText = ModelingResources.BoxStep1;
            Dependency.Steps[1].HintText = ModelingResources.BoxStep2;
            Dependency.Steps[2].HintText = ModelingResources.BoxStep3;
        }

        private void BoxBaseDrawing(bool updateShape)
        {
            if (Dependency.Steps[1].Data is Mouse3DPosition)
            {
                // If point received from mouse
                Dependency.Steps[0].Get<gpAx1>().Direction = (Dependency.Steps[1].Get<Mouse3DPosition>().Axis.Direction);
                Dependency.Steps[1].Data = Dependency.Steps[1].Get<Mouse3DPosition>().Point;
            }

            // Make the animation
            var builder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Rectangle);
            builder[0].Axis3D = new Axis(Dependency.Steps[0].Get<gpAx1>());
            builder[1].TransformedPoint3D = Dependency.Steps[1].Get<Point3D>();
            builder.EnableSelection = false;
            builder.Color = Color.Red;
            builder.DisplayMode = AISDisplayMode.AIS_WireFrame;
            builder.Transparency = 0.2;
            builder.ExecuteFunction();
        }

        private void BoxHeight(bool updateShape)
        {
            var axis = Dependency.Steps[0].Get<gpAx1>();
            var secondPoint = Dependency.Steps[1].Get<Point3D>();

            var basePoint = axis.Location;
            var excludedPlane = new gpPln(basePoint, axis.Direction);

            // Prevent the mouse from generating point on the base
            Dependency.Inputs.Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.ExcludedPlane, excludedPlane);
            // After the base is drawn disable the face picker
            Dependency.Inputs.Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);

            PreprocesHeight(excludedPlane);
            var height = Dependency.Steps[2].Get<double>();

            BoxAnimation(axis, height, secondPoint);
        }

        private void PreprocesHeight(gpPln basePlane)
        {
            if (!(Dependency.Steps[2].Data is Mouse3DPosition)) return;
            var fourthPoint = Dependency.Steps[2].Get<Mouse3DPosition>().Point;
            var height = CalculateBoxHeight(basePlane, fourthPoint);
            Dependency.Steps[2].Data = height;
        }

        private void BoxAnimation(gpAx1 axis, double height, Point3D secondPoint)
        {
            // First build a rectangle
            var rectangleBuilder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Rectangle);
            rectangleBuilder[0].Axis3D = new Axis(axis);
            rectangleBuilder[1].TransformedPoint3D = secondPoint;
            rectangleBuilder.EnableSelection = false;
            rectangleBuilder.ExecuteFunction();
            // Extrude the rectangle built
            var builder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Extrude);
            builder[0].ReferenceData = new SceneSelectedEntity(rectangleBuilder.Node);
            builder[1].Integer = (int)ExtrusionTypes.ToDepth;
            builder[2].Real = height;
            builder.Color = Color.White;
            builder.Transparency = 0.3;
            builder.EnableSelection = false;
            builder.ExecuteFunction();
            Dependency.AnimationNodeBuilder = builder;
            // Add also a dimension animation
            NodeUtils.DisplayTemporaryDimension(Dependency.AnimationDocument, builder.Node, false);
        }

        private static double CalculateBoxHeight(gpPln plane, Point3D fourthPoint)
        {
            return GeomUtils.PointPosition(plane, fourthPoint.GpPnt);
        }

        private void AnimationFinished()
        {
            var axis = Dependency.Steps[0].Get<gpAx1>();
            var secondPoint = Dependency.Steps[1].Get<Point3D>();

            var basePlane = new gpPln(axis.Location, axis.Direction);
            PreprocesHeight(basePlane);
            var height = Dependency.Steps[2].Get<double>();

            // Build the final box
            var builder = Dependency.DocumentNodeBuilder;
            builder[0].Axis3D = new Axis(axis);
            builder[1].TransformedPoint3D = secondPoint;
            builder[2].Real = height;
            builder.ExecuteFunction();
            Dependency.DocumentNodeBuilder = builder;
            // Resume the face picker
            Dependency.Inputs.Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
            // Reset the plane on which the mouse points are generated
            Dependency.Inputs.Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.ExcludedPlane);
        }
    }
}