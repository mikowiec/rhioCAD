using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Features
{
    /// <summary>
    /// Lógica de interacción para RevolveToolButton.xaml
    /// </summary>
    public partial class RevolveToolButton
    {
        public RevolveToolButton()
        {
            InitializeComponent();
        }

        private void RevolveClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Revolve);
        }
    }
}
