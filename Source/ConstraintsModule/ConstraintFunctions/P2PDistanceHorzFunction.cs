#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class P2PDistanceHorzFunction : Constraint2DFunction
    {
        public P2PDistanceHorzFunction()
            : base(Constraint2DNames.P2PDistanceHorzFunction)
        {
        }
    }
}