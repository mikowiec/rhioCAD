#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Features
{
    /// <summary>
    ///   Lógica de interacción para RevolveToolButton.xaml
    /// </summary>
    public partial class RevolveToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public RevolveToolButton()
        {
            InitializeComponent();
        }

        private void RevolveClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Revolve button");
            SwitchUserAction(ModifierNames.Revolve);
        }
    }
}