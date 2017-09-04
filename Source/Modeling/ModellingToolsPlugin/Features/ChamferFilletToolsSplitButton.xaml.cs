#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Features
{
    /// <summary>
    ///   Lógica de interacción para ChamferFilletToolsSplitButton.xaml
    /// </summary>
    public partial class ChamferFilletToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public ChamferFilletToolsSplitButton()
        {
            InitializeComponent();
        }

        private void FilletClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Fillet button");
            filletGroup.Command = Fillet.Command;
            SwitchUserAction(ModifierNames.Fillet);
        }

        private void ChamferClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Chamfer button");
            filletGroup.Command = Chamfer.Command;
            SwitchUserAction(ModifierNames.Chamfer);
        }
    }
}