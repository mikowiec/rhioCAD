#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ViewInterfacePlugin.Constraints
{
    /// <summary>
    ///   Lógica de interacción para ConstraintShapesToolButton.xaml
    /// </summary>
    public partial class ConstraintShapesToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public ConstraintShapesToolButton()
        {
            InitializeComponent();
        }

        private void ConstraintShapeClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ConstraintShapeAction button");
            SwitchUserAction(ModifierNames.ConstraintShapeAction);
        }
    }
}