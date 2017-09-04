#region Usings

//using SketchSolve.Primitives;

#endregion

namespace ConstraintsModule.Primitives
{
    public struct Circle
    {
        public Point Center { get; set; }
        public DoubleRefObject Radius { get; set; }
    }

    public struct RefCircle
    {
        public RefPoint Center;
        public int Radius;

        public RefCircle(int radius, int x, int y)
        {
            Radius = radius;
            Center = new RefPoint(x,y);
        }
    }
}