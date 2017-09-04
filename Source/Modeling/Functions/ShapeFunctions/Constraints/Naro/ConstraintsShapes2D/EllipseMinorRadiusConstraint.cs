#region Usings

using System;
using NaroConstants.Names;

using ShapeFunctionsInterface.Utils;
using NaroCppCore.Occ.Precision;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes2D
{
    internal class EllipseMinorRadiusConstraint : EllipseConstraint
    {
        public EllipseMinorRadiusConstraint()
            : base(FunctionNames.EllipseMinorRadiusConstraint)
        {
        }

        protected override bool ConstraintApply(NodeBuilder ellipse)
        {
            if (Math.Abs(MinorRadius - NewValue) < Precision.Confusion)
                return true;
            SetMinorRadius(NewValue);
            return true;
        }
    }
}