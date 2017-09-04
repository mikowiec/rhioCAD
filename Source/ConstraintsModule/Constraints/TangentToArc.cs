using System;
using System.Collections.Generic;
////using CleanSolver.SolverSystem;
using ConstraintsModule;
using ConstraintsModule.Constraints;

namespace SketchSolve.Constraints
{
    public class TangentToArc : ConstraintBase
    {
        public override double Calc()
        {
            var dx = L1.P2.X.Value - L1.P1.X.Value;
            var dy = L1.P2.Y.Value - L1.P1.Y.Value;


            var radsq = (Arc1.Center.X.Value - Arc1.StartX)*(Arc1.Center.X.Value - Arc1.StartX) +
                        (Arc1.Center.Y.Value - Arc1.StartY)*(Arc1.Center.Y.Value - Arc1.StartY);
            var t = -(L1.P1.X.Value*dx - Arc1.Center.X.Value*dx + L1.P1.Y.Value*dy - Arc1.Center.Y.Value*dy)/
                    (dx*dx + dy*dy);
            var xint = L1.P1.X.Value + dx*t;
            var yint = L1.P1.Y.Value + dy*t;
            var temp = (Arc1.Center.X.Value - xint)*(Arc1.Center.X.Value - xint) +
                       (Arc1.Center.Y.Value - yint)*(Arc1.Center.Y.Value - yint) -
                       radsq;
            return temp*temp;
        }
    }

    public class TangentToArcRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var dx = parameters[L1.P2.X] - parameters[L1.P1.X];
            var dy = parameters[L1.P2.Y] - parameters[L1.P1.Y];

            var hyp = Utils.Hypot(dx, dy);
           
            // new algorithm
            var radius = Utils.Hypot(parameters[Arc1.Start.X] - parameters[Arc1.Center.X],
                                           parameters[Arc1.Start.Y] - parameters[Arc1.Center.Y]);
            var distance =
                (dx * (parameters[L1.P1.Y] - parameters[Arc1.Center.Y]) -
                         dy * (parameters[L1.P1.X] - parameters[Arc1.Center.X])) / hyp;
            var error4 = distance - radius;
            return error4 * error4;
        }

        public override double Grad(List<double> parameters, int index)
        {
            return GradCalc.GradApproximation(parameters, index, this);
            //var pert = 1e-6;
            //var temper = parameters[index];
            //parameters[index] = temper - pert;
            //var first = Calc(parameters);
            //parameters[index] = temper + pert;
            //var second = Calc(parameters);
            //parameters[index] = temper;
            //var grad = .5 * (second - first) / pert;

            //return grad;

            //var dx = parameters[L1.P2.X] - parameters[L1.P1.X];
            //var dy = parameters[L1.P2.Y] - parameters[L1.P1.Y];

            //var lineLengthSq = dx * dx + dy * dy;
            //var lineLength = Math.Sqrt(lineLengthSq);
            //var abs = dx * (parameters[L1.P1.Y] - parameters[Arc1.Center.Y]) -
            //          dy * (parameters[L1.P1.X] - parameters[Arc1.Center.X]) / lineLength;
            //var sign = abs >= 0 ? 1 : -1;

            //if (index == Arc1.Center.X)
            //    return sign * (parameters[L1.P1.Y] - parameters[L1.P2.Y]) / lineLength;
            //if (index == Arc1.Center.Y)
            //    return sign * (parameters[L1.P2.X] - parameters[L1.P1.X]) / lineLength;

            //if (index == L1.P1.X)
            //{
            //    return sign * (lineLength * (parameters[L1.P2.Y] - parameters[Arc1.Center.Y]) + abs * dx / lineLength) /
            //    lineLengthSq;
            //}
            //if (index == L1.P1.Y)
            //{
            //    return sign * (lineLength * (parameters[Arc1.Center.X] - parameters[L1.P2.X]) + abs * dy / lineLength) /
            //     lineLengthSq;
            //}
            //if (index == L1.P2.X)
            //{
            //    return sign * (lineLength * (parameters[Arc1.Center.Y] - parameters[L1.P1.Y]) - abs * dx / lineLength) /
            //     lineLengthSq;
            //}
            //if (index == L1.P2.Y)
            //{
            //    return sign * (lineLength * (parameters[L1.P1.X] - parameters[Arc1.Center.X]) - abs * dy / lineLength) /
            //     lineLengthSq;
            //}

            //if (index == Arc1.Radius)
            //    return -1;

            //return 0;
        }
    }
}