using System.Collections.Generic;

namespace ConstraintsModule.Constraints
{
    public class PositiveParameter : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var temp = parameters[Index] > 0 ? 0: 10000;

            return temp;
        }

        public override double Grad(List<double> parameters, int index)
        {
            if (index == Index)
            {
                return parameters[Index] > 0 ? 0 : 10000;
            }

            return 0;
        }
    }
}