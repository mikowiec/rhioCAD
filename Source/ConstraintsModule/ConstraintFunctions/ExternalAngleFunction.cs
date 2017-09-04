#region Usings

using NaroConstants.Names;
using NaroSketchAdapter.Common;

#endregion

namespace NaroSketchAdapter.ConstraintFunctions
{
    internal class ExternalAngleFunction : Constraint2DFunction
    {
        public ExternalAngleFunction()
            : base(Constraint2DNames.ExternalAngleFunction)
        {
        }
    }
}