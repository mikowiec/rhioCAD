using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Sketch
{
    /// <summary>
    /// Lógica de interacción para ArcToolsSplitButton.xaml
    /// </summary>
    public partial class ArcToolsSplitButton
    {
        public ArcToolsSplitButton()
        {
            InitializeComponent();
        }

        private void ArcRseClick(object sender, ExecutedRoutedEventArgs e)
        {
            arcGroup.Command = ArcRSE.Command;
            SwitchUserAction(ModifierNames.Arc);
        }

        private void ArcSerClick(object sender, ExecutedRoutedEventArgs e)
        {
            arcGroup.Command = ArcSER.Command;
            SwitchUserAction(ModifierNames.ArcStartEndRadius);
        }
    }
}
