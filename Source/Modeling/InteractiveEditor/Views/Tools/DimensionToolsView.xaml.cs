#region Usings

using System.Windows;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;
using NaroPipes.Constants;

using TreeData.AttributeInterpreter;

#endregion

namespace InteractiveEditor.Views.Tools
{
    /// <summary>
    ///   Interaction logic for DimensionToolsView.xaml
    /// </summary>
    public partial class DimensionToolsView
    {
        private readonly ActionsGraph _actionsGraph;
        private readonly SceneSelectedEntity _selectedEntity;

        public DimensionToolsView(InteractionContainer selectedEntity, ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
            var items = selectedEntity[TopAbsShapeEnum.TopAbs_FACE];
            _selectedEntity = items[0];
            InitializeComponent();
        }

        private void ExtrudeClicked(object sender, RoutedEventArgs e)
        {
            var pusherInput = _actionsGraph[InputNames.CommandLinePrePusher];
            pusherInput.Send(NotificationNames.PushValue, _selectedEntity);
            _actionsGraph.SwitchAction(ModifierNames.Extrude);
        }

        private void DimensionClicked(object sender, RoutedEventArgs e)
        {
            var pusherInput = _actionsGraph[InputNames.CommandLinePrePusher];
            pusherInput.Send(NotificationNames.PushValue, _selectedEntity);
            _actionsGraph.SwitchAction(ModifierNames.Cut);
        }
    }
}