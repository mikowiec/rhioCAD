#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para CircleToolsSplitButton.xaml
    /// </summary>
    public partial class CircleToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public CircleToolsSplitButton()
        {
            InitializeComponent();
          //  IsEnabled = false;
        }

        private void CircleClick(object sender, ExecutedRoutedEventArgs e)
        {
            circleGroup.Command = Circle.Command;
            Log.Info("After pressing Circle button");
            SwitchUserAction(ModifierNames.DrawCircle);
        }

        private void EllipseClick(object sender, ExecutedRoutedEventArgs e)
        {
            circleGroup.Command = Ellipse.Command;
            Log.Info("After pressing Ellipse button");
            SwitchUserAction(ModifierNames.Ellipse);
        }
    }
}