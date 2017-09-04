using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Solid
{
    /// <summary>
    /// Lógica de interacción para SphereButtonTool.xaml
    /// </summary>
    public partial class SphereButtonTool 
    {
        public SphereButtonTool()
        {
            InitializeComponent();
        }

        private void SphereClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Sphere);
        }
    }
}
