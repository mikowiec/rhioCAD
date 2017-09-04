using System;
using System.Collections.Generic;

namespace ConstraintsModule.Constraints
{
    public class HorizontalDistanceToCenterRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var temp = parameters[P1.X] - Distance;
            return Math.Abs(temp) * 31.62;// *1000;
        }

        public override double Grad(List<double> parameters, int index)
        {
            var temp = parameters[P1.X] - Distance;

            var sign = temp >= 0 ? 1 : -1;
            if (index == P1.X)
                return sign * 31.62;// Math.Abs(parameters[P1.Y] - Distance);
            return 0;
        }
    }
}