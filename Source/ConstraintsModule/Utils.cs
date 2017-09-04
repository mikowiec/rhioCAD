#region Usings

using System;

#endregion

namespace ConstraintsModule
{
    public static class Utils
    {
        public static double Hypot(double x, double y)
        {
            return Math.Sqrt(x*x + y*y);
        }

        public static double HypotSq(double x, double y)
        {
            return x * x + y * y;
        }
    }
}