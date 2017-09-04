#region Usings

using System;
using NUnit.Framework;
using OccCode;

using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace NaroTestSuite.SplineHelpers
{
    [TestFixture]
    public class SplineHelperTests
    {
        [Test]
        public void TestAngleGet()
        {
            var a = new Point3D();
            var b = new Point3D(1, 1, 0);
            var c = new Point3D(1, 0, 0);
            const double angle = Math.PI/4;
            var angleCoordinate = GeomUtils.GetPointAngle(b, a, c);
            Assert.IsTrue(Math.Abs(angleCoordinate - angle) < Precision.Confusion);
        }

        [Test]
        public void TestAngleSetup()
        {
            var sqr3D2 = Math.Sqrt(3)/2;
            const double _1D2 = 1.0/2;
            var a = new Point3D();
            var b = new Point3D(sqr3D2, _1D2, 0);
            var c = new Point3D(_1D2, sqr3D2, 0);
            const double angle = Math.PI/3;
            var angleCoordinate = GeomUtils.GetAnglePointPosition(b, a, c, angle);
            var expected = new Point3D(0, 1, 0);
            Assert.IsTrue(expected.IsEqual(angleCoordinate));
        }

        [Test]
        public void TestParallel()
        {
            var a = new Point3D(10, 10, 0);
            var b = new Point3D(20, 10, 0);
            var c = new Point3D(18, 15, 0);
            var d = new Point3D(12, 15, 0);
            var finalD = GeomUtils.GetLastTrapezoidPoint(a, b, c);
            Assert.IsTrue(finalD.IsEqual(d));
        }

        [Test]
        public void TestParallelOnDistance()
        {
            var a = new Point3D(0, 0, 0);
            var b = new Point3D(10, 0, 0);
            var c = new Point3D(5, 10, 0);
            const double distance = 5.0;
            var lastPoint = GeomUtils.GetParallelPointOnDistance(a, b, c, distance);
            Assert.IsTrue(lastPoint.IsEqual(new Point3D(10, 10, 0)));
        }
    }
}