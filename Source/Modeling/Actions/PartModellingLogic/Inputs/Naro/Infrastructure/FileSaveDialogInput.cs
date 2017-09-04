#region Usings

using System;
using System.Windows.Forms;
using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Inputs.Naro.Infrastructure
{
    public class FileSaveDialogInput : InputBase
    {
        private SaveFileDialog _fileDialog;
        private string _fileName;

        public FileSaveDialogInput()
            : base(InputNames.FileSaveDialog)
        {
        }

        public override void OnConnect()
        {
            _fileDialog = new SaveFileDialog();
        }

        public override void OnDisconnect()
        {
            _fileDialog.Dispose();
            _fileDialog = null;
        }

        protected override void OnNotification(string name, DataPackage dataPackage)
        {
            switch (name)
            {
                case NotificationNames.Show:
                    if (String.IsNullOrEmpty(_fileName))
                        DisplaySaveAs();
                    break;
                case NotificationNames.ShowSaveAs:
                    DisplaySaveAs();
                    break;

                case NotificationNames.SetFilter:
                    _fileDialog.Filter = dataPackage.Text;
                    break;
                case NotificationNames.GetFile:
                    ReturnData = new DataPackage(_fileName);
                    break;
            }
        }

        private void DisplaySaveAs()
        {
            var dialogresult = _fileDialog.ShowDialog();
            if (dialogresult != DialogResult.Cancel)
            {
                ReturnData = new DataPackage(dialogresult);
                _fileName = _fileDialog.FileName;
            }
            else
            {
                ReturnData = new DataPackage(dialogresult);
            }
           
        }
    }
}