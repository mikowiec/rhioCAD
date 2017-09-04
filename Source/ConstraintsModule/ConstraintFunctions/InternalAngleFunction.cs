#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace ConstraintsModule.ConstraintFunctions
{
    internal class InternalAngleFunction : Constraint2DFunction
    {
        public InternalAngleFunction()
            : base(Constraint2DNames.InternalAngleFunction)
        {
        }
    }
}