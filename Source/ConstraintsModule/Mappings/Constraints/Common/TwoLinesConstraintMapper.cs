#region Usings

using System.Collections.Generic;
using ConstraintsModule.Primitives;
using SketchSolve;
using SketchSolve.Constraints;
//using SketchSolve.Primitives;

#endregion

namespace ConstraintsModule.Mappings.Constraints.Common
{
  

    internal class TwoLinesConstraintRefMapper<T> : TwoShapesConstraintMapper<RefLine, RefLine>
        where T : ConstraintRefBase, new()
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new T
                       {
                           L1 = new RefLine()
                           {
                               P1 = new RefPoint(L1P1, shapeToParamIndex[L1P1], shapeToParamIndex[L1P1] + 1),
                               P2 = new RefPoint(L1P2, shapeToParamIndex[L1P2], shapeToParamIndex[L1P2] + 1)
                           },
                           L2 = new RefLine()
                           {
                               P1 = new RefPoint(L2P1, shapeToParamIndex[L2P1], shapeToParamIndex[L2P1] + 1),
                               P2 = new RefPoint(L2P2, shapeToParamIndex[L2P2], shapeToParamIndex[L2P2] + 1)
                           },
                       };
            return new List<ConstraintRefBase> { constraint };
        }
    }
}