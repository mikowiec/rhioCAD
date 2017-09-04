#region Usings

using System.Windows.Controls;
using System.Windows.Input;
using log4net;
using NaroPipes.Constants;
using NaroUiBuilder;

#endregion

namespace ViewInterfacePlugin.Orientation
{
    /// <summary>
    ///   Lógica de interacción para OrientationToolsMapping.xaml
    /// </summary>
    public partial class OrientationToolsMapping : IControllerUiMapping
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        private UiBuilder _uiBuilder;

        public OrientationToolsMapping()
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

        private void BackClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing BackView button");
            SwitchUserAction(ModifierNames.Back);
        }

        private void RightClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing RighttView button");
            SwitchUserAction(ModifierNames.Right);
        }

        private void BottomClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing BottomView button");
            SwitchUserAction(ModifierNames.Bottom);
        }

        private void LeftClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Sew button");
            SwitchUserAction(ModifierNames.Left);
        }

        private void TopClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing TopView button");
            SwitchUserAction(ModifierNames.Top);
        }

        private void FrontClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing FrontView button");
            SwitchUserAction(ModifierNames.Front);
        }

        private void AxoClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Axo button");
            SwitchUserAction(ModifierNames.Axo);
        }

        private void ResetClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Reset button");
            SwitchUserAction(ModifierNames.Reset);
        }

        public void SwitchUserAction(string actionName)
        {
            _uiBuilder.ActionsGraph.SwitchAction(actionName);
        }
    }
}