#region Usings

using ShapeFunctionsInterface.Utils;
using SketchHinter.ConstraintPreview;

#endregion

namespace SketchHinter.Primitives
{
    public abstract class HinterShapeBase
    {
        public NodeBuilder Builder { get; set; }
        public abstract BoundingRectangle Size { get; }
    }
}