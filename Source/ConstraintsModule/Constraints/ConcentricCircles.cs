#region Usings

using System.Collections.Generic;

//using CleanSolver.SolverSystem;

#endregion

namespace ConstraintsModule.Constraints
{
   public class ConcentricCirclesRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var temp = Utils.Hypot(parameters[Circle1.Center.X] - parameters[Circle2.Center.X],
                                         parameters[Circle1.Center.Y] - parameters[Circle2.Center.Y]);
            return temp;// *temp;
        }

        public override double Grad(List<double> parameters, int index)
        {
            var dx = parameters[Circle1.Center.X] - parameters[Circle2.Center.X];
            var dy = parameters[Circle1.Center.Y] - parameters[Circle2.Center.Y];
            var calc = 1 / Utils.Hypot(parameters[Circle1.Center.X] - parameters[Circle2.Center.X],
                                         parameters[Circle1.Center.Y] - parameters[Circle2.Center.Y]);
            if (index == Circle1.Center.X)
                return calc* dx;
            if (index == Circle2.Center.X)
                return -calc * dx;
            if (index == Circle1.Center.Y)
                return calc*dy;
            if (index == Circle2.Center.Y)
                return - calc*dy;
            return 0;
        }
    }
}