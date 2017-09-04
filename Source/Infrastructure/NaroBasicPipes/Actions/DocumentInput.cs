#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.NaroData;

#endregion

namespace NaroBasicPipes.Actions
{
    public class DocumentInput : InputBase
    {
        private readonly Document _document;

        public DocumentInput(Document document)
            : base(InputNames.Document)
        {
            _document = document;
        }

        public override void OnConnect()
        {
            AddData(_document);
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_document);
        }
    }
}