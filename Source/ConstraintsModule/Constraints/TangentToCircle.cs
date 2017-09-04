#region Usings

using System;
using System.Collections.Generic;

//using CleanSolver.SolverSystem;

#endregion

namespace ConstraintsModule.Constraints
{
    public class TangentToCircleRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var dx = parameters[L1.P2.X] - parameters[L1.P1.X];
            var dy = parameters[L1.P2.Y] - parameters[L1.P1.Y];

            var hyp = Utils.Hypot(dx, dy);
           
            // new algorithm
            var distance =
                Math.Abs(
                dx * (parameters[L1.P1.Y] - parameters[Circle1.Center.Y]) -
                         dy * (parameters[L1.P1.X] - parameters[Circle1.Center.X])) / hyp;
            var error = distance - parameters[Circle1.Radius];
            return Math.Abs(error*10);// *error;
        }

        public override double Grad(List<double> parameters, int index)
        {
            var dx = parameters[L1.P2.X] - parameters[L1.P1.X];
            var dy = parameters[L1.P2.Y] - parameters[L1.P1.Y];

            var lineLengthSq = dx * dx + dy * dy;
            var lineLength = Utils.Hypot(dx, dy);

            var abs = dx * (parameters[L1.P1.Y] - parameters[Circle1.Center.Y]) -
                      dy * (parameters[L1.P1.X] - parameters[Circle1.Center.X]);

            //var distance =
            //Math.Abs(dx * (parameters[L1.P1.Y] - parameters[Circle1.Center.Y]) -
            //         dy * (parameters[L1.P1.X] - parameters[Circle1.Center.X])) / lineLength;
            var error = Math.Abs(abs)/lineLength - parameters[Circle1.Radius];

            var sign1 = abs >= 0 ? 1 : -1;
            var sign2 = error >= 0 ? 10 : -10;
            if (index == Circle1.Center.X)
                return sign1 *sign2* dy / lineLength;
            if (index == Circle1.Center.Y)
                return sign1 * sign2 * (-dx) / lineLength;

            if (index == L1.P2.X)
            {
                return sign1 * sign2 * (lineLength * (parameters[L1.P1.Y] - parameters[Circle1.Center.Y]) - abs * dx / lineLength) /
                       lineLengthSq;
            }
            if (index == L1.P2.Y)
            {
                return sign1 * sign2 * (-lineLength * (parameters[L1.P1.X] - parameters[Circle1.Center.X]) - abs * dy / lineLength) /
                       lineLengthSq;
            }
            if (index == L1.P1.X)
            {
                return sign1 * sign2 * (lineLength * (parameters[Circle1.Center.Y] - parameters[L1.P2.Y]) + abs * dx / lineLength) /
                       lineLengthSq;
            }
            if (index == L1.P1.Y)
            {
                return sign1 * sign2 * (lineLength * (parameters[L1.P2.X] - parameters[Circle1.Center.X]) + abs * dy / lineLength) /
                       lineLengthSq;
            }
            if (index == Circle1.Radius)
                return -sign2;
            return 0;
        }
    }
}