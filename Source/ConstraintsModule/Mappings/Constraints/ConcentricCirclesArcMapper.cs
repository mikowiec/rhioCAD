#region Usings

using System.Collections.Generic;
//using CleanSolver.Primitives;
using ConstraintsModule;
using ConstraintsModule.Constraints;
using ConstraintsModule.Mappings.Constraints.Common;
using ConstraintsModule.Primitives;
using SketchSolve;
using SketchSolve.Constraints;
//using SketchSolve.Primitives;

#endregion

namespace NaroSketchAdapter.Mappings.Constraints
{
    internal class ConcentricCirclesArcRefMapper : TwoShapesConstraintMapper<RefArc, RefCircle>
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new ConcentricCircArcRef
            {
                Arc1 = new RefArc()
                {
                    Center =
                        new RefPoint(A1P1, shapeToParamIndex[A1P1],
                                     shapeToParamIndex[A1P1] + 1),
                    Start =
                        new RefPoint(shapeToParamIndex[A1P2],
                                     shapeToParamIndex[A1P2] + 1),
                    End =
                        new RefPoint(shapeToParamIndex[A1P3],
                                     shapeToParamIndex[A1P3] + 1),

                },
                Circle1 = new RefCircle()
                {
                    Center = new RefPoint(C1, shapeToParamIndex[C1], shapeToParamIndex[C1] + 1),
                    Radius = shapeToParamIndex[C1] + 2
                }
            };
            return new List<ConstraintRefBase>(){constraint};
        }
    }
}