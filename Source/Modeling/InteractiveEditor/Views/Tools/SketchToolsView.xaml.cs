#region Usings

using System.Windows;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using TreeData.AttributeInterpreter;

#endregion

namespace InteractiveEditor.Views.Tools
{
    /// <summary>
    ///   Interaction logic for SketchToolsView.xaml
    /// </summary>
    public partial class SketchToolsView
    {
        private readonly ActionsGraph _actionsGraph;
        private readonly SceneSelectedEntity _sceneSelectedEntity;

        public SketchToolsView(InteractionContainer sceneSelectedEntity, ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
            _sceneSelectedEntity = sceneSelectedEntity.Entities[0];

            InitializeComponent();
        }

        private void LineClicked(object sender, RoutedEventArgs e)
        {
            _actionsGraph[InputNames.RestrictedPlane].Send(NotificationNames.SetData,
                                                           _sceneSelectedEntity);
            _actionsGraph.SwitchAction(ModifierNames.Line3D);
        }

        private void RectangleClicked(object sender, RoutedEventArgs e)
        {
            _actionsGraph[InputNames.RestrictedPlane].Send(NotificationNames.SetData,
                                                           _sceneSelectedEntity);
            _actionsGraph.SwitchAction(ModifierNames.RectangleTwoPoints);
        }

        private void CircleClicked(object sender, RoutedEventArgs e)
        {
            _actionsGraph[InputNames.RestrictedPlane].Send(NotificationNames.SetData,
                                                           _sceneSelectedEntity);
            _actionsGraph.SwitchAction(ModifierNames.DrawCircle);
        }
    }
}