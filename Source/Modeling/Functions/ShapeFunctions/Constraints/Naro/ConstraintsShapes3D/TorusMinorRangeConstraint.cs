#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class TorusMinorRangeConstraint : ConstraintOneRealFunction
    {
        public TorusMinorRangeConstraint()
            : base(FunctionNames.TorusMinorRangeConstraint, 2)
        {
        }
    }
}