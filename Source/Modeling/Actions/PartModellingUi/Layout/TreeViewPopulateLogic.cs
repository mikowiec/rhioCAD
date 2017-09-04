#region Usings

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Interface.Views;
using NaroConstants.Names;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.Capabilities;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingUi.Layout
{
    internal class TreeViewPopulateLogic
    {
        private readonly SortedDictionary<int, int> _usedTreeIndexes;
        internal List<string> FilterTokens = new List<string>();
        private CapabilitiesCollection _capabilties;
        private ImageBitmapCache _imageBitmapCache;

        public TreeViewPopulateLogic()
        {
            _usedTreeIndexes = new SortedDictionary<int, int>();
        }

        public Node LastNode { get; set; }

        public TreeView TreeView { private get; set; }

        public void LoadTree(Node nodes, bool showIcon)
        {
            LastNode = nodes;
            Ensure.IsNotNull(nodes);

            var root = nodes.Root;
            TreeView.Items.Clear();

            _usedTreeIndexes.Clear();
            var shapesNode = new TreeViewItem {Header = "Shapes", IsExpanded = true};
            BuildTreeNodes(root, shapesNode, 0, showIcon);

            TreeView.Items.Add(shapesNode);
        }

        public void AddTreeNode(Node node, bool showIcon)
        {
            var item = (TreeViewItem) (TreeView.Items[0]);
            var itemToAdd = CreateChildNode(item, node, showIcon);
            var passFiltering = BuildTreeNodes(node, itemToAdd, 1, showIcon);
            if (!passFiltering)
                item.Items.Remove(itemToAdd);
        }


        private bool NodePassFiltering(Node node)
        {
            if (node == null) throw new ArgumentNullException("node");
            return node.Get<StringInterpreter>() != null &&
                   FilteringUtils.PassFiltering(node.Get<StringInterpreter>().Value.ToUpper(), FilterTokens);
        }


        private bool BuildTreeNodes(Node parentLabel, TreeViewItem parentNode, int level, bool showIcon)
        {
            level++;
            if (level > 5)
                return true;
            if (level == 2)
            {
                try
                {
                    var nodeIndex = parentLabel.Index;
                    //Ensure.IsNotTrue(_usedTreeIndexes.ContainsKey(nodeIndex));
                    _usedTreeIndexes[nodeIndex] = 0;
                }
                catch
                {
                    return true;
                }
            }
            LevelBasedExpanding(level, parentNode);

            var mainPassFiltering = NodePassFiltering(parentLabel);

            foreach (var label in parentLabel.Children.Values)
            {
                var passFiltering = false;
                if (HasReferencesInsideNode(label))
                    BuildReferencesNode(level, ref passFiltering, ref parentNode, label, showIcon);
                if (NeedToContinue(label))
                    continue;

                var childNode = CreateChildNode(parentNode, label, showIcon);

                foreach (var childLabel in label.Children.Values)
                {
                    BuildReferencesNode(level, ref passFiltering, ref childNode, childLabel, showIcon);
                }

                var shouldBeAdded = passFiltering || NodePassFiltering(label);
                if (shouldBeAdded)
                    mainPassFiltering = true;
                else
                    parentNode.Items.Remove(childNode);
            }

            return mainPassFiltering;
        }

        private static void LevelBasedExpanding(int level, TreeViewItem parentNode)
        {
            parentNode.IsExpanded = (level <= 1);
        }

        private void BuildReferencesNode(int level, ref bool passFiltering,
                                         ref TreeViewItem childNode, Node childLabel, bool showIcon)
        {
            if (childLabel.Get<ReferenceInterpreter>() != null && childLabel.Get<ReferenceInterpreter>().Node != null)
            {
                var referenceNode = childLabel.Get<ReferenceInterpreter>().Node;
                var functionName = FunctionUtils.GetFunctionName(referenceNode);
                if (functionName == FunctionNames.SubShape)
                {
                    referenceNode = new NodeBuilder(referenceNode)[0].Reference;
                }
                if (BlockCircularReferences(childLabel, referenceNode))
                {
                    BuildReferencedChildNode(level, ref passFiltering, ref childNode, referenceNode, showIcon);
                }
            }

            if (childLabel.Get<ReferenceListInterpreter>() != null)
            {
                BuildReferencedListChildrenNodes(level, ref passFiltering, ref childNode, childLabel, showIcon);
            }
        }

        private static bool BlockCircularReferences(Node childLabel, Node referenceNode)
        {
            return !string.IsNullOrEmpty(referenceNode.Path) && childLabel.Parent != null &&
                   childLabel.Parent.Index > referenceNode.Index;
        }

        private void BuildReferencedListChildrenNodes(int level,
                                                      ref bool passFiltering, ref TreeViewItem childNode,
                                                      Node childLabel, bool showIcon)
        {
            var childLabels = childLabel.Get<ReferenceListInterpreter>().Nodes;
            foreach (var newChild in childLabels)
            {
                if (!NodePassFiltering(newChild.Node)) continue;
                passFiltering = true;
                var newChildNode = CreateChildNode(childNode, newChild.Node, showIcon);
                SetTreeLabel(newChildNode, newChild.Node, showIcon);
                BuildTreeNodes(newChild.Node, newChildNode, level, showIcon);
            }
        }

        private void BuildReferencedChildNode(int level, ref bool passFiltering,
                                              ref TreeViewItem childNode, Node childLabel, bool showIcon)
        {
            var newChild = childLabel;
            if (!NodePassFiltering(newChild)) return;
            passFiltering = true;
            var newChildNode = CreateChildNode(childNode, childLabel, showIcon);
            SetTreeLabel(newChildNode, childLabel, showIcon);
            BuildTreeNodes(newChild, newChildNode, level, showIcon);
        }

        private static bool NeedToContinue(Node node)
        {
            var function = node.Get<FunctionInterpreter>();
            var strInterpreter = node.Get<StringInterpreter>();
            var treeVisibility = node.Get<TreeViewVisibilityInterpreter>();

            var needToContinue = (function == null || strInterpreter == null || treeVisibility != null);
            return needToContinue;
        }

        private static bool HasReferencesInsideNode(Node node)
        {
            var reference = node.Get<ReferenceInterpreter>();
            var referenceList = node.Get<ReferenceListInterpreter>();
            var hasReference = reference != null || referenceList != null;
            return hasReference;
        }

        private TreeViewItem CreateChildNode(ItemsControl parentNode, Node label, bool showIcon)
        {
            var childNode = AddNodeToTree(parentNode);
            SetTreeLabel(childNode, label, showIcon);

            return childNode;
        }

        public void SetShapesCapabilities(CapabilitiesCollection capabilitiesCollection,
                                          ImageBitmapCache imageBitmapCache)
        {
            _capabilties = capabilitiesCollection;
            _imageBitmapCache = imageBitmapCache;
        }

        private static TreeViewItem AddNodeToTree(ItemsControl parent)
        {
            var result = new TreeViewItem {IsExpanded = true};
            parent.Items.Add(result);
            return result;
        }

        private bool SetTreeLabel(HeaderedItemsControl treeNode, Node node, bool showIcon)
        {
            try
            {
                var functionName = FunctionUtils.GetFunctionName(node);
                var text = node.Get<StringInterpreter>().Value;
                var pan = new StackPanel {Orientation = Orientation.Horizontal};

                if (showIcon)
                {
                    var iconName = GetIconName(functionName);
                    if (!String.IsNullOrEmpty(iconName))
                    {
                        var image = new Image
                                        {Height = 16, Width = 16, Source = _imageBitmapCache.GetImageFromName(iconName)};

                        pan.Children.Add(image);
                        image.VerticalAlignment = VerticalAlignment.Center;
                    }
                }
                SetTextBlock(node, text, pan);

                treeNode.Header = pan;
                treeNode.Tag = node;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void SetTextBlock(Node node, string text, Panel pan)
        {
            var tb = new TextBlock {Text = text};
            if (node.Get<IntegerInterpreter>() != null &&
                node.Get<IntegerInterpreter>().Value == (int) ObjectVisibility.Hidden)
            {
                tb.Foreground = new SolidColorBrush(Color.FromRgb(96, 96, 0x60));
            }
            tb.Margin = new Thickness(5, 0, 0, 0);
            pan.Children.Add(tb);
            tb.VerticalAlignment = VerticalAlignment.Center;
        }

        private string GetIconName(string functionName)
        {
            var capabilityBuilder = _capabilties.GetConcept(functionName);
            if (capabilityBuilder.Node == null)
                capabilityBuilder = _capabilties.GetConcept(ConceptNames.None);
            return capabilityBuilder.GetCapability(ShapeCapabilitiesNames.DefaultIcon);
        }
    }
}