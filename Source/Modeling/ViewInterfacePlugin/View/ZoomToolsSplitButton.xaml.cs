#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.View
{
    /// <summary>
    ///   Lógica de interacción para ZoomToolsSplitButton.xaml
    /// </summary>
    public partial class ZoomToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public ZoomToolsSplitButton()
        {
            InitializeComponent();
        }

        private void DynamicZoomWindow(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ViewDynamicZooming button");
            SwitchUserAction(ModifierNames.ViewDynamicZooming);
        }

        private void ZoomWindow(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ViewZoomWindow button");
            SwitchUserAction(ModifierNames.ViewZoomWindow);
        }

        private void FitAll(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing FitAll button");
            SwitchUserAction(ModifierNames.FitAll);
        }
    }
}