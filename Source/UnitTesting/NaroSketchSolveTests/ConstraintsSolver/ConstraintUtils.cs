#region Usings

using NaroConstants.Names;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroSketchSolveTests.ConstraintsSolver
{
    internal static class ConstraintUtils
    {
        public static NodeBuilder BuildLine(Document document, DocumentPointLinker documentPointLiner,
                                            Point3D firstCoordinate, Point3D secondCoordinate)
        {
            var firstPoint = documentPointLiner.GetPoint(firstCoordinate);
            var secondPoint = documentPointLiner.GetPoint(secondCoordinate);
            var line = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            line[0].Reference = firstPoint.Node;
            line[1].Reference = secondPoint.Node;
            line.ExecuteFunction();
            return line;
        }

    }
}