#region Usings

using System.Collections.Generic;
using InteractiveEditor.Views.FloatingTool;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    public class None : DocumentActionBase
    {
        #region Delegates

        public delegate void OnChangedShapeClickHander(Node node);

        #endregion

        public OnChangedShapeClickHander OnChangedShapeClick;

        public None() : base(ModifierNames.None)
        {
            DependsOn(InputNames.Context);
            DependsOn(InputNames.MouseCursorInput);
            DependsOn(InputNames.GeometricSolverPipe);
            DependsOn(InputNames.SelectionContainerPipe, HandleMouseDataInput);
            DependsOn(InputNames.MirrorEntireScenePipe);
            DependsOn(InputNames.NodeSelect, OnNodeSelect);
        }

        private void OnNodeSelect(DataPackage data)
        {
            OnTreeNodeSelect(data.Get<Node>());
        }

        public override void OnActivate()
        {
            base.OnActivate();
            
            Document.Revert();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Inputs[InputNames.MouseCursorInput].Send(NotificationNames.Reset);
            Inputs[InputNames.NodeSelect].Send(NotificationNames.Reset);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
            NodeBuilderUtils.HidePlanes(Document);
            ToolsFloatingWindow.Instance.Setup(ActionsGraph);
        }

        public override void OnDeactivate()
        {
            if (OnChangedShapeClick != null)
                OnChangedShapeClick(null);

            base.OnDeactivate();
        }

        private void HandleMouseDataInput(DataPackage data)
        {
            var mouseData = data.Get<Mouse3DPosition>();
            MouseEventHandler(mouseData);
        }

        private void MouseEventHandler(Mouse3DPosition mouseData)
        {
            if (_prevMouse != mouseData.MouseDown)
                MouseClickHandler(mouseData);
            _prevMouse = mouseData.MouseDown;
        }

        private void MouseClickHandler(Mouse3DPosition mousePosition)
        {
            if (mousePosition.MouseDown)
                return;

            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            if (entities.Count <= 0)
            {
                var selectedFace =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetSelectedFace).Get
                    <SceneSelectedEntity>();
                if(selectedFace == null)
                    return;
                if (selectedFace.Node.Index < 3)
                    return;
                entities.Add(selectedFace);
            }
            var selectedLabel = entities[entities.Count - 1].Node;
            OnChangedShapeClick(selectedLabel);

            if (mousePosition.ShiftDown || mousePosition.ControlDown)
                return;

            var selectionMode =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetSelectionMode).Get
                    <TopAbsShapeEnum>();
            //if (selectionMode != TopAbsShapeEnum.TopAbs_SOLID)
            //    return;
            if(selectedLabel.Interpreters.Count > 0)
                ActionsGraph.SwitchAction(ModifierNames.EditingAction);
        }

        private void OnTreeNodeSelect(Node node)
        {
            var selectedLabel = node;
            if (selectedLabel.Get<FunctionInterpreter>() == null)
                return;

            OnChangedShapeClick(selectedLabel);

            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            entities.Add(new SceneSelectedEntity(node));
            ActionsGraph.SwitchAction(ModifierNames.EditingAction);
        }

        #region Data members

        private bool _prevMouse;

        #endregion
    }
}