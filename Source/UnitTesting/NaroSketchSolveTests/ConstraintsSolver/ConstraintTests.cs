#region Usings

using System;
using System.Collections.Generic;
using ConstraintsModule;
using ConstraintsModule.Constraints;
using ConstraintsModule.Helpers;
using ConstraintsModule.Primitives;
using NUnit.Framework;
using NaroCAD.SolverModule;


#endregion

namespace NaroSketchSolveTests.ConstraintsSolver
{
    [TestFixture]
    public class ConstraintTests
    {
        private static double LineSlope(Line line)
        {
            if (Math.Abs(line.P2.X.Value - line.P1.X.Value) > 0.0001)
                return (line.P2.Y.Value - line.P1.Y.Value) / (line.P2.X.Value - line.P1.X.Value);
            return double.PositiveInfinity;
        }

        private static double LineSlope(RefLine line, List<double> parameters)
        {
            if (Math.Abs(parameters[line.P2.X] - parameters[line.P1.X]) > 0.0001)
                return (parameters[line.P2.Y] - parameters[line.P1.Y]) / (parameters[line.P2.X] - parameters[line.P1.X]);
            return double.PositiveInfinity;
        }

        [Test]
        public void HorizontalTest()
        {
            var parametersList = new List<double> { 3, 1, 4, 2 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();
            constraints.Add(new HorizontalRef
            {
                L1 = new RefLine(0, 1, 2, 3)
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 2, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid horizontal solution");
            Assert.IsTrue(Math.Abs(parameters[0] - parameters[2]) > 0.01, "invalid x axis values");
            Assert.IsTrue(Math.Abs(parameters[1] - parameters[3]) < 0.01, "invalid y axis values");
        }

        [Test]
        public void ParallelToYAxisTest()
        {
            var parametersList = new List<double> { 1, 0, 1, 4, 5, 0, 5, 13 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();
            var line1 = new RefLine(0, 1, 2, 3);
            var line2 = new RefLine(4, 5, 6, 7);
            constraints.Add(new ParallelRef
            {
                L1 = line1,
                L2 = line2
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 0, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid parallel solution");
            var m1 = LineSlope(line1, parameters);
            var m2 = LineSlope(line2, parameters);

            Assert.IsTrue(double.IsPositiveInfinity(m1));
            Assert.AreEqual(m1, m2);
        }

        [Test]
        public void ParallelTest()
        {
            var parametersList = new List<double> { 0, 0, 3, 0, 0, 10, -5, 5 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();
            constraints.Add(new ParallelRef
            {
                L1 = new RefLine(6, 7, 0, 1),
                L2 = new RefLine(2, 3, 4, 5)
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 0, constraints, 0);
            Assert.IsTrue(error == 1, "Invalid solution");

            solver = new BFGSSolver();
            error = solver.SolveRef(ref parameters, 1, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid solution");
            //parameters[0] = -3.49999

            Assert.IsTrue(Math.Abs(parameters[0] + 3.4999) < 0.001);
        }

        [Test]
        public void PerpendicularTest()
        {
            var parametersList = new List<double> { 5, 3, 1, 1, 4, 1 };
            var parameters = new Vector(parametersList);

            var constraints = new ConstraintRefContainer();
            constraints.Add(new PerpendicularRef
            {
                L1 = new RefLine(2, 3, 4, 5),
                L2 = new RefLine(0, 1, 4, 5)
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 1, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid perpendicular solution");
            Assert.IsTrue(Math.Abs(parameters[0] - 4) < 0.0001);
            Assert.IsTrue(Math.Abs(parameters[1] - 3) < 0.0001);
        }

        [Test]
        public void PointOnPointTest()
        {
            var parametersList = new List<double> { 3, 1, 4, 2 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();
            constraints.Add(new PointOnPointRef
            {
                P1 = new RefPoint(0, 1),
                P2 = new RefPoint(2, 3)
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 2, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid point on point solution");
            Assert.IsTrue(Math.Abs(parameters[0] - parameters[2]) < 0.01, "invalid x axis values");
            Assert.IsTrue(Math.Abs(parameters[1] - parameters[3]) < 0.01, "invalid y axis values");
        }

        [Test]
        public void PointOnLineTest()
        {
            var parametersList = new List<double> { 3, 1, 4, 2, 5, 2 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();
            constraints.Add(new PointOnLineRef
            {
                P1 = new RefPoint(0, 1),
                L1 = new RefLine(2, 3, 4, 5)
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 2, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid point on point solution");
            Assert.IsTrue(Math.Abs(parameters[0] - 3) < 0.01, "invalid x axis value");
            Assert.IsTrue(Math.Abs(parameters[1] - 2) < 0.01, "invalid y axis value");
        }

        [Test]
        public void RectangleTest()
        {
            var parametersList = new List<double> { 1, 4, 6, 1, 6, 5, 1, 1 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();
            constraints.Add(new ParallelRef
            {
                L1 = new RefLine(4, 5, 0, 1),
                L2 = new RefLine(6, 7, 2, 3)
            });
            constraints.Add(new ParallelRef
            {
                L1 = new RefLine(2, 3, 4, 5),
                L2 = new RefLine(0, 1, 6, 7)
            });
            constraints.Add(new PerpendicularRef
            {
                L1 = new RefLine(4, 5, 0, 1),
                L2 = new RefLine(0, 1, 6, 7)
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 0, constraints, 0);
            Assert.IsTrue(error == 1, "Invalid solution");

             solver = new BFGSSolver();
             error = solver.SolveRef(ref parameters, 2, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid solution");
            Assert.IsTrue(Math.Abs(parameters[0] - 1) < 0.001);
            Assert.IsTrue(Math.Abs(parameters[1] - 5) < 0.001);
        }

        [Test]
        public void VerticalTest()
        {
            var parametersList = new List<double> { 3, 1, 4, 2 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();
            constraints.Add(new VerticalRef
            {
                L1 = new RefLine(0, 1, 2, 3)
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 1, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid horizontal solution");
            Assert.IsTrue(Math.Abs(parameters[0] - 4) < 0.01, "invalid x axis values");
        }

        [Test]
        public void ThreeRectanglesTest()
        {
            var parametersList = new List<double> { 2, 1, 5, 4, 8, 1, 11, 1, /*fixed points:*/  7, -1, 2, 4, 8, 4, 11, 4 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();

            /* first rectangle*/
            constraints.Add(new ParallelRef
            {
                L1 = new RefLine(0, 1, 8, 9),
                L2 = new RefLine(10, 11, 2, 3)
            });
            constraints.Add(new ParallelRef
            {
                L1 = new RefLine(10, 11, 0, 1),
                L2 = new RefLine(2, 3, 8, 9)
            });
            constraints.Add(new PerpendicularRef
            {
                L1 = new RefLine(10, 11, 0, 1),
                L2 = new RefLine(0, 1, 8, 9)
            });

            /*second rectangle*/
            constraints.Add(new ParallelRef
            {
                L1 = new RefLine(2, 3, 12, 13),
                L2 = new RefLine(8, 9, 4, 5)
            });
            constraints.Add(new ParallelRef
            {
                L1 = new RefLine(2, 3, 8, 9),
                L2 = new RefLine(12, 13, 4, 5)
            });
            constraints.Add(new PerpendicularRef
            {
                L1 = new RefLine(2, 3, 8, 9),
                L2 = new RefLine(8, 9, 4, 5)
            });

            /*third rectangle*/
            constraints.Add(new ParallelRef
            {
                L1 = new RefLine(12, 13, 14, 15),
                L2 = new RefLine(4, 5, 6, 7)
            });
            constraints.Add(new ParallelRef
            {
                L1 = new RefLine(12, 13, 4, 5),
                L2 = new RefLine(14, 15, 6, 7)
            });
            constraints.Add(new PerpendicularRef
            {
                L1 = new RefLine(12, 13, 4, 5),
                L2 = new RefLine(4, 5, 6, 7)
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, parameters.Count - 8, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid parallel solution");

            Assert.IsTrue(Math.Abs(parameters[1] + 1) < 0.001, "P0.y is not -1!");
            Assert.IsTrue(Math.Abs(parameters[5] + 1) < 0.001, "P3.y is not -1!");
            Assert.IsTrue(Math.Abs(parameters[7] + 1) < 0.001, "P4.y is not -1!");
            Assert.IsTrue(Math.Abs(parameters[9] + 1) < 0.001, "P5.y is not -1!");
            Assert.IsTrue(Math.Abs(parameters[0] - 2) < 0.001, "P0.x is not 7!");
            Assert.IsTrue(Math.Abs(parameters[4] - 8) < 0.001, "P3.x is not 2!");
            Assert.IsTrue(Math.Abs(parameters[6] - 11) < 0.001, "P4.x is not 8!");
            Assert.IsTrue(Math.Abs(parameters[8] - 7) < 0.001, "P5.x is not 11!");
            Assert.IsTrue(Math.Abs(parameters[2] - 7) < 0.001, "P2.x is not 7!");
            Assert.IsTrue(Math.Abs(parameters[3] - 4) < 0.001, "P2.Y is not 4!");
        }

        [Test]
        public void VerticalDistanceToCenterTest()
        {
            var parametersList = new List<double> { 2, 2 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();
            constraints.Add(new VerticalDistanceToCenterRef
            {
                P1 = new RefPoint(0, 1),
                Distance = 10
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 2, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid horizontal solution");
            Assert.IsTrue(Math.Abs(parameters[1] - 10) < 0.01, "invalid y axis values");
        }

        [Test]
        public void HorizontalDistanceToCenterTest()
        {
            var parametersList = new List<double> { 2, 2 };
            var parameters = new Vector(parametersList);
            var constraints = new ConstraintRefContainer();
            constraints.Add(new HorizontalDistanceToCenterRef
            {
                P1 = new RefPoint(0, 1),
                Distance = 10
            });

            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 2, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid horizontal solution");
            Assert.IsTrue(Math.Abs(parameters[0] - 10) < 0.01, "invalid x axis values");
        }

        [Test]
        public void PerpendicularWithFixedPointTest()
        {
            var parametersList = new List<double> { 6, 8, 6, 3, 2, 6 };
            var parameters = new Vector(parametersList);

            var constraints = new ConstraintRefContainer();
            constraints.Add(new PerpendicularRef
            {
                L1 = new RefLine(0, 1, 2, 3),
                L2 = new RefLine(0, 1, 4, 5)
            });

            constraints.Add(new HorizontalDistanceToCenterRef
            {
                P1 = new RefPoint(0, 1),
                Distance = 2
            });
            constraints.Add(new VerticalDistanceToCenterRef
            {
                P1 = new RefPoint(0, 1),
                Distance = 2
            });
            var solver = new BFGSSolver();
            var error = solver.SolveRef(ref parameters, 6, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid perpendicular solution");
            var m1 = LineSlope(new RefLine(0, 1, 2, 3), parameters);
            var m2 = LineSlope(new RefLine(0, 1, 4, 5), parameters);
            Assert.IsTrue((m1 * m2 + 1) < 0.01, "invalid perpendicular values");
            Assert.IsTrue(Math.Abs(parameters[0] - 2) < 0.0001, "invalid point values for Horizontal distance constraint");
            Assert.IsTrue(Math.Abs(parameters[1] - 2) < 0.0001, "invalid point values for Vertical distance constraint");
        }
    }
}
