#region Usings

using System.Collections.Generic;
using ConstraintsModule.Constraints;
using ConstraintsModule.Mappings.Constraints.Common;
using ConstraintsModule.Primitives;
//using CleanSolver.Primitives;

//using SketchSolve.Primitives;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
   

    internal class TangentToCircleRefMapper : TwoShapesConstraintMapper<Circle, Line>
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new TangentToCircleRef
            {
                Circle1 = new RefCircle() { Center = new RefPoint(C1, shapeToParamIndex[C1], shapeToParamIndex[C1] + 1),
                                            Radius = shapeToParamIndex[C1] + 2
                },
                L1 = new RefLine()
                {
                    P1 = new RefPoint(L1P1, shapeToParamIndex[L1P1], shapeToParamIndex[L1P1] + 1),
                    P2 = new RefPoint(L1P2, shapeToParamIndex[L1P2], shapeToParamIndex[L1P2] + 1)
                },
            };
            return new List<ConstraintRefBase> { constraint };
        }
    }
}