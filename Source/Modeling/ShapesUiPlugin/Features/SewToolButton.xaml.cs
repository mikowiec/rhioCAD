using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Features
{
    /// <summary>
    /// Lógica de interacción para SewToolButton.xaml
    /// </summary>
    public partial class SewToolButton
    {
        public SewToolButton()
        {
            InitializeComponent();
        }

        private void SewingClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Sew);
        }
    }
}
