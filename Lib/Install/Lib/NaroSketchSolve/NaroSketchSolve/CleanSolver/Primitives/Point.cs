using System;

namespace CleanSolver.Primitives
{
    public class Point
    {
        public DoubleRefObject X { get; set; }
        public DoubleRefObject Y { get; set; }

        public Point(DoubleRefObject x, DoubleRefObject y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point p)
        {
            return Math.Sqrt((X.Value - p.X.Value)*(X.Value - p.X.Value) + (Y.Value - p.Y.Value)*(Y.Value - p.Y.Value));
        }
    }
}
