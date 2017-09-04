#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Command launching
    /// </summary>
    public partial class RectangleToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public RectangleToolsSplitButton()
        {
            InitializeComponent();
        //    IsEnabled = false;
        }

        //private void RectangleTwoPointsExecute(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Command = Rectangle.Command;
        //    Log.Info("After pressing RectangleTwoPoints button");
        //    SwitchUserAction(ModifierNames.RectangleTwoPoints);
        //}

        private void RectangleThreePointsExecute(object sender, ExecutedRoutedEventArgs e)
        {
            //Command = RectangleFourPoints.Command;
            //Log.Info("After pressing Parallelogram button");
            SwitchUserAction(ModifierNames.ThreePointsRectangle);
            //Command = Rectangle3p.Command;
            //Log.Info("After pressing RectangleThreePoints button");
            //SwitchUserAction(ModifierNames.ThreePointsRectangle);
        }

        //private void ParallelogramExecute(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Command = Parallelogram.Command;
        //    Log.Info("After pressing Parallelogram button");
        //    SwitchUserAction(ModifierNames.Parallelogram);
        //}

        private void RectangleFourPointsExecute(object sender, ExecutedRoutedEventArgs e)
        {
            Command = RectangleFourPoints.Command;
            Log.Info("After pressing Parallelogram button");
            SwitchUserAction(ModifierNames.FourLinesRectangle);
        }
    }
}