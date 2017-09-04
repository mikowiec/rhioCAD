#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Tools
{
    /// <summary>
    ///   Lógica de interacción para TranslateToolButton.xaml
    /// </summary>
    public partial class TranslateToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public TranslateToolButton()
        {
            InitializeComponent();
        }

        private void TranslateClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Translate button");
            SwitchUserAction(ModifierNames.Translate);
        }
    }
}