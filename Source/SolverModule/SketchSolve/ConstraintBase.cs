//#region Usings

//using System;
//using System.Collections.Generic;
//using CleanSolver.Primitives;
//using SketchSolve.Primitives;

//#endregion

//namespace SketchSolve
//{
//    public abstract class ConstraintBase
//    {
//        public Arc Arc1;
//        public Arc Arc2;
//        public Circle Circle1;
//        public Circle Circle2;
//        public Line L1;
//        public Line L2;
//        public Point P1;
//        public Point P2;
//        public Line SymLine;

//        public DoubleRefObject Parameter = new DoubleRefObject(0);

//        public double Value
//        {
//            get { return Parameter.Value; }
//            set { Parameter.Value = value; }
//        }

//        public double Distance
//        {
//            get { return Value; }
//            set { Value = value; }
//        }

//        public double Length
//        {
//            get { return Value; }
//            set { Value = value; }
//        }

//        public double Radius
//        {
//            get { return Value; }
//            set { Value = value; }
//        }


//        protected double Arc1StartY
//        {
//            get { return Arc1.Center.Y.Value + Arc1.Radius.Value*Math.Sin(Arc1.StartAngle.Value); }
//        }

//        public abstract double Calc();
//    }

//    public abstract class ConstraintRefBase
//    {
//        public RefLine L1;
//        public RefLine L2;
//        public RefCircle Circle1;
//        public RefCircle Circle2;
//        public RefPoint P1;
//        public RefPoint P2;
//        public RefPoint P3;
//        public RefPoint P4;
//        public RefLine SymLine;
//        public RefArc Arc1;
//        public RefArc Arc2;
//        public double Distance
//         { get; set; }

//        public double Length
//        { get; set; }

//        public double Radius
//        { get; set; }

//        public double StartAngle;
//        public double EndAngle;
       
//        public abstract double Calc(List<double> parameters);

//        public abstract double Grad(List<double> parameters, int index);
//    }
//}