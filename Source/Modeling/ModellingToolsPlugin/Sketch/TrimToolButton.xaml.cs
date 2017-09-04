#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para PointToolButton.xaml
    /// </summary>
    public partial class TrimToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public TrimToolButton()
        {
            InitializeComponent();
           // IsEnabled = false;
        }

        private void TrimClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Trim);
            Log.Info("After pressing Trim button");
        }
    }
}