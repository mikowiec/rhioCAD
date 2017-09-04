using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Tools
{
    /// <summary>
    /// Lógica de interacción para TranslateToolButton.xaml
    /// </summary>
    public partial class TranslateToolButton
    {
        public TranslateToolButton()
        {
            InitializeComponent();
        }

        private void TranslateClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Translate);
        }
    }
}
