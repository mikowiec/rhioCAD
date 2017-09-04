#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class BoxMetaActionTests : MetaActionsTestBase
    {
        [Test]
        public void BoxMetaToolNodeCreationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestBox(Setup);

            Assert.AreEqual(2, Setup.Document.Root.Children.Count);
        }
    }
}