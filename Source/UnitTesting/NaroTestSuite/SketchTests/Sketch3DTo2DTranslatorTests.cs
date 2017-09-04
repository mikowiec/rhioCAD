#region Usings

using NaroSketchAdapter;
using NUnit.Framework;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroTestSuite.SketchTests
{
    [TestFixture]
    public class Sketch3DTo2DTranslatorTests
    {
        [Test]
        public void Sketch2DTo3DTest()
        {
            var axis = new Axis(new Point3D(0, 0, 10), new Point3D(0, 0, 1));
            var result3D = Sketch3DTo2DTranslator.ConvertToGlobal(axis, new Point3D(10, 10, 0));
            Assert.IsTrue(result3D.IsEqual(new Point3D(10, 10, 10)), "invalid translated coordinate");
        }

        [Test]
        public void Sketch3DTo2DTest()
        {
            var axis = new Axis(new Point3D(0, 0, 0), new Point3D(0, 0, 1));
            var result2D = Sketch3DTo2DTranslator.Translate(axis, new Point3D(10, 10, 10));
            Assert.IsTrue(result2D.IsEqual(new Point3D(10, 10, 0)), "invalid translated coordinate");
        }
    }
}