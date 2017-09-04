#region Usings

using System.Collections.Generic;
using CleanSolver.Primitives;
using NaroSketchAdapter.Mappings.Constraints.Common;
using SketchSolve;
using SketchSolve.Constraints;
using SketchSolve.Primitives;

#endregion

namespace NaroSketchAdapter.Mappings.Constraints
{
    internal class EqualRadiusCircArcRefMapper : TwoShapesConstraintMapper<RefArc, RefCircle>
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new EqualRadiusCircArcRef
            {
                Arc1 = new RefArc()
                {
                    Center = new RefPoint(A1, shapeToParamIndex[A1], shapeToParamIndex[A1] + 1),
                    Start = new RefPoint(shapeToParamIndex[A1] + 2, shapeToParamIndex[A1] + 3),
                    End = new RefPoint(shapeToParamIndex[A1] + 4, shapeToParamIndex[A1] + 5),
                    Angle = shapeToParamIndex[A1] + 6,
                    Radius = shapeToParamIndex[A1] + 7
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