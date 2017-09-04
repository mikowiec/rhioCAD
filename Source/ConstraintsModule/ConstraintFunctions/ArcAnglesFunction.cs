#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class ArcAnglesFunction : Constraint2DFunction
    {
        public ArcAnglesFunction()
            : base(Constraint2DNames.ArcAnglesFunction)
        {
            AddDependency(InterpreterNames.Reference);
            AddDependency(InterpreterNames.Real);
            AddDependency(InterpreterNames.Real);
        }
    }
}