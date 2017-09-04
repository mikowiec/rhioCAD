#region Usings
using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class SplineActionTests : MetaActionsTestBase
    {
        [Test]
        [Ignore]
        public void SplineCreationTest()
        {
            ShapeBuildHelper.BuildTestSpline(Setup);

            Assert.AreEqual(5, Setup.Document.Root.Children.Count);
        }

    }
}