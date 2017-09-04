#region Usings

using Naro.Infrastructure.Interface.Constraints;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Constraints.RealSizeLimits
{
    public class MiddleRectanglePointConstraint : ConstraintReferenceInterpreter
    {
        #region Methods

        private void Execute()
        {
            var midPoint = ComputeMiddleOfFace(Node);
            SetupPointCoordinate(midPoint);
        }

        #endregion

        #region Overriden Methods

        protected override void OnActivate()
        {
            base.OnActivate();
            Parent.OnModified += delegate { Execute(); };
        }

        public override void OnRemove()
        {
            if (Node != null)
            {
                Parent.OnModified -= delegate { Execute(); };
            }
            base.OnRemove();
        }

        #endregion

        public static Point3D ComputeMiddleOfFace(Node shapeNode)
        {
            var builder = new NodeBuilder(shapeNode);
            var firstPoint = builder[0].Axis3D.Location;
            var secondPoint = builder[1].TransformedPoint3D;

            var middleOfFace = new Point3D(
                (secondPoint.X + firstPoint.X)/2,
                (secondPoint.Y + firstPoint.Y)/2,
                (secondPoint.Z + firstPoint.Z)/2
                );
            return middleOfFace;
        }
    }
}