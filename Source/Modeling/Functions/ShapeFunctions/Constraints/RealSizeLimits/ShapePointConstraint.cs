#region Usings

using System;
using Naro.Infrastructure.Interface.Constraints;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Constraints.RealSizeLimits
{
    public class ShapePointConstraint : ConstraintReferenceInterpreter
    {
        #region Overridden methods

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
            if (Node == null)
                return;
            var midPoint = ComputePointPosition(Node, Data.ShapeCount);
            SetupPointCoordinate(midPoint);
        }

        public static Point3D ComputePointPosition(Node node, int vertexIndex)
        {
            if (node == null) throw new ArgumentNullException("node");
            return ShapeUtils.ExtractShape(node) == null
                       ? new Point3D()
                       : new Point3D(ShapeUtils.ExtractShapesPoint(node, vertexIndex));
        }

        #endregion
    }
}