#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Booleans
{
    /// <summary>
    ///   Lógica de interacción para FuseToolButton.xaml
    /// </summary>
    public partial class FuseToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public FuseToolButton()
        {
            InitializeComponent();
        }

        private void BooleanAddClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing BooleanAdd button");
            SwitchUserAction(ModifierNames.BooleanAdd);
        }
    }
}