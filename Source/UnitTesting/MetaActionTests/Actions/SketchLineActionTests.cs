#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class SketchLineActionTests : MetaActionsTestBase
    {
        [Test]
        [Ignore("SketchLineAction isn't updated")]
        public void SketchLineToolNodeCreationTest()
        {
            ShapeBuildHelper.BuildTestLineUsingClicks(Setup);
            // Test that the new nodes were added
            Assert.AreEqual(4, Setup.Document.Root.Children.Count);

            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Point-1", Setup.Document.Root.Children[1].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Point-2", Setup.Document.Root.Children[2].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("LineTwoPoints-1", Setup.Document.Root.Children[3].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
        }
    }
}