#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using Naro.Infrastructure.Interface;
using NaroConstants.Names;
using NaroSketchAdapter.Views;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PropertyDescriptorsInterface
{
    public abstract class GridTabBase
    {
        public readonly UiTabGenerator PropertyListGenerator = new UiTabGenerator();
        private IPropertyGridView _parentGrid;
        protected ViewInfo _viewInfo;

        protected GridTabBase(string title)
        {
            Title = title;
        }

        protected Node Parent { get; private set; }
        protected Node SecondNode { get; private set; }
        protected List<Node> Nodes { get; private set; }

        protected NodeBuilder Builder
        {
            get { return new NodeBuilder(Parent); }
        }

        public StackPanel Control { get; private set; }
        public String Title { get; private set; }
        public int TabChildCount { get; set; }

        public void SetParentGrid(IPropertyGridView parentGrid)
        {
            _parentGrid = parentGrid;
        }

        public void RefreshNode(StackPanel stackPanel, Node parent, ViewInfo viewInfo,
                                IEnumerable<string> filteringTokens)
        {
            Parent = parent;
            UpdateViewInfo(viewInfo);
            PropertyListGenerator.RemoveAll();
            BuildInterface();
            RefreshControl(stackPanel, filteringTokens);
        }

        public void RefreshNodes(StackPanel stackPanel, Node firstNode, Node secondNode, ViewInfo viewInfo,
                               IEnumerable<string> filteringTokens)
        {
            Parent = firstNode;
            SecondNode = secondNode;
            UpdateViewInfo(viewInfo);
            PropertyListGenerator.RemoveAll();
            BuildInterface();
            RefreshControl(stackPanel, filteringTokens);
        }

        public void RefreshNode(StackPanel stackPanel, List<SceneSelectedEntity> nodes, ViewInfo viewInfo,
                                IEnumerable<string> filteringTokens)
        {
            if(Nodes == null)
                Nodes = new List<Node>();
            else
                Nodes.Clear();
            foreach(var sse in nodes)
                Nodes.Add(sse.Node);
            UpdateViewInfo(viewInfo);
            PropertyListGenerator.RemoveAll();
            BuildInterface();
            RefreshControl(stackPanel, filteringTokens);
        }

        protected abstract void BuildInterface();

        private void UpdateViewInfo(ViewInfo viewInfo)
        {
            _viewInfo = viewInfo;
        }

        protected void BeginUpdate()
        {
            _viewInfo.BeginUpdate();
        }

        protected void EndUpdate(string reason)
        {
            _viewInfo.EndUpdate(reason);
            _parentGrid.RefreshGrid();
        }

        protected void EndVisualUpdate(string reason)
        {
            var successfullApply = true;
            if (Builder.Node != null)
                successfullApply = Builder.ExecuteFunction();
            if (successfullApply)
                _viewInfo.EndVisualUpdate(reason);
            else
                _viewInfo.RevertVisualUpdate();
            _parentGrid.RefreshGrid();
        }

        public virtual void SetTabOrder(int tabIndex)
        {
        }

        private void RefreshControl(StackPanel stackPanel, IEnumerable<string> filteringTokens)
        {
            Control = stackPanel;
            PropertyListGenerator.PopulateControl(stackPanel, filteringTokens);
        }

        private void AddConstraintToOneField(string functionName, int childIndex)
        {
            NodeBuilderUtils.AddConstraintToOneField(_viewInfo.Document, Parent, functionName, childIndex);
        }

        private void AddConstraintToOneField(string functionName, double value)
        {
            NodeBuilderUtils.AddConstraintToOneField(_viewInfo.Document, Parent, functionName, value);
        }

        protected void UpdateLock(bool islocked, string functionName, int index)
        {
            BeginUpdate();
            if (!islocked)
                NodeBuilderUtils.RemoveShapeThatReferenceCurrent(Parent, functionName, _viewInfo.Document);
            else
                AddConstraintToOneField(functionName, index);
            EndVisualUpdate("Update constraint");
        }

        protected void UpdateLock(bool islocked, string functionName, double value)
        {
            BeginUpdate();
            var constraint = NodeBuilderUtils.ShapeHasConstraint(Parent, functionName, _viewInfo.Document);
            if (constraint != -1)
            {
                _viewInfo.Document.Root.Remove(constraint);
            }
            else
            {
                AddConstraintToOneField(functionName, value);
            }
            EndVisualUpdate("Update constraint");
        }

        protected void UpdateLineLock()
        {
            BeginUpdate();
           
            var constraint = NodeBuilderUtils.ShapeHasConstraint(Parent, Constraint2DNames.LineLengthFunction, _viewInfo.Document);
            if (constraint != -1)
            {
                _viewInfo.Document.Root.Remove(constraint);
                // remove dimension
                var dimensionNodeIndex = 0;
                foreach(var child in _viewInfo.Document.Root.Children)
                {
                    if(child.Value.Get<FunctionInterpreter>().Name == FunctionNames.Dimension)
                    {
                        if(child.Value.Children[1].Get<ReferenceInterpreter>().Node.Index == Parent.Index)
                        {
                            dimensionNodeIndex = child.Value.Index;
                            break;
                        }
                    }
                }
                if(dimensionNodeIndex!= 0)
                    _viewInfo.Document.Root.Remove(dimensionNodeIndex);
                
            }
            else
            {
                NodeBuilderUtils.AddLengthAndDimensionConstraint(_viewInfo.Document, Parent, true);
            }
            EndVisualUpdate("Update constraint");
        }

        protected void UpdateCircleLock()
        {
            BeginUpdate();

            var constraint = NodeBuilderUtils.ShapeHasConstraint(Parent, Constraint2DNames.CircleRadiusFunction, _viewInfo.Document);
            if (constraint != -1)
            {
                _viewInfo.Document.Root.Remove(constraint);
            }
            else
            {
                NodeBuilderUtils.AddRadiusConstraint(_viewInfo.Document, Parent);//, value);
            }
            EndVisualUpdate("Update constraint");
        }

       
    }
}