#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace ConstraintsModule.ConstraintFunctions
{
    internal class CircleRadiusFunction : Constraint2DFunction
    {
        public CircleRadiusFunction()
            : base(Constraint2DNames.CircleRadiusFunction)
        {
            
            AddDependency(InterpreterNames.Reference);
            AddDependency(InterpreterNames.Real);
        }
    }
}