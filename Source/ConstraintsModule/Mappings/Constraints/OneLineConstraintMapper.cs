#region Usings

using System.Collections.Generic;
using ConstraintsModule.Mappings.Constraints.Common;
using ConstraintsModule.Primitives;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class OneLineConstraintRefMapper<T> : OneShapeConstraintMapping<Line>
            where T : ConstraintRefBase, new()
        {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
            {
                var constraint = new T
                           {
                               L1 = new RefLine()
                                        {
                                            P1 = new RefPoint(L1P1, shapeToParamIndex[L1P1], shapeToParamIndex[L1P1] + 1),
                                            P2 =
                                            new RefPoint(shapeToParamIndex[L1P2],
                                                         shapeToParamIndex[L1P2] + 1)
                                        },
                           };
            return new List<ConstraintRefBase>{constraint};
            }
        }
}