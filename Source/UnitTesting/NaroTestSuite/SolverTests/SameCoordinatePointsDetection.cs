#region Usings

using System.Collections.Generic;
using Moq;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCAD.SolverModule;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.gp;
using NUnit.Framework;
using NaroSketchAdapter;
using NaroSketchAdapter.Rules.Naro;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using ShapeFunctionsInterface.Utils;
using System.Linq;
#endregion

namespace NaroTestSuite.SolverTests
{
    [TestFixture]
    public class SameCoordinatePointsDetection
    {
        private static void InitializeGeometry(ICollection<SolverGeometricObject> geometry)
        {
            // Make a rectangle
            var rectObject = new SolverGeometricObject(null);

            // Add some dummy points
            rectObject.Points.Add(new SolverDataPoint(new Point3D(0, 0, 0), GeometryType.EndPoint));
            rectObject.Points.Add(new SolverDataPoint(new Point3D(10, 10, 0), GeometryType.EndPoint));
            rectObject.Points.Add(new SolverDataPoint(new Point3D(0, 10, 0), GeometryType.EndPoint));
            rectObject.Points.Add(new SolverDataPoint(new Point3D(10, 0, 0), GeometryType.EndPoint));
            rectObject.Points.Add(new SolverDataPoint(new Point3D(-10, -10, 0), GeometryType.EndPoint));

            // Add two edges to intersect
            var edge1 = new BRepBuilderAPIMakeEdge(new Point3D(0, 0, 0).GpPnt, new Point3D(10, 10, 0).GpPnt).Edge;
            rectObject.Edges.Add(new SolverEdge(edge1));
            var edge2 = new BRepBuilderAPIMakeEdge(new Point3D(0, 10, 0).GpPnt, new Point3D(10, 0, 0).GpPnt).Edge;
            rectObject.Edges.Add(new SolverEdge(edge2));

            geometry.Add(rectObject);
        }

