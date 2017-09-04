#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para DimensionToolButton.xaml
    /// </summary>
    public partial class DimensionToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public DimensionToolButton()
        {
            InitializeComponent();
        //    IsEnabled = false;
        }

        private void DimensionClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Dimension);
            Log.Info("After pressing Dimension button");
        }

        private void MeasureClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.MeasureDistance);
        }
    }
}