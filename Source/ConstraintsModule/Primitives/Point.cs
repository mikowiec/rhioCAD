#region Usings

using System;

#endregion

namespace ConstraintsModule.Primitives
{
    public class Point
    {
        public Point(DoubleRefObject x, DoubleRefObject y)
        {
            X = x;
            Y = y;
        }

        public DoubleRefObject X { get; set; }
        public DoubleRefObject Y { get; set; }

        public double Distance(Point p)
        {
            return Math.Sqrt((X.Value - p.X.Value)*(X.Value - p.X.Value) + (Y.Value - p.Y.Value)*(Y.Value - p.Y.Value));
        }
    }

    public class RefPoint
    {
        public RefPoint(int index)
        {
            Index = index;
        }

        public RefPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public RefPoint(int index, int x, int y)
        {
            Index = index;
            X = x;
            Y = y;
        }

        public int Index { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}