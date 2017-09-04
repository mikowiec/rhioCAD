#region Usings

using System.Windows.Input;
using NaroConstants.Enums;
using NaroConstants.Names;

#endregion

namespace ModellingToolsPlugin.Selection
{
    /// <summary>
    ///   Lógica de interacción para GizmoTypeRotateButton.xaml
    /// </summary>
    public partial class GizmoTypeRotateButton
    {
        public GizmoTypeRotateButton()
        {
            InitializeComponent();
        }

        private void RotateGizmoExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            ActionGraph[InputNames.EditingToolsInput].Send(NotificationNames.SwitchGizmoType,
                                                           GizmoTypes.Rotate);
        }
    }
}