#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class ExtrudeHeightConstraint : ConstraintOneRealFunction
    {
        public ExtrudeHeightConstraint()
            : base(FunctionNames.ExtrudeHeightConstraint, 2)
        {
        }
    }
}