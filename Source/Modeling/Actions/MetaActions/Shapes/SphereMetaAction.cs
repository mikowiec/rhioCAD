#region Usings

using System.Drawing;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActions.Shapes
{
    public class SphereMetaAction : MetaActionBase
    {
        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            dependency.FunctionName = FunctionNames.Sphere;

            dependency.Steps[1].OnCandidateUpdateHandler += SphereRadius;
            dependency.OnStepsCompletedHandler += AnimationFinished;

            dependency.AutoReset = true;

            Dependency.Steps[0].HintText = ModelingResources.SphereStep1;
            Dependency.Steps[1].HintText = ModelingResources.SphereStep2;
        }

        private void SphereRadius(bool updateShape)
        {
            gpPnt radiusPoint = null;

            if (Dependency.Steps[1].Data is Mouse3DPosition)
            {
                // If point received from mouse
                radiusPoint = Dependency.Steps[1].Get<Mouse3DPosition>().Point.GpPnt;
                var radius = Dependency.Steps[0].Get<Point3D>().GpPnt.Distance(radiusPoint);
                Dependency.Steps[1].Data = radius;
            }
            else if (Dependency.Steps[1].Data is Point3D)
            {
                var currentPoint = Dependency.Steps[1].Get<Point3D>().GpPnt;
                var radius = Dependency.Steps[0].Get<Point3D>().GpPnt.Distance(currentPoint);
                Dependency.Steps[1].Data = radius;
            }
            Dependency.AnimationNodeBuilder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.Sphere);
            var builder = Dependency.AnimationNodeBuilder;
            builder[0].TransformedPoint3D = Dependency.Steps[0].Get<Point3D>();
            builder[1].Real = Dependency.Steps[1].Get<double>();
            builder.EnableSelection = false;
            builder.Color = Color.Red;
            builder.Transparency = 0.4;
            
            //builder.ExecuteFunction();
            //var trsf = builder.Node.Get<TransformationInterpreter>();
            //trsf.Pivot = new gpPnt(0,0,0);
            builder.Node.Set<TransformationInterpreter>().Pivot = new gpPnt(0,0,0);
            builder.ExecuteFunction();
            Dependency.AnimationNodeBuilder = builder;
            // Build a distance dimension just for animation purposes
            if (radiusPoint == null) return;
            var animationBuilder = new NodeBuilder(Dependency.AnimationDocument, FunctionNames.PointsDimension);
            var firstDimensionPoint = Dependency.Steps[0].Get<Point3D>().GpPnt;
            animationBuilder[0].TransformedPoint3D = new Point3D(firstDimensionPoint);
            var secondPoint = new Point3D(radiusPoint);
            animationBuilder[1].TransformedPoint3D = secondPoint;
            var textLocation = secondPoint;
            textLocation.X++;
            textLocation.Y++;
            textLocation.Z++;
            animationBuilder[2].TransformedPoint3D = textLocation;
            animationBuilder.EnableSelection = false;
            animationBuilder.ExecuteFunction();
        }

        private void AnimationFinished()
        {
            var builder = Dependency.DocumentNodeBuilder;
            builder[0].TransformedPoint3D = Dependency.Steps[0].Get<Point3D>();
            builder[1].Real = Dependency.Steps[1].Get<double>();
            builder.ExecuteFunction();
            Dependency.DocumentNodeBuilder = builder;
        }
    }
}