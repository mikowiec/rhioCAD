#region Usings

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Input;
using Naro.Infrastructure.Interface;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using NaroSetup;
using TreeData.AttributeInterpreter;

#endregion

namespace InteractiveEditor.Views.FloatingTool
{
    /// <summary>
    ///   Description of ToolsFloatingWindow.
    /// </summary>
    public sealed class ToolsFloatingWindow
    {
        private static readonly ToolsFloatingWindow SingletonInstance = new ToolsFloatingWindow();
        private readonly FloatingToolsFactory _factory = new FloatingToolsFactory();
        private ActionsGraph _actionsGraph;
        private SelectionContainer _entity;
        private FloatingWindow _window;

        private ToolsFloatingWindow()
        {
            _factory.RegisterTools();
        }

        public static ToolsFloatingWindow Instance
        {
            get { return SingletonInstance; }
        }

        public void UpdateViewInfo(ViewInfo viewInfo)
        {
            _factory.UpdateViewInfo(viewInfo);
        }

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point lpPoint);

        public void Show(SelectionContainer entity)
        {
            var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionSection = optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle);
            DestroyOldWindow(entity);

            if (!optionSection.GetBoolValue(1))
                return;

            if (entity == null || entity.Entities.Count == 0)
                return;
            const int deltaX = 16;
            const int deltaY = 16;
            if (IsDifferentEntity(entity.Entities[0]))
            {
                _entity = entity;
                _window = new FloatingWindow();
                _window.KeyDown += WindowKeyDown;
                _window.Closed += WindowClosed;
            }
            var defPnt = new Point();
            GetCursorPos(ref defPnt);

            _window.Left = defPnt.X + deltaX;
            _window.Top = defPnt.Y + deltaY;
            _factory.PopulateView(_window, _entity, _actionsGraph);
            _window.ShowActivated = false;
            _window.Show();
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Escape:
                    _factory.ViewInfo.SwitchAction(ModifierNames.None);
                    break;
                case Key.Delete:
                    _factory.ViewInfo.SwitchAction(ModifierNames.Delete);
                    break;
            }
        }

        private bool IsDifferentEntity(SceneSelectedEntity entity)
        {
            if (_entity == null && entity == null)
                return false;
            if (_entity != null && entity == null)
                return true;
            if (_entity == null)
                return true;
            if (_entity.Entities.Count == 0)
                return false;
            return _entity.Entities[0].Node != entity.Node || _entity.Entities[0].ShapeCount == entity.ShapeCount;
        }

        private void DestroyOldWindow(InteractionContainer entity)
        {
            if (_window == null) return;
            if (!IsDifferentEntity(entity == null ? null : entity.Entities[0]))
                return;
            if (_window.IsVisible)
                _window.Close();
            _window = null;
        }

        public void Setup(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            _window = null;
        }
    }
}