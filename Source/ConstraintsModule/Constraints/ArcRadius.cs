#region Usings

using System.Collections.Generic;
////using CleanSolver.SolverSystem;
using ConstraintsModule;

#endregion

namespace SketchSolve.Constraints
{
    public class ArcRadiusRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var rad1 = Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc1.Start.X], parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y]);
            var temp = rad1 - Radius;
            return temp * temp;
        }
        public override double Grad(List<double> parameters, int index)
        {
            return 0;
        }
    }
}