#region Usings

using System.Collections.Generic;
using System.Linq;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;
using NaroPipes.Constants;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    internal class EditingAction : DocumentActionBase
    {
        private bool _prevMouse;

        public EditingAction() : base(ModifierNames.EditingAction)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.EditingToolsInput);
            DependsOn(InputNames.Mouse3DEventsPipe);
            DependsOn(InputNames.SelectionContainerPipe, OnSelectionContainer);
            DependsOn(InputNames.NodeSelect, OnNodeSelect);
            DependsOn(InputNames.CoordinateParser);
        }

        private void OnSelectionContainer(DataPackage data)
        {
            MouseEventHandler(data.Get<Mouse3DPosition>());
        }

        private void ShowHint(string message)
        {
            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetHint, message);
        }

        private void MouseEventHandler(Mouse3DPosition mouseData)
        {
            if (_prevMouse != mouseData.MouseDown)
                MouseClickHandler(mouseData);
            _prevMouse = mouseData.MouseDown;
        }

        public override void OnActivate()
        {
            base.OnActivate();
            //Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, new DataPackage(null));
            Inputs[InputNames.EditingToolsInput].Send(NotificationNames.SetEditor);
           
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>().ToList();
            if (entities.Count == 1 && entities[0].Node.Index < 3)
                Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                         TopAbsShapeEnum.TopAbs_SOLID);
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTabMultipleSelections, entities);
            ShowHint(
                "Press Delete to remove current shape. Press Tilde (near 1) to activate action that creates the same shape");
        }

        private void MouseClickHandler(Mouse3DPosition mouseData)
        {
            if (mouseData.MouseDown)
                return;

            if (mouseData.ShiftDown || mouseData.ControlDown)
            {
                Inputs[InputNames.EditingToolsInput].Send(NotificationNames.HideEditor);
                return;
            }

            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();

            if(entities.Count == 0)
                ActionsGraph.SwitchAction(ModifierNames.None);
            if(entities.Count == 1)
                ActionsGraph.SwitchAction(ModifierNames.EditingAction);
        }

        private void OnNodeSelect(DataPackage data)
        {
            OnTreeNodeSelect(data.Get<Node>());
        }


        private void OnTreeNodeSelect(Node node)
        {
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            entities.Clear();
            entities.Add(new SceneSelectedEntity(node));
            ActionsGraph.SwitchAction(ModifierNames.EditingAction);
        }
    }
}