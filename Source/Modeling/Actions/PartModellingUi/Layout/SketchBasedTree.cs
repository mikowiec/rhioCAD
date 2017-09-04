using System.Collections.Generic;
using System.Windows.Controls;
using TreeData.NaroData;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using System;
using System.Linq;
using NaroConstants.Names;
using TreeData.Capabilities;
using Naro.Infrastructure.Interface.Views;
using System.Windows;
using System.Windows.Media;

namespace NaroSketchSolveTests
{
    public class SketchBasedTree
    {
        private TreeView _treeView;

        private static readonly List<string> _constraintFunctions = new List<string>();
        private static readonly List<string> _globalFunctions = new List<string>();
        private static readonly List<string> _3dShapesFunctions = new List<string>();
        private static readonly List<string> _usingSketchFunctions = new List<string>();
        private static readonly List<string> _onSketchFunctions = new List<string>();
        private readonly List<Node> _sketchNodes = new List<Node>();
        private readonly List<Node> _globalNodes = new List<Node>();
        private readonly List<Node> _3dShapeNodes = new List<Node>();
        private readonly List<Node> _onSketchNodes = new List<Node>();
        private readonly List<Node> _usingSketchNodes = new List<Node>();
        private readonly List<Node> _pointNodes = new List<Node>();
        private readonly List<Node> _constraintNodes = new List<Node>();
        private readonly List<Node> _hintNodes = new List<Node>();
        private readonly List<Node> _planeNodes = new List<Node>(); 
        private Document _document;
        private CapabilitiesCollection _capabilties;
        private ImageBitmapCache _imageBitmapCache;
        private enum NodeType
        {
            Point,
            Constraint,
            Sketch,
            UsingSketch,
            Global,
            OnSketch,
            SolidShape,
            Auxiliary,
            Plane,
        }

        public void Setup(Document document, TreeView treeView)
        {
            _document = document;
            _treeView = treeView;
        }

        public SketchBasedTree()
        {
            InitializeListsOfFunctionNames();
        }

        public void Update(bool showIcon)
        {
            _treeView.Items.Clear();
            FillElemetLists(_document);
            AddElements(showIcon);
        }

        //SortedDictionary<string, SortedDictionary<int, TreeViewItem>> _cacheTreeNodes;
        public void AddTreeNode(Node node, bool showIcon)
        {
            var builder = new NodeBuilder(node);

            var currentNodeType = FindNodeType(builder.FunctionName);

            switch (currentNodeType)
            {
                //case NodeType.Constraint: AddConstraintNode(node, showIcon); break;
                case NodeType.Global: _treeView.Items.Add(NewItem(node, showIcon)); break;
                case NodeType.OnSketch: AddOnSketchTreeNode(node, showIcon); break;
                case NodeType.Sketch: _treeView.Items.Add(NewExpandedItem(node, showIcon)); break;
                case NodeType.Point: AddPointTreeNode(node, showIcon); break;
                case NodeType.SolidShape: Add3dSolidNode(node, showIcon); break;
                case NodeType.Plane: _treeView.Items.Add(NewItem(node, showIcon)); break;
                case NodeType.Auxiliary:
                    break;
                //case NodeType.UsingSketch: _usingSketchNodes.Add(node); break;
                default: _treeView.Items.Add(NewItem(node, showIcon)); break;
            }
        }

        private void AddPointTreeNode(Node node, bool showIcon)
        {
            var builder = new NodeBuilder(node);
            var reference = builder[0].ReferenceBuilder;
            var sketchNode = reference.Node;
            var newItem = NewItem(node, showIcon);
            FindTreeItem(sketchNode).Items.Add(newItem);//Exception thrown => The sketch must exist before the node is added
        }

        private void Add3dSolidNode(Node node, bool showIcon)
        {
            var builder = new NodeBuilder(node);
            builder.ExecuteFunction();
            _treeView.Items.Add(NewItem(node, showIcon));
            //var reference = builder[0].ReferenceBuilder;
            //var sketchNode = reference.Node;
            //var newItem = NewItem(node, showIcon);
            //FindTreeItem(sketchNode).Items.Add(newItem);//Exception thrown => The sketch must exist before the node is added
        }


