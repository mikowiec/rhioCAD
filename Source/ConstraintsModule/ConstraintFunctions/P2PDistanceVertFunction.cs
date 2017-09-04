#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class P2PDistanceVertFunction : Constraint2DFunction
    {
        public P2PDistanceVertFunction()
            : base(Constraint2DNames.P2PDistanceVertFunction)
        {
        }
    }
}