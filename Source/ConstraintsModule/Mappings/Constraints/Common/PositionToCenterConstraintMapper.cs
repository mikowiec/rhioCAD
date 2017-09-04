#region Usings

using System.Collections.Generic;
using ConstraintsModule.Common;
using ConstraintsModule.Constraints;
using ConstraintsModule.Primitives;
using SketchSolve.Constraints;

#endregion

namespace ConstraintsModule.Mappings.Constraints.Common
{
    internal class PositionToCenterConstraintMapper : ConstraintMapperBase
    {
        protected override List<ConstraintRefBase> MapToSolverRef()
        {
            var constrHorizontal = new HorizontalDistanceToCenterRef()
            {
                P1 = new RefPoint(ShapeToParamIndex[Builder[0].Reference.Index], ShapeToParamIndex[Builder[0].Reference.Index] + 1),
                Distance = Builder[1].Real
            };

            var constrVertical = new VerticalDistanceToCenterRef()
            {
                P1 = new RefPoint(ShapeToParamIndex[Builder[0].Reference.Index], ShapeToParamIndex[Builder[0].Reference.Index]+1),
                Distance = Builder[2].Real
            };

            return new List<ConstraintRefBase> { constrVertical, constrHorizontal };
        }
    }
}