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
    public partial class CopyToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public CopyToolButton()
        {
            InitializeComponent();
        }

        private void CopyClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Copy button");
            SwitchUserAction(ModifierNames.Copy);
        }
    }
}