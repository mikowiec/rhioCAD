#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.Constraints
{
    /// <summary>
    ///   Lógica de interacción para SynchronizeToolsButton.xaml
    /// </summary>
    public partial class SynchronizeToolsButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public SynchronizeToolsButton()
        {
            InitializeComponent();
            IsEnabled = false;
        }

        private void SynchronizeToolsButtonClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing SynchronizeToolValues button");
            SwitchUserAction(ModifierNames.SynchronizeToolValues);
        }
    }
}