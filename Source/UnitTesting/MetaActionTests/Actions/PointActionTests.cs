#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class PointActionTests : MetaActionsTestBase
    {
        [Test]
        public void PointToolNodeCreationTest()
        {
            ShapeBuildHelper.BuildTestPointUsingClicks(Setup);

            Assert.AreEqual(2, Setup.Document.Root.Children.Count);
            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Point-1", Setup.Document.Root.Children[1].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
        }
    }
}