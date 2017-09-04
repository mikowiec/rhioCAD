#region Usings

using System;
using System.Collections.Generic;
#endregion

namespace ConstraintsModule.Constraints
{
    public class PerpendicularRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var dx1 = parameters[L1.P1.X] - parameters[L1.P2.X];
            var dy1 = parameters[L1.P1.Y] - parameters[L1.P2.Y];
            var dx2 = parameters[L2.P1.X] - parameters[L2.P2.X];
            var dy2 = parameters[L2.P1.Y] - parameters[L2.P2.Y];
            var scale = 1/Math.Sqrt((dx1*dx1 + dy1*dy1)*(dx2*dx2 + dy2*dy2));
            var temp = scale * (dx1 * dx2 + dy1 * dy2);
            return temp;
        }


        public override double Grad(List<double> parameters, int index)
        {
            var dx1 = parameters[L1.P1.X] - parameters[L1.P2.X];
            var dy1 = parameters[L1.P1.Y] - parameters[L1.P2.Y];
            var dx2 = parameters[L2.P1.X] - parameters[L2.P2.X];
            var dy2 = parameters[L2.P1.Y] - parameters[L2.P2.Y];
            var temp = dx1*dx2 + dy1*dy2;
            var prod = Math.Sqrt((dx1 * dx1 + dy1 * dy1) * (dx2 * dx2 + dy2 * dy2));
            var calc = 1/(prod*prod);
            var result = 0.0;
            if (index == L1.P1.X)
            {
                result += dx2 *prod - temp * dx1 / prod;
            }
            if (index == L1.P1.Y)
            {
                result += dy2 *prod - temp * dy1 / prod;
            }
            if (index == L1.P2.X)
            {
                result += (-dx2) *prod + temp * dx1 / prod;
            }
            if (index == L1.P2.Y)
            {
                result += (-dy2) *prod + temp * dy1 / prod;
            }

            if (index == L2.P1.X)
            {
                result += dx1 *prod - temp * dx2 / prod;
            }
            if (index == L2.P1.Y)
            {
                result += dy1 *prod - temp * dy2 / prod;
            }
            if (index == L2.P2.X)
            {
                result += (-dx1) *prod + temp * dx2 / prod;
            }
            if (index == L2.P2.Y)
            {
                result += (-dy1) *prod + temp * dy2 / prod;
            }
            return result*calc;
        }
    }
}
