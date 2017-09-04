using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Booleans
{
    /// <summary>
    /// Lógica de interacción para SubstractToolButton.xaml
    /// </summary>
    public partial class SubstractToolButton
    {
        public SubstractToolButton()
        {
            InitializeComponent();
        }

        private void BooleanSubtractClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.BooleanSubstract);
        }
    }
}
