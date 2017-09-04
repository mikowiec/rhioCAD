#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.NaroData;

#endregion

namespace Extensions.NotificationTree
{
    public class NotificationTreeInput : InputBase
    {
        private readonly Document _notificationDocument = new Document();

        public NotificationTreeInput()
            : base(InputNames.NotificationTreeInput)
        {
        }

        public override void OnConnect()
        {
            base.OnConnect();
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_notificationDocument);
        }
    }
}