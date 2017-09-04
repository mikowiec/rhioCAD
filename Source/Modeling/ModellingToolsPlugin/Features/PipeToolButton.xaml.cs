#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Features
{
    /// <summary>
    ///   Lógica de interacción para PipeToolButton.xaml
    /// </summary>
    public partial class PipeToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public PipeToolButton()
        {
            InitializeComponent();
        }

        private void PipeClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Pipe button");
            SwitchUserAction(ModifierNames.Pipe);
        }
    }
}