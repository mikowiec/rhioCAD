#region Usings

using System.Windows.Forms;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace PartModellingLogic.Inputs.Naro.Infrastructure
{
    public class FileOpenDialogInput : InputBase
    {
        private OpenFileDialog _fileDialog;

        public FileOpenDialogInput() : base(InputNames.FileOpenDialog)
        {
        }

        public override void OnRegister()
        {
            AddNotificationHandler(NotificationNames.Show, ShowNotification);
            AddNotificationHandler(NotificationNames.SetFilter, SetFilterNotification);
            AddNotificationHandler(NotificationNames.SetMultiFile, SetMultiFileNotification);
            AddNotificationHandler(NotificationNames.GetFile, GetFileNotification);
        }

        public override void OnConnect()
        {
            _fileDialog = new OpenFileDialog();
        }

        public override void OnDisconnect()
        {
            _fileDialog.Dispose();
            _fileDialog = null;
        }

        private void GetFileNotification(DataPackage dataPackage)
        {
            ReturnName();
        }

        private void SetMultiFileNotification(DataPackage dataPackage)
        {
            var dataResult = dataPackage.Get<bool?>();
            if (dataResult != null)
                _fileDialog.Multiselect = (bool) dataResult;
        }

        private void SetFilterNotification(DataPackage dataPackage)
        {
            _fileDialog.Filter = dataPackage.Text;
        }

        private void ShowNotification(DataPackage dataPackage)
        {
            ReturnData = new DataPackage(_fileDialog.ShowDialog());
        }

        private void ReturnName()
        {
            ReturnData = _fileDialog.Multiselect
                             ? new DataPackage(_fileDialog.FileNames)
                             : new DataPackage(_fileDialog.FileName);
        }
    }
}