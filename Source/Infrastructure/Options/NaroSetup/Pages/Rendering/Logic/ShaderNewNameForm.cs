#region Usings

using System;
using System.IO;
using System.Windows.Forms;
using ErrorReportCommon.Messages;
using NaroConstants.Names;

#endregion

namespace NaroSetup.Pages.Rendering.Logic
{
    public partial class ShaderNewNameForm : Form
    {
        public ShaderNewNameForm()
        {
            InitializeComponent();

            InitialDialogSetup();
        }

        public string ShaderName { get; private set; }
        public string ShaderContent { get; private set; }

        private void InitialDialogSetup()
        {
            try
            {
                var fileNames = Directory.GetFiles(NaroAppConstantNames.ShadersFolder, "*.shd");
                comboBox1.Items.Clear();
                foreach (var fileName in fileNames)
                    comboBox1.Items.Add(ExtractShaderName(fileName));
            }
            catch (Exception ex)
            {
                NaroMessage.Show(ex.Message);
            }
        }

        private static string ExtractShaderName(string fileShader)
        {
            var words = fileShader.Split('\\');
            var lastword = words[words.Length - 1];
            words = lastword.Split('.');
            return words[words.Length - 2];
        }

        private void GlassButton1Click(object sender, EventArgs e)
        {
            ShaderName = textBox1.Text;
            ShaderContent = FileToString(NaroAppConstantNames.ShadersFolder + comboBox1.Text + ".shd");
        }

        private static string FileToString(string fileName)
        {
            try
            {
                var streamReader = new StreamReader(fileName);
                var text = streamReader.ReadToEnd();
                streamReader.Close();
                return text;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}