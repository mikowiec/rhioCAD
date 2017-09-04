#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class BooleanMetaActionTests : MetaActionsTestBase
    {
        [Test]
        public void BooleanAddMetaToolNodeCreationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestBoolAdd(Setup);
            Assert.AreEqual(4, Setup.Document.Root.Children.Count);
        }

        [Test]
        public void BooleanCutMetaToolNodeCreationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestBoolCut(Setup);
            Assert.AreEqual(4, Setup.Document.Root.Children.Count);
        }

        [Test]
        public void BooleanIntersectMetaToolNodeCreationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestBoolIntersect(Setup);
            Assert.AreEqual(4, Setup.Document.Root.Children.Count);
        }
    }
}