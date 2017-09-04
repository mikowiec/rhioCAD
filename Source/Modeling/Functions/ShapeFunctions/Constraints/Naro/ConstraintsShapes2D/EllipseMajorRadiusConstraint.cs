#region Usings

using System;
using NaroConstants.Names;

using ShapeFunctionsInterface.Utils;
using NaroCppCore.Occ.Precision;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes2D
{
    internal class EllipseMajorRadiusConstraint : EllipseConstraint
    {
        public EllipseMajorRadiusConstraint()
            : base(FunctionNames.EllipseMajorRadiusConstraint)
        {
        }

        protected override bool ConstraintApply(NodeBuilder ellipse)
        {
            if (Math.Abs(MajorRadius - NewValue) < Precision.Confusion)
                return true;

            SetMajorRadius(EllipseBuilder, NewValue);

            return true;
        }
    }
}