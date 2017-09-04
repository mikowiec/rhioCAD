#region Usings

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using NaroConstants.Names;
using NaroSetup.Pages.Rendering.Logic;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSetup.Pages.Rendering
{
    internal class RenderingOptionsItem : OptionsItem
    {
        private RenderingOptionsView _renderingOptionsWindow;
        private List<Shader> _shaders = new List<Shader>();

        public RenderingOptionsItem()
            : base(OptionSectionNames.RenderingPageTitle, "Rendering", "Rendering Options")
        {
        }

        protected override Control PopulateChild()
        {
            _renderingOptionsWindow = new RenderingOptionsView();
            var result = _renderingOptionsWindow;

            _renderingOptionsWindow.btnConfShaders.Click += BtnConfShadersClick;
            _renderingOptionsWindow.tbxWidth.TextChanged += TbxWidthTextChanged;
            _renderingOptionsWindow.tbxHeight.TextChanged += TbxHeightTextChanged;
            _renderingOptionsWindow.tbxFOV.TextChanged += TbxFovTextChanged;


            return result;
        }

        public override void OnUpdateData()
        {
            if (View == null)
                return;
            var renderWidth = Data.GetIntegerValue(0);
            _renderingOptionsWindow.tbxWidth.Text = renderWidth.ToString();
            var renderHeight = Data.GetIntegerValue(1);
            _renderingOptionsWindow.tbxHeight.Text = renderHeight.ToString();
            var fovValue = Data.GetIntegerValue(2);
            _renderingOptionsWindow.tbxFOV.Text = fovValue.ToString();

            UpdateShaderListFromConfig();
        }

        private void UpdateShaderListFromConfig()
        {
            var shaderNode = Data.Node[1];
            var shaderCount = shaderNode.Set<IntegerInterpreter>().Value;
            _shaders = new List<Shader>();
            for (var i = 0; i < shaderCount; i++)
            {
                var shader = new Shader(shaderNode[i][0].Set<StringInterpreter>().Value)
                                 {
                                     Definition = shaderNode[i][1].Set<StringInterpreter>().Value
                                 };
                _shaders.Add(shader);
            }
        }

        private void BtnConfShadersClick(object sender, RoutedEventArgs e)
        {
            var shadersDialog = new RenderingShaders(_shaders);
            shadersDialog.ShowDialog();
            var pos = 0;
            foreach (var shader in _shaders)
            {
                Data.Node[1][pos][0].Set<StringInterpreter>().Value = shader.Name;
                Data.Node[1][pos][1].Set<StringInterpreter>().Value = shader.Definition;

                pos++;
            }
            Data.Node[1].Set<IntegerInterpreter>().Value = pos;
        }

        private void TbxWidthTextChanged(object sender, TextChangedEventArgs e)
        {
            var intValue = 0;
            try
            {
                intValue = Convert.ToInt32(_renderingOptionsWindow.tbxWidth.Text);
            }
            catch
            {
            }
            Data.SetValue(0, intValue);
        }

        private void TbxHeightTextChanged(object sender, TextChangedEventArgs e)
        {
            var intValue = 0;
            try
            {
                intValue = Convert.ToInt32(_renderingOptionsWindow.tbxHeight.Text);
            }
            catch
            {
            }
            Data.SetValue(1, intValue);
        }

        public override void DefaultValues()
        {
            Data.SetValue(0, 0);
            Data.SetValue(1, 0);
            Data.SetValue(2, 0);
        }

        private void TbxFovTextChanged(object sender, TextChangedEventArgs e)
        {
            var fovValue = 0;
            try
            {
                fovValue = Convert.ToInt32(_renderingOptionsWindow.tbxFOV.Text);
            }
            catch
            {
            }
            Data.SetValue(2, fovValue);
        }
    }
}