#region Usings

using System.Collections.Generic;
using System.Linq;
using InteractiveEditor;
using InteractiveEditor.Views.FloatingTool;
using Naro.Infrastructure.Interface;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    internal class EditingToolsPipe : PipeBase
    {
        private readonly List<EditingToolBase> _editingTools = new List<EditingToolBase>();
        private GizmoTypes _currentGizmoType = GizmoTypes.Translate;
        private GizmoContainer _gizmoContainer;
        private EditingContainer _shapeEditingContainer;
        private ViewInfo _viewInfo;

        public EditingToolsPipe() : base(InputNames.EditingToolsInput)
        {
        }

        public override void OnRegister()
        {
            DependsOn(InputNames.SelectionContainerPipe);
            DependsOn(InputNames.UiElementsItem);
            DependsOn(InputNames.Mouse3DEventsPipe, Mouse3DEventHandler);
            DependsOn(InputNames.CommandLinePrePusher);

            AddNotificationHandler(NotificationNames.UpdateViewInfo, UpdateViewInfo);
            AddNotificationHandler(NotificationNames.SetEditor, SetEditor);
            AddNotificationHandler(NotificationNames.HideEditor, HideEditor);
            AddNotificationHandler(NotificationNames.SwitchGizmoType, SwitchGizmoType);
        }

        public override void OnConnect()
        {
            base.OnConnect();
            SetupEditingTools();
        }

        public override void OnDisconnect()
        {
            HideEditor(null);
        }

        private void HideEditor(DataPackage dataPackage)
        {
            foreach (var editingtool in _editingTools)
                editingtool.OnCleanup();
        }

        private void SwitchGizmoType(DataPackage dataPackage)
        {
            var gizmoType = dataPackage.Get<GizmoTypes>();
            _currentGizmoType = gizmoType;
        }

        private void SetEditor(DataPackage dataPackage)
        {
            if (Inputs.ContainsKey(InputNames.CommandLinePrePusher))
            {
                var pusherInput = Inputs[InputNames.CommandLinePrePusher];
                var pusherData = (List<object>) pusherInput.GetData(NotificationNames.GetValue).Data;
                if (pusherData.Count > 0)
                {
                    return;
                }
            }

            if (_gizmoContainer != null)
            {
                _gizmoContainer.CurrentGizmoType = _currentGizmoType;
            }

            if (Inputs.ContainsKey(InputNames.SelectionContainerPipe))
            {
                var selectionContainer =
                    Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetContainer).Get
                        <SelectionContainer>();

                foreach (var editingTool in _editingTools)
                {
                    editingTool.SetViewInfo(_viewInfo, ActionsGraph);
                    editingTool.SetEditor(selectionContainer, ActionsGraph);
                    if (selectionContainer.CurrentSelectionMode == TopAbsShapeEnum.TopAbs_FACE)
                        break;
                }
            }
        }

        private void UpdateViewInfo(DataPackage dataPackage)
        {
            _viewInfo = dataPackage.Get<ViewInfo>();
            foreach (var editingTool in _editingTools)
                editingTool.SetViewInfo(_viewInfo, ActionsGraph);
        }

        private void SetupEditingTools()
        {
            _shapeEditingContainer = new EditingContainer();
            _gizmoContainer = new GizmoContainer();
            _editingTools.Clear();
            _editingTools.Add(_shapeEditingContainer);
            _editingTools.Add(_gizmoContainer);
            _editingTools.Add(new FloatingToolbarEditingTool());
        }

        private void Mouse3DEventHandler(DataPackage data)
        {
            _shapeEditingContainer.Mouse3DEventHandler(data.Get<Mouse3DPosition>());
            _gizmoContainer.Mouse3DEventHandler(data.Get<Mouse3DPosition>());
            var selectionContainer =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetContainer).Get
                    <SelectionContainer>();
            if(selectionContainer.Entities.Count == 1 && data.Get<Mouse3DPosition>().Clicks == 2 )
            {
                if(FunctionNames.GetSketchShapes().ToList().Contains(selectionContainer.Entities[0].Node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name))
                    ActionsGraph.SwitchAction(ModifierNames.StartSketch);
            }
        }
    }
}