#region Usings

using System.Collections.Generic;

//using CleanSolver.SolverSystem;

#endregion

namespace ConstraintsModule.Constraints
{
    public class ConcentricArcsRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var temp = Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc2.Center.X],
                                         parameters[Arc1.Center.Y] - parameters[Arc2.Center.Y]);
            return temp;// *temp;
        }

        public override double Grad(List<double> parameters, int index)
        {
            var dx = parameters[Arc1.Center.X] - parameters[Arc2.Center.X];
            var dy = parameters[Arc1.Center.Y] - parameters[Arc2.Center.Y];
            var calc = 1/Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc2.Center.X],
                                          parameters[Arc1.Center.Y] - parameters[Arc2.Center.Y]);
            if (index == Arc1.Center.X)
                return  calc*dx;
            if (index == Arc2.Center.X)
                return - calc* dx;
            if (index == Arc1.Center.Y)
                return  calc *dy;
            if (index == Arc2.Center.Y)
                return -calc * dy;
            return 0;
        }
    }
}