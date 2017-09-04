#region Usings

using System.Windows.Input;
using NaroConstants.Enums;
using NaroConstants.Names;

#endregion

namespace ModellingToolsPlugin.Selection
{
    /// <summary>
    ///   Lógica de interacción para GizmoTypeScaleButton.xaml
    /// </summary>
    public partial class GizmoTypeScaleButton
    {
        public GizmoTypeScaleButton()
        {
            InitializeComponent();
        }

        private void ScaleGizmoExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            ActionGraph[InputNames.EditingToolsInput].Send(NotificationNames.SwitchGizmoType,
                                                           GizmoTypes.Scale);
        }
    }
}