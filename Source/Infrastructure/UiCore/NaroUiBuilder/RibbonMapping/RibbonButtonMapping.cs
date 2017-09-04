#region Usings

using System.Windows.Controls;
using Microsoft.Windows.Controls.Ribbon;
using NaroPipes.Actions;

#endregion

namespace NaroUiBuilder.RibbonMapping
{
    public class RibbonButtonMapping : RibbonButton, IControllerUiMapping
    {
        private UiBuilder _uiBuilder;

        protected ActionsGraph ActionGraph
        {
            get { return _uiBuilder.ActionsGraph; }
        }

        #region IControllerUiMapping Members

        public void SetUiBuilder(UiBuilder uiBuilder)
        {
            _uiBuilder = uiBuilder;
        }

        public Control GetControl()
        {
            return this;
        }

        #endregion

        protected void SwitchUserAction(string actionName)
        {
            _uiBuilder.ActionsGraph.SwitchAction(actionName);
        }
    }
}