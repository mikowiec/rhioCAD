#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class ConeHeightConstraint : ConstraintOneRealFunction
    {
        public ConeHeightConstraint()
            : base(FunctionNames.ConeHeightConstraint, 3)
        {
        }
    }
}