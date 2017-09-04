using System;
using System.Collections.Generic;

namespace ConstraintsModule.Constraints
{
    public class PointOnLineMidpointRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var ex = (parameters[L1.P1.X] + parameters[L1.P2.X]) / 2;
            var ey = (parameters[L1.P1.Y] + parameters[L1.P2.Y]) / 2;
            var temp = ex - parameters[P1.X];
            var temp2 = ey -parameters[P1.Y];
            return 
             Math.Sqrt(temp * temp + temp2 * temp2);
        }

        public override double Grad(List<double> parameters, int index)
        {
            var calcX = (parameters[L1.P1.X] + parameters[L1.P2.X])/2 - parameters[P1.X];
            var calcY = (parameters[L1.P1.Y] + parameters[L1.P2.Y]) / 2 - parameters[P1.Y];
            var rad = Math.Sqrt(calcX*calcX + calcY*calcY);
            if (index == P1.X)
                return - calcX;
            if (index == P1.Y)
                return - calcY;

            if (index == L1.P1.X || index == L1.P2.X)
            {
                return calcX /(2 * rad) ;
            }
            if (index == L1.P1.Y || index == L1.P2.Y)
            {
                return calcY / (2 * rad);
            }
          
            return 0;
        }
    }
}