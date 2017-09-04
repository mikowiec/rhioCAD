#region Usings

using System.Collections.Generic;
using ConstraintsModule.Mappings.Constraints.Common;
using ConstraintsModule.Primitives;
using SketchSolve.Constraints;
//using SketchSolve.Constraints;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class TangentToArcRefMapper : TwoShapesConstraintMapper<Arc, Line>
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new TangentToArcRef
            {
                Arc1 = new RefArc()
                {
                    Center = new RefPoint(A1P1, shapeToParamIndex[A1P1], shapeToParamIndex[A1P1] + 1),
                    Start = new RefPoint(shapeToParamIndex[A1P2], shapeToParamIndex[A1P2] + 1),
                    End = new RefPoint(shapeToParamIndex[A1P3], shapeToParamIndex[A1P3] + 1),
                    
                },
                L1 = new RefLine()
                {
                    P1 = new RefPoint(L1P1, shapeToParamIndex[L1P1], shapeToParamIndex[L1P1] + 1),
                    P2 = new RefPoint(L1P2, shapeToParamIndex[L1P2], shapeToParamIndex[L1P2] + 1)
                },
            };
            return new List<ConstraintRefBase>(){constraint};
        }
    }
}