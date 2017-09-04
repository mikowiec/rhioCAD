#region Usings

using System.Windows.Input;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    /// <summary>
    ///   Lógica de interacción para SketchConstraintToolButton.xaml
    /// </summary>
    public partial class SketchConstraintPointsButton
    {
        public SketchConstraintPointsButton()
        {
            InitializeComponent();
        }

        private void ApplyOneToolOnAnotherClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.GuardPointFromMovingAction);
        }
    }
}