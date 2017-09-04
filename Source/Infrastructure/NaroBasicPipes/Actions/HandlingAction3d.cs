#region Usings

using Naro.Infrastructure.Interface.Views;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.V3d;
using NaroPipes.Actions;
using NaroPipes.Constants;


#endregion

namespace NaroBasicPipes.Actions
{
    public class HandlingAction3D : ActionBase
    {
        #region Constructor

        protected HandlingAction3D(string name)
            : base(name)
        {
            DependsOn(InputNames.View, ExractViews);
            DependsOn(InputNames.MouseEventsInput, HandleMouseEvents);
            DependsOn(InputNames.MouseCursorInput);
        }

        #endregion

        #region Properties

        protected V3dView View { get; set; }
        protected V3dViewer Viewer { get; set; }

        #endregion

        private bool _prevMouse;

        private void HandleMouseEvents(DataPackage data)
        {
            var mouseData = data.Get<MouseEventData>();
            MouseEventHandler(mouseData);
        }

        private void ExractViews(DataPackage data)
        {
            var viewItems = data.Get<ViewInput.Items>();
            Viewer = viewItems.Viewer;
            View = viewItems.View;
            KeysMappingSingleton.Instance.UpdateView(View);
        }

        private void MouseEventHandler(MouseEventData mouseData)
        {
            KeysMappingSingleton.Instance.UpdateMouse(mouseData.X, mouseData.Y, mouseData.MouseDown);
            if (_prevMouse == mouseData.MouseDown)
            {
                MouseMoveHandler(mouseData.X, mouseData.Y, mouseData.MouseDown);
            }
            else
            {
                if (false == mouseData.MouseDown)
                    MouseUpHandler(mouseData.X, mouseData.Y);
                else
                    MouseDownHandler(mouseData.X, mouseData.Y);
            }
            _prevMouse = mouseData.MouseDown;
        }

        protected virtual void MouseMoveHandler(int x, int y, bool mouseDown)
        {
        }

        protected virtual void MouseUpHandler(int x, int y)
        {
        }

        protected virtual void MouseDownHandler(int x, int y)
        {
        }

        protected void BackToNeutralModifier()
        {
            ActionsGraph.SwitchAction(ModifierNames.None);
        }
    }
}