#region Usings

using System.Collections.Generic;
using ConstraintsModule.Constraints;
using ConstraintsModule.Mappings.Constraints.Common;
using ConstraintsModule.Primitives;
using SketchSolve.Constraints;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class PointOnPointConstraintRefMapper : TwoShapesConstraintMapper<Point, Point>
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new PointOnPointRef
            {
                P1 = new RefPoint(P1, shapeToParamIndex[P1], shapeToParamIndex[P1] + 1),
                P2 = new RefPoint(P2, shapeToParamIndex[P2], shapeToParamIndex[P2] + 1),
            };
            return new List<ConstraintRefBase> { constraint };
        }
    }
}