#region Usings

using System;

#endregion

namespace ConstraintsModule.Constraints
{
    public class P2LDistanceHorz : ConstraintBase
    {
        public override double Calc()
        {
            var dx = L1.P2.X.Value - L1.P1.X.Value;
            var dy = L1.P2.Y.Value - L1.P1.Y.Value;

            var t = (P1.Y.Value - L1.P1.Y.Value)/dy;
            var xint = L1.P1.X.Value + dx*t;
            var temp = Math.Abs((P1.X.Value - xint)) - Distance;
            return temp*temp/10;
        }
    }
}