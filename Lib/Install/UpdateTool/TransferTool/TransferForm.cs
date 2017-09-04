#region Usings

using System;
using System.Windows.Forms;

#endregion

namespace TransferTool
{
    public partial class TransferForm : Form
    {
        private delegate void UpdateProgessCallback(Int64 BytesRead, Int64 TotalBytes);

        private UpdateLogic _logic;

        public TransferForm()
        {
            InitializeComponent();
            btnCopy_Click();
        }

        private void UpdateProgress(Int64 BytesRead, Int64 TotalBytes)
        {
            this.Invoke(new UpdateProgessCallback(this.UpdateProgressUI), new object[] {BytesRead, TotalBytes});
        }

        private void UpdateProgressUI(Int64 BytesRead, Int64 TotalBytes)
        {
            var percentProgress = Convert.ToInt32((BytesRead*100)/TotalBytes);
            progressBar1.Value = percentProgress;

            lblCopyPath.Text = "Downloaded " + BytesRead + " out of " + TotalBytes + " (" + percentProgress + "%)";
        }

        private void btnCopy_Click()
        {
            string filePath = "http://www.cipdevel.com/download/NaroNightly.exe";
            string downPath = @"c:\NaroHg\narocad\bin\Debug\NaroNightly.exe";
            _logic = new UpdateLogic(filePath, downPath);
            _logic.OnProgressUpdate += UpdateProgress;
        }

        private void TransferForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logic.OnProgressUpdate -= UpdateProgress;
        }
    }
}