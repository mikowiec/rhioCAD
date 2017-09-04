using System;
using System.Collections.Generic;

namespace ConstraintsModule.Constraints
{
    public class EqualRadiusCirclesRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var temp = parameters[Circle1.Radius] - parameters[Circle2.Radius];
            return Math.Abs(temp);// *temp;
        }

        public override double Grad(List<double> parameters, int index)
        {
             var sign = parameters[Circle1.Radius] - parameters[Circle2.Radius]>0? 1:-1;
            if (index == Circle1.Radius)
                return sign;
            if (index == Circle2.Radius)
                return -sign;
            return 0;
        }
    }
}