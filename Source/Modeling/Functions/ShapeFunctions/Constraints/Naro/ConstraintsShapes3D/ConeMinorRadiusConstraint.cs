#region Usings

using NaroConstants.Names;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes3D
{
    internal class ConeMinorRadiusConstraint : ConstraintOneRealFunction
    {
        public ConeMinorRadiusConstraint()
            : base(FunctionNames.ConeMinorRadiusConstraint, 1)
        {
        }
    }
}