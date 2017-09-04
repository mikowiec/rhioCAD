#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;
using NaroCppCore.Occ.Precision;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class CylinderTransformationTests : MetaActionsTestBase
    {
        private const double TestedRadius = 100;
        private const double TestedHeight = 200;

        [Test]
        public void CylinderMetaToolWithMousePointsTransformationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestCylinder(Setup);

            Assert.AreEqual(2, Setup.Document.Root.Children.Count);

            var nodeBuilder = new NodeBuilder(Setup.Document.Root.Children[1]);
            var axisLocation = nodeBuilder[0].TransformedAxis3D.Location;
            Assert.AreEqual(SetupUtils.CheckNodeTranslationAgainst(nodeBuilder.Node, new Point3D(axisLocation)), true,
                            "Invalid transform interpreter on Node");
            Assert.AreEqual(nodeBuilder[0].TransformedAxis3D.Location.IsEqual(axisLocation,Precision.Confusion),
                            true, "Invalid first point coordinate");

            var radiusFromDependency = nodeBuilder[1].Real;
            Assert.AreEqual(radiusFromDependency, TestedRadius, "Invalid final radius");

            var height = nodeBuilder[2].Real;
            Assert.AreEqual(height, TestedHeight, "Invalid height");
        }
    }
}