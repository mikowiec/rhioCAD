using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Sketch
{
    /// <summary>
    /// Lógica de interacción para DimensionToolButton.xaml
    /// </summary>
    public partial class DimensionToolButton
    {
        public DimensionToolButton()
        {
            InitializeComponent();
        }

        private void DimensionClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Dimension);
        }
    }
}
