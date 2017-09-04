using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Features
{
    /// <summary>
    /// Lógica de interacción para CutToolButton.xaml
    /// </summary>
    public partial class CutToolButton
    {
        public CutToolButton()
        {
            InitializeComponent();
        }

        private void CutClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Cut);
        }
    }
}
