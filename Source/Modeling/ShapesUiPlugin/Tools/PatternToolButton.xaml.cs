using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Tools
{
    /// <summary>
    /// Lógica de interacción para PatternToolButton.xaml
    /// </summary>
    public partial class PatternToolButton
    {
        public PatternToolButton()
        {
            InitializeComponent();
        }

        private void PatternLinClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.PatternLinearCircular);
        }
    }
}
