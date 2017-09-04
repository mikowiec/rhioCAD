#region Usings

using System.Collections.Generic;
using ConstraintsModule.Primitives;

#endregion

namespace ConstraintsModule.Mappings.Constraints.Common
{
    internal class TwoArcsConstraintRefMapper<T> : TwoShapesConstraintMapper<RefArc, RefArc>
    where T : ConstraintRefBase, new()
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new T
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
                Arc2 = new RefArc()
                {
                    Center =
                        new RefPoint(A2P1, shapeToParamIndex[A2P1],
                                     shapeToParamIndex[A2P1] + 1),
                    Start =
                        new RefPoint(shapeToParamIndex[A2P2],
                                     shapeToParamIndex[A2P2] + 1),
                    End =
                        new RefPoint(shapeToParamIndex[A2P3],
                                     shapeToParamIndex[A2P3] + 1),

                },
            };
            return new List<ConstraintRefBase>(){constraint};
        }
    }
}