#region Usings

using System;

#endregion

namespace CleanSolver.Constraints
{
    internal class LineLength : ConstraintBase
    {
        public override double Calc()
        {
            var temp = Math.Sqrt(Math.Pow(L1.P2.X.Value - L1.P1.X.Value, 2) + Math.Pow(L1.P2.Y.Value - L1.P1.Y.Value, 2)) - Length;
            return temp*temp*100;
        }
    }
}