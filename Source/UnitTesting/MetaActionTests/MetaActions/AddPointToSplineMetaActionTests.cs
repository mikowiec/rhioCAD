#region Usings

using MetaActionFakesInterface;
using NaroPipes.Constants;
using NUnit.Framework;

#endregion

namespace MetaActionTests.MetaActions
{
    [TestFixture]
    public class AddPointToSplineMetaActionTests : MetaActionsTestBase
    {
        [Test]
        [Ignore("Incomplete test method")]
        public void NoSelectedSpline()
        {
            Setup.SwitchUserMetaAction(ModifierNames.SplineAddPoint);
            Setup.SwitchUserAction(ModifierNames.None);
        }
    }
}