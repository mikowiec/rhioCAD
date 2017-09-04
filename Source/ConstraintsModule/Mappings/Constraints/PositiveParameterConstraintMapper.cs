#region Usings

using System.Collections.Generic;
using ConstraintsModule.Common;
using ConstraintsModule.Constraints;
using ConstraintsModule.Primitives;
using System;
//using CleanSolver.Primitives;
//using SketchSolve.Primitives;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class PositiveParameterConstraintMapper : ConstraintMapperBase
    {
        protected override List<ConstraintRefBase> MapToSolverRef()
        {
            var constraint = new PositiveParameter()
            {
                Index = ShapeToParamIndex[Builder.Dependency[0].Reference.Index]+2
            };

            return new List<ConstraintRefBase> { constraint };
        }
    }
}