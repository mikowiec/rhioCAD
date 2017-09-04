#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.NaroData;

#endregion

namespace NaroBasicPipes.Actions
{
    public class CurrentDocumentInput : InputBase
    {
        private ActionsGraph _currentActionGraph;
        private Document _document;

        public CurrentDocumentInput()
            : base(InputNames.CurrentDocumentInput)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.GetContainer, OnContainer);
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
            AddNotificationHandler(NotificationNames.SetData, OnSetValue);
        }

        private void OnContainer(DataPackage data)
        {
            ReturnData = new DataPackage(_currentActionGraph);
        }

        private void OnSetValue(DataPackage data)
        {
            _currentActionGraph = data.Get<ActionsGraph>();

            _document =
                _currentActionGraph[InputNames.Document].GetData(NotificationNames.GetValue).Get<Document>();
            AddData(_document);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_document);
        }
    }
}