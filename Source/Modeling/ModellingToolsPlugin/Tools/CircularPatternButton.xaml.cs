#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Tools
{
    /// <summary>
    ///   Lógica de interacción para PatternToolButton.xaml
    /// </summary>
    public partial class CircularPatternButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public CircularPatternButton()
        {
            InitializeComponent();
        }

        private void CircularPatternClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Circular Pattern button");
            SwitchUserAction(ModifierNames.CircularPattern);
        }
    }
}