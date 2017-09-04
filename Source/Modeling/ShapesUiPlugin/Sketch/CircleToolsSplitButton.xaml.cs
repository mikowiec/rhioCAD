using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Sketch
{
    /// <summary>
    /// Lógica de interacción para CircleToolsSplitButton.xaml
    /// </summary>
    public partial class CircleToolsSplitButton
    {
        public CircleToolsSplitButton()
        {
            InitializeComponent();
        }

        private void CircleClick(object sender, ExecutedRoutedEventArgs e)
        {
            circleGroup.Command = Circle.Command;
            SwitchUserAction(ModifierNames.DrawCircle);
        }

        private void EllipseClick(object sender, ExecutedRoutedEventArgs e)
        {
            circleGroup.Command = Ellipse.Command;
            SwitchUserAction(ModifierNames.Ellipse3D);
        }
    }
}
