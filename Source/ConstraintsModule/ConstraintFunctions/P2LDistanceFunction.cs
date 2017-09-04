#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class P2LDistanceFunction : Constraint2DFunction
    {
        public P2LDistanceFunction()
            : base(Constraint2DNames.P2LDistanceFunction)
        {
        }
    }
}