using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin
{
    /// <summary>
    /// Lógica de interacción para PointToolButton.xaml
    /// </summary>
    public partial class PointToolButton 
    {
        public PointToolButton()
        {
            InitializeComponent();
        }

        private void PointClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Point3D);
        }
    }
}
