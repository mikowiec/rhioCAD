#region Usings

using MetaActionFakesInterface;
using NaroPipes.Constants;
using NUnit.Framework;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class AngleDraftMetaActionTests
    {
        #region Setup/Teardown

        [TearDown]
        public void TestModificationsCleanup()
        {
            _setup.ResetSetupEnvironment();
        }

        #endregion

        private SetupUtils _setup;

        [TestFixtureSetUp]
        public void ConfigureTestEnvironment()
        {
            _setup = new SetupUtils();
            _setup.InitializeModifiersSetup();
        }

        [Test]
        public void AngleDraftMetaToolNodeCreationTest()
        {
            _setup.SwitchUserMetaAction(ModifierNames.AngleDraft);
        }
    }
}