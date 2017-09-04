#region Usings

using System.Collections.Generic;
//using CleanSolver.Primitives;
using ConstraintsModule.Primitives;
using SketchSolve;
//using SketchSolve.Primitives;

#endregion

namespace ConstraintsModule.Mappings.Constraints.Common
{
    internal class TwoCirclesConstraintRefMapper<T> : TwoShapesConstraintMapper<RefCircle, RefCircle>
        where T : ConstraintRefBase, new()
    {
        protected override List<ConstraintRefBase> ConstraintRefBuild()
        {
            var constraint = new T
            {
                Circle1 = new RefCircle()
                {
                    Center = new RefPoint(C1, shapeToParamIndex[C1], shapeToParamIndex[C1] + 1),
                    Radius = shapeToParamIndex[C1] + 2
                },
                Circle2 = new RefCircle()
                {
                    Center = new RefPoint(C2, shapeToParamIndex[C2], shapeToParamIndex[C2] + 1),
                    Radius = shapeToParamIndex[C2] + 2
                },
            };
            return new List<ConstraintRefBase> { constraint };
        }
    }
}