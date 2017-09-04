#region Usings

using NaroConstants.Names;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace InteractiveEditor.Handlers
{
    public abstract class SplineBasedEditingHandler : GenericEditingShapeHandler
    {
        protected void PreviewLine(int pointIndex)
        {
            var builder = new NodeBuilder(Document, FunctionNames.DottedLine);
            UpdateLinePoint(builder, 0, pointIndex);
            UpdateLinePoint(builder, 1, pointIndex + 1);
            builder.ExecuteFunction();
        }

        private void UpdateLinePoint(NodeBuilder builder, int childId, int pointIndex)
        {
            builder[childId].TransformedPoint3D = GetSplinePoint(pointIndex);
        }

        private Point3D GetSplinePoint(int pointIndex)
        {
            return Dependency[pointIndex].TransformedPoint3D;
        }
    }
}