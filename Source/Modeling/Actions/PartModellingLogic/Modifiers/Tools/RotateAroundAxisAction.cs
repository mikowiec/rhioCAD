#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;
using NaroUiControls.Values;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.Capabilities;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Implements the Revolve modifier.
    /// </summary>
    public class RotateAroundAxisAction : DrawingLiveShape
    {
        private readonly List<Node> _selectedNodes = new List<Node>();
        private gpAx1 _axis;
        private NodeBuilder _builder;
        private CapabilitiesCollection _collection;
        private ToolRangeValuesWindow _sizeWindow;

        public RotateAroundAxisAction()
            : base(ModifierNames.RotateAroundAxis)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();

            DependsOn(InputNames.GlobalCapabilitiesInput);
        }

        protected override void OnTreeNodeSelect(Node node)
        {
            OnShapePicked(node);
        }

        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            Ensure.IsNotNull(Document);

            OnSceneShapePicked();
        }

        private void OnSceneShapePicked()
        {
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            if (entities.Count <= 0)
                return;
            OnShapePicked(entities[0].Node);
        }


        private bool IsNodeValid(int dependencyIndex, Node node)
        {
            var builder = new NodeBuilder(node);
            if (dependencyIndex != 1)
                return true;
            if (!_collection.HasConcept(builder.FunctionName))
                return false;
            if (!_collection.IsRelatedWith(builder.FunctionName, ConceptNames.Axis))
                return false;
            try
            {
                _axis = GeomUtils.ExtractAxis(builder.Shape);
                Ensure.IsNotNull(_axis);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void OnShapePicked(Node node)
        {
            if (!IsNodeValid(_selectedNodes.Count, node))
                return;
            if (_selectedNodes.Count > 0 && _selectedNodes[0].Index == node.Index)
                return;
            SelectShape(node);
            _selectedNodes.Add(node);
            UpdateShapeSelection();
        }

        private void UpdateShapeSelection()
        {
            if (_selectedNodes.Count < 2) return;
            BuildDialog("Rotate around axis angle");
        }

        private void BuildDialog(string dialogTitle)
        {
            if (_sizeWindow != null)
                return;
            _builder = new NodeBuilder(_selectedNodes[0]);
            _axis = GeomUtils.ExtractAxis(new NodeBuilder(_selectedNodes[1]).Shape);
            _sizeWindow = new ToolRangeValuesWindow(-360, 360, dialogTitle);
            _sizeWindow.OnValueChange += PreviewRotate;
            _sizeWindow.OnDialogClosed += OnClosed;
            _sizeWindow.Show();
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _collection = Inputs[InputNames.GlobalCapabilitiesInput].Get<CapabilitiesCollection>();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Reset();
        }

        private void Reset()
        {
            Context.Select(true);
            _selectedNodes.Clear();
        }

        private void PreviewRotate()
        {
            InitSession();
            PerformRotate(_builder, _sizeWindow.Value);
            UpdateView();
        }

        private void PerformRotate(NodeBuilder nodeBuilder, double value)
        {
            if (!NodeUtils.NodeIsOnSketch(nodeBuilder))
            {
                var existingFaces = NodeUtils.GetDocumentFaces(Document);
                var list = NodeBuilderUtils.GetAllContained3DNodesIndexes(nodeBuilder.Node).Distinct().ToList();
                var sketchNodes = new List<Node>();
                foreach (var nodeIndex in list)
                {
                    var node = Document.Root[nodeIndex.Key];
                    var affectedSketchNode = NodeUtils.RotateNode(new NodeBuilder(node), Document,
                                                                             _axis, value);
                    if (affectedSketchNode != null)
                        sketchNodes.Add(affectedSketchNode);
                }

                foreach (var sketchNode in sketchNodes)
                {
                    sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, Document);
                    if (sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape != null)
                    {
                        if (nodeBuilder.Visibility == ObjectVisibility.Hidden)
                            nodeBuilder.Visibility = ObjectVisibility.ToBeDisplayed;
                    }
                }

                var newFaces = NodeUtils.GetDocumentFaces(Document);
                foreach (int face in newFaces.Except(existingFaces))
                {
                    Document.Root.Remove(face);
                }
            }
            else
            {
                NodeUtils.RotateSketchNode(nodeBuilder, _axis, value);
            }
        }

        private void OnClosed()
        {
            var rotationValue = _sizeWindow.Value;
            var dialogResult = _sizeWindow.Result;
            _sizeWindow = null;
            InitSession();
            if (!dialogResult)
            {
                BackToNeutralModifier();
                return;
            }
            PerformRotate(_builder, rotationValue);
            
            // Finish the transaction
            CommitFinal("Apply Rotate Axis");

            // Change back to selection mode
            BackToNeutralModifier();
        }

        public override void OnDeactivate()
        {
            if (_sizeWindow != null)
            {
                _sizeWindow.Close();
                _sizeWindow = null;
            }
            base.OnDeactivate();
        }
    }
}