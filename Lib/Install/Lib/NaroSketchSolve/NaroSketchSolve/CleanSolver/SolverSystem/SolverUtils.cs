#region Usings

using System;

#endregion

namespace CleanSolver.SolverSystem
{
    internal static class SolverUtils
    {
        public static double Hypot(double x, double y)
        {
            return Math.Sqrt(x*x + y*y);
        }
    }
}