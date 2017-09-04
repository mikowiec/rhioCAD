using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin
{
    /// <summary>
    /// Lógica de interacción para SplineToolsSplitButton.xaml
    /// </summary>
    public partial class SplineToolsSplitButton 
    {
        public SplineToolsSplitButton()
        {
            InitializeComponent();
        }

        private void SplineClick(object sender, ExecutedRoutedEventArgs e)
        {
            splineGroup.Command = Spline.Command;
            SwitchUserAction(ModifierNames.Spline);
        }

        private void SplineAddPointClick(object sender, ExecutedRoutedEventArgs e)
        {
            splineGroup.Command = SplineAddPoint.Command;
            SwitchUserAction(ModifierNames.SplineAddPoint);
        }
    }
}
