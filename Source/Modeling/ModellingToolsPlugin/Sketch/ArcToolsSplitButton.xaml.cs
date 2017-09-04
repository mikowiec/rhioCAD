#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para ArcToolsSplitButton.xaml
    /// </summary>
    public partial class ArcToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public ArcToolsSplitButton()
        {
            InitializeComponent();
          //  IsEnabled = false;
        }

        private void ArcRseClick(object sender, ExecutedRoutedEventArgs e)
        {
            arcGroup.Command = ArcRSE.Command;
            Log.Info("After pressing ArcRSE button");
            SwitchUserAction(ModifierNames.ArcCenterStartEnd);
        }

        private void ArcSerClick(object sender, ExecutedRoutedEventArgs e)
        {
            arcGroup.Command = ArcSER.Command;
            Log.Info("After pressing ArcSER button");
            SwitchUserAction(ModifierNames.ArcStartEndRadius);
        }
    }
}