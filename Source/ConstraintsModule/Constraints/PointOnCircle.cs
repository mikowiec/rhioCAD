#region Usings

using System;
using System.Collections.Generic;
//using CleanSolver.SolverSystem;
using ConstraintsModule;
using SketchSolve;
using TreeData.AttributeInterpreter;

#endregion

namespace CleanSolver.Constraints
{
    internal class PointOnCircle : ConstraintBase
    {
        public override double Calc()
        {
            //see what the current radius to the point is
            var rad1 = Utils.Hypot(Circle1.Center.X.Value - P1.X.Value, Circle1.Center.Y.Value - P1.Y.Value);
            //Compare this radius to the radius of the circle, return the error squared
            var temp = rad1 - Circle1.Radius.Value;
            return temp;// *temp;
        }
    }

    public class PointOnCircleRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            var rad1 = Utils.Hypot(parameters[Circle1.Center.X] - parameters[P1.X], parameters[Circle1.Center.Y] - parameters[P1.Y]);

            //Compare this radius to the radius of the circle, return the error squared
            var temp = rad1 - parameters[Circle1.Radius];
            return Math.Abs(temp);// *temp;
        }
        public override double Grad(List<double> parameters, int index)
        {
            var dx = parameters[Circle1.Center.X] - parameters[P1.X];
            var dy = parameters[Circle1.Center.Y] - parameters[P1.Y];
            var hypotCalc = Utils.Hypot(parameters[Circle1.Center.X] - parameters[P1.X],
                                        parameters[Circle1.Center.Y] - parameters[P1.Y]);

            //Compare this radius to the radius of the circle, return the error squared
            var temp = hypotCalc - parameters[Circle1.Radius];
            var calc = temp >= 0 ? 1 : -1;;

            if (index == P1.X)
                return calc * (-dx) / hypotCalc;
            if (index == P1.Y)
                return calc * (-dy) / hypotCalc;
            if (index == Circle1.Center.X)
                return calc * dx / hypotCalc;
            if (index == Circle1.Center.Y)
                return calc * dy / hypotCalc;
            if (index == Circle1.Radius)
                return -calc;
         
            return 0;
        }
    }
}