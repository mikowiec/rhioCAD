#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class LineLengthFunction : Constraint2DFunction
    {
        public LineLengthFunction()
            : base(Constraint2DNames.LineLengthFunction)
        {
            // the 2 points references
            AddDependency(InterpreterNames.Reference);
            AddDependency(InterpreterNames.Reference);
            // line length reference
            AddDependency(InterpreterNames.Real);
        }
    }
}