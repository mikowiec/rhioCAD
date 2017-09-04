using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Features
{
    /// <summary>
    /// Lógica de interacción para ChamferFilletToolsSplitButton.xaml
    /// </summary>
    public partial class ChamferFilletToolsSplitButton
    {
        public ChamferFilletToolsSplitButton()
        {
            InitializeComponent();
        }

        private void FilletClick(object sender, ExecutedRoutedEventArgs e)
        {
            filletGroup.Command = Fillet.Command;
            SwitchUserAction(ModifierNames.Fillet);
        }

        private void ChamferClick(object sender, ExecutedRoutedEventArgs e)
        {
            filletGroup.Command = Chamfer.Command;
            SwitchUserAction(ModifierNames.Chamfer);
        }

        private void Fillet2DClick(object sender, ExecutedRoutedEventArgs e)
        {
            filletGroup.Command = Fillet2D.Command;
            SwitchUserAction(ModifierNames.Fillet2D);
        }

        private void Chamfer2DClick(object sender, ExecutedRoutedEventArgs e)
        {
            filletGroup.Command = Chamfer2D.Command;
            SwitchUserAction(ModifierNames.Chamfer2D);
        }
    }
}
