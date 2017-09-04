#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.View
{
    /// <summary>
    ///   Lógica de interacción para RotationToolButton.xaml
    /// </summary>
    public partial class RotationToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public RotationToolButton()
        {
            InitializeComponent();
        }

        private void DynamicRotation(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing DynamicRotation button");
            SwitchUserAction(ModifierNames.DynamicRotation);
        }
    }
}