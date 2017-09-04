#region Usings

using NaroConstants.Names;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Constraints.Naro
{
    public class RangeSizeConstraint : FunctionBase
    {
        public RangeSizeConstraint() : base(FunctionNames.RangeSizeConstraint)
        {
            // Reference shape on source shape
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Source value intentifier
            Dependency.AddAttributeType(InterpreterNames.Integer);
            // Minimum value
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Maximum value
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var node = Dependency[0].Reference;
            var expectedMinValue = Dependency[2].Real;
            var expectedMaxValue = Dependency[3].Real;
            var valueNodeId = Dependency[1].Integer;
            var refDependency = node.Get<FunctionInterpreter>().Dependency[valueNodeId];
            var actualValue = refDependency.Real;
            if (actualValue < expectedMinValue)
            {
                refDependency.Real = expectedMinValue;
            }
            if (actualValue > expectedMaxValue)
            {
                refDependency.Real = expectedMaxValue;
            }
            return true;
        }
    }
}