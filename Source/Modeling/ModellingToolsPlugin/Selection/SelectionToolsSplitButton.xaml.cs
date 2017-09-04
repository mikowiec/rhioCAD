#region Usings

using System.Windows.Input;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Constants;


#endregion

namespace ModellingToolsPlugin.Selection
{
    /// <summary>
    ///   Lógica de interacción para SelectionToolsSplitButton.xaml
    /// </summary>
    public partial class SelectionToolsSplitButton
    {
        public SelectionToolsSplitButton()
        {
            InitializeComponent();
        }

        private void SelectSolidExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Command = SelectSolid.Command;
            SwitchUserAction(ModifierNames.None);
            ActionsGraph.InputContainer[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                                TopAbsShapeEnum.TopAbs_SOLID);
        }

        private void SelectFacesExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Command = SelectFace.Command;
            SwitchUserAction(ModifierNames.None);
            ActionsGraph.InputContainer[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                                TopAbsShapeEnum.TopAbs_FACE);
        }

        private void SelectEdgesExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Command = SelectEdge.Command;
            SwitchUserAction(ModifierNames.None);
            ActionsGraph.InputContainer[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                                TopAbsShapeEnum.TopAbs_EDGE);
        }

        private void SelectVerticesExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Command = SelectVertex.Command;
            SwitchUserAction(ModifierNames.None);
            ActionsGraph.InputContainer[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                                TopAbsShapeEnum.TopAbs_VERTEX);
        }
    }
}