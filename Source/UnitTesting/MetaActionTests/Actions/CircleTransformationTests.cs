#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class CircleTransformationTests : MetaActionsTestBase
    {
        [Test]
        public void CircleWithMousePointsTransformationTest()
        {
            ShapeBuildHelper.BuildTestCircleUsingClicks(Setup);

            // Test that the new nodes were added
            Assert.AreEqual(3, Setup.Document.Root.Children.Count);

            // Check transformations, coordinates and radius of the node
            var nodeBuilder = new NodeBuilder(Setup.Document.Root.Children[2]);
            Assert.AreEqual(
                nodeBuilder[0].RefTransformedPoint3D.IsEqual(new Point3D(100, 200, 0)), true,
                "Invalid first point coordinate");
            var radiusFromDependency = nodeBuilder[1].Real;
            Assert.AreEqual(radiusFromDependency, (double)100, "Invalid final radius");
        }
    }
}