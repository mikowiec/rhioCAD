#region Usings
using NaroPipes.Constants;
using MetaActionFakesInterface;
using NUnit.Framework;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class ExtrudeRectangleActionTests : MetaActionsTestBase
    {
        [Test]
        public void ExtrudedRectangleCreationTest()
        {
            Setup.SwitchUserAction(ModifierNames.FourLinesRectangle);

            // Push two points on meta action and check that it works correctly

            Setup.MouseInput.MouseDown(383, 231, 1, false, false);
            Setup.MouseInput.MouseUp(383, 231, false, false);

            Setup.MouseInput.MouseDown(524, 220, 1, false, false);
            Setup.MouseInput.MouseUp(524, 220, false, false);

            Setup.SwitchUserAction(ModifierNames.None);

            //Test that the new nodes were added
            Assert.AreEqual(16, Setup.Document.Root.Children.Count);
            Setup.SwitchUserAction(ModifierNames.Extrude);
            Setup.MouseInput.MouseDown(502, 235, 1, false, false);
            Setup.MouseInput.MouseUp(502, 235, false, false);

            Setup.MouseInput.MouseDown(390, 119, 1, false, false);
            Setup.MouseInput.MouseUp(390, 119, false, false);

            Setup.SwitchUserAction(ModifierNames.None);
            Assert.AreEqual(17, Setup.Document.Root.Children.Count);
        }
    }
}