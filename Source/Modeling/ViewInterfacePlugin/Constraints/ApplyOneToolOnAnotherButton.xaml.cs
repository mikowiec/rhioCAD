#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.Constraints
{
    /// <summary>
    ///   Lógica de interacción para ApplyOneToolOnAnotherButton.xaml
    /// </summary>
    public partial class ApplyOneToolOnAnotherButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public ApplyOneToolOnAnotherButton()
        {
            InitializeComponent();
            IsEnabled = false;
        }

        private void ApplyOneToolOnAnotherClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ApplyOneToolOnAnother button");
            SwitchUserAction(ModifierNames.ApplyOneToolOnAnother);
        }
    }
}