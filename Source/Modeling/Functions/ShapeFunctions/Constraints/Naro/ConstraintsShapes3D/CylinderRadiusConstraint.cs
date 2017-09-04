#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;
using ShapeFunctionsInterface.Utils;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class CylinderRadiusConstraint : ConstraintOneRealFunction
    {
        public CylinderRadiusConstraint()
            : base(FunctionNames.CylinderRadiusConstraint, 1)
        {
        }

        public override bool Execute()
        {
            return ConstraintCircleRange(Dependency[0].ReferenceBuilder);
        }

        private bool ConstraintCircleRange(NodeBuilder circleNode)
        {
            ApplyConstraint(circleNode);
            return true;
        }
    }
}