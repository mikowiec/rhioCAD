#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class EllipseTransformationTests : MetaActionsTestBase
    {
        private readonly Point3D _testedFirstPoint = new Point3D(100, 100, 0);
        private readonly Point3D _testedSecondPoint = new Point3D(200, 100, 0);
        private readonly Point3D _testedThirdPoint = new Point3D(100, 50, 0);

        [Test]
        public void EllipseToolWithMousePointsTransformationTest()
        {
            ShapeBuildHelper.BuildTestEllipseUsingClicks(Setup);
            var nodeBuilder = new NodeBuilder(Setup.Document.Root.Children[4]);

            // Test that the new nodes were added
            Assert.AreEqual(5, Setup.Document.Root.Children.Count);

            // Check transformations, coordinates of the node
          Assert.AreEqual(nodeBuilder[0].RefTransformedPoint3D.IsEqual(_testedFirstPoint), true,
                            "Invalid first point coordinate");
            Assert.AreEqual(nodeBuilder[1].RefTransformedPoint3D.IsEqual(_testedSecondPoint), true,
                            "Invalid second point coordinate");
            Assert.AreEqual(nodeBuilder[2].RefTransformedPoint3D.IsEqual(_testedThirdPoint), true,
                            "Invalid third point coordinate");
        }
    }
}