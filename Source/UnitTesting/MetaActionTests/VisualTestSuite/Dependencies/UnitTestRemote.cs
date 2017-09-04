#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetaActionFakesInterface;

#endregion

namespace MetaActionTests.VisualTestSuite.Dependencies
{
    public partial class UnitTestRemote : Form
    {
        #region Delegates

        public delegate void OnStepUpdateEvent(SetupUtils setup);

        public delegate void RestartDelegate();

        #endregion

        private readonly Queue<DummyStep> _steps = new Queue<DummyStep>();
        private readonly VisualTestBuilder _testBuilder;
        public RestartDelegate OnRestart;

        public UnitTestRemote()
        {
            InitializeComponent();
            AutoCloseOnFinish = true;
            _testBuilder = new VisualTestBuilder();
            _testBuilder.BuildForm(600, 300);
            _testBuilder.Form.Show();
        }

        public bool AutoCloseOnFinish { private get; set; }

        public void AddQueueStep(string description, OnStepUpdateEvent updateEvent)
        {
            var step = new DummyStep {Name = description};
            step.OnStepUpdate += updateEvent;

            _steps.Enqueue(step);
        }

        private void PlayPauseButtonClick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            DisplayNextVisualStep();
        }

        private void DisplayNextVisualStep()
        {
            if (_steps.Count != 0)
            {
                var step = _steps.Dequeue();
                step.OnStepUpdate(_testBuilder.SetupUtils);
                descriptonLabel.Text = step.Name;
            }
            else if (AutoCloseOnFinish)
            {
                Close();
            }

            _testBuilder.ViewUpdate();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            _testBuilder.SetupUtils.ResetSetupEnvironment();
            OnRestart();
        }

        private void UnitTestRemoteShown(object sender, EventArgs e)
        {
            DisplayNextVisualStep();
        }

        #region Nested type: DummyStep

        private class DummyStep
        {
            public OnStepUpdateEvent OnStepUpdate;
            public string Name { get; set; }
        }

        #endregion
    }
}