        private void AddOnSketchTreeNode(Node node, bool showIcon)
        {
            var builder = new NodeBuilder(node);
            var pointReference = builder[0].ReferenceBuilder;
            var reference = pointReference[0].ReferenceBuilder;
            var sketchNode = reference.Node;
            var newItem = NewItem(node, showIcon);
            AddReferenceToOnSketchNode(pointReference.Node, sketchNode, newItem, showIcon);
            for (var i = 1; i < builder.Node.Get<FunctionInterpreter>().Dependency.Count; i++)
                if (builder[i].Name == InterpreterNames.Reference)
                {
                    AddReferenceToOnSketchNode(builder[i].ReferenceBuilder.Node, sketchNode, newItem, showIcon);
                }
            FindTreeItem(sketchNode).Items.Add(newItem);//Exception thrown => The sketch must exist before the node is added or reference node is invalid
        }


        private void AddConstraintNode(Node node, bool showIcon)
        {
            var builder = new NodeBuilder(node);
            var pointReference = builder[0].ReferenceBuilder;
            var reference = pointReference[0].ReferenceBuilder;
            var sketchNode = reference.Node;
            var newItem = NewItem(node, showIcon);
            AddReferenceToOnSketchNode(pointReference.Node, sketchNode, newItem, showIcon);
            for (var i = 1; i < builder.Node.Get<FunctionInterpreter>().Dependency.Count; i++)
                AddReferenceToOnSketchNode(builder[i].ReferenceBuilder.Node, sketchNode, newItem, showIcon);
            FindTreeItem(sketchNode).Items.Add(newItem);
        }

        private void AddReferenceToOnSketchNode(Node pointReferenceNode, Node sketchNode, TreeViewItem newItem, bool showIcon)
        {
            if (FindTreeItem(pointReferenceNode) == null)
            {
                var items = FindTreeItem(sketchNode);
                if(items != null)
                    items.Items.Add(NewItem(pointReferenceNode, showIcon));
            }
            newItem.Items.Add(NewItem(pointReferenceNode, showIcon));
        }

        private void AddElements(bool showIcon)
        {
            foreach (var element in _globalNodes) AddGlobalElement(element, showIcon);
            foreach (var element in _planeNodes) AddPlaneElement(element, showIcon);
            foreach (var element in _usingSketchNodes) AddGlobalElement(element, showIcon);

            foreach (var element in _sketchNodes)
            {
                AddSketch(element, showIcon);
            }
            foreach (var element in _pointNodes)
            {
                AddPoint(element, showIcon);
            }
            foreach (var element in _onSketchNodes)
            {
                AddSketchElement(element, showIcon);
            }

            foreach(var element in _3dShapeNodes)
            {
                Add3dSolidNode(element, showIcon);
            }

            foreach (var element in _constraintNodes)
            {
                AddConstraint(element, showIcon);
            }

            var list = new List<Node>();
            list.AddRange(_onSketchNodes);
            list.AddRange(_sketchNodes);
            list.AddRange(_pointNodes);
            foreach (var element in list)
            {
                AddNodeToExistingParents(element, showIcon);
            }
        }

        private void FillElemetLists(Document document)
        {
            ClearElementLists();
            foreach (var node in document.Root.ChildrenList)
            {
                var interpreter = node.Get<FunctionInterpreter>();
                var crrentNodeTypeName = string.Empty;
                if (interpreter != null)
                {
                    crrentNodeTypeName = new NodeBuilder(node).FunctionName;
                }
                var currentNodeType = FindNodeType(crrentNodeTypeName);
                if (crrentNodeTypeName == string.Empty)
                    continue;
                switch (currentNodeType)
                {
                    case NodeType.Constraint: _constraintNodes.Add(node); 
                        break;
                    case NodeType.Global: _globalNodes.Add(node); break;
                    case NodeType.OnSketch: _onSketchNodes.Add(node); break;
                    case NodeType.Sketch: _sketchNodes.Add(node); break;
                    case NodeType.Point: _pointNodes.Add(node); break;
                    case NodeType.SolidShape: _3dShapeNodes.Add(node); break;
                    case NodeType.UsingSketch: _usingSketchNodes.Add(node); break;
                    case NodeType.Plane: _planeNodes.Add(node); break;
                    case NodeType.Auxiliary: _hintNodes.Add(node);
                        break;
                    default: _globalNodes.Add(node); break;
                }
            }
        }