        [Test]
        public void SameXCoordinateMatch()
        {
            var document = TestUtils.DefaultsSetup();
            var solver = new Solver(document);
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Commit("Added sketch");
            document.Transact();

            var point = new SolverGeometricObject(sketchNode);
            point.AddPoint(new SolverDataPoint(new Point3D(10, 2, 0)));
            solver.Geometry.Add(point);
            solver.LastGeometry.Add(point);
            var coordinateMatch = new SameCoordinatePoints(solver, 2);

            var pointN = new Point3D(10 + 0.1, 20 - 0.1, 0.1);
            var plnOfTheView = new gpPln(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
            var solutions = coordinateMatch.InterestingShapeAroundPoint(plnOfTheView, pointN);
            Assert.AreEqual(solutions.Count, 1);
            var solution = solutions.First();
            Assert.IsTrue(solution != null, "A solution should be found");
            Assert.IsTrue(solution is SolverEdgeTwoPointsResult, "Invalid solution type");
            Assert.IsTrue(solution.Point.IsEqual(new Point3D(10, 19.9, 0)), "Invalid magic point found");
        }

        [Test]
        public void XYCoordinatesMatch()
        {
            var document = TestUtils.DefaultsSetup();
            var solver = new Solver(document);
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Commit("Added sketch");
            document.Transact();

            var point = new SolverGeometricObject(sketchNode);
            point.AddPoint(new SolverDataPoint(new Point3D(4 ,11, 0)));
            solver.Geometry.Add(point);
            solver.LastGeometry.Add(point);
            var interestingPoints = new List<SolverPreviewObject>();
            var pointN = new Point3D(3.9, 2.9, 0.1);
            var plnOfTheView = new gpPln(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
            var coordinateMatch = new SameCoordinatePoints(solver, 2);
            var solutions = coordinateMatch.InterestingShapeAroundPoint(plnOfTheView, pointN);
            Assert.AreEqual(solutions.Count, 1);
            var solution = solutions.First();
            Assert.IsTrue(solution != null, "A solution should be found");
            Assert.IsTrue(solution is SolverEdgeTwoPointsResult, "Invalid solution type");
            interestingPoints.Add(solution);

            point = new SolverGeometricObject(sketchNode);
            point.AddPoint(new SolverDataPoint(new Point3D(10, 3, 0)));
            solver.Geometry.Clear();
            solver.LastGeometry.Clear();
            solver.Geometry.Add(point);
            solver.LastGeometry.Add(point);
            coordinateMatch = new SameCoordinatePoints(solver, 2);
            solutions = coordinateMatch.InterestingShapeAroundPoint(plnOfTheView, pointN);
            Assert.AreEqual(solutions.Count, 1);
            solution = solutions.First();
            interestingPoints.Add(solution);
            Assert.IsTrue(solution != null, "A solution should be found");
            Assert.IsTrue(solution is SolverEdgeTwoPointsResult, "Invalid solution type");
            
            var results = SolverTestsUtils.GetIntersectionPoints(interestingPoints, document);
            Assert.AreEqual(results.Count, 1, "Wrong number of intersection results!");
            Assert.IsTrue(results[0].IsEqual(new Point3D(4,3, 0)), "Invalid magic point found");
        }

        [Test]
        public void MultipleIntersections()
        {
            var document = TestUtils.DefaultsSetup();
            var solver = new Solver(document);
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Commit("Added sketch");
            document.Transact();
            var pointN = new Point3D(4.6, 2.9, 0);
            var point = new SolverGeometricObject(sketchNode);
            point.AddPoint(new SolverDataPoint(new Point3D(4, 11, 0)));
            solver.Geometry.Add(point);
            solver.LastGeometry.Add(point);
            var interestingPoints = new List<SolverPreviewObject>();
            
            var plnOfTheView = new gpPln(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
            var coordinateMatch = new SameCoordinatePoints(solver, 2);
            var solutions = coordinateMatch.InterestingShapeAroundPoint(plnOfTheView, pointN);
            Assert.AreEqual(solutions.Count, 1);
            var solution = solutions.First();
            Assert.IsTrue(solution != null, "A solution should be found");
            Assert.IsTrue(solution is SolverEdgeTwoPointsResult, "Invalid solution type");
            interestingPoints.Add(solution);

            point = new SolverGeometricObject(sketchNode);
            point.AddPoint(new SolverDataPoint(new Point3D(10, 3, 0)));
            solver.Geometry.Clear();
            solver.LastGeometry.Clear();
            solver.Geometry.Add(point);
            solver.LastGeometry.Add(point);
            coordinateMatch = new SameCoordinatePoints(solver, 2);
            solutions = coordinateMatch.InterestingShapeAroundPoint(plnOfTheView, pointN);
            Assert.AreEqual(solutions.Count, 1);
            solution = solutions.First();
            interestingPoints.Add(solution);
            Assert.IsTrue(solution != null, "A solution should be found");
            Assert.IsTrue(solution is SolverEdgeTwoPointsResult, "Invalid solution type");

            point = new SolverGeometricObject(sketchNode);
            point.AddPoint(new SolverDataPoint(new Point3D(4.6,11, 0)));
            solver.Geometry.Clear();
            solver.LastGeometry.Clear();
            solver.Geometry.Add(point);
            solver.LastGeometry.Add(point);
            coordinateMatch = new SameCoordinatePoints(solver, 2);
            solutions = coordinateMatch.InterestingShapeAroundPoint(plnOfTheView, pointN);
            Assert.AreEqual(solutions.Count, 1);
            solution = solutions.First();
            interestingPoints.Add(solution);
            Assert.IsTrue(solution != null, "A solution should be found");
            Assert.IsTrue(solution is SolverEdgeTwoPointsResult, "Invalid solution type");

            var results = SolverTestsUtils.GetIntersectionPoints(interestingPoints, document);
            Assert.AreEqual(results.Count, 1, "Wrong number of intersection results!");
            Assert.IsTrue(results[0].IsEqual(new Point3D(4.6, 3, 0)), "Invalid magic point found");
        }

        [Test]
        public void SameXNegativeCoordinateMatch()
        {
            var document = TestUtils.DefaultsSetup();
            var solver = new Solver(document);
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Commit("Added sketch");
            document.Transact();

            var point = new SolverGeometricObject(sketchNode);
            point.AddPoint(new SolverDataPoint(new Point3D(-10, 2, 0)));
            solver.Geometry.Add(point);
            solver.LastGeometry.Add(point);
            var coordinateMatch = new SameCoordinatePoints(solver, 2);

            var pointN = new Point3D(-10 + 0.1, 20 - 0.1, 0.1);
            var plnOfTheView = new gpPln(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
            var solutions = coordinateMatch.InterestingShapeAroundPoint(plnOfTheView, pointN);
            Assert.AreEqual(solutions.Count, 1);
            var solution = solutions.First();
            Assert.IsTrue(solution != null, "A solution should be found");
            Assert.IsTrue(solution is SolverEdgeTwoPointsResult, "Invalid solution type");
            Assert.IsTrue((solution).Point.IsEqual(new Point3D(-10, 19.9, 0)), "Invalid magic point found");
        }
    }
}
