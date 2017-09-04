#region Usings

using TreeData.AttributeInterpreter;
using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class ArcActionTests : MetaActionsTestBase
    {
        [Test]
        public void ArcCSECreationTest()
        {
            ShapeBuildHelper.BuildTestCSEArc(Setup);

            Assert.AreEqual(5, Setup.Document.Root.Children.Count);
            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-1", Setup.Document.Root.Children[1].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-2", Setup.Document.Root.Children[2].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-3", Setup.Document.Root.Children[3].Get<StringInterpreter>().Value);
            Assert.AreEqual("Arc-1", Setup.Document.Root.Children[4].Get<StringInterpreter>().Value);
        }

        [Test]
        public void ArcSERCreationTest()
        {
            ShapeBuildHelper.BuildTestSERArc(Setup);

            Assert.AreEqual(5, Setup.Document.Root.Children.Count);
            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-1", Setup.Document.Root.Children[1].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-2", Setup.Document.Root.Children[2].Get<StringInterpreter>().Value);
            Assert.AreEqual("Point-3", Setup.Document.Root.Children[3].Get<StringInterpreter>().Value);
            Assert.AreEqual("Arc3p-1", Setup.Document.Root.Children[4].Get<StringInterpreter>().Value);
        }
    }
}