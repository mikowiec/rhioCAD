#region Usings

using System;
using CleanSolver.Primitives;

#endregion

namespace CleanSolver.Constraints
{
    public abstract class ConstraintBase
    {
        public Line L1;
        public Line L2;
        public Point P1;
        public Point P2;
        public Line SymLine;

        public Arc arc1;
        public Arc arc2;
        public Circle circle1;
        public Circle circle2;
        public object parameter;

        public double Value
        {
            get { return (double) parameter; }
            set { parameter = value; }
        }

        public double Distance
        {
            get { return Value; }
            set { Value = value; }
        }

        public double Length
        {
            get { return Value; }
            set { Value = value; }
        }

        public double Radius
        {
            get { return Value; }
            set { Value = value; }
        }


        protected double Arc1StartY
        {
            get { return arc1.Center.Y.Value + arc1.Radius.Value * Math.Sin(arc1.StartAngle.Value); }
        }

        public abstract double Calc();
    }
}