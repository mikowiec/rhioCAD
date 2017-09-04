#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Tools
{
    /// <summary>
    ///   Lógica de interacción para Offset2DToolButton.xaml
    /// </summary>
    public partial class Offset2DToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public Offset2DToolButton()
        {
            InitializeComponent();
            IsEnabled = false;
        }

        private void OffsetClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Offset button");
            SwitchUserAction(ModifierNames.Offset);
        }
    }
}