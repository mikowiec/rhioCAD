#region Usings

using System;
using System.Collections.Generic;
////using CleanSolver.SolverSystem;
using ConstraintsModule;

#endregion

namespace SketchSolve.Constraints
{

    public class PointOnArcRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var radius = Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc1.Start.X],
                                           parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y]);
                
            var rad1 = Utils.Hypot(parameters[Arc1.Center.X] - parameters[P1.X], parameters[Arc1.Center.Y] - parameters[P1.Y]);
        
            //Compare this radius to the radius of the circle, return the error squared
            var temp = rad1 - radius;
            return Math.Abs(temp);// *temp;
        }

        public override double Grad(List<double> parameters, int index)
        {
            var dx1 = parameters[Arc1.Center.X] - parameters[Arc1.Start.X];
            var dy1 = parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y];
            var dx2 = parameters[Arc1.Center.X] - parameters[P1.X];
            var dy2 = parameters[Arc1.Center.Y] - parameters[P1.Y];

            var rad1 = Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc1.Start.X],
                                          parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y]);

            var rad2 = Utils.Hypot(parameters[Arc1.Center.X] - parameters[P1.X], parameters[Arc1.Center.Y] - parameters[P1.Y]);

            var calc = Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc1.Start.X], parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y]) -
                       Utils.Hypot(parameters[Arc1.Center.X] - parameters[P1.X], parameters[Arc1.Center.Y] - parameters[P1.Y]);
            var sign = calc > 0 ? 1 : -1;
            if (index == Arc1.Center.X)
                return sign*(dx1/rad1 - dx2/rad2);
            if (index == Arc1.Center.Y)
                return sign * (dy1 / rad1 - dy2 / rad2);

            if (index == Arc1.Start.X)
                return sign * (-dx1/rad1);
            if (index == Arc1.Start.Y)
                return sign*(-dy1/rad1);

            if (index == P1.X)
                return sign * (dx2/rad2);
            if (index == P1.Y)
                return sign * (dy2/rad2);  
           
            return 0;
        }
    }
}