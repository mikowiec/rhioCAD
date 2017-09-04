#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.Constraints
{
    /// <summary>
    ///   Lógica de interacción para PointToPointConstraintToolButton.xaml
    /// </summary>
    public partial class PointToPointConstraintToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public PointToPointConstraintToolButton()
        {
            InitializeComponent();
        }

        private void PointToPointConstraintClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing PointToPointConstraint button");
            SwitchUserAction(ModifierNames.PointToPointConstraint);
        }
    }
}