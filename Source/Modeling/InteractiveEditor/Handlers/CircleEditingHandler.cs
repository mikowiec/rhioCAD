#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroSketchAdapter.Views;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace InteractiveEditor.Handlers
{
    /// <summary>
    ///   Implements circle editing code.
    /// </summary>
    public class CircleEditingHandler : GenericEditingShapeHandler
    {
        protected const int DistanceToObject = 1;

        public override int EditingPointsCount()
        {
            return 4;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            return FunctionNames.Triangle2DHandle;
        }

        public override gpAx2 GetPointLocation(int index)
        {
            //var transform = Node.Get<TransformationInterpreter>().CurrTransform;
            var transform = NodeBuilderUtils.GetGlobalTransformation(new NodeBuilder(NodeBuilderUtils.FindSketchNode(Node)));
            var ax2 = new gpAx2();
            var centerAxis=new gpAx1();
            if (Dependency[0].Name == InterpreterNames.Reference)
            {
                var circleLocation = Dependency[0].RefTransformedPoint3D.GpPnt;
                var pointBuilder = Dependency[0].ReferenceBuilder;
                var circleNormal = pointBuilder[0].Reference.Children[1].Get<Axis3DInterpreter>().Axis.Direction;
                
                centerAxis = new gpAx1(circleLocation, new gpDir(circleNormal.GpPnt.XYZ).Transformed(transform));
                ax2.Axis = (centerAxis);
            }
            if(Dependency[0].Name == InterpreterNames.Axis3D)
            {
                centerAxis = Dependency[0].TransformedAxis3D;
                ax2.Axis = (centerAxis);
            }
            var circleCenter = centerAxis;
            var pointOnCircle = GetPointOnCircle(centerAxis, Dependency[1].Real, transform);
            var radius = pointOnCircle.Distance(circleCenter.Location);

            var leftArrowVector = new gpVec(circleCenter.Location, pointOnCircle);
            leftArrowVector.Normalize();
            leftArrowVector.Multiply(radius + DistanceToObject);
            var leftArrowLocation = circleCenter.Location.Translated(leftArrowVector);

            var rightArrowVector = leftArrowVector.Reversed;
            var rightArrowLocation = circleCenter.Location.Translated(rightArrowVector);

            var topArrowVector = new gpVec(leftArrowVector.XYZ);
            topArrowVector.Cross(new gpVec(ax2.Direction));
            topArrowVector.Normalize();
            topArrowVector.Multiply(radius + DistanceToObject);
            var topArrowLocation = circleCenter.Location.Translated(topArrowVector);

            var bottomArrowVector = topArrowVector.Reversed;
            var bottomArrowLocation = circleCenter.Location.Translated(bottomArrowVector);

            switch (index)
            {
                case 0:
                    ax2.Location = (leftArrowLocation);
                    ax2.XDirection = (new gpDir(leftArrowVector));
                    return ax2;
                case 1:
                    ax2.Location = (topArrowLocation);
                    ax2.XDirection = (new gpDir(topArrowVector));
                    return ax2;
                case 2:
                    ax2.Location = (rightArrowLocation);
                    ax2.XDirection = (new gpDir(rightArrowVector));
                    return ax2;
                case 3:
                    ax2.Location = (bottomArrowLocation);
                    ax2.XDirection = (new gpDir(bottomArrowVector));
                    return ax2;
                default:
                    return null;
            }
        }

        /// <summary>
        ///   Builds a circle with the parameters passed and extracts a point locted on the circle
        /// </summary>
        protected static gpPnt GetPointOnCircle(gpAx1 axis, double radius, gpTrsf trsf)
        {
            var centerCoord = new gpAx2();
            centerCoord.Axis = (axis);
            var circle = new GeomCircle(centerCoord, radius);
            // Get the first point on the circle's parametric curve
            return circle.Value(circle.FirstParameter);//.Transformed(trsf);
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            var radiusConstraint = NodeBuilderUtils.ShapeHasConstraint(Node, Constraint2DNames.CircleRadiusFunction,
                                                                       Dependency[0].Node.Root.Get
                                                                       <DocumentContextInterpreter>().Document);
            // allow edits only if we don't have a radius constraint
            if (radiusConstraint == -1)
            {
                var transform = Node.Get<TransformationInterpreter>();
                switch (index)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        // The radius is the distance between the center and the new point
                        var dependency = TreeUtils.GetFunctionDependency(Node);
                        if (Dependency[0].Name == FunctionNames.Point || Dependency[0].Name == InterpreterNames.Reference)
                        {
                            dependency[1].Real =
                                vertex.Point.GpPnt.Distance(
                                    Dependency[0].RefTransformedPoint3D.GpPnt.Transformed(transform.CurrTransform));
                        }
                        if (Dependency[0].Name == FunctionNames.AxisHandle)
                        {
                            dependency[1].Real =
                                vertex.Point.GpPnt.Distance(
                                    Dependency[0].TransformedAxis3D.Location.Transformed(transform.CurrTransform));
                        }
                        break;
                }
                if (Dependency[0].Name == FunctionNames.Point || Dependency[0].Name == InterpreterNames.Reference)
                {
                    var document = Dependency[0].Node.Root.Get<DocumentContextInterpreter>().Document;
                    var sketchNode = Dependency[0].ReferenceBuilder[0].ReferenceBuilder[0].Node;
                    var constraintMapper =
                        new ConstraintDocumentHelper(document,
                                                     sketchNode);
                    constraintMapper.SetMousePosition(Dependency[0].Reference.Index);
                    var error = constraintMapper.ImpactAndSolve(Dependency[0].Node.Parent);
                }
            }
        }
    }
}