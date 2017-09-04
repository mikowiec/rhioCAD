#region Usings

using System;
using System.Windows.Forms;
using NUnit.Framework;

#endregion

namespace MetaActionTests.VisualTestSuite.Dependencies
{
    public abstract class VisualTestBase
    {
        private readonly string _title;
        private UnitTestRemote _form;

        protected VisualTestBase(string title)
        {
            _title = title;
        }

        [TestFixtureSetUp]
        [STAThread]
        public void ConfigureTestEnvironment()
        {
            _form = new UnitTestRemote {Text = _title};
            SetupSteps(_form);
            _form.OnRestart += () => SetupSteps(_form);
        }

        protected void ExecuteTest()
        {
            Application.Run(_form);
        }

        protected void SetTimerSpeed(int interval, bool autoStart)
        {
            _form.timer1.Interval = interval;
            _form.timer1.Enabled = autoStart;
        }

        protected void SetAutoClose(bool autoCloseOnFinish)
        {
            _form.AutoCloseOnFinish = autoCloseOnFinish;
        }

        protected abstract void SetupSteps(UnitTestRemote remote);
    }
}