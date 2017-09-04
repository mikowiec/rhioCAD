#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class SphereTransformationTests : MetaActionsTestBase
    {
        private readonly Point3D _testedFirstPoint = new Point3D(100, 100, 100);
        private const double TestedRadius = 200;

        [Test]
        public void SphereMetaToolWithMousePointsTransformationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestSphere(Setup);
            Assert.AreEqual(2, Setup.Document.Root.Children.Count);

            // Check transformations, coordinates and radius of the node
            var nodeBuilder = new NodeBuilder(Setup.Document.Root.Children[1]);
            Assert.AreEqual(nodeBuilder[0].TransformedPoint3D.IsEqual(_testedFirstPoint), true,
                            "Invalid first point coordinate");
            var radiusFromDependency = nodeBuilder[1].Real;
            Assert.AreEqual(radiusFromDependency, TestedRadius, "Invalid final radius");
        }
    }
}