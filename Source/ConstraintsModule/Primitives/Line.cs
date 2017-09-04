namespace ConstraintsModule.Primitives
{
    public struct Line
    {
        public Point P1;
        public Point P2;
    }

    public struct RefLine
    {
        public RefPoint P1;
        public RefPoint P2;

        public RefLine(RefPoint p1, RefPoint p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public RefLine(int p1X, int p1Y, int p2X, int p2Y)
        {
            P1 = new RefPoint(p1X, p1Y);
            P2 = new RefPoint(p2X, p2Y);
        }
    }
}