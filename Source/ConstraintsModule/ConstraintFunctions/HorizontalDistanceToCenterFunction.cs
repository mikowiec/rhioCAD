#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace ConstraintsModule.ConstraintFunctions
{
    internal class PositionToCenterFunction : Constraint2DFunction
    {
        public PositionToCenterFunction()
            : base(Constraint2DNames.PositionToCenterFunction)
        {
            AddDependency(InterpreterNames.Reference);
            AddDependency(InterpreterNames.Real);
            AddDependency(InterpreterNames.Real);
        }
    }
}