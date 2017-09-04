#region Usings

using Naro.Infrastructure.Interface.Constraints;
using ShapeFunctions.Utils;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Constraints.RealSizeLimits
{
    public class MiddleEdgeConstraint : ConstraintReferenceInterpreter
    {
        #region Overriden methods

        protected override void OnActivate()
        {
            base.OnActivate();
            Parent.OnModified += delegate { Execute(); };
        }

        public override void OnRemove()
        {
            if (Node != null)
            {
                Node.OnModified -= delegate { Execute(); };
            }
            base.OnRemove();
        }

        public override void Serialize(AttributeData data)
        {
        }

        public override void Deserialize(AttributeData data)
        {
        }

        #endregion

        #region Methods

        private void Execute()
        {
            var midPoint = DimensionUtils.ComputeMiddlePointPosition(Node, Data.ShapeCount);
            SetupPointCoordinate(midPoint);
        }

        #endregion
    }
}