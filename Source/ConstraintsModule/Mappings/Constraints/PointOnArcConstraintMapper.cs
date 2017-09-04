#region Usings

using System.Collections.Generic;
using ConstraintsModule;
using ConstraintsModule.Mappings.Constraints.Common;
using ConstraintsModule.Primitives;
using SketchSolve;
using SketchSolve.Constraints;
//using SketchSolve.Primitives;

#endregion

namespace NaroSketchAdapter.Mappings.Constraints
{
    internal class PointOnArcConstraintRefMapper : TwoShapesConstraintMapper<Arc, Point>
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new PointOnArcRef
            {
                Arc1 = new RefArc()
                           {
                               Center = new RefPoint(A1P1, shapeToParamIndex[A1P1], shapeToParamIndex[A1P1] + 1),
                               Start = new RefPoint(A1P2, shapeToParamIndex[A1P2], shapeToParamIndex[A1P2] + 1),
                               End = new RefPoint(A1P3, shapeToParamIndex[A1P3], shapeToParamIndex[A1P3] + 1),
                           },
                P1 = new RefPoint(P1, shapeToParamIndex[P1], shapeToParamIndex[P1] + 1)
            };
            return new List<ConstraintRefBase> { constraint };
        }
    }
}