#region Usings

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Naro.Infrastructure.Interface.Views;
using Naro.Infrastructure.Library.Qos;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroSetup;
using NaroSketchSolveTests;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.Capabilities;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingUi.Layout
{
    /// <summary>
    ///   Interaction logic for WpfTreeView.xaml
    /// </summary>
    public partial class WpfTreeView : ITreeViewControl
    {
        private readonly ImageBitmapCache _imageBitmapCache;
        private ActionsGraph _actionsGraph;

        private SketchBasedTree _sketchPopulateLogic;

        public WpfTreeView()
        {
            InitializeComponent();
            _populateLogic.TreeView = TreeView;
            _sketchPopulateLogic = new SketchBasedTree();
            _imageBitmapCache = new ImageBitmapCache();
            searchControl.TokensChanged += UpdateFilter;
            var qosLock = QosFactory.Instance.Create(QosNames.TreeViewPopulate, 120,
                                                     "Populating Tree View took too long! A way to improve performance is to disable icon displaying.  Do you want to disable them?");
            qosLock.TestPayload += TreeViewPopulateTestPayload;
            qosLock.Payload += TreeViewPopulatePayload;
            IsVisibleChanged += OnIsVisibleChanged;
        }

        private void OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
           if((bool)dependencyPropertyChangedEventArgs.NewValue)
           {
               var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
               var showIcon = optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle).GetBoolValue(2);

               var document = CurrentActionGraph[InputNames.Document].Get<Document>();
               _sketchPopulateLogic.Setup(document, TreeView);

               var qosLock = QosFactory.Instance.Get(QosNames.TreeViewPopulate);

               qosLock.Begin();
               _sketchPopulateLogic.Update(showIcon);
               qosLock.End();

           }
        }

        #region ITreeViewControl Members

        public event SelectedLabelEventHandler SelectedLabel;
        public event SelectedLabelEventHandler MouseLeaveTree;

        public void ClearCache()
        {
            // _populateLogic.ResetTreeCache();
        }

        public void LoadTree(Node nodes)
        {
            _populateLogic.LastNode = nodes;
            var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var showIcon = optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle).GetBoolValue(2);

            var document = CurrentActionGraph[InputNames.Document].Get<Document>();
            _sketchPopulateLogic.Setup(document, TreeView);

            var qosLock = QosFactory.Instance.Get(QosNames.TreeViewPopulate);

            qosLock.Begin();
            _sketchPopulateLogic.Update(showIcon);
            qosLock.End();
        }

        public void AddNode(Node node)
        {
            Ensure.IsNotNull(node);
            _populateLogic.LastNode = node;
            var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var showIcon = optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle).GetBoolValue(2);

            var qosLock = QosFactory.Instance.Get(QosNames.TreeViewPopulate);
            qosLock.Begin();
            _sketchPopulateLogic.AddTreeNode(node, showIcon);
            //_populateLogic.AddTreeNode(node, showIcon);
            qosLock.End();
        }

        public void SelectNode(Node label)
        {
            if(label != null && !label.Get<DrawingAttributesInterpreter>().EnableSelection)
                return;
            
            if (label != null)
            {
                var document = _actionsGraph[InputNames.CurrentDocumentInput].GetData(NotificationNames.GetValue).Get<Document>();
               
                var node = FindTreeNode(TreeView.Items, label);
                var nodeBuilder = new NodeBuilder(label);
                document.Commit("");
                document.Transact();
                for (int i = 0; i < 3; i++)
                {
                    var nb = new NodeBuilder(label.Root.Children[i]);
                    if (nb.FunctionName == FunctionNames.Plane)
                        nb.Visibility = nb.Node.Index == nodeBuilder.Node.Index ? ObjectVisibility.ToBeDisplayed : ObjectVisibility.Hidden;
                }
                if (node == null) return;
                node.IsSelected = true;
                document.Commit("Node selected");
                ShowChange();
            }
            else
            {
                if (TreeView.SelectedItem == null)
                    return;
                ((TreeViewItem)TreeView.SelectedItem).IsSelected = false;
                ShowChange();
                return;
            }
            
        }

        public Node GetSelectedNode()
        {
            var treeViewItem = (TreeViewItem)TreeView.SelectedItem;

            return treeViewItem == null || treeViewItem.Tag == null ? null : (Node)treeViewItem.Tag;
        }

        public void SetShapesCapabilities(CapabilitiesCollection capabilitiesCollection)
        {
            //TO DO: code review here
            _sketchPopulateLogic.SetShapesCapabilities(capabilitiesCollection, _imageBitmapCache);
        }

        #endregion

        #region Members

        private readonly TreeViewPopulateLogic _populateLogic = new TreeViewPopulateLogic();

        #endregion

        private void TreeViewPopulatePayload()
        {
            var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            optionsSetup.Document.Transact();
            optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle).SetValue(2, false);
            optionsSetup.Document.Commit("Changed options");
        }

        private bool TreeViewPopulateTestPayload()
        {
            var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            return optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle).GetBoolValue(2);
        }
        private ActionsGraph CurrentActionGraph
        {
            get
            {
                return _actionsGraph[InputNames.CurrentDocumentInput].GetData(NotificationNames.GetContainer).Get
                    <ActionsGraph>();
            }
        }
        public void Setup(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;

        }

        private void UpdateFilter()
        {
            _populateLogic.FilterTokens = searchControl.UpperKeyTokens;
            var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var showIcon = optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle).GetBoolValue(2);
            _populateLogic.LoadTree(_populateLogic.LastNode, showIcon);
        }

        private static void ShowChange()
        {
            //ObjectsTreeList.Select();
        }

        private static TreeViewItem FindTreeNode(ItemCollection nodes, Node label)
        {
            foreach (TreeViewItem node in nodes)
            {
                var nodeLabel = node.Tag as Node;

                if ((nodeLabel != null) && (nodeLabel == label))
                    return node;

                var foundNode = FindTreeNode(node.Items, label);
                if (foundNode == null) continue;
                return foundNode;
            }

            return null;
        }

        /// <summary>
        ///   When one item from the tree is selected, extract the label from the Node.Tag and inform listeners
        ///   that a Node containing a Label was selected.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        private void TreeViewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (TreeView == null || TreeView.SelectedItem == null)
                return;

            if (SelectedLabel != null && ((TreeViewItem)TreeView.SelectedItem).Tag != null)
                SelectedLabel((TreeView.SelectedItem as TreeViewItem).Tag as Node);
        }
    }
}