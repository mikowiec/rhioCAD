#region Usings

using ShapeFunctionsInterface.Utils;

#endregion

namespace SketchHinter.Primitives
{
    internal class PointHinterCreatorShape : HinterShapeCreatorBase
    {
        public override HinterShapeBase Build(NodeBuilder builder)
        {
            var secondPoint = builder[1].TransformedPoint3D;
            var result = new PointHinterShape
                             {
                                 Position = secondPoint
                             };
            return result;
        }
    }
}