#region Usings

using MetaActionFakesInterface;
using NaroCppCore.Occ.gp;
using NUnit.Framework;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class BoxTransformationTests : MetaActionsTestBase
    {
        private readonly gpAx1 _testedFirstPoint = new gpAx1(new Point3D(100, 100, 100).GpPnt,
                                                                   new gpDir(0, 0, 1));


        [Test]
        public void BoxMetaToolWithMousePointsTransformationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestBox(Setup);

            // Test that a new node was added
            Assert.AreEqual(2, Setup.Document.Root.Children.Count);

            // Check transformations and coordinates of the node
            var nodeBuilder = new NodeBuilder(Setup.Document.Root.Children[1]);
            Assert.AreEqual(
                SetupUtils.CheckNodeTranslationAgainst(nodeBuilder.Node, new Point3D(_testedFirstPoint.Location)),
                true, "Invalid transform interpreter on Node");
            Assert.AreEqual(
                nodeBuilder[0].TransformedAxis3D.Location.IsEqual(_testedFirstPoint.Location,
                                                                    Precision.Confusion), true,
                "Invalid first point coordinate");
        }
    }
}