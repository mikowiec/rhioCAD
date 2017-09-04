#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class CircleActionTests : MetaActionsTestBase
    {
        [Test]
        public void CircleNodeCreationClickTest()
        {
            ShapeBuildHelper.BuildTestCircleUsingClicks(Setup);

            //Test that the new nodes were added
            Assert.AreEqual(3, Setup.Document.Root.Children.Count);
            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Point-1", Setup.Document.Root.Children[1].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Circle-1", Setup.Document.Root.Children[2].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
        }
    }
}