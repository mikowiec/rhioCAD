#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCAD.SolverModule;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using NUnit.Framework;
using NaroSketchAdapter;
using NaroSketchAdapter.Rules.Naro;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using System.Linq;
#endregion

namespace NaroTestSuite.SolverTests
{
    [TestFixture]
    public class PlaneDetection
    {
        private static void InitializeGeometry(ICollection<SolverGeometricObject> geometry)
        {
            var document = TestUtils.DefaultsSetup();

            // Make a rectangle
            var rectObject = new SolverGeometricObject(null);

            rectObject.Points.Add(new SolverDataPoint(new Point3D(0, 0, 0), GeometryType.EndPoint));
            rectObject.Points.Add(new SolverDataPoint(new Point3D(0, 0, 100), GeometryType.EndPoint));
            rectObject.Points.Add(new SolverDataPoint(new Point3D(100, 0, 0), GeometryType.EndPoint));
            rectObject.Points.Add(new SolverDataPoint(new Point3D(100, 0, 100), GeometryType.EndPoint));

            var pln = new gpPln(new gpPnt(0, 0, 0), new gpDir(0, 1, 0));
            var plane = new SolverPlane(pln);
            rectObject.Planes.Add(plane);

            geometry.Add(rectObject);
        }

        /// <summary>
        ///   Check that point in plane is detected
        /// </summary>
        [Test]
        public void PointOnPlane()
        {
            var document = TestUtils.DefaultsSetup();

            // Initialize the data test geometry
            var solver = new Solver(new Document());
            InitializeGeometry(solver.Geometry);

            // Test a magic point near a plane
            var planeMatch = new PlaneMatch(solver, 2.0);
            var point = new Point3D(1000, .5, 150);

            var pln = new gpPln(new gpPnt(0, 0, 0), new gpDir(0, 1, 0));
            var solutions = planeMatch.InterestingShapeAroundPoint(pln, point);
            Assert.AreEqual(solutions.Count, 1);
            var solution = solutions.First();
            Assert.IsTrue(solution.Point.X - 1000 < Precision.Confusion, "Invalid X plane magic point");
            Assert.IsTrue(solution.Point.Y < Precision.Confusion, "Invalid Y plane magic point");
            Assert.IsTrue(solution.Point.Z - 150 < Precision.Confusion, "Invalid Z plane magic point");
        }
    }
}