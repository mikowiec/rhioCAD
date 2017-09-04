#region Usings

using System;
using System.Collections.Generic;
using ConstraintsModule;

//using CleanSolver.SolverSystem;

#endregion

namespace SketchSolve.Constraints
{
    public class EqualRadiusArcsRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var rad1 = Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc1.Start.X], parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y]);
            var rad2 = Utils.Hypot(parameters[Arc2.Center.X] - parameters[Arc2.Start.X], parameters[Arc2.Center.Y] - parameters[Arc2.Start.Y]);
            var temp = rad1 - rad2;
            return Math.Abs(temp);// *temp;
        }

        public override double Grad(List<double> parameters, int index)
        {
            var dx1 = parameters[Arc1.Center.X] - parameters[Arc1.Start.X];
            var dy1 = parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y];
            var dx2 = parameters[Arc2.Center.X] - parameters[Arc2.Start.X];
            var dy2 = parameters[Arc2.Center.Y] - parameters[Arc2.Start.Y];
            var rad1 = Utils.Hypot(parameters[Arc1.Center.X] - parameters[Arc1.Start.X], parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y]);
            var rad2 = Utils.Hypot(parameters[Arc2.Center.X] - parameters[Arc2.Start.X], parameters[Arc2.Center.Y] - parameters[Arc2.Start.Y]);
            var sign = rad1 - rad2 > 0 ? 1 : -1;
            var calc1 = sign/rad1;
            var calc2 = - sign/ rad2;

            if (index == Arc1.Center.X)
                return dx1 * calc1;
            if (index == Arc1.Center.Y)
                return dy1 * calc1;
            if (index == Arc1.Start.X)
                return -dx1 * calc1;
            if (index == Arc1.Start.Y)
                return - dy1 * calc1;

            if (index == Arc2.Center.X)
                return dx2 * calc2;
            if (index == Arc2.Center.Y)
                return dy2 * calc2;
            if (index == Arc2.Start.X)
                return - dx2 * calc2;
            if (index == Arc2.Start.Y)
                return - dy2 * calc2;

            //var dx1 = parameters[Arc1.Center.X] - parameters[Arc1.Start.X];
            //var dy1 = parameters[Arc1.Center.Y] - parameters[Arc1.Start.Y];
            //var dx2 = parameters[Arc2.Center.X] - parameters[Arc2.Start.X];
            //var dy2 = parameters[Arc2.Center.Y] - parameters[Arc2.Start.Y];

            //var calc = dx1*dx1 + dy1*dy1 - dx2*dx2 - dy2*dy2;

            //if (index == Arc1.Center.X)
            //    return calc * dx1;
            //if (index == Arc1.Center.Y)
            //    return calc * dy1;
            //if (index == Arc1.Start.X)
            //    return -calc * dx1;
            //if (index == Arc1.Start.Y)
            //    return -calc * dy1;

            //if (index == Arc2.Center.X)
            //    return calc * dx2;
            //if (index == Arc2.Center.Y)
            //    return calc * dy2;
            //if (index == Arc2.Start.X)
            //    return -calc * dx2;
            //if (index == Arc2.Start.Y)
            //    return -calc * dy2;

            return 0;
        }
    }
}