#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class ConeMajorRadiusConstraint : ConstraintOneRealFunction
    {
        public ConeMajorRadiusConstraint()
            : base(FunctionNames.ConeMajorRadiusConstraint, 2)
        {
        }
    }
}