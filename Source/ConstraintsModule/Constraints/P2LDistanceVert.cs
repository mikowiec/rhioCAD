#region Usings

using System;

#endregion

namespace ConstraintsModule.Constraints
{
    public class P2LDistanceVert : ConstraintBase
    {
        public override double Calc()
        {
            var dx = L1.P2.X.Value - L1.P1.X.Value;
            var dy = L1.P2.Y.Value - L1.P1.Y.Value;

            var t = (P1.X.Value - L1.P1.X.Value)/dx;
            var yint = L1.P1.Y.Value + dy*t;
            var temp = Math.Abs((P1.Y.Value - yint)) - Distance;
            return temp*temp;
        }
    }
}