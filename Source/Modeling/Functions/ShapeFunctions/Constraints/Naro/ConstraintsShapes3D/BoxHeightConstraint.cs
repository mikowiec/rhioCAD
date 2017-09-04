#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class BoxHeightConstraint : ConstraintOneRealFunction
    {
        public BoxHeightConstraint()
            : base(FunctionNames.BoxHeightConstraint, 2)
        {
        }
    }
}