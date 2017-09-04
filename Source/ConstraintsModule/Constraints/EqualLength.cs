#region Usings

using System.Collections.Generic;
////using CleanSolver.SolverSystem;

#endregion

namespace ConstraintsModule.Constraints
{
    public class EqualLengthRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var temp = Utils.Hypot(parameters[L1.P2.X] - parameters[L1.P1.X], parameters[L1.P2.Y] - parameters[L1.P1.Y]) -
                       Utils.Hypot(parameters[L2.P2.X] - parameters[L2.P1.X], parameters[L2.P2.Y] - parameters[L2.P1.Y]);
            return temp * temp;
        }

        public override double Grad(List<double> parameters, int index)
        {
            var dx1 = parameters[L1.P2.X] - parameters[L1.P1.X];
            var dy1 = parameters[L1.P2.Y] - parameters[L1.P1.Y];
            var dx2 = parameters[L2.P2.X] - parameters[L2.P1.X];
            var dy2 = parameters[L2.P2.Y] - parameters[L2.P1.Y];

            var calc = Utils.Hypot(parameters[L1.P2.X] - parameters[L1.P1.X], parameters[L1.P2.Y] - parameters[L1.P1.Y]) *
                       Utils.Hypot(parameters[L2.P2.X] - parameters[L2.P1.X], parameters[L2.P2.Y] - parameters[L2.P1.Y]);

            if (index == L1.P2.X)
                return 2 * dx1 - 2 * dx1 * (dx2 * dx2 + dy2 * dy2) / calc;
            if (index == L1.P2.Y)
                return 2 * dy1 - 2 * dy1 * (dx2 * dx2 + dy2 * dy2) / calc;
            if (index == L1.P1.X)
                return -2 * dx1 + 2 * dx1 * (dx2 * dx2 + dy2 * dy2) / calc;
            if (index == L1.P1.Y)
                return -2 * dy1 + 2 * dy1 * (dx2 * dx2 + dy2 * dy2) / calc;

            if (index == L2.P2.X)
                return 2 * dx2 - 2 * dx2 * (dx1 * dx1 + dy1 * dy1) / calc;
            if (index == L2.P2.Y)
                return 2 * dy2 - 2 * dy2 * (dx1 * dx1 + dy1 * dy1) / calc;
            if (index == L2.P1.X)
                return -2 * dx2 + 2 * dx2 * (dx1 * dx1 + dy1 * dy1) / calc;
            if (index == L2.P1.Y)
                return -2 * dy2 + 2 * dy2 * (dx1 * dx1 + dy1 * dy1) / calc;

            return 0;
        }
    }
}