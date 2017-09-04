using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstraintsModule.Constraints
{
    public static class GradCalc
    {
        public static double PointToLineDistanceGrad(List<double> parameters, int index, int dist, int Px, int Py,
                                                     int Lx1, int Ly1, int Lx2, int Ly2)
        {
            var dx = parameters[Lx2] - parameters[Lx1];
            var dy = parameters[Ly2] - parameters[Ly1];

            var lineLengthSq = dx*dx + dy*dy;
            var lineLength = Math.Sqrt(lineLengthSq);

            var distance =
                (dx*(parameters[Ly1] - parameters[Py]) -
                 dy*(parameters[Lx1] - parameters[Px]))/lineLength;
            var error = distance - parameters[dist];
            var abs = dx*(parameters[Ly1] - parameters[Py]) -
                      dy*(parameters[Lx1] - parameters[Px])/lineLength;
            var sign = abs >= 0 ? -1 : 1;

            if (index == Px)
                return 2*error*sign*(parameters[Ly1] - parameters[Ly2])/lineLength;
            if (index == Py)
                return 2*error*sign*(parameters[Lx2] - parameters[Lx1])/lineLength;

            if (index == Lx1)
            {
                return 2*error*sign*(lineLength*(parameters[Ly2] - parameters[Py]) + abs*dx/lineLength)/
                       lineLengthSq;
            }
            if (index == Ly1)
            {
                return 2*error*sign*(lineLength*(parameters[Px] - parameters[Lx2]) + abs*dy/lineLength)/
                       lineLengthSq;
            }
            if (index == Lx2)
            {
                return 2*error*sign*(lineLength*(parameters[Py] - parameters[Ly1]) - abs*dx/lineLength)/
                       lineLengthSq;
            }
            if (index == Ly2)
            {
                return 2*error*sign*(lineLength*(parameters[Lx1] - parameters[Px]) - abs*dy/lineLength)/
                       lineLengthSq;
            }

            if (index == dist)
                return -2*error;

            return 0;
        }

        public static double PointOnLineGrad(List<double> parameters, int index, int Px, int Py, int Lx1, int Ly1,
                                             int Lx2, int Ly2)
        {
            var dx = parameters[Lx2] - parameters[Lx1];
            var dy = parameters[Ly2] - parameters[Ly1];

            var lineLengthSq = dx*dx + dy*dy;
            var lineLength = Math.Sqrt(lineLengthSq);

            var distance =
                (dx*(parameters[Ly1] - parameters[Py]) -
                 dy*(parameters[Lx1] - parameters[Px]))/lineLength;
            var error = 1.0/2;// distance;
            var abs = dx*(parameters[Ly1] - parameters[Py]) -
                      dy*(parameters[Lx1] - parameters[Px]);
            var sign = abs >= 0 ? -1 : 1;

            if (index == Px)
                return 2*error*sign*(parameters[Ly1] - parameters[Ly2])/lineLength;
            if (index == Py)
                return 2*error*sign*(parameters[Lx2] - parameters[Lx1])/lineLength;

            if (index == Lx1)
            {
                return 2*error*sign*(lineLength*(parameters[Ly2] - parameters[Py]) - abs*dx/lineLength)/
                       lineLengthSq;
            }
            if (index == Ly1)
            {
                return 2*error*sign*(-lineLength*(parameters[Lx2] - parameters[Px]) - abs*(-dy)/lineLength)/
                       lineLengthSq;
            }
            if (index == Lx2)
            {
                return 2*error*sign*(lineLength*(parameters[Py] - parameters[Ly1]) - abs*dx/lineLength)/
                       lineLengthSq;
            }
            if (index == Ly2)
            {
                return 2*error*sign*(lineLength*(parameters[Lx1] - parameters[Px]) - abs*dy/lineLength)/
                       lineLengthSq;
            }

            return 0;
        }

        public static double GradApproximation(List<double> parameters, int index, ConstraintRefBase constraint)
        {
            var pert = 1e-6;
            var temper = parameters[index];
            parameters[index] = temper - pert;
            var first = constraint.Calc(parameters) * constraint.Calc(parameters);
            parameters[index] = temper + pert;
            var second = constraint.Calc(parameters)* constraint.Calc(parameters);
            parameters[index] = temper;
            var grad = .5*(second - first)/pert;

            return grad;

        }
    }
}
