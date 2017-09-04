#region Usings

using System.Collections.Generic;
using ConstraintsModule.Common;
using ConstraintsModule.Primitives;
using SketchSolve.Constraints;
using TreeData.AttributeInterpreter;
//using SketchSolve.Primitives;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class ArcAnglesConstraintMapper : ConstraintMapperBase
    {
        protected override List<ConstraintRefBase> MapToSolverRef()
        {
            var constraint = new ArcAnglesRef()
            {
                Arc1 = new RefArc()
                {
                    Center =
                       new RefPoint(ShapeToParamIndex[Builder.Dependency[0].Reference.Children[1].Get<ReferenceInterpreter>().Node.Index],
                                    ShapeToParamIndex[Builder.Dependency[0].Reference.Children[1].Get<ReferenceInterpreter>().Node.Index] + 1),
                    Start =
                        new RefPoint(ShapeToParamIndex[Builder.Dependency[0].Reference.Children[2].Get<ReferenceInterpreter>().Node.Index],
                                     ShapeToParamIndex[Builder.Dependency[0].Reference.Children[2].Get<ReferenceInterpreter>().Node.Index] + 1),
                    End =
                        new RefPoint(ShapeToParamIndex[Builder.Dependency[0].Reference.Children[3].Get<ReferenceInterpreter>().Node.Index],
                                     ShapeToParamIndex[Builder.Dependency[0].Reference.Children[3].Get<ReferenceInterpreter>().Node.Index] + 1),
                },
                StartAngle = Builder[1].Real,
                EndAngle = Builder[2].Real
            };

            return new List<ConstraintRefBase> { constraint};
        }
    }
}