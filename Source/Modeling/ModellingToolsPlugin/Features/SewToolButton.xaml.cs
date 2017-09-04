#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Features
{
    /// <summary>
    ///   Lógica de interacción para SewToolButton.xaml
    /// </summary>
    public partial class SewToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (SewToolButton));

        public SewToolButton()
        {
            InitializeComponent();
        }

        private void SewingClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Sew button");
            SwitchUserAction(ModifierNames.Sew);
        }
    }
}