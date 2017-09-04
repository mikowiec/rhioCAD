#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para PointToolButton.xaml
    /// </summary>
    public partial class PointToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public PointToolButton()
        {
            InitializeComponent();
           // IsEnabled = false;
        }

        private void PointClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Point3D);
            Log.Info("After pressing Point button");
        }
    }
}