#region Usings

using NUnit.Framework;

#endregion

namespace MetaActionFakesInterface
{
    public class MetaActionsTestBase
    {
        #region Setup/Teardown

        [TearDown]
        public void TestModificationsCleanup()
        {
            Setup.ResetSetupEnvironment();
        }

        #endregion

        protected SetupUtils Setup;

        [TestFixtureSetUp]
        public void ConfigureTestEnvironment()
        {
            Setup = new SetupUtils();
            Setup.InitializeModifiersSetup();
        }
    }
}