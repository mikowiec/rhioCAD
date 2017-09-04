#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class ArcRadiusFunction : Constraint2DFunction
    {
        public ArcRadiusFunction()
            : base(Constraint2DNames.ArcRadiusFunction)
        {
            AddDependency(InterpreterNames.Reference);
            AddDependency(InterpreterNames.Real);
        }
    }
}