using System;
using System.Collections.Generic;

namespace ConstraintsModule.Constraints
{
    public class HorizontalRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var calc = parameters[L1.P2.Y] - parameters[L1.P1.Y];
            return Math.Abs(calc);
        }
        public override double Grad(List<double> parameters, int index)
        {
            var calc = parameters[L1.P2.Y] - parameters[L1.P1.Y];
            var sign = calc >= 0 ? 1 : -1;
            if (index == L1.P2.Y)
                return sign;
            if (index == L1.P1.Y)
                return -sign;
            return 0;
        }
    }
}