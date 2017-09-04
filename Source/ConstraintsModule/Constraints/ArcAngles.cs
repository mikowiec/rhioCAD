#region Usings

using System;
using System.Collections.Generic;
////using CleanSolver.SolverSystem;
using ConstraintsModule;

//using OccCode;
//using TreeData.AttributeInterpreter;

#endregion

namespace SketchSolve.Constraints
{
    public class ArcAnglesRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            //var slope1 = GeomUtils.LineSlope(new Point3D(parameters[Arc1.Center.X], parameters[Arc1.Center.Y], 0),
            //                                 new Point3D(parameters[Arc1.Start.X], parameters[Arc1.Start.Y], 0));

            //var slope2 = GeomUtils.LineSlope(new Point3D(parameters[Arc1.Center.X], parameters[Arc1.Center.Y], 0),
            //                     new Point3D(parameters[Arc1.End.X], parameters[Arc1.End.Y], 0));

            var angle1 = Math.Atan2(parameters[Arc1.Start.Y] - parameters[Arc1.Center.Y], parameters[Arc1.Start.X] - parameters[Arc1.Center.X]);
            var angle2 = Math.Atan2(parameters[Arc1.End.Y] - parameters[Arc1.Center.Y], parameters[Arc1.End.X] - parameters[Arc1.Center.X]) ;
            var temp1 = angle1 - StartAngle;
            var temp2 = angle2 - EndAngle;
            return temp1 * temp2;
        }
        public override double Grad(List<double> parameters, int index)
        {
            return 0;
        }
    }
}