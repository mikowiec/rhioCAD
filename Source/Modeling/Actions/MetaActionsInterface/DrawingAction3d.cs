#region Usings

using System.Collections.Generic;
using System.Drawing;
using System.IO;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopoDS;
using log4net;
using Naro.Infrastructure.Interface.Views;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroBasicPipes.Inputs.Layers;
using NaroConstants.Names;
using NaroPipes.Actions;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace MetaActionsInterface
{
    /// <summary>
    ///   Base class for drawing actions like: extrude, line 3d, rectangle 3d
    /// </summary>
    public class DrawingAction3D : HandlingAction3D
    {
        private static readonly ILog Log = LogManager.GetLogger("DrawingAction3D");
        protected OcLayer2DManager _manager;

        protected DrawingAction3D(string name)
            : base(name)
        {
            Points = new List<Point3D>();
        }

        protected List<Point3D> Points { get; private set; }
        protected Document Document { get; private set; }
        protected Document AnimationDocument { get; private set; }
        protected AISInteractiveContext Context { get; private set; }
        protected ITreeViewControl TreeView { get; private set; }
        protected TopoDSFace CurrentFacePicked { get; private set; }
        private bool PreviousMouseDown { get; set; }

        private void SetDependencies()
        {
            DependsOn(InputNames.Mouse3DEventsPipe);

            DependsOn(InputNames.UiElementsItem, OnReceiveUiElementsItem);
            DependsOn(InputNames.Context, OnReceiveContext);
            DependsOn(InputNames.Document, OnReceiveDocument);
            DependsOn(InputNames.FacePickerPlane, OnReceiveFacePickerPlane);
            DependsOn(InputNames.NodeSelect, OnReceiveNodeSelect);
            DependsOn(InputNames.SelectionContainerPipe, OnReceiveSelectionContainerPipe);
            DependsOn(InputNames.View, OnReceiveView);
        }

        public override void OnRegister()
        {
            base.OnRegister();

            SetDependencies();

            AnimationDocument = new Document();
            AnimationDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph = ActionsGraph;
        }

        public static void SelectShape(Node selectedShape)
        {
            if (selectedShape == null)
                return;
            var drawingAttributesInterpreter = selectedShape.Set<DrawingAttributesInterpreter>();
            drawingAttributesInterpreter.Disable();
            drawingAttributesInterpreter.Color = Color.RoyalBlue;
            drawingAttributesInterpreter.Transparency = 0.2;
            drawingAttributesInterpreter.Enable();
            selectedShape.Set<NamedShapeInterpreter>().Disable();
            selectedShape.Set<NamedShapeInterpreter>().RegenerateInteractive();
            selectedShape.Set<NamedShapeInterpreter>().Enable();
        }

        public override void OnActivate()
        {
            base.OnActivate();

            var solverPipe = ActionsGraph[InputNames.GeometricSolverPipe];
            solverPipe.Send(NotificationNames.EnableAll);
            solverPipe.Send(NotificationNames.ResetPreviousPoint);
            Document.Transact();
            var contextInterpreter = AnimationDocument.Root.Set<DocumentContextInterpreter>();
            contextInterpreter.Context =
                Document.Root.Get<DocumentContextInterpreter>().Context;
            contextInterpreter.Document = AnimationDocument;
            AnimationDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph = ActionsGraph;
            AnimationDocument.Transact();
        }

        private void OnReceiveUiElementsItem(DataPackage data)
        {
            TreeView = data.Get<UiElementsItem.Items>().TreeView;
        }

        private void OnReceiveSelectionContainerPipe(DataPackage data)
        {
            var mouseData = data.Get<Mouse3DPosition>();
            Mouse3DEventHandler(mouseData);
        }

        private void OnReceiveContext(DataPackage data)
        {
            Context = data.Get<AISInteractiveContext>();
        }

        private void OnReceiveFacePickerPlane(DataPackage data)
        {
            FacePicked(data.Get<TopoDSFace>());
        }

        private void OnReceiveNodeSelect(DataPackage data)
        {
            OnNodeSelect(data.Get<Node>());
        }

        private void OnReceiveDocument(DataPackage data)
        {
            Document = data.Get<Document>();
            Ensure.IsNotNull(Document, "Document provided is invalid or null!");
        }

        private void OnReceiveView(DataPackage data)
        {
            var viewItems = data.Get<ViewInput.Items>();
            View = viewItems.View;
            Viewer = viewItems.Viewer;
        }

        protected virtual void OnNodeSelect(Node node)
        {
        }

        private void Mouse3DEventHandler(Mouse3DPosition mouseData)
        {
            if (mouseData.MouseDown != PreviousMouseDown)
                OnMouseClick3DAction(mouseData);
            else
                OnMouseMove3DAction(mouseData);

            PreviousMouseDown = mouseData.MouseDown;
        }

        protected virtual void OnMouseDownAction(Mouse3DPosition mouseData)
        {
        }

        protected virtual void OnMouseUpAction(Mouse3DPosition mouseData)
        {
        }

        protected virtual void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            Log.Info("StartSketch - OnMouseClick3DAction");

            if (mouseData.MouseDown)
            {
                Log.Info("StartSketch - OnMouseClick3DAction - mouse down");
                OnMouseDownAction(mouseData);
            }
            else
            {
                Log.Info("StartSketch - OnMouseClick3DAction - mouse up");
                OnMouseUpAction(mouseData);
            }
        }

        protected virtual void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
        }

        protected override void MouseMoveHandler(int x, int y, bool mouseDown)
        {
            Context.MoveTo(x, y, View);
        }

        protected void AddToPointList(Point3D point)
        {
            // The point is added only if the list is empty or if it is different
            // than the previously added point (check for the two point coincidence)
            if (Points.Count == 0)
                Points.Add(point);
            else if (!Points[Points.Count - 1].IsEqual(point))
                Points.Add(point);
        }

        protected void AddNewEmptyPoint()
        {
            Points.Add(new Point3D());
        }

        public override void OnDeactivate()
        {
        //    ActionsGraph[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);

            Points.Clear();

            Document.Revert();
            AnimationDocument.Revert();

            base.OnDeactivate();
        }

        /// <summary>
        ///   Called when notified that the FacPicker detected a new face selected.
        /// </summary>
        protected virtual void FacePicked(TopoDSFace face)
        {
            // Don't allow null faces
            if ((face == null) || (face.IsNull))
                return;

            // Filter duplicate faces
            if ((CurrentFacePicked != null) && (!CurrentFacePicked.IsNull) && (CurrentFacePicked.IsSame(face)))
                return;

            CurrentFacePicked = face;
        }

        protected void UpdateView()
        {
            //if(_manager == null)
            //{
            //    _manager =
            //        ActionsGraph[InputNames.View].GetData(NotificationNames.GetLayerManager).Get<OcLayer2DManager>();
            //}
            if(_manager!=null)
                _manager.Draw();
            Inputs[InputNames.View].Send(NotificationNames.RefreshView);
        }


        private static void AddChainedShapesToList(Node node, SortedDictionary<int, Node> shapes)
        {
            if (node == null) return;
            if (shapes.ContainsKey(node.Index)) return;
            shapes[node.Index] = node;
            var dependency = node.Get<FunctionInterpreter>().Dependency;
            foreach (var dependencyNode in dependency.Children)
            {
                var name = dependencyNode.Name;

                switch (name)
                {
                    case InterpreterNames.Reference:
                        AddChainedShapesToList(dependencyNode.Reference, shapes);
                        break;
                    case InterpreterNames.ReferenceList:
                        {
                            var refList = dependencyNode.ReferenceList;
                            foreach (var entity in refList)
                                AddChainedShapesToList(entity.Node, shapes);
                        }
                        break;
                }
            }
        }

        protected void AddBuilderToTreeRecursively(NodeBuilder rootBuilder)
        {
            var shapes = new SortedDictionary<int, Node>();

            AddChainedShapesToList(rootBuilder.Node, shapes);

            AddNodeListToTree(shapes.Values);
        }

        public void RebuildTreeView()
        {
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RebuildTreeView);
        }

        protected void AddNodeListToTree(IEnumerable<Node> nodes)
        {
            var nodesToAdd = new SortedDictionary<int, Node>();
            //added 
            foreach (var node in nodes)
                nodesToAdd[node.Index] = node;
            foreach (var nodeVal in nodesToAdd.Values)
                AddNodeToTree(nodeVal);
        }

        protected void AddNodeToTree(Node node)
        {
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.AddNewNodeToTree, node);
        }

        protected void WriteTextOnPos(int x, int y, string text)
        {
            var layer = _manager.SetLayer("DrawingLiveShape");
            layer.SetPosition(x + 20, y + 5);
            
            layer.TextOut(text);
        }
    }
}