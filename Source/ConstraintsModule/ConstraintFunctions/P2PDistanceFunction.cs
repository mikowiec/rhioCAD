#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class P2PDistanceFunction : Constraint2DFunction
    {
        public P2PDistanceFunction()
            : base(Constraint2DNames.P2PDistanceFunction)
        {
            AddDependency(InterpreterNames.Reference);
            AddDependency(InterpreterNames.Reference);
            AddDependency(InterpreterNames.Real);
        }
    }
}