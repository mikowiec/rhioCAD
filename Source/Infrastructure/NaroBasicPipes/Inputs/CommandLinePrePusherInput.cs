#region Usings

using System.Collections.Generic;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace NaroBasicPipes.Inputs
{
    public class CommandLinePrePusherInput : InputBase
    {
        private readonly List<object> _objectList = new List<object>();

        public CommandLinePrePusherInput()
            : base(InputNames.CommandLinePrePusher)
        {
        }

        public override void OnRegister()
        {
            AddNotificationHandler(NotificationNames.Reset, ResetNotification);
            AddNotificationHandler(NotificationNames.PushValue, PushValueNotification);
            AddNotificationHandler(NotificationNames.GetValue, GetValueNotification);
        }

        private void GetValueNotification(DataPackage dataPackage)
        {
            ReturnData = new DataPackage(_objectList);
        }

        private void PushValueNotification(DataPackage dataPackage)
        {
            _objectList.Add(dataPackage.Get<object>());
        }

        private void ResetNotification(DataPackage dataPackage)
        {
            _objectList.Clear();
        }

        public override void OnDisconnect()
        {
            _objectList.Clear();
        }
    }
}