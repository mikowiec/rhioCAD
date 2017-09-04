#region Usings
using System.Collections.Generic;
using ConstraintsModule.Common;
using ConstraintsModule.Constraints;
using ConstraintsModule.Primitives;
#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class CircleRadiusConstraintMapper : ConstraintMapperBase
    {
        protected override List<ConstraintRefBase> MapToSolverRef()
        {
            var constraint = new CircleRadiusRef()
            {
               Circle1 = new RefCircle()
                {
                    Center = new RefPoint(ShapeToParamIndex[Builder.Dependency[0].Reference.Index], ShapeToParamIndex[Builder.Dependency[0].Reference.Index] + 1),
                    Radius = ShapeToParamIndex[Builder.Dependency[0].Reference.Index]+2
                },
                Radius = Builder[1].Real
            };

            return new List<ConstraintRefBase> { constraint};
        }
    }
}