        private static NodeType FindNodeType(string currentNodeTypeName)
        {
            if(currentNodeTypeName == FunctionNames.Plane)
                return NodeType.Plane;
            if (NodeIsFunction(currentNodeTypeName))
            {
                return NodeType.Auxiliary;
            }
            if (NodeIsUsingSketchFunctions(currentNodeTypeName))
            {
                return NodeType.UsingSketch;
            }
            if (NodeIsGlobalFunctions(currentNodeTypeName))
            {
                return NodeType.Global;
            }
            if (NodeIsOnSketchFunctions(currentNodeTypeName))
            {
                return NodeType.OnSketch;
            }
            if (NodeIs3dShapesFunctions(currentNodeTypeName))
            {
                return NodeType.SolidShape;
            }
            switch (currentNodeTypeName)
            {
                case FunctionNames.Point:
                    return NodeType.Point;
                case "Sketch":
                    return NodeType.Sketch;
                case FunctionNames.LineHints:
                case FunctionNames.PointHints:
                    return NodeType.Auxiliary;
                default:
                    return NodeType.Global;
            }
        }

        private Node RefferedBy(Node node)
        {
            var refList = _document.Root.Set<DocumentContextInterpreter>().ShapesGraph.GetReferredByNodes(node);
            if (refList.Count == 0)
                return null;
            foreach (var element in refList)
            {
                var elementBuilder = new NodeBuilder(element);
                if (elementBuilder.FunctionName != FunctionNames.Point && elementBuilder.Node.Index != node.Index)
                    return elementBuilder.Node;
            }
            return null;
        }

        private void AddPoint(Node node, bool showIcon)
        {
            try
            {
                var sketchReferenceToPoint = SketchReferenceToPoint(node);
                if (sketchReferenceToPoint == null)
                    return;
                FindTreeItem(sketchReferenceToPoint).Items.Add(NewItem(node, showIcon));
            }
            catch
            {
            }
            
        }

        private Node SketchReferenceToPoint(Node node)
        {
            if (node == null)
                return null;
            var nodeText = node.Get<StringInterpreter>().Value;
            foreach (var sketchElement in _sketchNodes)
            {
                var refList = _document.Root.Set<DocumentContextInterpreter>().ShapesGraph.GetReferredByNodes(sketchElement);
                foreach (var element in refList)
                {
                    if (element.Get<StringInterpreter>().Value == nodeText)
                        return sketchElement;
                }
            }
            return null;
        }

        private Node GetSketchReference(Node node)
        {
            var builder = new NodeBuilder(node);
            var functionName = builder.FunctionName;
            switch (functionName)
            {
                case FunctionNames.Point:
                    return SketchReferenceToPoint(node);
                default:
                    if (NodeIsFunction(functionName))
                        if ((GetFirstChildNode(node).Get<FunctionInterpreter>().Name == FunctionNames.Point))
                            return SketchReferenceToPoint(GetFirstChildNode(node));
                        else return SketchReferenceToPoint(GetFirstChildNode(GetFirstChildNode(node)));
                return null;
            }
        }

        private Node GetFirstChildNode(Node node)
        {
            var nodeText = node.Get<StringInterpreter>().Value;
            foreach (var pointNode in _pointNodes)
            {
                var list = _document.Root.Set<DocumentContextInterpreter>().ShapesGraph.GetReferredByNodes(pointNode);
                if (list.Count <= 0) continue;
                foreach (var reference in list)
                {
                    if (reference.Get<StringInterpreter>().Value == nodeText)
                        return pointNode;
                }
            }
            foreach (var onSketchElement in _onSketchNodes)
            {
                var list = _document.Root.Set<DocumentContextInterpreter>().ShapesGraph.GetReferredByNodes(onSketchElement);
                if (list.Count <= 0) continue;
                foreach (var reference in list)
                {
                    if (reference.Get<StringInterpreter>().Value == nodeText)
                        return onSketchElement;
                }
            }
            return null;
        }

