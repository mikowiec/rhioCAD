#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.View
{
    /// <summary>
    ///   Lógica de interacción para PanningToolsSplitButton.xaml
    /// </summary>
    public partial class PanningToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public PanningToolsSplitButton()
        {
            InitializeComponent();
        }

        private void DynamicPannning(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ViewDynamicPanning button");
            SwitchUserAction(ModifierNames.ViewDynamicPanning);
        }

        private void GlobalPannning(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ViewGlobalPanning button");
            SwitchUserAction(ModifierNames.ViewGlobalPanning);
        }
    }
}