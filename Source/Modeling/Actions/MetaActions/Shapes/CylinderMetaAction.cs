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
    public class CylinderMetaAction : MetaActionBase
    {
        #region Overriden methods

        protected override void FillUiDependencies()
        {
            Dependency.FunctionName = FunctionNames.Cylinder;

            Dependency.Steps[3].Real = 360;
            Dependency.Steps[3].IsDefaultValue = true;

            Dependency.AutoReset = true;

            Dependency.Steps[1].OnCandidateUpdateHandler += CirclePreview;
            Dependency.Steps[2].OnCandidateUpdateHandler += CylinderPreview;
            Dependency.OnStepsCompletedHandler += AnimationFinished;

            Dependency.Steps[0].HintText = ModelingResources.CylinderStep1;
            Dependency.Steps[1].HintText = ModelingResources.CylinderStep2;
            Dependency.Steps[2].HintText = ModelingResources.CylinderStep3;
        }

        #endregion

        #region Methods

        private void CirclePreview(bool updateShape)
        {
            double radius;

            if (Dependency.Steps[1].Data is Mouse3DPosition)
            {
                // If point received from mouse
                Dependency.Steps[0].Get<gpAx1>().Direction =(
                    Dependency.Steps[1].Get<Mouse3DPosition>().Axis.Direction);
                var currentPoint = Dependency.Steps[1].Get<Mouse3DPosition>().Point.GpPnt;
                radius = Dependency.Steps[0].Get<gpAx1>().Location.Distance(currentPoint);
                Dependency.Steps[1].Data = radius;
            }
            else
            {
                // If radius received from command line
                radius = Dependency.Steps[1].Get<double>();
            }

            // Make the animation
            // Dependency.AnimationNodeBuilder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Circle);
           
            var sketchCreator = new SketchCreator(Dependency.AnimationDocument);
            var center =
               sketchCreator.GetPoint(new Point3D((Dependency.Steps[0].Data as gpAx1).Location)).Node;
            sketchCreator = new SketchCreator(Dependency.AnimationDocument);
            var builder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Circle);
            builder[0].Reference =center;
            builder[1].Real = radius;
            builder.EnableSelection = false;
            builder.Color = Color.Red;
            builder.DisplayMode = AISDisplayMode.AIS_WireFrame;
            builder.Transparency = 0.2;
            builder.ExecuteFunction();
            Dependency.AnimationNodeBuilder = builder;
        }

        private void CylinderPreview(bool updateShape)
        {
            double height;

            if (Dependency.Steps[2].Data is Mouse3DPosition)
            {
                // If point received from mouse, recalculate the axis direction
                var plane = new GeomPlane(Dependency.Steps[0].Get<gpAx1>().Location,
                                             Dependency.Steps[0].Get<gpAx1>().Direction);
                height = GeomUtils.PointPosition(plane.Pln, Dependency.Steps[2].Get<Mouse3DPosition>().Point.GpPnt);
            }
            else
            {
                // If height received from command line
                height = Dependency.Steps[2].Get<double>();
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

            height = Math.Abs(height);
            Dependency.Steps[2].Data = height;

            // Prevent the mouse from generating point on the base
            var basePoint = axis.Location;
            var excludedPlane = new GeomPlane(basePoint, axis.Direction);
            Dependency.Inputs.Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.ExcludedPlane,
                                                                        excludedPlane.Pln);
            // After the base is drawn disable the face picker
            Dependency.Inputs.Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);

            var builder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Cylinder);
            DrawCylinder(ref builder, axis, Dependency.Steps[1].Get<double>(), height, GeomUtils.DegreesToRadians(360),
                         true,
                         false);

            // Build a distance dimension just for animation purposes
            Dependency.AnimationNodeBuilder = new NodeBuilder(Dependency.AnimationDocument,
                                                              FunctionNames.PointsDimension);
            var animationBuilder = Dependency.AnimationNodeBuilder;
            var firstTransformedPoint = axis.Location;
            var firstPoint = new Point3D(firstTransformedPoint);
            animationBuilder[0].TransformedPoint3D = firstPoint;
            var translationVector = new gpVec(axis.Direction);
            translationVector.Normalize();
            translationVector.Multiply(height);
            var secondPoint = new Point3D(firstPoint.GpPnt.Translated(translationVector));
            animationBuilder[1].TransformedPoint3D = secondPoint;
            var textLocation = GeomUtils.ComputeMidPoint(firstPoint, secondPoint);
            textLocation.X++;
            textLocation.Y++;
            textLocation.Z++;
            animationBuilder[2].TransformedPoint3D = textLocation;
            animationBuilder[3].Integer = (int) DsgPrsArrowSide.DsgPrs_AS_FIRSTPT_LASTAR;
            animationBuilder.EnableSelection = false;
            animationBuilder.ExecuteFunction();
            Dependency.AnimationNodeBuilder = animationBuilder;
        }

        private static void DrawCylinder(ref NodeBuilder builder, gpAx1 axis, double radius, double length,
                                         double angle,
                                         bool animation, bool enableSelection)
        {
            builder[0].Axis3D = new Axis(axis);
            builder[1].Real = radius;
            builder[2].Real = length;
            builder[3].Real = angle;
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
            DrawCylinder(ref builder, Dependency.Steps[0].Get<gpAx1>(), Dependency.Steps[1].Get<double>(),
                         Dependency.Steps[2].Get<double>(), GeomUtils.DegreesToRadians(360), false, true);
            Dependency.DocumentNodeBuilder = builder;
            // Resume the face picker
            Dependency.Inputs.Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
            // Reset the plane on which the mouse points are generated
            Dependency.Inputs.Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.ExcludedPlane);
        }

        #endregion
    }
}