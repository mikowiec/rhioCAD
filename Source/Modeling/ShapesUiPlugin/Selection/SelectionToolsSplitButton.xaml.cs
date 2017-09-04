using System.Windows.Input;
using Naro.Infrastructure.Interface.Constants;
using NaroPipes.Constants;
using OCNaroWrappers;

namespace ShapesUiPlugin.Selection
{
    /// <summary>
    /// Lógica de interacción para SelectionToolsSplitButton.xaml
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
                                                                                OCTopAbs_ShapeEnum.TopAbs_SOLID);
        }

        private void SelectFacesExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Command = SelectFace.Command;
            SwitchUserAction(ModifierNames.None);
            ActionsGraph.InputContainer[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                                OCTopAbs_ShapeEnum.TopAbs_FACE);
        }

        private void SelectEdgesExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Command = SelectEdge.Command;
            SwitchUserAction(ModifierNames.None);
            ActionsGraph.InputContainer[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                                OCTopAbs_ShapeEnum.TopAbs_EDGE);
        }

        private void SelectVerticesExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Command = SelectVertex.Command;
            SwitchUserAction(ModifierNames.None);
            ActionsGraph.InputContainer[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                                OCTopAbs_ShapeEnum.TopAbs_VERTEX);
        }
    }
}
