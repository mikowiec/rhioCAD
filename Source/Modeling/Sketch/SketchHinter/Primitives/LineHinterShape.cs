#region Usings

using System;
using SketchHinter.ConstraintPreview;
using TreeData.AttributeInterpreter;

#endregion

namespace SketchHinter.Primitives
{
    public class LineHinterShape : HinterShapeBase
    {
        public LineHinterShape(Point3D firstPoint, Point3D secondPoint)
        {
            Point1 = firstPoint;
            Point2 = secondPoint;
        }

        public Point3D Point1 { get; private set; }
        public Point3D Point2 { get; private set; }

        public override BoundingRectangle Size
        {
            get
            {
                var boundingRectangle = new BoundingRectangle
                                            {
                                                Left = Math.Min(Point1.X, Point2.X),
                                                Top = Math.Min(Point1.Y, Point2.Y),
                                                Width = Math.Abs(Point2.X - Point1.X),
                                                Height = Math.Abs(Point2.Y - Point1.Y)
                                            };
                return boundingRectangle;
            }
        }
    }
}