#region Usings

using System;
using System.Windows.Forms;

#endregion

namespace PartModellingLogic.UI.Views.AutoSave
{
    public partial class AutoSaveRestoreDialog : Form
    {
        public AutoSaveRestoreDialog()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}