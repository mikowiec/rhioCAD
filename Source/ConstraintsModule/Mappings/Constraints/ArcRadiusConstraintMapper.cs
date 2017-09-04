#region Usings

using System.Collections.Generic;
using ConstraintsModule.Common;
using ConstraintsModule.Primitives;
using NaroSketchAdapter.Common;
using ShapeFunctionsInterface.Utils;
using SketchSolve;
using SketchSolve.Constraints;
//using SketchSolve.Primitives;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ConstraintsModule.Mappings.Constraints
{
    internal class ArcRadiusConstraintMapper : ConstraintMapperBase
    {
        protected override List<ConstraintRefBase> MapToSolverRef()
        {
            var constraint = new ArcRadiusRef()
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
                Radius = Builder[1].Real
            };

            return new List<ConstraintRefBase> { constraint};
        }
    }
}