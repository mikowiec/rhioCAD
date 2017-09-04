#region Usings

using System.Windows.Input;
using NaroConstants.Enums;
using NaroConstants.Names;

#endregion

namespace ModellingToolsPlugin.Selection
{
    /// <summary>
    ///   Lógica de interacción para GizmoTypeTranslateButton.xaml
    /// </summary>
    public partial class GizmoTypeTranslateButton
    {
        public GizmoTypeTranslateButton()
        {
            InitializeComponent();
        }

        private void TranslateGizmoExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            ActionGraph[InputNames.EditingToolsInput].Send(NotificationNames.SwitchGizmoType,
                                                           GizmoTypes.Translate);
        }
    }
}