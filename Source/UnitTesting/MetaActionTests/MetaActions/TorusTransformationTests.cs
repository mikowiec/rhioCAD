#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class TorusTransformationTests : MetaActionsTestBase
    {
        private const double TestedExternalRadius = 200;
        private const double TestedInternalRadius = 100;

        [Test]
        public void TorusMetaToolWithMousePointsTransformationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestTorus(Setup);

            Assert.AreEqual(1, Setup.Document.Root.Children.Count);

            var nodeBuilder = new NodeBuilder(Setup.Document.Root.Children[0]);
            Assert.AreEqual(
                SetupUtils.CheckNodeTranslationAgainst(Setup.Document.Root.Children[0], new Point3D(100, 100, 100)),
                true, "Invalid transform interpreter on Node");
            Assert.AreEqual(
                nodeBuilder[0].TransformedAxis3D.Location.IsEqual(new Point3D(100, 100, 100).GpPnt,
                                                                    Precision.Confusion), true,
                "Invalid first point coordinate");
            var internalRadiusFromDependency = nodeBuilder[1].Real;
            Assert.AreEqual(internalRadiusFromDependency, TestedInternalRadius, "Invalid internal radius");
            var externalRadiusFromDependency = nodeBuilder[2].Real;
            Assert.AreEqual(externalRadiusFromDependency, TestedExternalRadius, "Invalid external radius");
        }
    }
}