#region Usings

using System;
using NaroConstants.Names;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Constraints.Naro
{
    public class FixedSizeConstraint : FunctionBase
    {
        public FixedSizeConstraint() : base(FunctionNames.FixedSizeConstraint)
        {
            // Reference shape on source shape
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Source value intentifier
            Dependency.AddAttributeType(InterpreterNames.Integer);
            // Expected value
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var node = Dependency[0].Reference;
            var expectedValue = Dependency[2].Real;
            var valueNodeId = Dependency[1].Integer;
            var refDependency = node.Get<FunctionInterpreter>().Dependency;
            var actualValue = refDependency[valueNodeId].Real;
            if (Math.Abs(actualValue - expectedValue) < 1e-12)
            {
                refDependency[valueNodeId].Real = expectedValue;
            }
            return true;
        }
    }
}