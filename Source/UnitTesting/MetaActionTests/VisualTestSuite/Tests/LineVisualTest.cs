#region Usings

using MetaActionFakesInterface;
using MetaActionTests.VisualTestSuite.Dependencies;
using NaroPipes.Constants;
using NUnit.Framework;

#endregion

namespace MetaActionTests.VisualTestSuite.Tests
{
    [TestFixture]
    [Ignore]
    public class LineVisualTest : VisualTestBase
    {
        public LineVisualTest() : base("Line Visual Test")
        {
        }


        protected override void SetupSteps(UnitTestRemote remote)
        {
            SetAutoClose(true);
            SetTimerSpeed(2000, true);
            remote.AddQueueStep("Draw first point", FirstPointStep);
            remote.AddQueueStep("Draw second point", SecondPointStep);
            remote.AddQueueStep("Back to none", setup => setup.SwitchUserAction(ModifierNames.None));
        }

        private static void FirstPointStep(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.Line3D);

            setup.MouseInput.MouseDown(100, 100, 1, false, false);
            setup.MouseInput.MouseUp(100, 100, false, false);
        }

        private static void SecondPointStep(SetupUtils setup)
        {
            setup.MouseInput.MouseDown(200, 200, 1, false, false);
            setup.MouseInput.MouseUp(200, 200, false, false);
        }

        [Test]
        public void TestCode()
        {
            ExecuteTest();
        }
    }
}