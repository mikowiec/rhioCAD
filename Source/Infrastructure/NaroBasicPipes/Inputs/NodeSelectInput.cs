#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.NaroData;

#endregion

namespace NaroBasicPipes.Inputs
{
    public class NodeSelectInput : InputBase
    {
        private Node _node;

        public NodeSelectInput()
            : base(InputNames.NodeSelect)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
            AddNotificationHandler(NotificationNames.Reset, OnReset);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_node);
        }

        private void OnReset(DataPackage data)
        {
               _node = null;
        }

        public void OnSelect(Node node)
        {
            if (node == null)
                return;
            _node = node;
            AddData(node);
        }
    }
}