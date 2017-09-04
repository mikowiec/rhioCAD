#region Usings

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

#endregion

namespace NaroSetup.Pages.Rendering.Logic
{
    public partial class RenderingShaders : Form
    {
        private readonly List<Shader> _shaders;
        private bool _disableSelectShader;
        private Shader _lastShader;

        public RenderingShaders(List<Shader> shaders)
        {
            InitializeComponent();

            _shaders = shaders;
        }

        private void RenderingShadersLoad(object sender, EventArgs e)
        {
            RefreshCombo();
        }

        private void RefreshCombo()
        {
            comboBox1.BeginUpdate();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("New shader ...");
            foreach (var shader in _shaders)
            {
                comboBox1.Items.Add(shader.Name);
            }
            comboBox1.SelectedIndex = _shaders.Count == 0 ? 0 : 1;
            comboBox1.EndUpdate();
        }

        private void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                var form = new ShaderNewNameForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var newShaderName = form.ShaderName;
                    var newShader = new Shader(newShaderName) {Definition = form.ShaderContent};
                    _shaders.Add(newShader);
                    textEditorControl1.Text = newShader.Definition;
                    RefreshCombo();
                    comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                }
                return;
            }
            if (_disableSelectShader)
            {
                return;
            }
            var shaderName = comboBox1.SelectedItem.ToString();
            shaderNameLabel.Text = shaderName;
            SetShader(shaderName);
        }

        private void SetShader(string shaderName)
        {
            if (_lastShader != null && _lastShader.Name == shaderName)
                return;
            foreach (var shader in _shaders)
            {
                if (shader.Name != shaderName) continue;
                _lastShader = shader;
                textEditorControl1.Text = shader.Definition;
            }
        }

        private void TextEditorControl1TextChanged(object sender, EventArgs e)
        {
            if (_lastShader == null)
            {
                return;
            }
            _lastShader.Definition = textEditorControl1.Text;
        }

        private void GlassButton3Click(object sender, EventArgs e)
        {
            _disableSelectShader = true;
            var selIndex = comboBox1.SelectedIndex;
            if (selIndex != 0)
            {
                _shaders.Remove(_lastShader);
                _lastShader = null;
                RefreshCombo();
            }
            comboBox1.SelectedIndex = selIndex - 1;
            _disableSelectShader = false;
        }

        private void GlassButton2Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PreviewButtonClick(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("shader {");
            sb.AppendLine("name \"shader05\"");
            sb.AppendLine(textEditorControl1.Text);
            sb.AppendLine("}");
            File.WriteAllText(@"shaders\testShader.sc", sb.ToString());
            var proc = new Process
                           {
                               StartInfo =
                                   {
                                       FileName = "sunflow.exe",
                                       Arguments = @"shaders\preview.sc",
                                       WindowStyle = ProcessWindowStyle.Normal
                                   }
                           };
            proc.Start();
        }
    }
}