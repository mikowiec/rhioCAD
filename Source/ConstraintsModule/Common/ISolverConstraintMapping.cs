#region Usings

using System.Collections.Generic;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;
//using CleanSolver.SolverSystem;

#endregion

namespace ConstraintsModule.Common
{
    public interface ISolverConstraintMapping
    {
        //void Map(NodeBuilder builder, List<DoubleRefObject> parameters,
        //         Dictionary<int, object> globalObjectMapping, Sketch3DTo2DTranslator coordinateTranslator,
        //         ConstraintContainer constraintList);

        List<ConstraintRefBase> MapRef(Document document, NodeBuilder builder, Dictionary<int, int> shapeToParamIndex);
    }
}