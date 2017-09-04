#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TreeData.Utils;

#endregion

namespace Naro.Infrastructure.Interface.Views.Timers
{
    public class TimerTaskManager
    {
        private static readonly TimerTaskManager SingletonInstance = new TimerTaskManager();
        private readonly SortedDictionary<string, TimerWrapper> _timers;

        private TimerTaskManager()
        {
            _timers = new SortedDictionary<string, TimerWrapper>();
        }

        public static TimerTaskManager Instance
        {
            get { return SingletonInstance; }
        }

        private TimerWrapper AddTimer(string timerName)
        {
            if (_timers.ContainsKey(timerName)) return _timers[timerName];
            var newTimer = new TimerWrapper();
            _timers[timerName] = newTimer;
            return newTimer;
        }

        public void StartTimer(string timerName, int interval)
        {
            Ensure.IsTrue(_timers.ContainsKey(timerName));
            var timer = _timers[timerName];
            timer.Enable(interval);
        }

        public void AddTask(string timerName, EventHandler handler)
        {
            var timer = AddTimer(timerName);
            timer.AddEvent(handler);
        }

        public void StopTask(string timerName)
        {
            if (!_timers.ContainsKey(timerName))
                return;
            var timer = _timers[timerName];
            timer.Disable();
            timer.Dispose();
            _timers.Remove(timerName);
        }

        #region Nested type: TimerWrapper

        private class TimerWrapper : IDisposable
        {
            private readonly Queue<EventHandler> _eventsQueue;
            private Timer _instance;

            public TimerWrapper()
            {
                _eventsQueue = new Queue<EventHandler>();
                _instance = new Timer();
                _instance.Tick += InstanceTick;
            }

            #region IDisposable Members

            public void Dispose()
            {
                if (_instance == null) return;
                _instance.Dispose();
                _instance = null;
            }

            #endregion

            ~TimerWrapper()
            {
                Dispose();
            }

            private void InstanceTick(object sender, EventArgs e)
            {
                if (_eventsQueue.Count != 0)
                {
                    var handler = _eventsQueue.Dequeue();
                    handler.Invoke(sender, e);
                }
                if (_instance != null) _instance.Enabled = _eventsQueue.Count != 0;
            }

            public void AddEvent(EventHandler handler)
            {
                _eventsQueue.Enqueue(handler);
            }

            public void Enable(int interval)
            {
                _instance.Interval = interval;
                _instance.Enabled = true;
            }

            public void Disable()
            {
                _instance.Enabled = false;
            }
        }

        #endregion
    }
}