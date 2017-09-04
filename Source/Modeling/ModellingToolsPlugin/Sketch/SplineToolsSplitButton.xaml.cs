#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para SplineToolsSplitButton.xaml
    /// </summary>
    public partial class SplineToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public SplineToolsSplitButton()
        {
            InitializeComponent();
          //  IsEnabled = false;
        }

        private void SplineClick(object sender, ExecutedRoutedEventArgs e)
        {
            splineGroup.Command = Spline.Command;
            Log.Info("After pressing Spline button");
            SwitchUserAction(ModifierNames.Spline);
        }

        /*
        private void SplineAddPointClick(object sender, ExecutedRoutedEventArgs e)
        {
            splineGroup.Command = SplineAddPoint.Command;
            Log.Info("After pressing SplineAddPoint button");
            SwitchUserAction(ModifierNames.SplineAddPoint);
        }
         */

        private void SplinepathClick(object sender, ExecutedRoutedEventArgs e)
        {
            splineGroup.Command = SplinePath.Command;
            Log.Info("After pressing SplinePath button");
            SwitchUserAction(ModifierNames.InterpolatedSpline);
        }

        private void SplineControlPointsClick(object sender, ExecutedRoutedEventArgs e)
        {
            splineGroup.Command = SplineControlPoints.Command;
            Log.Info("After pressing ControlPointSpline button");
            SwitchUserAction(ModifierNames.ControlPointSpline);
        }

        private void SplineSplitClick(object sender, ExecutedRoutedEventArgs e)
        {
            splineGroup.Command = SplineSplit.Command;
            Log.Info("After pressing SplineSplit button");
            SwitchUserAction(ModifierNames.SplitSpline);
        }

        private void SplineCombineClick(object sender, ExecutedRoutedEventArgs e)
        {
            splineGroup.Command = SplineSplit.Command;
            Log.Info("After pressing SplineSplit button");
            SwitchUserAction(ModifierNames.CombineSplines);
        }
    }
}