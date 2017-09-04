#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para LineToolsSplitButton.xaml
    /// </summary>
    public partial class LineToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public LineToolsSplitButton()
        {
            InitializeComponent();
         //   IsEnabled = false;
        }

        private void LineClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = Line.Command;
            Log.Info("After pressing Line button");
            SwitchUserAction(ModifierNames.Line3D);
        }

        private void LineInPolyModeClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = LineInPolyMode.Command;
            Log.Info("After pressing PolyLine button");
            SwitchUserAction(ModifierNames.LineInPolylineMode);
        }

        //private void LineNormalClick(object sender, ExecutedRoutedEventArgs e)
        //{
        //    lineGroup.Command = NormalLine.Command;
        //    Log.Info("After pressing NormaLine button");
        //    SwitchUserAction(ModifierNames.LineNormal);
        //}

        //private void LineParallelClick(object sender, ExecutedRoutedEventArgs e)
        //{
        //    lineGroup.Command = ParallelLine.Command;
        //    SwitchUserAction(ModifierNames.ParallelLine);
        //}

        private void LineHorizontalClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = HorizontalLine.Command;
            Log.Info("After pressing HorizontalLine button");
            SwitchUserAction(ModifierNames.HorizontalLine);
        }

        private void LineVerticalClick(object sender, ExecutedRoutedEventArgs e)
        {
            lineGroup.Command = VerticalLine.Command;
            Log.Info("After pressing VerticalLine button");
            SwitchUserAction(ModifierNames.VerticalLine);
        }

        //private void LineSetAngleClick(object sender, ExecutedRoutedEventArgs e)
        //{
        //    lineGroup.Command = LineSetAngle.Command;
        //    Log.Info("After pressing LinesSetAngle button");
        //    SwitchUserAction(ModifierNames.LinesSetAngle);
        //}
    }
}