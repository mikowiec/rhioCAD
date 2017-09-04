#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Booleans
{
    /// <summary>
    ///   Lógica de interacción para SubstractToolButton.xaml
    /// </summary>
    public partial class SubstractToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public SubstractToolButton()
        {
            InitializeComponent();
        }

        private void BooleanSubtractClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing BooleanSubstract button");
            SwitchUserAction(ModifierNames.BooleanSubstract);
        }
    }
}