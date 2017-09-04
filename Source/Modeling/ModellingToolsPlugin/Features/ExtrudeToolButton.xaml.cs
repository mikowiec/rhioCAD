#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Features
{
    /// <summary>
    ///   Lógica de interacción para ExtrudeToolButton.xaml
    /// </summary>
    public partial class ExtrudeToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public ExtrudeToolButton()
        {
            InitializeComponent();
        }

        private void ExtrudeClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Extrude button");
            SwitchUserAction(ModifierNames.Extrude);
        }
    }
}