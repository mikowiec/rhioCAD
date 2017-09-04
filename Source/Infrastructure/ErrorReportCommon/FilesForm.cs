#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace ErrorReportCommon
{
    public partial class FilesForm : Form
    {
        #region Constructor

        public FilesForm(IEnumerable<string> fileNames)
        {
            InitializeComponent();

            InitialDialogSetup(fileNames);
        }

        #endregion

        #region Properties

        public List<string> FileNames { get; private set; }

        #endregion

        #region Methods

        private void InitialDialogSetup(IEnumerable<string> fileNames)
        {
            FileNames = new List<string>();
            foreach (var fileName in fileNames)
            {
                FileNames.Add(fileName);
            }
            UpdateFileList();
        }

        private void UpdateFileList()
        {
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            foreach (var s in FileNames)
            {
                var lastBackSlash = s.LastIndexOf('\\');
                var itemName = s.Remove(0, lastBackSlash + 1);
                listBox1.Items.Add(itemName);
            }
            listBox1.EndUpdate();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ListBox1DoubleClick(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            FileNames.RemoveAt(index);
            UpdateFileList();
        }

        private void GlassButton1Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                AddFiles();
                return;
            }
            FileNames.Add(textBox1.Text);
            textBox1.Text = string.Empty;
            UpdateFileList();
        }

        private void AddFiles()
        {
            var fileDialog = new OpenFileDialog {Multiselect = true};
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            foreach (var fileName in fileDialog.FileNames)
                FileNames.Add(fileName);
            UpdateFileList();
        }

        private void TextBox1DoubleClick(object sender, EventArgs e)
        {
            AddFiles();
        }

        #endregion
    }
}