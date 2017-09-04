#region Usings

using System.Collections.Generic;
using ConstraintsModule.Common;
using ConstraintsModule.Constraints;
using ConstraintsModule.Primitives;
using SketchSolve.Constraints;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class LineLengthConstraintMapper : ConstraintMapperBase
    {
        protected override List<ConstraintRefBase> MapToSolverRef()
        {
            var constraint = new LineLengthRef()
            {
                L1 = new RefLine()
                {
                    P1 = new RefPoint(ShapeToParamIndex[Builder.Dependency[0].Reference.Index],
                                      ShapeToParamIndex[Builder.Dependency[0].Reference.Index] + 1),
                    P2 = new RefPoint(ShapeToParamIndex[Builder.Dependency[1].Reference.Index],
                                      ShapeToParamIndex[Builder.Dependency[1].Reference.Index] + 1)
                },
                Length = Builder[2].Real
            };

            return new List<ConstraintRefBase> { constraint};
        }
    }
}