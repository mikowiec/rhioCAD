using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin
{
    /// <summary>
    /// Lógica de interacción para RectangleToolButton.xaml
    /// </summary>
    public partial class RectangleToolButton
    {
        public RectangleToolButton()
        {
            InitializeComponent();
        }

        private void RectangleClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Rectangle3D);
        }
    }
}
