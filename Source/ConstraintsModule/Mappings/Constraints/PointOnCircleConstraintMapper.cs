#region Usings

using System.Collections.Generic;
using CleanSolver.Constraints;
using ConstraintsModule.Mappings.Constraints.Common;
using ConstraintsModule.Primitives;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class PointOnCircleConstraintRefMapper : TwoShapesConstraintMapper<Arc, Point>
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new PointOnCircleRef
            {
                Circle1 = new RefCircle()
                {
                    Center = new RefPoint(C1, shapeToParamIndex[C1], shapeToParamIndex[C1] + 1),
                    Radius = shapeToParamIndex[C1] + 2
                },
                P1 = new RefPoint(P1, shapeToParamIndex[P1], shapeToParamIndex[P1] + 1)
            };
            return new List<ConstraintRefBase> { constraint };
        }
    }
}