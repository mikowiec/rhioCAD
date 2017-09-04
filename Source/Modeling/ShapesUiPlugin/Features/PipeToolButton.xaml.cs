using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Features
{
    /// <summary>
    /// Lógica de interacción para PipeToolButton.xaml
    /// </summary>
    public partial class PipeToolButton
    {
        public PipeToolButton()
        {
            InitializeComponent();
        }

        private void PipeClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Pipe);
        }
    }
}
