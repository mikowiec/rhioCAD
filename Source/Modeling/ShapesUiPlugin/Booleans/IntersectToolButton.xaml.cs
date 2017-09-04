using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Booleans
{
    /// <summary>
    /// Lógica de interacción para IntersectToolButton.xaml
    /// </summary>
    public partial class IntersectToolButton
    {
        public IntersectToolButton()
        {
            InitializeComponent();
        }

        private void BooleanIntersectClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.BooleanIntersect);
        }
    }
}
