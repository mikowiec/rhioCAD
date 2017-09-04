#region Usings

using System.Collections.Generic;
using ConstraintsModule.Constraints;
using ConstraintsModule.Mappings.Constraints.Common;
using ConstraintsModule.Primitives;
using SketchSolve.Constraints;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class PointOnLineMidPointRefMapper : TwoShapesConstraintMapper<Line, Point>
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new PointOnLineMidpointRef
            {
                L1 = new RefLine()
                {
                    P1 = new RefPoint(L1P1, shapeToParamIndex[L1P1], shapeToParamIndex[L1P1] + 1),
                    P2 = new RefPoint(L1P2, shapeToParamIndex[L1P2], shapeToParamIndex[L1P2] + 1)
                },
                P1 = new RefPoint(P1, shapeToParamIndex[P1], shapeToParamIndex[P1] + 1)
            };
            return new List<ConstraintRefBase> { constraint };
        }

    }
}