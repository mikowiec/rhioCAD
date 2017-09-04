#region Usings

using System.Collections.Generic;
using ConstraintsModule.Common;
using NaroConstants.Names;
using NaroSketchAdapter.Common;
using ShapeFunctionsInterface.Utils;

#endregion

namespace ConstraintsModule.Mappings.Constraints.Common
{
    internal abstract class OneShapeConstraintMapping<TShape1> : ConstraintMapperBase
    {
        protected int P1 { get; private set; }
        protected int L1P1 { get; private set; }
        protected int L1P2 { get; private set; }

        protected Dictionary<int, int> shapeToParamIndex;

        protected override List<ConstraintRefBase> MapToSolverRef()
        {
            var shape = new NodeBuilder(Document.Root[Builder[0].Reference.Index]);

            if (shape.FunctionName == FunctionNames.Point || shape.FunctionName == FunctionNames.Circle)
            {
                P1 = shape.Node.Index;
            }
            else
                if(shape.FunctionName == FunctionNames.LineTwoPoints)
                {
                    L1P1 = shape.Dependency[0].Reference.Index;
                    L1P2 = shape.Dependency[1].Reference.Index;
                }
            shapeToParamIndex = ShapeToParamIndex;
            return ConstraintRefBuild();
        }

        protected abstract List<ConstraintRefBase> ConstraintRefBuild();
    }
}