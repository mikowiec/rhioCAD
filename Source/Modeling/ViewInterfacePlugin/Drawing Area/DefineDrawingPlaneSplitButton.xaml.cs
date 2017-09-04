#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.Constraints
{
    /// <summary>
    ///   Lógica de interacción para ArcToolsSplitButton.xaml
    /// </summary>
    public partial class DefineDrawingPlaneSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public DefineDrawingPlaneSplitButton()
        {
            InitializeComponent();
            IsEnabled = false;
        }

        private void ThreePointsPlaneClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ThreePointsPlane button");
            SwitchUserAction(ModifierNames.DefineDrawingPlane);
        }

        private void TwoLinesClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing TwoLinesPlane button");
        }
    }
}