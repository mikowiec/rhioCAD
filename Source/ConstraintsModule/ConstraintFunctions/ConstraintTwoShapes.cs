#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    public class ConstraintTwoShapes : Constraint2DFunction
    {
        public ConstraintTwoShapes(string name) : base(name)
        {
            AddDependency(InterpreterNames.Reference);
            AddDependency(InterpreterNames.Reference);
        }
    }
}