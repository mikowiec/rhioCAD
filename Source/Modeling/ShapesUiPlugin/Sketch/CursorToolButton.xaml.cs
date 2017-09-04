using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin
{
    /// <summary>
    /// Lógica de interacción para CursorToolButton.xaml
    /// </summary>
    public partial class CursorToolButton
    {
        public CursorToolButton()
        {
            InitializeComponent();
        }

        private void CursorClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.None);
        }
    }
}
