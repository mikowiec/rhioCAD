#region Usings

using Naro.Infrastructure.Interface.Views;
using NaroConstants.Names;
using NaroPipes.Actions;
using PropertyDescriptorsInterface;
using TestBuilderPlugin.View;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using System.Collections.Generic;
#endregion

namespace MetaActionsInterface
{
    public class UiElementsItem : PipeBase
    {
        private readonly BooView _booView;
        private readonly IHelpView _helpView;
        private readonly ILayerView _layerView;
        private readonly ITreeViewControl _treeView;
        private readonly IPropertyGridView _wpfPropertyView;

        public UiElementsItem(ITreeViewControl treeView, IPropertyGridView wpfPropertyView, ILayerView layerView,
                              IHelpView helpView, BooView booView)
            : base(InputNames.UiElementsItem)
        {
            _treeView = treeView;
            _helpView = helpView;
            _booView = booView;
            _wpfPropertyView = wpfPropertyView;
            _layerView = layerView;
        }

        private void RefreshTreeWithLastNode(Node node)
        {
            var lastLabelAdded = node;
            if (node == null)
                lastLabelAdded = _treeView.GetSelectedNode();
            if (NodeIsSelectable(lastLabelAdded))
            {
                _treeView.SelectNode(lastLabelAdded);
                _wpfPropertyView.OnSelectNode(lastLabelAdded);
            }
            _layerView.Refresh();
        }

        private bool NodeIsSelectable(Node node)
        {
      //      var functionaName = node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name;
            return true;
        }

        private void RebuildTreeView(DataPackage dataObject)
        {
            var document =
                ActionsGraph[InputNames.CurrentDocumentInput].GetData(NotificationNames.GetValue).Get<Document>();
            _treeView.LoadTree(document.Root);
        }

        private void RefreshPropertyTab(DataPackage dataObject)
        {
            var node = dataObject.Get<Node>();
            _wpfPropertyView.OnSelectNode(node);
            _wpfPropertyView.RefreshGrid();
        }

        private void RefreshPropertyTabTwoSelections(DataPackage dataObject)
        {
            var nodes = dataObject.Get<List<SceneSelectedEntity>>();
            if (nodes.Count != 2)
                return;
            _wpfPropertyView.OnSelectNodes(nodes[0].Node, nodes[1].Node);
        }

        private void RefreshPropertyTabMultipleSelections(DataPackage dataObject)
        {
            var nodes = dataObject.Get<List<SceneSelectedEntity>>();
            switch(nodes.Count)
            {
                case 0:
                    break;
                case 1: 
                    RefreshTreeWithLastNode(nodes[0].Node);
                    break;
                case 2: _wpfPropertyView.OnSelectNodes(nodes[0].Node, nodes[1].Node);
                    break;
                default:
                    _wpfPropertyView.OnSelectNodes(nodes);
                    break;
            }
        }


        public override void OnRegister()
        {
            DependsOn(InputNames.CurrentDocumentInput);
            AddNotificationHandler(NotificationNames.SelectNode, SelectNode);
            AddNotificationHandler(NotificationNames.RebuildTreeView, RebuildTreeView);
            AddNotificationHandler(NotificationNames.RefreshPropertyTab, RefreshPropertyTab);
            AddNotificationHandler(NotificationNames.RefreshPropertyTabTwoSelections, RefreshPropertyTabTwoSelections);
            AddNotificationHandler(NotificationNames.RefreshPropertyTabMultipleSelections, RefreshPropertyTabMultipleSelections);
            AddNotificationHandler(NotificationNames.AddNewNodeToTree, HandleAddNode);
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
            AddNotificationHandler(NotificationNames.SetBooEditorText, HandleBooEditorText);
        }

        private void HandleBooEditorText(DataPackage data)
        {
            _booView.UpdateEditorText(data.Text);
        }

        private void HandleAddNode(DataPackage data)
        {
            var node = data.Get<Node>();
            _treeView.AddNode(node);
            _wpfPropertyView.OnSelectNode(node);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(new Items(_treeView, _wpfPropertyView, _layerView, _helpView, _booView));
        }

        private void SelectNode(DataPackage dataObject)
        {
             RefreshTreeWithLastNode(dataObject.Get<Node>());
        }

        public override void OnConnect()
        {
            AddData(new Items(_treeView, _wpfPropertyView, _layerView, _helpView, _booView));
            _wpfPropertyView.RefreshGrid();
        }

        #region Nested type: Items

        public class Items
        {
            private readonly ILayerView _layerView;

            public Items(ITreeViewControl treeView, IPropertyGridView wpfPropertyView, ILayerView layerView,
                         IHelpView helpView, BooView booView)
            {
                _layerView = layerView;
                TreeView = treeView;
                WpfPropertyView = wpfPropertyView;
                HelpView = helpView;
                BooView = booView;
            }

            public ITreeViewControl TreeView { get; private set; }
            public IPropertyGridView WpfPropertyView { get; private set; }

            public ILayerView LayerView
            {
                get { return _layerView; }
            }

            public IHelpView HelpView { get; private set; }
            public BooView BooView { get; private set; }
        }

        #endregion
    }
}