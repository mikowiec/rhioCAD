#region Usings

using ShapeFunctionsInterface.Functions;

#endregion

namespace NaroSketchAdapter.Common
{
    public class Constraint2DFunction : FunctionBase
    {
        protected Constraint2DFunction(string name) : base(name)
        {
        }

        public override bool Execute()
        {
            //logic solved by SketchSolve
            return true;
        }
    }
}