#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class SketchLineTransformationTests : MetaActionsTestBase
    {
        private readonly Point3D _testedFirstPoint = new Point3D(100, 100, 0);
        private readonly Point3D _testedSecondPoint = new Point3D(200, 200, 0);

        [Test]
        [Ignore("SketchLineAction isn't updated")]
        public void SketchLineToolTransformationTest()
        {
            ShapeBuildHelper.BuildTestLineUsingClicks(Setup);
            Assert.AreEqual(4, Setup.Document.Root.Children.Count);
            var nodeBuilder = new NodeBuilder(Setup.Document.Root.Children[3]);

            Assert.AreEqual(nodeBuilder[0].RefTransformedPoint3D.IsEqual(_testedFirstPoint), true,
                            "Invalid first point coordinate");
            Assert.AreEqual(nodeBuilder[1].RefTransformedPoint3D.IsEqual(_testedSecondPoint), true,
                            "Invalid second point coordinate");
        }
    }
}