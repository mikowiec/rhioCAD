#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace NaroAppDocumentCore
{
    internal class ParentActionGraphInput : InputBase
    {
        private readonly ActionsGraph _parentGraph;

        public ParentActionGraphInput(ActionsGraph parentGraph)
            : base(InputNames.ParentActionGraphInput)
        {
            _parentGraph = parentGraph;
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_parentGraph);
        }
    }
}