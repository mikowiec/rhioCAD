#region Usings

using System.Drawing;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.gp;

using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActions.Shapes
{
    public class TorusMetaAction : MetaActionBase
    {
        private gpPnt _lastPoint;

        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            dependency.FunctionName = FunctionNames.Torus;

            dependency.AutoReset = true;

            Dependency.Steps[1].OnCandidateUpdateHandler += CirclePreview;
            Dependency.Steps[2].OnCandidateUpdateHandler += TorusPreview;
            Dependency.OnStepsCompletedHandler += AnimationFinished;

            Dependency.Steps[0].HintText = ModelingResources.TorusStep1;
            Dependency.Steps[1].HintText = ModelingResources.TorusStep2;
            Dependency.Steps[2].HintText = ModelingResources.TorusStep3;
        }

        private void CirclePreview(bool updateShape)
        {
            double radius;

            if (Dependency.Steps[1].Data is Mouse3DPosition)
            {
                // If point received from mouse
                _lastPoint = Dependency.Steps[1].Get<Mouse3DPosition>().Point.GpPnt;
                Dependency.Steps[0].Get<gpAx1>().Direction = Dependency.Steps[1].Get<Mouse3DPosition>().Axis.Direction;
                radius = Dependency.Steps[0].Get<gpAx1>().Location.Distance(_lastPoint);
                Dependency.Steps[1].Data = radius;
            }
            else if (Dependency.Steps[1].Data is Point3D)
            {
                var currentPoint = Dependency.Steps[1].Get<Point3D>().GpPnt;
                radius = Dependency.Steps[0].Get<gpAx1>().Location.Distance(currentPoint);
                Dependency.Steps[1].Data = radius;
            }
            else
            {
                // If radius received from command line
                radius = Dependency.Steps[1].Get<double>();
            }

            // Make the animation
            var sketchCreator = new SketchCreator(Dependency.AnimationDocument);
            
           // builder[1].Reference = sketchCreator.GetPoint(Dependency.Steps[0].Get<Point3D>()).Node;
            var center =
                sketchCreator.GetPoint(new Point3D((Dependency.Steps[0].Data as gpAx1).Location)).Node;
            sketchCreator = new SketchCreator(Dependency.AnimationDocument);
            var builder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Circle);
            builder[0].Reference = center;
            builder[1].Real = radius;
            builder.EnableSelection = false;
            builder.Color = Color.Red;
            builder.DisplayMode = AISDisplayMode.AIS_WireFrame;
            builder.Transparency = 0.2;
            builder.ExecuteFunction();
            Dependency.AnimationNodeBuilder = builder;
        }

        private void TorusPreview(bool updateShape)
        {
            double externalRadius;

            if (Dependency.Steps[2].Data is Mouse3DPosition)
            {
                if (_lastPoint == null)
                    return;
                // If point received from mouse, recalculate the axis direction
                externalRadius = Dependency.Steps[2].Get<Mouse3DPosition>().Point.GpPnt.Distance(_lastPoint);
                Dependency.Steps[2].Data = externalRadius;
            }
            else
            {
                // If height received from command line
                externalRadius = Dependency.Steps[2].Get<double>();
            }

            var builder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Torus);
            DrawTorus(ref builder, Dependency.Steps[0].Get<gpAx1>(), Dependency.Steps[1].Get<double>(),
                      externalRadius,
                      true, false);
            Dependency.AnimationNodeBuilder = builder;
        }

        private static void DrawTorus(ref NodeBuilder builder, gpAx1 axis, double radius, double externalRadius,
                                      bool animation, bool enableSelection)
        {
            builder[0].Axis3D = new Axis(axis);
            builder[1].Real = radius;
            builder[2].Real = externalRadius;
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
            DrawTorus(ref builder, Dependency.Steps[0].Get<gpAx1>(), Dependency.Steps[1].Get<double>(),
                      Dependency.Steps[2].Get<double>(), false, true);
            Dependency.DocumentNodeBuilder = builder;
        }
    }
}