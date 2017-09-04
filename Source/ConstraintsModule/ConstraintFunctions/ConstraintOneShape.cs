#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class ConstraintOneShape : Constraint2DFunction
    {
        public ConstraintOneShape(string name)
            : base(name)
        {
            AddDependency(InterpreterNames.Reference);
        }
    }
}