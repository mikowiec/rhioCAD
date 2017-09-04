#region Usings

using System;
using System.Collections.Generic;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCAD.SolverModule;
using NaroCAD.SolverModule.Helpers;
using NaroCAD.SolverModule.Interface.Geometry;
using System.Linq;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using NUnit.Framework;
using NaroSketchAdapter;
using NaroSketchAdapter.Rules.Naro;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroTestSuite.SolverTests
{
    [TestFixture]
    public class EdgeIntersectionDetection
    {
        [Test]
        public void EdgeContinuationDetectionTest()
        {
            var plnOfTheView = new gpPln(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
            var document = TestUtils.DefaultsSetup();
            var solver = new Solver(document);
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Commit("Added sketch");
            document.Transact();
            // Test parallelism
            var linecontinuationMatch = new EdgeContinuationMatch(solver, 5.0 / 180 * Math.PI);

            var currentPosition = new Point3D(4.02, 4, 0);
            var line = TestUtils.Line(document, sketchNode, new Point3D(1, 1, 0), new Point3D(3, 3, 0));
            var result = new SolverGeometricObject(line.Node);
            NodeHelper.BuildSolverInfo(result, result.Parent, 0.0872,
                                       true);
            solver.Refresh();
            var solutions = linecontinuationMatch.InterestingShapeAroundPoint(plnOfTheView, currentPosition);
            Assert.AreEqual(solutions.Count, 1);
            var solution = solutions.First();

            Assert.IsTrue(solution.Point.X - 4.01 < Precision.Confusion, "Invalid X solution");
            Assert.IsTrue(solution.Point.Y - 4.01 < Precision.Confusion, "Invalid Y solution");
            Assert.IsTrue(solution.Point.Z < Precision.Confusion, "Invalid Z solution");
        }
    }
}