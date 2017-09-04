#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class CylinderHeightConstraint : ConstraintOneRealFunction
    {
        public CylinderHeightConstraint()
            : base(FunctionNames.CylinderHeightConstraint, 2)
        {
        }
    }
}