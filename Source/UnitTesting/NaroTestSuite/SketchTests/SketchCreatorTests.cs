#region Usings

using NUnit.Framework;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.SketchTests
{
    [TestFixture]
    public class SketchCreatorTests
    {
        private Document _document;

        #region Setup/Teardown

        [SetUp]
        public void ConfigureTestEnvironment()
        {
            DefaultsSetup();
        }

        [TearDown]
        public void TestModificationsCleanup()
        {
            _document = null;
        }

        #endregion

        private void DefaultsSetup()
        {
            _document = TestUtils.DefaultsSetup();
            Assert.IsTrue(_document.Root.Get<DocumentContextInterpreter>() != null, "invalid interpreter setup");
        }

        [Test]
        public void SketchCreatorConstructorTests()
        {
            _document.Transact();
            _document.Revert();
            var defaultSketchCreator = new SketchCreator(_document);
            Assert.IsTrue(defaultSketchCreator.CurrentSketch != null, "invalid sketch constructor");
            Assert.IsTrue(defaultSketchCreator.AutoCreateSketch == true, "invalid sketch constructor");

            _document.Undo();
            var sketchCreator = new SketchCreator(_document, false);
            Assert.IsTrue(sketchCreator.CurrentSketch == null, "invalid sketch constructor");
            Assert.IsTrue(sketchCreator.AutoCreateSketch == false, "invalid sketch constructor");
        }

        [Test]
        public void SketchCreatorAxisTest()
        {
            var sketchBuilder = new SketchCreator(_document);
            sketchBuilder.BuildSketchNode();
            var sketchAxis = sketchBuilder.NormalOnSketch;
            Assert.IsTrue(sketchAxis != null, "invalid sketch axis");

            Assert.IsTrue(sketchAxis.Value.Location.IsEqual(new Point3D(0, 0, 0)), "invalid axis location");
            Assert.IsTrue(sketchAxis.Value.Direction.IsEqual(new Point3D(0, 0, 1)), "invalid axis direction");
        }

        [Test]
        public void SketchCreatorProjectTest()
        {
            var sketchBuilder = new SketchCreator(_document);
            sketchBuilder.BuildSketchNode();
            var projectionPoint = sketchBuilder.Project(new Point3D(10, 10, 10));
            Assert.IsNotNull(projectionPoint);
            Assert.IsTrue(projectionPoint.Value.IsEqual(new Point3D(10, 10, 0)), "invalid projection point");
        }
    }
}
