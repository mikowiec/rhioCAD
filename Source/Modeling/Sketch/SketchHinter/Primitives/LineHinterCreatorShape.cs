#region Usings

using ShapeFunctionsInterface.Utils;

#endregion

namespace SketchHinter.Primitives
{
    internal class LineHinterCreatorShape : HinterShapeCreatorBase
    {
        public override HinterShapeBase Build(NodeBuilder builder)
        {
            var firstPoint = builder[0].RefTransformedPoint3D;
            var secondPoint = builder[1].RefTransformedPoint3D;
            var result = new LineHinterShape(firstPoint, secondPoint);
            return result;
        }
    }
}