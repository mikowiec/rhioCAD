#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class CylinderMetaActionTests : MetaActionsTestBase
    {
        [Test]
        public void CylinderMetaToolNodeCreationTest()
        {
            ShapeBuildHelper.BuildMetaActionTestCylinder(Setup);

            Assert.AreEqual(2, Setup.Document.Root.Children.Count);
            Assert.AreEqual("Sketch-1", Setup.Document.Root.Children[0].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
            Assert.AreEqual("Cylinder-1", Setup.Document.Root.Children[1].Get<TreeData.AttributeInterpreter.StringInterpreter>().Value);
        }
    }
}