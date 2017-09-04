#region Usings

using System.Collections.Generic;
using System.Drawing;
using InteractiveEditor;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.EditingActions
{
    internal class HandleDraggingAction : DocumentActionBase
    {
        private NodeBuilder _builder;
        private Document _editingDocument;
        private bool _prevMouse;
        private GenericEditingShapeHandler _shapeHandler;

        public HandleDraggingAction() : base(ModifierNames.HandleDragging)
        {
            DependsOn(InputNames.EditingToolsInput);
            DependsOn(InputNames.SelectionContainerPipe, OnSelectionContainerPipe);
            DependsOn(InputNames.CommandLinePrePusher);
            DependsOn(InputNames.Mouse3DEventsPipe);
            DependsOn(InputNames.GeometricSolverPipe);
        }

        private void OnSelectionContainerPipe(DataPackage data)
        {
            MouseEventHandler(data.Get<Mouse3DPosition>());
        }

        private void MouseEventHandler(Mouse3DPosition mouseData)
        {
            if (_prevMouse != mouseData.MouseDown)
            {
                if (!mouseData.MouseDown)
                    MouseUpHandler(mouseData);
            }
            else
                MouseMoveHandler(mouseData);
            _prevMouse = mouseData.MouseDown;
        }

        private void MouseUpHandler(Mouse3DPosition mouseData)
        {
            if (_shapeHandler == null) return;
            if (!_shapeHandler.IsDragging) return;
      //      var interpreter = _shapeHandler.Node.Get<TransformationInterpreter>();
      //      var transform = interpreter.CurrTransform.Multiplied(new OCgp_Trsf());
          
            _shapeHandler.MouseDrag(mouseData);
            //_builder.Transformation = transform;
            //_builder.ExecuteFunction();
            _shapeHandler.EndDragging(mouseData);

            _editingDocument.Revert();
            //var autoGroupNode = AutoGroupLogic.TryAutoGroup(Document, _shapeHandler.Node);
            //if (autoGroupNode != null)
            //{
            //    RebuildTreeView();
            //}
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.SelectNode, _shapeHandler.Node);
            Document.Commit("Finished dragging");
            UpdateView();

            ActionsGraph.SwitchAction(ModifierNames.None);
        }

        private void MouseMoveHandler(Mouse3DPosition mouseData)
        {
            if (_shapeHandler == null) return;

            if (!_shapeHandler.IsDragging) return;
            _editingDocument.Revert();
            _shapeHandler.MouseDrag(mouseData);
            _shapeHandler.DisplayHandle(_shapeHandler.DraggingIndex, _editingDocument);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Document.Transact();

            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.EnableAll);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Disable);
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, new DataPackage(null));
            var pusherInput = Inputs[InputNames.CommandLinePrePusher];
            var pusherData = (List<object>) pusherInput.GetData(NotificationNames.GetValue).Data;
            _shapeHandler = (GenericEditingShapeHandler) pusherData[0];
            _editingDocument = (Document) pusherData[1];
            pusherInput.Send(NotificationNames.Reset);
            _builder = new NodeBuilder(_shapeHandler.Node) {Transparency = 0.5, Color = Color.RoyalBlue};
          //  SetWorkingPlane(_shapeHandler);
        }

        private void SetWorkingPlane(GenericEditingShapeHandler shapeHandler)
        {
            var axis = shapeHandler.GetPointLocation(shapeHandler.DraggingIndex);
            var workingPlane = new gpPln(axis.Location, axis.Direction);
            //Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, workingPlane);
        }

        public override void OnDeactivate()
        {
            base.OnDeactivate();

            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
        }
    }
}