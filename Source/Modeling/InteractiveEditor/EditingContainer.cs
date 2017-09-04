#region Usings

using System.Collections.Generic;
using InteractiveEditor.Handlers;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace InteractiveEditor
{
    public class EditingContainer : EditingToolBase
    {
        private readonly Document _editingDocument = new Document();

        public EditingContainer()
        {
            RegisterHandlers();
        }

        protected override void OnSetViewInfo()
        {
            SetDocument(ViewInfo.Document);
        }

        private void SetDocument(Document document)
        {
            var context = document.Root.Set<DocumentContextInterpreter>().Context;
            _context = context;
            _editingDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph = ActionsGraph;
            _editingDocument.Root.Set<DocumentContextInterpreter>().Context = _context;
            _editingDocument.Transact();
        }

        private void Register(string shapeName, GenericEditingShapeHandler handler)
        {
            _handlers[shapeName] = handler;
            handler.Document = _editingDocument;
        }

        public override void OnCleanup()
        {
            DeactivateEditingHandler();
            base.OnCleanup();
        }

        private void RegisterHandlers()
        {
            Register(FunctionNames.LineTwoPoints, new LineEditingHandler());
            //Register(FunctionNames.SplineLeg, new SplineLegEditingHandler());
            Register(FunctionNames.Spline, new SplineEditingHandler());
            //Register(FunctionNames.Ellipse, new GenericEditingShapeHandler());
            Register(FunctionNames.ThreePointsRectangle, new RectangleEditingHandler());
            //Register(FunctionNames.Point, new GenericEditingShapeHandler());
            Register(FunctionNames.Circle, new CircleEditingHandler());
            Register(FunctionNames.Arc, new ArcEditingHandler());
            Register(FunctionNames.Arc3P, new Arc3PEditingHandler());
            //Register(FunctionNames.Box, new BoxEditingHandler());
            Register(FunctionNames.Cone, new ConeEditingHandler());
            //Register(FunctionNames.Sphere, new SphereEditingHandler());
            Register(FunctionNames.SplinePath, new SplinePathEditingHandler());
            Register(FunctionNames.Face, new FaceEditingHandler());
        }

        public override void SetEditor(SelectionContainer selectedEntity, ActionsGraph actionsGraph)
        {
            SelectionContainer = selectedEntity;
            var entities = selectedEntity.Entities;
            if (entities.Count == 0)
                return;
            SelectedNode = entities[entities.Count - 1].Node;
            var name = FunctionUtils.GetFunctionName(entities[entities.Count - 1].Node);
            if (!_handlers.ContainsKey(name))
            {
                if (selectedEntity.CurrentSelectionMode != TopAbsShapeEnum.TopAbs_FACE)
                {
                    DeactivateEditingHandler();
                    return;
                }
                else
                {
                    _currentHandler = _handlers[FunctionNames.Face];
                    _currentHandler.SetSelectedEntity(entities[entities.Count - 1]);
                }
            }
            else
            {
                _currentHandler = _handlers[name];    
            }
            
            _currentHandler.SetNode(entities[entities.Count-1].Node);
            _currentHandler.DisplayHandles();

            ViewUpdate();
        }

        private void DeactivateEditingHandler()
        {
            if (_currentHandler == null) return;
            _editingDocument.Revert();
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
            _currentHandler.previousMousePosition = mouseData.Point.GpPnt;
           _currentHandler.startX = mouseData.Initial2Dx;
           _currentHandler.startY = mouseData.Initial2Dy;
            var selectedNodes = NodeBuilderUtils.IdentifyShapesUnderMouse(_editingDocument.Root, mouseData.Initial2Dx,
                                                                          mouseData.Initial2Dy, ViewInfo.View);
            if (selectedNodes.Count <= 0 && (_currentHandler.SelectedEntity == null || _currentHandler.SelectedEntity.Node == null))
                return;
            if (selectedNodes.Count > 0)
                _currentHandler.StartDragging(selectedNodes[0]);
            else
                _currentHandler.StartDragging(_currentHandler.SelectedEntity);
            var pusherInput = ActionsGraph[InputNames.CommandLinePrePusher];
            pusherInput.Send(NotificationNames.Reset);
            pusherInput.Send(NotificationNames.PushValue, _currentHandler);
            pusherInput.Send(NotificationNames.PushValue, _editingDocument);
            _editingDocument.Transact();

            ViewInfo.SwitchAction(ModifierNames.HandleDragging);
        }

        #region Data members

        private readonly SortedDictionary<string, GenericEditingShapeHandler> _handlers =
            new SortedDictionary<string, GenericEditingShapeHandler>();

        private AISInteractiveContext _context;
        private GenericEditingShapeHandler _currentHandler;
        private bool _prevMouse;

        #endregion

        #region Properties

        private Node SelectedNode { get; set; }
        private SelectionContainer SelectionContainer { get; set; }

        #endregion
    }
}