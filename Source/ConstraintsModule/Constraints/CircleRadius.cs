using System.Collections.Generic;

namespace ConstraintsModule.Constraints
{
    public class CircleRadiusRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var temp =
                parameters[Circle1.Radius] - Radius;

            return temp;
        }

        public override double Grad(List<double> parameters, int index)
        {
            if (index == Circle1.Radius)
                return 1;

            return 0;
        }
    }
}