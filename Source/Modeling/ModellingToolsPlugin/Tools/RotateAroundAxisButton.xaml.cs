#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Tools
{
    /// <summary>
    ///   Lógica de interacción para RotateAroundAxisButton.xaml
    /// </summary>
    public partial class RotateAroundAxisButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public RotateAroundAxisButton()
        {
            InitializeComponent();
        }

        private void RotateClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing RotateAroundAxis button");
            SwitchUserAction(ModifierNames.RotateAroundAxis);
        }
    }
}