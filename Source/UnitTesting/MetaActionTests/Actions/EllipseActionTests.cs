#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class EllipseActionTests : MetaActionsTestBase
    {
        [Test]
        public void EllipseNodeCreationClickTest()
        {
            ShapeBuildHelper.BuildTestEllipseUsingClicks(Setup);

            Assert.AreEqual(5, Setup.Document.Root.Children.Count);
            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Point-1", Setup.Document.Root.Children[1].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Point-2", Setup.Document.Root.Children[2].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Point-3", Setup.Document.Root.Children[3].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Ellipse-1", Setup.Document.Root.Children[4].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
        }
    }
}