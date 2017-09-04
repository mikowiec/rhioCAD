#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Tools
{
    /// <summary>
    ///   Lógica de interacción para MirrorToolsSplitButton.xaml
    /// </summary>
    public partial class MirrorToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public MirrorToolsSplitButton()
        {
            InitializeComponent();
        }

        private void MirrorPointClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing MirrorPoint button");
            Command = MirrorPoint.Command;
            SwitchUserAction(ModifierNames.MirrorPoint);
        }

        private void MirrorAxisClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing MirrorLine button");
            Command = MirrorLine.Command;
            SwitchUserAction(ModifierNames.MirrorLine);
        }

        private void MirrorPlaneClick(object sender, ExecutedRoutedEventArgs e)
        {
            //Log.Info("After pressing MirrorPlane button");
            //Command = MirrorPlane.Command;
            //SwitchUserAction(ModifierNames.MirrorPlane);
        }
    }
}