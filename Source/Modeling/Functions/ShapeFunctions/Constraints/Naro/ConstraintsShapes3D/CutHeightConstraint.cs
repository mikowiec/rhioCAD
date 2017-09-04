#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class CutHeightConstraint : ConstraintOneRealFunction
    {
        public CutHeightConstraint()
            : base(FunctionNames.CutHeightConstraint, 1)
        {
        }
    }
}