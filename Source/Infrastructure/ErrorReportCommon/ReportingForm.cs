#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NaroConstants.Names;
using Resources.Infrastructure;

#endregion

namespace ErrorReportCommon
{
    public partial class ReportingForm : Form
    {
        public ReportingForm()
        {
            InitializeComponent();
            InititialTexts();
        }

        #region Properties

        public bool NaroNeedRestart { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public List<string> FileNames { get; private set; }

        #endregion

        #region Methods

        private void InititialTexts()
        {
            textBoxTitle.Text = ErrorReportCommonResources.ReportingForm_Automatically_generated + DateTime.Now;
            textBoxDetails.Text = StarterUtils.GetDescriptionMessage(NaroAppConstantNames.AppName,
                                                                     NaroAppConstantNames.Version,
                                                                     true,
                                                                     ErrorReportCommonResources.
                                                                         ReportingForm_Write_what_was_happening);
            FileNames = new List<string>();
        }


        private void Button1Click(object sender, EventArgs e)
        {
            Title = textBoxTitle.Text;
            Description = textBoxDetails.Text;
            NaroNeedRestart = checkBoxRestart.Checked;
            DialogResult = DialogResult.OK;
        }

        private void Button2Click(object sender, EventArgs e)
        {
            NaroNeedRestart = checkBoxRestart.Checked;
            DialogResult = DialogResult.Cancel;
        }

        private void LabelTitleClick(object sender, EventArgs e)
        {
            textBoxTitle.Focus();
        }

        private void LabelDetailsClick(object sender, EventArgs e)
        {
            textBoxDetails.Focus();
        }

        private void MainFormShown(object sender, EventArgs e)
        {
            Focus();
        }

        private void FilesButtonClick(object sender, EventArgs e)
        {
            var form = new FilesForm(FileNames);
            form.ShowDialog();
            FileNames = form.FileNames;
        }

        #endregion
    }
}