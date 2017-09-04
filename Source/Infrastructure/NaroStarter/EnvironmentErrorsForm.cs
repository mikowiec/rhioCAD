#region Usings

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion

namespace NaroStarter
{
    public partial class EnvironmentErrorsForm : Form
    {
        public const string CheckEnvironmentFileLock = ".doNaroNotCheckEnvironment";

        private const string NoOpenCascadeDetected =
            "NaroCAD cannot detect that OpenCascade is installed to your machine!\n Please download it from http://www.opencascade.org/getocc/download/ You may need to register to OpenCascade site to get it for download.";

        private const string NoVisualCppRuntimeDetected =
            "NaroCAD cannot detect the Visual C++ 2008 SP1 Redistributable Runtime on your machine \n\r Please download it from http://www.microsoft.com/downloads/details.aspx?FamilyID=a5c84275-3b97-4ab7-a40d-3802b2af5fc2&displaylang=en";

        public static bool NoOcc = true;
        public static bool NoVcRuntime;
        public static bool IgnoreErrors;

        public EnvironmentErrorsForm()
        {
            InitializeComponent();

            InitialDialogSetup();
        }

        [DllImport("msi.dll")]
        public static extern int MsiQueryProductState(string productName);

        private void InitialDialogSetup()
        {
            textBox1.Text = "";
            if (NoOcc)
                textBox1.Text = textBox1.Text + NoOpenCascadeDetected + Environment.NewLine + Environment.NewLine;
            if (NoVcRuntime)
                textBox1.Text = textBox1.Text + NoVisualCppRuntimeDetected + Environment.NewLine + Environment.NewLine;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            SetIgnoreErrors(true);
        }

        private void Button2Click(object sender, EventArgs e)
        {
            SetIgnoreErrors(false);
        }

        private void SetIgnoreErrors(bool ignore)
        {
            IgnoreErrors = ignore;
            Close();
            if (!checkBox1.Checked) return;
            var f = File.CreateText(CheckEnvironmentFileLock);
            f.Close();
        }

        private static void TextBox1LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}