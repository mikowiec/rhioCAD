#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.Constraints
{
    /// <summary>
    ///   Lógica de interacción para CopyDeepToolsButton.xaml
    /// </summary>
    public partial class CopyDeepToolsButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public CopyDeepToolsButton()
        {
            InitializeComponent();
            IsEnabled = false;
        }

        private void CopyDeepToolsExecute(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing CopyDeepTools button");
            SwitchUserAction(ModifierNames.CopyDeepTools);
        }
    }
}