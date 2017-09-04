#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class ConeTransformationTests : MetaActionsTestBase
    {
        private readonly Point3D _testedFirstPoint = new Point3D(100, 100, 100);

        [Test]
        public void ConeMetaToolWithMousePointsTransformationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestCone(Setup);
            // Test that a new node was added
            Assert.AreEqual(2, Setup.Document.Root.Children.Count);
            // Check transformations, coordinates and radius of the node
            Assert.AreEqual(SetupUtils.CheckNodeTranslationAgainst(Setup.Document.Root.Children[1], _testedFirstPoint),
                            true, "Invalid transform interpreter on Node");
        }
    }
}