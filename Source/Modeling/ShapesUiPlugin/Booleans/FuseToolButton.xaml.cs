using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Booleans
{
    /// <summary>
    /// Lógica de interacción para FuseToolButton.xaml
    /// </summary>
    public partial class FuseToolButton
    {
        public FuseToolButton()
        {
            InitializeComponent();
        }

        private void BooleanAddClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.BooleanAdd);
        }
    }
}
