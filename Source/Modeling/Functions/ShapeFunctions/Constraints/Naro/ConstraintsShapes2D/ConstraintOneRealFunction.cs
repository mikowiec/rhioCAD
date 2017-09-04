#region Usings

using System;
using NaroConstants.Names;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes2D
{
    public abstract class ConstraintOneRealFunction : FunctionBase
    {
        private readonly int _index;
        private bool _beginUpdate;

        protected ConstraintOneRealFunction(string name, int index) : base(name)
        {
            _index = index;
            // Reference shape that contains the circle
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // the value or ranged constraint
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        protected void ApplyConstraint(NodeBuilder constraintBuilder)
        {
            var oldRangeValue = constraintBuilder[_index].Real;
            var newRangeValue = Dependency[1].Real;
            if (Math.Abs(newRangeValue - oldRangeValue) > Precision.Confusion)
                constraintBuilder[_index].Real = newRangeValue;

            Parent.Set<TreeViewVisibilityInterpreter>();
        }

        public override bool Execute()
        {
            if (_beginUpdate) return true;
            _beginUpdate = true;
            ApplyConstraint(Dependency[0].ReferenceBuilder);
            _beginUpdate = false;
            return true;
        }
    }
}