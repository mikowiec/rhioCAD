#region Usings

using NaroSketchAdapter.ConstraintFunctions;
using ShapeFunctionsInterface.Functions;

#endregion

namespace NaroSketchAdapter.Common
{
    internal class TwoShapesConstraintFunctionCreator : FunctionCreatorBase
    {
        private readonly string _functionName;

        public TwoShapesConstraintFunctionCreator(string functionName)
        {
            _functionName = functionName;
        }

        public override FunctionBase Create()
        {
            return new ConstraintTwoShapes(_functionName);
        }
    }

    internal class OneShapesConstraintFunctionCreator : FunctionCreatorBase
    {
        private readonly string _functionName;

        public OneShapesConstraintFunctionCreator(string functionName)
        {
            _functionName = functionName;
        }

        public override FunctionBase Create()
        {
            return new ConstraintOneShape(_functionName);
        }
    }
}