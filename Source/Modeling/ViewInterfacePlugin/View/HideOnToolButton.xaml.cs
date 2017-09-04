#region Usings

using System.Windows.Controls;
using System.Windows.Input;
using log4net;
using NaroPipes.Constants;
using NaroUiBuilder;

#endregion

namespace ViewInterfacePlugin.View
{
    /// <summary>
    ///   Lógica de interacción para HideOnToolButton.xaml
    /// </summary>
    public partial class HideOnToolButton : IControllerUiMapping
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        private UiBuilder _uiBuilder;

        public HideOnToolButton()
        {
            InitializeComponent();
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

        private void HiddenOn(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing HiddenOnOf button");
            SwitchUserAction((HideOn.IsChecked ?? false) ? ModifierNames.HiddenOn : ModifierNames.HiddenOff);
        }

        public void SwitchUserAction(string actionName)
        {
            _uiBuilder.ActionsGraph.SwitchAction(actionName);
        }
    }
}