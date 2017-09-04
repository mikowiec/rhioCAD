#region Usings

using System;
using NaroCAD.SolverModule;
using NaroCAD.SolverModule.Helpers;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using NUnit.Framework;
using NaroSketchAdapter;
using NaroSketchAdapter.Rules.Naro;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.SolverTests
{
    [TestFixture]
    public class ParallelismDetection
    {
        /// <summary>
        ///   Check that parallelism with axis is detected
        /// </summary>
        [Test]
        public void AxisParalelism()
        {
            TestUtils.DefaultsSetup();

            var ruleMath = new ParallelLineMatch(null, 0.05);
            // Parallel with Y axis
            var initialPosition = new Point3D(100, 100, 0);
            var currentPosition = new Point3D(100.2, 200, 0);

            var solution = ruleMath.AxisParallel(currentPosition, initialPosition);
            Assert.IsTrue(solution.Point.X - 100 < Precision.Confusion, "Invalid X axis parallelism");
            Assert.IsTrue(solution.Point.Y - 200 < Precision.Confusion, "Invalid Y axis parallelism");
            Assert.IsTrue(solution.Point.Z < Precision.Confusion, "Invalid Z axis parallelism");

            // Parallel with X axis
            currentPosition = new Point3D(200, 100.2, 0);

            solution = ruleMath.AxisParallel(currentPosition, initialPosition);
            Assert.IsTrue(solution.Point.X - 200 < Precision.Confusion, "Invalid X axis parallelism");
            Assert.IsTrue(solution.Point.Y - 100 < Precision.Confusion, "Invalid Y axis parallelism");
            Assert.IsTrue(solution.Point.Z < Precision.Confusion, "Invalid Z axis parallelism");

            // Parallel with Z axis
            initialPosition = new Point3D(100, 0, 100);
            currentPosition = new Point3D(100.2, 0, 200);

            solution = ruleMath.AxisParallel(currentPosition, initialPosition);
            Assert.IsTrue(solution.Point.X - 100 < Precision.Confusion, "Invalid X axis parallelism");
            Assert.IsTrue(solution.Point.Y < Precision.Confusion, "Invalid Y axis parallelism");
            Assert.IsTrue(solution.Point.Z - 200 < Precision.Confusion, "Invalid Z axis parallelism");
        }

        /// <summary>
        ///   Check geometry parallelism
        /// </summary>
        [Test]
        public void GeometryParallelismTest()
        {
            var document = TestUtils.DefaultsSetup();
            var solver = new Solver(document);
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Commit("Added sketch");
            document.Transact();
            // Test parallelism
            var parallelMatch = new ParallelLineMatch(solver, 5.0/180*Math.PI);

            var initialPosition = new Point3D(3, 1, 0);
            var currentPosition = new Point3D(4.05, 1.95, 0);
            var line = TestUtils.Line(document, sketchNode, new Point3D(1,1,0), new Point3D(3,3,0));
            var result = new SolverGeometricObject(line.Node);
            NodeHelper.BuildSolverInfo(result, result.Parent, 0.0872,
                                       true);
            solver.Refresh();
            var solution = parallelMatch.GeometryParallel(currentPosition, initialPosition);
            Assert.IsTrue(solution.Point.X - 4 < Precision.Confusion, "Invalid X axis parallelism");
            Assert.IsTrue(solution.Point.Y - 2 < Precision.Confusion, "Invalid Y axis parallelism");
            Assert.IsTrue(solution.Point.Z < Precision.Confusion, "Invalid Z axis parallelism");
        }
    }
}