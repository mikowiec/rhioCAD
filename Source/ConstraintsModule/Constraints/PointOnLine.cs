using System;
using System.Collections.Generic;

//using CleanSolver.SolverSystem;

namespace ConstraintsModule.Constraints
{
    public class PointOnLineRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            // point on line is equivalent to distance from line to point is 0
            var dx = parameters[L1.P2.X] - parameters[L1.P1.X];
            var dy = parameters[L1.P2.Y] - parameters[L1.P1.Y];

            var hyp = Utils.Hypot(dx, dy);

            // new algorithm
            var error =
                (dx * (parameters[L1.P1.Y] - parameters[P1.Y]) -
                         dy * (parameters[L1.P1.X] - parameters[P1.X])) / hyp;

            return Math.Abs(error);
        }

        public override double Grad(List<double> parameters, int index)
        {
            var dx = parameters[L1.P2.X] - parameters[L1.P1.X];
            var dy = parameters[L1.P2.Y] - parameters[L1.P1.Y];

            var lineLengthSq = dx * dx + dy * dy;
            var lineLength = Math.Sqrt(lineLengthSq);

            var abs = dx * (parameters[L1.P1.Y] - parameters[P1.Y]) -
                      dy * (parameters[L1.P1.X] - parameters[P1.X]);
            
            var sign = abs >= 0 ? 1 : -1;

            if (index == P1.X)
                return  sign * dy / lineLength ;
            if (index == P1.Y)
                return sign * (-dx) / lineLength;

            if (index == L1.P2.X)
            {
                return  sign * (lineLength * (parameters[L1.P1.Y] - parameters[P1.Y]) - abs * dx / lineLength) / lineLengthSq;
            }
            if (index == L1.P2.Y)
            {
                return sign * (-lineLength * (parameters[L1.P1.X] - parameters[P1.X]) - abs * dy / lineLength) / lineLengthSq;
            }
            if (index == L1.P1.X)
            {
                return sign * (lineLength * (parameters[P1.Y] - parameters[L1.P2.Y]) + abs * dx / lineLength) / lineLengthSq;
            }
            if (index == L1.P1.Y)
            {
                return sign * (lineLength * (parameters[L1.P2.X] - parameters[P1.X]) + abs * dy / lineLength) / lineLengthSq;
            }

            return 0;
        }
    }
}