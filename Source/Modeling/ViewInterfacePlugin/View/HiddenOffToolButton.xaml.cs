#region Usings

using System.Windows.Controls;
using System.Windows.Input;
using log4net;
using NaroPipes.Actions;
using NaroPipes.Constants;
using NaroUiBuilder;

#endregion

namespace ViewInterfacePlugin.View
{
    /// <summary>
    ///   Lógica de interacción para HiddenOffToolButton.xaml
    /// </summary>
    public partial class HiddenOffToolButton : IControllerUiMapping
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        private ActionsGraph _actionsGraph;
        private UiBuilder _uiBuilder;

        public HiddenOffToolButton()
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

        public void SetActionGraph(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
        }


        public void SwitchUserAction(string actionName)
        {
            _uiBuilder.ActionsGraph.SwitchAction(actionName);
        }

        private void HiddenOff(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing HiddenOff button");
            SwitchUserAction(ModifierNames.HiddenOff);
        }
    }
}