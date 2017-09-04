using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Features
{
    /// <summary>
    /// Lógica de interacción para ExtrudeToolButton.xaml
    /// </summary>
    public partial class ExtrudeToolButton
    {
        public ExtrudeToolButton()
        {
            InitializeComponent();
        }

        private void ExtrudeClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Extrude);
        }
    }
}
