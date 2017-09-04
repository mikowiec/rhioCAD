#region Usings

using System;
using System.Windows;
using Naro.Infrastructure.Interface.Views.Timers;

#endregion

namespace Naro.Infrastructure.Library.Qos
{
    public class QosLock
    {
        #region Delegates

        public delegate void OnPayload();

        public delegate bool OnTestPayload();

        #endregion

        private const string TimerName = "QosPayLoad";

        private readonly int _lockTime;
        private readonly string _qualityMessage;
        public OnPayload Payload;
        public OnTestPayload TestPayload;
        private int _startTime;

        internal QosLock(int lockTime, string qualityMessage)
        {
            _lockTime = lockTime;
            _qualityMessage = qualityMessage;
            Enabled = true;
        }

        private bool Enabled { get; set; }

        public void Begin()
        {
            _startTime = Environment.TickCount;
        }

        public void End()
        {
            var endTime = Environment.TickCount;
            if (!Enabled) return;
            var diff = endTime - _startTime;
            if (diff <= _lockTime) return;
            TimerTaskManager.Instance.AddTask(TimerName, ShowAndDoPayload);
            TimerTaskManager.Instance.StartTimer(TimerName, 1);
        }

        private void ShowAndDoPayload(object sender, EventArgs eventArgs)
        {
            if (TestPayload != null)
            {
                var testPatload = TestPayload.Invoke();
                if (!testPatload) return;
            }
            var result = MessageBox.Show(_qualityMessage, "Quality of service fails", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes && Payload != null)
                Payload();
            TimerTaskManager.Instance.StopTask(TimerName);
            Enabled = false;
        }
    }
}