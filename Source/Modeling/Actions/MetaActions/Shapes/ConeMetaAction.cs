#region Usings

using System;
using System.Drawing;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using OccCode;

using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActions.Shapes
{
    public class ConeMetaAction : MetaActionBase
    {
        #region Overriden Methods

        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            Dependency.FunctionName = FunctionNames.Cone;

            dependency.Steps[2].Real = 0;
            dependency.Steps[2].IsDefaultValue = true;
            dependency.Steps[4].Real = GeomUtils.DegreesToRadians(360);
            dependency.Steps[4].IsDefaultValue = true;

            dependency.Steps[1].OnCandidateUpdateHandler += ConeBaseCircle;
            dependency.Steps[3].OnCandidateUpdateHandler += ConeHeight;
            dependency.OnStepsCompletedHandler += AnimationFinished;

            Dependency.AutoReset = true;

            Dependency.Steps[0].HintText = ModelingResources.ConeStep1;
            Dependency.Steps[1].HintText = ModelingResources.ConeStep2;
            Dependency.Steps[3].HintText = ModelingResources.ConeStep3;
        }

        #endregion

        #region Methods

        private void ConeBaseCircle(bool updateShape)
        {
            if (Dependency.Steps[1].Data is Mouse3DPosition)
            {
                // If point received from mouse
                Dependency.Steps[0].Get<gpAx1>().Direction = Dependency.Steps[1].Get<Mouse3DPosition>().Axis.Direction;
                var currentPoint = Dependency.Steps[1].Get<Mouse3DPosition>().Point.GpPnt;
                Dependency.Steps[1].Data = Dependency.Steps[0].Get<gpAx1>().Location.Distance(currentPoint);
            }
            else if (Dependency.Steps[1].Data is Point3D)
            {
                var currentPoint = Dependency.Steps[1].Get<Point3D>().GpPnt;
                Dependency.Steps[1].Data = Dependency.Steps[0].Get<gpAx1>().Location.Distance(currentPoint);
            }

            var sketchCreator = new SketchCreator(Dependency.AnimationDocument);
            var center =
               sketchCreator.GetPoint(new Point3D((Dependency.Steps[0].Data as gpAx1).Location)).Node;
            sketchCreator = new SketchCreator(Dependency.AnimationDocument);
            var builder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Circle);
            builder[0].Reference = center;
            builder[1].Real = Dependency.Steps[1].Get<double>();
            builder.EnableSelection = false;
            builder.Color = Color.Red;
            builder.DisplayMode = AISDisplayMode.AIS_WireFrame;
            builder.Transparency = 0.2;
            builder.ExecuteFunction();
            Dependency.AnimationNodeBuilder = builder;
        }

        private void ConeHeight(bool updateShape)
        {
            double height;

            if (Dependency.Steps[3].Data is Mouse3DPosition)
            {
                // If point received from mouse, recalculate the axis direction
                var plane = new GeomPlane(Dependency.Steps[0].Get<gpAx1>().Location,
                                             Dependency.Steps[0].Get<gpAx1>().Direction);
                height = GeomUtils.PointPosition(plane.Pln, Dependency.Steps[3].Get<Mouse3DPosition>().Point.GpPnt);
                Dependency.Steps[3].Data = height;
            }
            else
            {
                // If height received from command line
                height = Dependency.Steps[3].Get<double>();
            }

            if (Math.Abs(height) < 0.01)
            {
                height = 1;
            }
            var axis = Dependency.Steps[0].Get<gpAx1>();
            if (height > 0)
            {
                axis = axis.Reversed;
                Dependency.Steps[0].Data = axis;
            }

            // Prevent the mouse from generating point on the base
            var basePoint = axis.Location;
            var excludedPlane = new GeomPlane(basePoint, axis.Direction);
            Dependency.Inputs.Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.ExcludedPlane,
                                                                        excludedPlane.Pln);
            // After the base is drawn disable the face picker
            Dependency.Inputs.Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
            Dependency.AnimationNodeBuilder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Cone);
            var builder = Dependency.AnimationNodeBuilder;
            DrawCone(ref builder, Dependency.Steps[1].Get<double>(), height, axis, true, false);

            // Build a distance dimension just for animation purposes
            var animationBuilder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.PointsDimension);
            var firstTransformedPoint = axis.Location;
            var firstPoint = new Point3D(firstTransformedPoint);
            animationBuilder[0].TransformedPoint3D = firstPoint;
            var translationVector = new gpVec(axis.Direction);
            translationVector.Normalize();
            translationVector.Multiply(height);
            var secondPoint = firstPoint.GpPnt.Translated(translationVector.Reversed);
            animationBuilder[1].TransformedPoint3D = new Point3D(secondPoint);
            var textLocation = new Point3D(secondPoint);
            textLocation.X++;
            textLocation.Y++;
            textLocation.Z++;
            animationBuilder[2].TransformedPoint3D = textLocation;
            animationBuilder[3].Integer = (int) DsgPrsArrowSide.DsgPrs_AS_FIRSTPT_LASTAR;
            animationBuilder.EnableSelection = false;
            animationBuilder.ExecuteFunction();
            Dependency.AnimationNodeBuilder = animationBuilder;
        }

        private static void DrawCone(ref NodeBuilder builder, double radius, double height, gpAx1 axis,
                                     bool animation,
                                     bool enableSelection)
        {
            builder[0].Axis3D = new Axis(axis);
            builder[1].Real = radius;
            builder[2].Real = 0;
            builder[3].Real = Math.Abs(height);
            builder[4].Real = GeomUtils.DegreesToRadians(360);
            if (animation)
            {
                builder.Color = Color.White;
                builder.Transparency = 0.3;
            }
            builder.EnableSelection = enableSelection;
            builder.ExecuteFunction();
        }

        private void AnimationFinished()
        {
            var builder = Dependency.DocumentNodeBuilder;
            DrawCone(ref builder, Dependency.Steps[1].Get<double>(), Dependency.Steps[3].Get<double>(),
                     Dependency.Steps[0].Get<gpAx1>(), false, true);
            Dependency.DocumentNodeBuilder = builder;
            // Resume the face picker
            Dependency.Inputs.Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
            // Reset the plane on which the mouse points are generated
            Dependency.Inputs.Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.ExcludedPlane);
        }

        #endregion
    }
}