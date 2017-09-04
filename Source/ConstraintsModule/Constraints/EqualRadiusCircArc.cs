#region Usings

using System;
using System.Collections.Generic;
//using CleanSolver.SolverSystem;
using ConstraintsModule;

#endregion

namespace SketchSolve.Constraints
{
   public class EqualRadiusCircArcRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var rad1 = Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc1.Start.X], parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y]);
            var temp = rad1 - parameters[Circle1.Radius];
            return Math.Abs(temp);// *temp;
        }

        public override double Grad(List<double> parameters, int index)
        {
            var dx = parameters[Arc1.Center.X] - parameters[Arc1.Start.X];
            var dy = parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y];
            var calcHypot = Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc1.Start.X],
                                        parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y]);

            var calc = calcHypot - parameters[Circle1.Radius];

            var sign = calc > 0 ? 1 : -1;
            
            if (index == Arc1.Center.X)
                return sign * dx / calcHypot;
            if (index == Arc1.Center.Y)
                return sign * dy / calcHypot;
            if (index == Arc1.Start.X)
                return -sign * dx / calcHypot;
            if (index == Arc1.Start.Y)
                return -sign * dy / calcHypot;

            if (index == Circle1.Radius)
                return - sign;

            return 0;
        }
    }
}