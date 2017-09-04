#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Features
{
    /// <summary>
    ///   Lógica de interacción para CutToolButton.xaml
    /// </summary>
    public partial class CutToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public CutToolButton()
        {
            InitializeComponent();
        }

        private void CutClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Cut button");
            SwitchUserAction(ModifierNames.Cut);
        }
    }
}