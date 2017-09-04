#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroBasicPipes.Actions;
using NaroCppCore.Occ.gp;
using TreeData.AttributeInterpreter;

#endregion

namespace InteractiveEditor.Handlers
{
    public class SphereEditingHandler : CircleEditingHandler
    {
        public override gpAx2 GetPointLocation(int index)
        {
            var transform = Node.Get<TransformationInterpreter>().CurrTransform;

            var ax2 = new gpAx2();
            ax2.Location = Dependency[0].TransformedPoint3D.GpPnt;

            var circleCenter = Dependency[0].TransformedPoint3D.GpPnt;
            var circleAxis = new gpAx1();
            circleAxis.Location = (Dependency[0].TransformedPoint3D.GpPnt);
            var pointOnCircle = GetPointOnCircle(circleAxis, Dependency[1].Real, transform);
            var radius = pointOnCircle.Distance(circleCenter);

            var leftArrowVector = new gpVec(circleCenter, pointOnCircle);
            leftArrowVector.Normalize();
            leftArrowVector.Multiply(radius + DistanceToObject);
            var leftArrowLocation = circleCenter.Translated(leftArrowVector);

            var rightArrowVector = leftArrowVector.Reversed;
            var rightArrowLocation = circleCenter.Translated(rightArrowVector);

            var topArrowVector = new gpVec(leftArrowVector.XYZ);
            topArrowVector.Cross(new gpVec(ax2.Direction));
            topArrowVector.Normalize();
            topArrowVector.Multiply(radius + DistanceToObject);
            var topArrowLocation = circleCenter.Translated(topArrowVector);

            var bottomArrowVector = topArrowVector.Reversed;
            var bottomArrowLocation = circleCenter.Translated(bottomArrowVector);

            switch (index)
            {
                case 0:
                    ax2.Location = (leftArrowLocation);
                    ax2.XDirection = (new gpDir(leftArrowVector));
                    return ax2;
                case 1:
                    ax2.Location =(topArrowLocation);
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

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
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
                    dependency[1].Real =
                        vertex.Point.GpPnt.Distance(
                            Dependency[0].TransformedPoint3D.GpPnt.Transformed(transform.CurrTransform));
                    break;
            }
        }
    }
}