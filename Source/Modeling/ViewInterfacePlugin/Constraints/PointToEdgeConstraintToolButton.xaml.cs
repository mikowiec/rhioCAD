#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.Constraints
{
    /// <summary>
    ///   Lógica de interacción para PointToEdgeConstraintToolButton.xaml
    /// </summary>
    public partial class PointToEdgeConstraintToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public PointToEdgeConstraintToolButton()
        {
            InitializeComponent();
        }

        private void PointToEdgeConstraintClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing PointToEdgeConstraint button");
            SwitchUserAction(ModifierNames.PointToEdgeConstraint);
        }
    }
}