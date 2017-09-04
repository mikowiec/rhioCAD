#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class SymmetricPointsFunction : Constraint2DFunction
    {
        public SymmetricPointsFunction()
            : base(Constraint2DNames.SymmetricPointsFunction)
        {
        }
    }
}