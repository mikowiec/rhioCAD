#region Usings

using System.Collections.Generic;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Constants;
using NaroSketchAdapter.Views;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Constraints
{
    internal class SketchConstraintMapperAction : DrawingLiveShape
    {
        private ConstraintDocumentHelper _constraintDocumentHelper;
        private Node _sketchNode;
        private ConstraintMapperView _view;

        public SketchConstraintMapperAction() : base(ModifierNames.SketchConstraintMapper)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            var sketchCreator = new SketchCreator(Document);
            _sketchNode = sketchCreator.CurrentSketch;
            _constraintDocumentHelper = new ConstraintDocumentHelper(Document, _sketchNode);

            _view = new ConstraintMapperView(_constraintDocumentHelper);
            _view.OnSceneChanged += SceneChanged;
            RibbonPanel.Children.Add(_view);
            _view.UpdateSelection(new List<Node>());
        }

        private void SceneChanged()
        {
            UpdateView();
        }

        public override void OnDeactivate()
        {
            RebuildTreeView();
            UpdateView();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.EnableAll);
            base.OnDeactivate();
        }

        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            base.OnMouseDownAction(mouseData);
            var nodeList = GetSelectedNodeList(mouseData);
            _view.UpdateSelection(nodeList);
        }

        private List<Node> GetSelectedNodeList(Mouse3DPosition mouseData)
        {
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.BuildSelections, mouseData);
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();

            var nodeList = new List<Node>();
            foreach (var entity in entities)
            {
                nodeList.Add(entity.Node);
            }
            return nodeList;
        }
    }
}