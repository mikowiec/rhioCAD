using System;
using System.Collections.Generic;

namespace ConstraintsModule.Constraints
{
    public class VerticalRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var calc = parameters[L1.P2.X] - parameters[L1.P1.X];
            return Math.Abs(calc);// * calc);
        }

        public override double Grad(List<double> parameters, int index)
        {
            var sign = parameters[L1.P2.X] - parameters[L1.P1.X] >= 0 ? 1 : -1; 
            if (index == L1.P2.X)
                return sign;
            if (index == L1.P1.X)
                return -sign;
            return 0;
        }
    }
}