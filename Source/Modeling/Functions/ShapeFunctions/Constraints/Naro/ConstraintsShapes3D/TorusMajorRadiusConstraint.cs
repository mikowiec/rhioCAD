#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class TorusMajorRadiusConstraint : ConstraintOneRealFunction
    {
        public TorusMajorRadiusConstraint()
            : base(FunctionNames.TorusMajorRangeConstraint, 1)
        {
        }
    }
}