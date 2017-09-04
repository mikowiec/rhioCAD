#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class SphereRadiusConstraint : ConstraintOneRealFunction
    {
        public SphereRadiusConstraint()
            : base(FunctionNames.SphereRadiusConstraint, 1)
        {
        }
    }
}