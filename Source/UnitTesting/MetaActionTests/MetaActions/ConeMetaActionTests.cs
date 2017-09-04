#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class ConeMetaActionTests : MetaActionsTestBase
    {
        [Test]
        public void ConeMetaToolNodeCreationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestCone(Setup);
            Assert.AreEqual(2, Setup.Document.Root.Children.Count);

            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Cone-1", Setup.Document.Root.Children[1].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
        }
    }
}