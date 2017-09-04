#region Usings

using System.Collections.Generic;
using InteractiveEditor.GizmoHandlers;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroPipes.Actions;
using NaroPipes.Constants;

using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace InteractiveEditor
{
    public class GizmoContainer : EditingToolBase
    {
        private readonly Document _gizmoDocument = new Document();

        private readonly SortedDictionary<GizmoTypes, GenericEditingShapeHandler> _handlers =
            new SortedDictionary<GizmoTypes, GenericEditingShapeHandler>();

        private AISInteractiveContext _context;
        private GenericEditingShapeHandler _currentHandler;
        private bool _prevMouse;
        private double _previousTransparency;

        public GizmoContainer()
        {
            CurrentGizmoType = GizmoTypes.Translate;
            RegisterHandlers();
        }

        public GizmoTypes CurrentGizmoType { private get; set; }

        protected override void OnSetViewInfo()
        {
            SetDocument(ViewInfo.Document);
        }

        private void SetDocument(Document document)
        {
            var context = document.Root.Set<DocumentContextInterpreter>().Context;
            _context = context;
            _gizmoDocument.Root.Set<DocumentContextInterpreter>().Context = _context;
            _gizmoDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph = ActionsGraph;
            _gizmoDocument.Transact();
        }

        private void Register(GizmoTypes gizmoType, GenericEditingShapeHandler handler)
        {
            _handlers[gizmoType] = handler;
            handler.Document = _gizmoDocument;
        }

        public override void OnCleanup()
        {
            DeactivateGizmoHandler();
            base.OnCleanup();
        }

        private void RegisterHandlers()
        {
            Register(GizmoTypes.Translate, new TranslateAxisHandler());
            Register(GizmoTypes.Scale, new ScaleAxisHandler());
            Register(GizmoTypes.Rotate, new RotateAxisHandler());
        }

        public override void SetEditor(SelectionContainer selectedEntity, ActionsGraph actionsGraph)
        {
            SelectionContainer = selectedEntity;
            var entities = selectedEntity.Entities;
            if (entities.Count == 0)
                return;
            SelectedNode = entities[0].Node;
            if (!_handlers.ContainsKey(CurrentGizmoType))
            {
                DeactivateGizmoHandler();
                return;
            }

            if (SelectedNode.Index < 3)
                return;

            var nodeBuilder = new NodeBuilder(SelectedNode);
            _previousTransparency = nodeBuilder.Transparency;
            nodeBuilder.Transparency = 0.5;
            _currentHandler = _handlers[CurrentGizmoType];
            _currentHandler.SetNode(entities[0].Node);
            _currentHandler.Document = _gizmoDocument;
            _currentHandler.DisplayHandles();

            ViewUpdate();
        }

        private void DeactivateGizmoHandler()
        {
            if (_currentHandler == null) return;
            new NodeBuilder(SelectedNode) {Transparency = _previousTransparency};
            _gizmoDocument.Revert();
            ViewUpdate();
        }

        public void Mouse3DEventHandler(Mouse3DPosition mouseData)
        {
            if (_prevMouse != mouseData.MouseDown)
            {
                if (mouseData.MouseDown)
                    MouseDownHandler(mouseData);
            }
            _prevMouse = mouseData.MouseDown;
        }

        private void MouseDownHandler(Mouse3DPosition mouseData)
        {
            if (_currentHandler == null) return;
            var selectedNodes = NodeBuilderUtils.IdentifyShapesUnderMouse(_gizmoDocument.Root, mouseData.Initial2Dx,
                                                                          mouseData.Initial2Dy, ViewInfo.View);
            if (selectedNodes.Count <= 0) return;
            _currentHandler.StartDragging(selectedNodes[0]);
            var pusherInput = ActionsGraph[InputNames.CommandLinePrePusher];
            pusherInput.Send(NotificationNames.Reset);
            pusherInput.Send(NotificationNames.PushValue, _currentHandler);
            pusherInput.Send(NotificationNames.PushValue, _gizmoDocument);
            _gizmoDocument.Transact();

            ViewInfo.SwitchAction(ModifierNames.HandleDragging);
        }

        #region Properties

        private Node SelectedNode { get; set; }
        private SelectionContainer SelectionContainer { get; set; }

        #endregion
    }
}