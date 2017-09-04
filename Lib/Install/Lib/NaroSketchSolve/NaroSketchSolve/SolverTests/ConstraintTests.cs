/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

#region Usings

using System;
using System.Collections.Generic;
using CleanSolver.Constraints;
using CleanSolver.Primitives;
using CleanSolver.SolverSystem;
using NUnit.Framework;

#endregion

namespace SolverTests
{
    [TestFixture]
    public class ConstraintTests
    {
        [Test]
        public void PointOnPointTest()
        {
            var parameters = new List<DoubleRefObject>
                                 {
                new DoubleRefObject(3),
                new DoubleRefObject(1),
                new DoubleRefObject(4),
                new DoubleRefObject(2)
            };
            var points = new List<Point>
                             {
                                 new Point(parameters[0], parameters[1]),
                                 new Point(parameters[2], parameters[3])
                             };

            var constraints = new ConstraintContainer();
            constraints.AddConstraint(new PointOnPoint()
            {
                P1 = points[0],
                P2 = points[1]
            });

            var error = SketchSolve.Solve(parameters, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid point on point solution");
            Assert.IsTrue(Math.Abs(parameters[0].Value - parameters[2].Value) < 0.01, "invalid x axis values");
            Assert.IsTrue(Math.Abs(parameters[1].Value - parameters[3].Value) < 0.01, "invalid y axis values");
        }

        [Test]
        public void HorizontalTest()
        {
            var parameters = new List<DoubleRefObject>() {
                new DoubleRefObject(3),
                new DoubleRefObject(1),
                new DoubleRefObject(4),
                new DoubleRefObject(2)
            };
            var points = new List<Point>();
            points.Add(new Point(parameters[0], parameters[1]));
            points.Add(new Point(parameters[2], parameters[3]));

            var lines = new List<Line>();
            var testLine = new Line();
            testLine.P1 = points[0];
            testLine.P2 = points[1];
            lines.Add(testLine);

            var constraints = new ConstraintContainer();
            constraints.AddConstraint(new Horizontal()
            {
                L1 = lines[0]
            });

            var error = SketchSolve.Solve(parameters, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid horizontal solution");
            Assert.IsTrue(Math.Abs(parameters[0].Value - parameters[2].Value) > 0.01, "invalid x axis values");
            Assert.IsTrue(Math.Abs(parameters[1].Value - parameters[3].Value) < 0.01, "invalid y axis values");
        }

        [Test]
        public void VerticalTest()
        {
            var parameters = new List<DoubleRefObject>() {
                new DoubleRefObject(3),
                new DoubleRefObject(1),
                new DoubleRefObject(4),
                new DoubleRefObject(2)
            };
            var points = new List<Point>();
            points.Add(new Point(parameters[0], parameters[1]));
            points.Add(new Point(parameters[2], parameters[3]));

            var lines = new List<Line>();
            var testLine = new Line();
            testLine.P1 = points[0];
            testLine.P2 = points[1];
            lines.Add(testLine);

            var constraints = new ConstraintContainer();
            constraints.AddConstraint(new Vertical()
            {
                L1 = lines[0]
            });

            var error = SketchSolve.Solve(parameters, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid horizontal solution");
            Assert.IsTrue(Math.Abs(parameters[0].Value - parameters[2].Value) < 0.01, "invalid x axis values");
            Assert.IsTrue(Math.Abs(parameters[1].Value - parameters[3].Value) > 0.01, "invalid y axis values");
        }

        [Test]
        public void ParallelTest()
        {
            var parameters = new List<DoubleRefObject>() {
                new DoubleRefObject(1),
                new DoubleRefObject(1),
                new DoubleRefObject(3),
                new DoubleRefObject(1.5),
                new DoubleRefObject(1),
                new DoubleRefObject(3),
                new DoubleRefObject(3),
                new DoubleRefObject(2.5)
            };
            var points = new List<Point>();
            points.Add(new Point(parameters[0], parameters[1]));
            points.Add(new Point(parameters[2], parameters[3]));
            points.Add(new Point(parameters[4], parameters[5]));
            points.Add(new Point(parameters[6], parameters[7]));

            var lines = new List<Line>();
            var line1 = new Line();
            line1.P1 = points[0];
            line1.P2 = points[1];
            lines.Add(line1);
            var line2 = new Line();
            line2.P1 = points[2];
            line2.P2 = points[3];
            lines.Add(line2);

            var constraints = new ConstraintContainer();
            constraints.AddConstraint(new Parallel()
            {
                L1 = lines[0],
                L2 = lines[1]
            });

            var error = SketchSolve.Solve(parameters, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid parallel solution");
            var m1 = LineSlope(lines[0]);
            var m2 = LineSlope(lines[1]);
            Assert.IsTrue(Math.Abs(m1 - m2) < 0.01, "invalid parallel values");
        }

        [Test]
        public void PerpendicularTest()
        {
            var parameters = new List<DoubleRefObject>() {
                new DoubleRefObject(1),
                new DoubleRefObject(1),
                new DoubleRefObject(4),
                new DoubleRefObject(1),
                new DoubleRefObject(5),
                new DoubleRefObject(3)
            };
            var points = new List<Point>();
            points.Add(new Point(parameters[0], parameters[1]));
            points.Add(new Point(parameters[2], parameters[3]));
            points.Add(new Point(parameters[4], parameters[5]));

            var lines = new List<Line>();
            var line1 = new Line();
            line1.P1 = points[0];
            line1.P2 = points[1];
            lines.Add(line1);
            var line2 = new Line();
            line2.P1 = points[1];
            line2.P2 = points[2];
            lines.Add(line2);

            var constraints = new ConstraintContainer();
            constraints.AddConstraint(new Perpendicular()
            {
                L1 = lines[0],
                L2 = lines[1]
            });

            var error = SketchSolve.Solve(parameters, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid perpendicular solution");
            var m1 = LineSlope(lines[0]);
            var m2 = LineSlope(lines[1]);
            Assert.IsTrue((m1*m2 + 1) < 0.01, "invalid perpendicular values");
        }

        public double LineSlope(Line line)
        {
            return (line.P2.Y.Value - line.P1.Y.Value)/(line.P2.X.Value - line.P1.X.Value);
        }

        [Test]
        public void RectangleTest()
        {
            var parameters = new List<DoubleRefObject>() {
                new DoubleRefObject(1),
                new DoubleRefObject(1),
                new DoubleRefObject(6),
                new DoubleRefObject(1),
                new DoubleRefObject(1),
                new DoubleRefObject(4),
                new DoubleRefObject(6),
                new DoubleRefObject(5)
            };
            var points = new List<Point>();
            points.Add(new Point(parameters[0], parameters[1]));
            points.Add(new Point(parameters[2], parameters[3]));
            points.Add(new Point(parameters[4], parameters[5]));
            points.Add(new Point(parameters[6], parameters[7]));

            var lines = new List<Line>();
            var line0 = new Line();
            line0.P1 = points[0];
            line0.P2 = points[1];
            lines.Add(line0);
            var line1 = new Line();
            line1.P1 = points[2];
            line1.P2 = points[3];
            lines.Add(line1);
            var line2 = new Line();
            line2.P1 = points[0];
            line2.P2 = points[2];
            lines.Add(line2);
            var line3 = new Line();
            line3.P1 = points[1];
            line3.P2 = points[3];
            lines.Add(line3);

            var constraints = new ConstraintContainer();
            constraints.AddConstraint(new Parallel()
            {
                L1 = lines[2],
                L2 = lines[3]
            });
            constraints.AddConstraint(new Parallel()
            {
                L1 = lines[0],
                L2 = lines[1]
            });
            constraints.AddConstraint(new Perpendicular()
            {
                L1 = lines[0],
                L2 = lines[2]
            });

            var error = SketchSolve.Solve(parameters, constraints, 0);
            Assert.IsTrue(error == 0, "Invalid parallel solution");

            var m0 = LineSlope(lines[0]);
            var m1 = LineSlope(lines[1]);
            var m2 = LineSlope(lines[2]);
            var m3 = LineSlope(lines[3]);
            Assert.IsTrue((m0 * m2 + 1) < 0.01, "invalid perpendicular values");
            Assert.IsTrue(Math.Abs(m0 - m1) < 0.01, "invalid parallel values");
            Assert.IsTrue(Math.Abs(m2 - m3) < 0.01, "invalid parallel values");
        }
    }
}
