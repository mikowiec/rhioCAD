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
    public class PerpendicularDetection
    {
        [Test]
        public void GeometryPerpendicularTest()
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
            var perpendicularMatch = new OrthogonalLineMatch(solver, 5.0 / 180 * Math.PI);

            var initialPosition = new Point3D(6, 2, 0);
            var currentPosition = new Point3D(3.9, 4, 0);
            var line = TestUtils.Line(document, sketchNode, new Point3D(1, 1, 0), new Point3D(4, 4, 0));
            var result = new SolverGeometricObject(line.Node);
            NodeHelper.BuildSolverInfo(result, result.Parent, 0.0872, true);
            solver.Refresh();
            var solution = perpendicularMatch.InterestingShapeAroundPoint(plnOfTheView, currentPosition, initialPosition);
            Assert.IsTrue(solution.Point.X - 3.95 < Precision.Confusion, "Invalid X solution");
            Assert.IsTrue(solution.Point.Y - 4.05 < Precision.Confusion, "Invalid Y solution");
            Assert.IsTrue(solution.Point.Z < Precision.Confusion, "Invalid Z solution");
        }
    }
}