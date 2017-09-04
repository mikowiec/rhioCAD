#region Usings

using TreeData.AttributeInterpreter;
using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class RectangleActionTests : MetaActionsTestBase
    {
        [Test]
        public void RectangeFourLinesNodeCreationTest()
        {
            ShapeBuildHelper.BuildTestFourLinesRectangle(Setup);

            Assert.AreEqual(16, Setup.Document.Root.Children.Count);
            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-1", Setup.Document.Root.Children[1].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-2", Setup.Document.Root.Children[2].Get<StringInterpreter>().Value);
            Assert.AreEqual("LineTwoPoints-1", Setup.Document.Root.Children[3].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-3", Setup.Document.Root.Children[4].Get<StringInterpreter>().Value);
            Assert.AreEqual("LineTwoPoints-2", Setup.Document.Root.Children[5].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-4", Setup.Document.Root.Children[6].Get<StringInterpreter>().Value);
            Assert.AreEqual("LineTwoPoints-3", Setup.Document.Root.Children[7].Get<StringInterpreter>().Value);
            Assert.AreEqual("LineTwoPoints-4", Setup.Document.Root.Children[8].Get<StringInterpreter>().Value);
            Assert.AreEqual("ParallelFunction-1", Setup.Document.Root.Children[9].Get<StringInterpreter>().Value);
            Assert.AreEqual("HorizontalFunction-1", Setup.Document.Root.Children[10].Get<StringInterpreter>().Value);
            Assert.AreEqual("HorizontalFunction-2", Setup.Document.Root.Children[11].Get<StringInterpreter>().Value);
            Assert.AreEqual("VerticalFunction-1", Setup.Document.Root.Children[12].Get<StringInterpreter>().Value);
            Assert.AreEqual("VerticalFunction-2", Setup.Document.Root.Children[13].Get<StringInterpreter>().Value);
            Assert.AreEqual("ParallelFunction-2", Setup.Document.Root.Children[14].Get<StringInterpreter>().Value);
            Assert.AreEqual("PerpendicularFunction-1", Setup.Document.Root.Children[15].Get<StringInterpreter>().Value);
        }

        [Test]
        public void RectangleThreePointsNodeCreationTest()
        {
            ShapeBuildHelper.BuildTestThreePointsRectangle(Setup);

            Assert.AreEqual(12, Setup.Document.Root.Children.Count);
            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-1", Setup.Document.Root.Children[1].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-2", Setup.Document.Root.Children[2].Get<StringInterpreter>().Value);
            Assert.AreEqual("LineTwoPoints-1", Setup.Document.Root.Children[3].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-3", Setup.Document.Root.Children[4].Get<StringInterpreter>().Value);
            Assert.AreEqual("LineTwoPoints-2", Setup.Document.Root.Children[5].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-4", Setup.Document.Root.Children[6].Get<StringInterpreter>().Value);
            Assert.AreEqual("LineTwoPoints-3", Setup.Document.Root.Children[7].Get<StringInterpreter>().Value);
            Assert.AreEqual("LineTwoPoints-4", Setup.Document.Root.Children[8].Get<StringInterpreter>().Value);
            Assert.AreEqual("ParallelFunction-1", Setup.Document.Root.Children[9].Get<StringInterpreter>().Value);
            Assert.AreEqual("ParallelFunction-2", Setup.Document.Root.Children[10].Get<StringInterpreter>().Value);
            Assert.AreEqual("PerpendicularFunction-1", Setup.Document.Root.Children[11].Get<StringInterpreter>().Value);
            
        }
    }
}