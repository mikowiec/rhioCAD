namespace SketchHinter.ConstraintPreview
{
    public class BoundingRectangle
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double MiddleX
        {
            get { return Left + Width/2; }
        }

        public double MiddleY
        {
            get { return Top + Height/2; }
        }
    }
}