        private List<Node> GetNodeParents(Node node)
        {
            var nodes =  _document.Root.Set<DocumentContextInterpreter>().ShapesGraph.GetReferredByNodes(node);

            return nodes;
        }

        private void AddSketchElement(Node node, bool showIcon)
        {
            var getSketchReference = SketchReferenceToPoint(GetFirstChildNode(node));
            if (getSketchReference == null)
                return;
            if ((GetFirstChildNode(node).Get<FunctionInterpreter>().Name != FunctionNames.Point))
                getSketchReference = SketchReferenceToPoint(GetFirstChildNode(GetFirstChildNode(node)));
            var newTreeViewItem = NewItem(node, showIcon);
            AddItem(FindTreeItem(getSketchReference), newTreeViewItem);
        }

        private void AddSketch(Node node, bool showIcon)
        {
            var refferedBy = RefferedBy(node);
            var newItem = NewExpandedItem(node, showIcon);//sketch is expanded when tree refresh is made
            if (refferedBy == null)
                AddItem(_treeView, newItem);
            else
                AddItem(FindTreeItem(refferedBy), newItem);
        }


        private static void AddItem(ItemsControl treeView, TreeViewItem newTreeViewItem)
        {
            treeView.Items.Add(newTreeViewItem);
        }

        private void AddConstraint(Node node, bool showIcon)
        {
            var getSketchReference = GetSketchReference(node);
            var nodeText = node.Get<StringInterpreter>().Value;
            var treeViewItem = NewItem(nodeText, node, showIcon);
            if (getSketchReference == null)
                throw new ArgumentNullException("Constraint is not defined on a sketch");
            AddItem(FindTreeItem(getSketchReference), treeViewItem);
        }

        private void AddNodeToExistingParents(Node node, bool showIcon)
        {
            var getElementReferences = GetNodeParents(node);
            if (getElementReferences == null) return;
            foreach (var parent in getElementReferences)
            {
                if (parent.Get<FunctionInterpreter>().Name == FunctionNames.Point) continue;
                if(parent.Get<FunctionInterpreter>().Name == FunctionNames.LineHints) continue;
                var treeViewItem = NewItem(node, showIcon);
                var treeItem = FindTreeItem(parent);
                if(treeItem != null)
                    AddItem(treeItem, treeViewItem);
            }
        }

        private TreeViewItem FindTreeItem(Node node)
        {
            foreach (TreeViewItem item in _treeView.Items)
            {
                if (item.Tag == node) return item;
                var result = FindTreeItem(node, item);
                if (result != null)
                    return result;
            }
            return null;
        }

        private static TreeViewItem FindTreeItem(Node node, ItemsControl treeViewItem)
        {
            foreach (TreeViewItem item in treeViewItem.Items)
            {
                if (item.Tag == node) return item;
                var result = FindTreeItem(node, item);
                if (result != null)
                    return result;
            }
            return null;
        }


        private void AddGlobalElement(Node node, bool showIcon)
        {
            _treeView.Items.Add(NewExpandedItem(node.Get<FunctionInterpreter>().Name, node, showIcon));
        }

        private void AddPlaneElement(Node node, bool showIcon)
        {
            _treeView.Items.Add(NewExpandedItem(node.Get<StringInterpreter>().Value, node, showIcon));
        }

        private TreeViewItem NewItem(Node node, bool showIcon)
        {
            var result = NewItem(node.Get<StringInterpreter>().Value, node, showIcon);
            return result;
        }

        private TreeViewItem NewExpandedItem(Node node, bool showIcon)
        {
            var result = NewExpandedItem(node.Get<StringInterpreter>().Value, node, showIcon);
            return result;
        }

