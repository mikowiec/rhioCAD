#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para CursorToolButton.xaml
    /// </summary>
    public partial class CursorToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public CursorToolButton()
        {
            InitializeComponent();
        }

        private void CursorClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.None);
            Log.Info("After pressing Cursor button");
        }
    }
}