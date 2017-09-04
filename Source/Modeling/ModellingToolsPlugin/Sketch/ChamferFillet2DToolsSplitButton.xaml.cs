#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para ChamferFilletToolsSplitButton.xaml
    /// </summary>
    public partial class ChamferFillet2DToolsSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public ChamferFillet2DToolsSplitButton()
        {
            InitializeComponent();
            //IsEnabled = false;
        }

        private void Fillet2DClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Fillet2D button");
            filletGroup.Command = Fillet2D.Command;
            SwitchUserAction(ModifierNames.Fillet2D);
        }

        private void Chamfer2DClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Chamfer2D button");
            filletGroup.Command = Chamfer2D.Command;
            SwitchUserAction(ModifierNames.Chamfer2D);
        }
    }
}