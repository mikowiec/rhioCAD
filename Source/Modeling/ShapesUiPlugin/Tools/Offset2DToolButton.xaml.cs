using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Tools
{
    /// <summary>
    /// Lógica de interacción para Offset2DToolButton.xaml
    /// </summary>
    public partial class Offset2DToolButton
    {
        public Offset2DToolButton()
        {
            InitializeComponent();
        }

        private void OffsetClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Offset);
        }
    }
}
