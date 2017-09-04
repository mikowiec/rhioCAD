using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Sketch
{
    /// <summary>
    /// Lógica de interacción para LineToolsSplitButton.xaml
    /// </summary>
    public partial class LineToolsSplitButton 
    {
        public LineToolsSplitButton()
        {
            InitializeComponent();
        }

        private void LineClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = Line.Command;
            SwitchUserAction(ModifierNames.Line3D);
        }

        private void LineInPolyModeClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = LineInPolyMode.Command;
            SwitchUserAction(ModifierNames.LineInPolylineMode);
        }

        private void LineNormalClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = NormalLine.Command;
            SwitchUserAction(ModifierNames.LineNormal);
        }

        private void LineParallelClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = ParallelLine.Command;
            SwitchUserAction(ModifierNames.ParallelLine);
        }

        private void LineHorizontalClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = HorizontalLine.Command;
            SwitchUserAction(ModifierNames.HorizontalLine);
        }

        private void LineVerticalClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = VerticalLine.Command;
            SwitchUserAction(ModifierNames.VerticalLine);
        }
    }
}
