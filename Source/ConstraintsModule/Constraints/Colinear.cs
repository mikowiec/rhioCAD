using System;
using System.Collections.Generic;

namespace ConstraintsModule.Constraints
{
    public class ColinearRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var pointOnLine = new PointOnLineRef {L1 = L1, P1 = L2.P1};
            var pointOnLine2 = new PointOnLineRef {L1 = L1, P1 = L2.P2};
            return pointOnLine2.Calc(parameters) + pointOnLine.Calc(parameters);
        }

        public override double Grad(List<double> parameters, int index)
        {
            var pointOnLine2 = new PointOnLineRef {L1 = L1, P1 = L2.P2};
            var pointOnLine = new PointOnLineRef {L1 = L1, P1 = L2.P1};
            return pointOnLine2.Grad(parameters, index) + pointOnLine.Grad(parameters, index);
        }
    }
}