        private TreeViewItem NewItem(string nodeText, Node node, bool showIcon)
        {
            var functionName = FunctionUtils.GetFunctionName(node);
            var pan = new StackPanel { Orientation = Orientation.Horizontal };
            if (showIcon)
            {
                var iconName = GetIconName(functionName);
                if (!String.IsNullOrEmpty(iconName))
                {
                    var image = new Image { Height = 16, Width = 16, Source = _imageBitmapCache.GetImageFromName(iconName) };

                    pan.Children.Add(image);
                    image.VerticalAlignment = VerticalAlignment.Center;
                }
            }
            SetTextBlock(node, nodeText, pan);
            return new TreeViewItem
            {
                Header = pan,
                IsExpanded = false,
                Tag = node
            };
        }

        private TreeViewItem NewExpandedItem(string nodeText, Node node, bool showIcon)
        {
            var result = NewItem(nodeText, node, showIcon);
            result.IsExpanded = true;
            return result;
        }

        private static bool NodeIsFunction(string nodeTypeName)
        {
            return _constraintFunctions.Contains(nodeTypeName);
        }

        private static bool NodeIsUsingSketchFunctions(string nodeTypeName)
        {
            return _usingSketchFunctions.Contains(nodeTypeName);
        }

        private static bool NodeIsGlobalFunctions(string nodeTypeName)
        {
            return _globalFunctions.Contains(nodeTypeName);
        }

        private static bool NodeIs3dShapesFunctions(string nodeTypeName)
        {
            return _3dShapesFunctions.Contains(nodeTypeName);
        }

        private static bool NodeIsOnSketchFunctions(string nodeTypeName)
        {
            return _onSketchFunctions.Contains(nodeTypeName);
        }

        private static void InitializeListsOfFunctionNames()
        {
            _constraintFunctions.AddRange(typeof(Constraint2DNames).GetMembers().
                Select(constraint => constraint.Name));
            _globalFunctions.AddRange(new[] { FunctionNames.Fillet });
            _3dShapesFunctions.AddRange(new[] { FunctionNames.Sphere, FunctionNames.Box, FunctionNames.Cylinder,
            FunctionNames.Torus, FunctionNames.Cone});
            _usingSketchFunctions.AddRange(new[] { FunctionNames.Extrude, FunctionNames.Revolve });
            _onSketchFunctions.AddRange(new[] { FunctionNames.Circle, FunctionNames.Arc,
                FunctionNames.LineTwoPoints, FunctionNames.Ellipse, FunctionNames.WireTwoPoints});//add others here when implemented
            
        }

        private void ClearElementLists()
        {
            _sketchNodes.Clear();
            _globalNodes.Clear();
            _onSketchNodes.Clear();
            _usingSketchNodes.Clear();
            _pointNodes.Clear();
            _constraintNodes.Clear();
            _3dShapeNodes.Clear();
            _planeNodes.Clear();
            _hintNodes.Clear();
        }

        private string GetIconName(string functionName)
        {
            var capabilityBuilder = _capabilties.GetConcept(functionName);
            if (capabilityBuilder.Node == null)
                capabilityBuilder = _capabilties.GetConcept(ConceptNames.None);
            return capabilityBuilder.GetCapability(ShapeCapabilitiesNames.DefaultIcon);
        }

        public void SetShapesCapabilities(CapabilitiesCollection capabilitiesCollection,
                                  ImageBitmapCache imageBitmapCache)
        {
            _capabilties = capabilitiesCollection;
            _imageBitmapCache = imageBitmapCache;
        }

        private void SetTextBlock(Node node, string text, Panel pan)
        {
            var tb = new TextBlock { Text = text };
            if (node.Get<IntegerInterpreter>() != null &&
                node.Get<IntegerInterpreter>().Value == (int)ObjectVisibility.Hidden)
            {
                tb.Foreground = new SolidColorBrush(Color.FromRgb(96, 96, 0x60));
            }
            tb.Margin = new Thickness(5, 0, 0, 0);
            pan.Children.Add(tb);
            tb.VerticalAlignment = VerticalAlignment.Center;
        }
    }
}