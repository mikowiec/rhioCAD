#region Usings

using Naro.Infrastructure.Interface.Constraints;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Constraints.RealSizeLimits
{
    public class IndexPointConstraintInterpreter : ConstraintReferenceInterpreter
    {
        #region Methods

        private void Execute()
        {
            var result = NodeBuilderUtils.GetNodePoint(Parent);
            if (result != null) SetupPointCoordinate((Point3D) result);
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
                Node.OnModified -= delegate { Execute(); };
            }
            base.OnRemove();
        }

        #endregion
    }
}