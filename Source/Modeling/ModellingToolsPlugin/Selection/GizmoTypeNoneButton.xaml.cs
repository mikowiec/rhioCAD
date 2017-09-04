#region Usings

using System.Windows.Input;
using NaroConstants.Enums;
using NaroConstants.Names;

#endregion

namespace ModellingToolsPlugin.Selection
{
    /// <summary>
    ///   Lógica de interacción para GizmoTypeNoneButton.xaml
    /// </summary>
    public partial class GizmoTypeNoneButton
    {
        public GizmoTypeNoneButton()
        {
            InitializeComponent();
        }

        private void SelectGizmoNoneExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            ActionGraph[InputNames.EditingToolsInput].Send(NotificationNames.SwitchGizmoType,
                                                           GizmoTypes.None);
        }
    }
}