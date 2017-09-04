#region Usings

using SketchHinter.ConstraintPreview;
using TreeData.AttributeInterpreter;

#endregion

namespace SketchHinter.Primitives
{
    public class PointHinterShape : HinterShapeBase
    {
        public Point3D Position { get; set; }

        public override BoundingRectangle Size
        {
            get { return new BoundingRectangle {Left = Position.X, Top = Position.Y, Width = 0, Height = 0}; }
        }
    }
}