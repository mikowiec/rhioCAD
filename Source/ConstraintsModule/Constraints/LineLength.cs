#region Usings

using System;
using System.Collections.Generic;

#endregion

namespace ConstraintsModule.Constraints
{
    public class LineLengthRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var dx = parameters[L1.P2.X] - parameters[L1.P1.X];
            var dy = parameters[L1.P2.Y] - parameters[L1.P1.Y];
            var temp = Utils.Hypot(dx, dy);
               
            return Math.Abs(temp - Length);
        }

        public override double Grad(List<double> parameters, int index)
        {
            var dx = parameters[L1.P2.X] - parameters[L1.P1.X];
            var dy = parameters[L1.P2.Y] - parameters[L1.P1.Y];
            var temp = Utils.Hypot(dx, dy);

            var sign = temp - Length > 0? 1:-1;

            var calc = sign / Utils.Hypot(dx, dy);

            if (index == L1.P2.X)
                return calc * dx;
            if (index == L1.P2.Y)
                return calc * dy;
            if (index == L1.P1.X)
                return -calc * dx;
            if (index == L1.P1.Y)
                return -calc * dy;

            return 0;
        }
    }
}