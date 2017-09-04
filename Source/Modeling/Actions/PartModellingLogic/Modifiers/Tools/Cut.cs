#region Usings

using System.Collections.Generic;
using System.Windows.Forms;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Algo;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Constants;
using OccCode;
using PartModellingLogic.UI.Views.Shapes;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using NaroPipes.Actions;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class Cut : DrawingAction3D
    {
        private Node _currentSelectedNode;
        private SceneSelectedEntity _selectedNode;
        private NodeBuilder cutBuilder;
        public Cut() : base(ModifierNames.Cut)
        {
            DependsOn(InputNames.CommandLinePrePusher);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            var sketchBuilder = new SketchCreator(Document, false);
            var sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode != null)
            {
                ActionsGraph.SwitchAction(ModifierNames.EndSketch, ModifierNames.Cut);
                return;
            }
            _selectedNode = null;
            PrePushItems();
            cutBuilder = new NodeBuilder(Document, FunctionNames.Cut);
            cutBuilder.ExecuteFunction();
            cutBuilder.Visibility = ObjectVisibility.Hidden;
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, cutBuilder.Node);
            if (_selectedNode == null)
            {
                var selectedShape = GeomUtils.GetCurrentSelectedShape(Context);
                if (selectedShape != null)
                {
                    _selectedNode = GeomUtils.IdentifyNode(Document.Root, selectedShape);
                    if (_selectedNode != null)
                    {
                        _currentSelectedNode = _selectedNode.Node;
                        cutBuilder[2].Integer = (int)CutTypes.ThroughAll;
                        ApplyCut();
                    }
                }
                else
                {
                    // Experimental code, needs review 
                    _currentSelectedNode = TreeView.GetSelectedNode();
                    if (_currentSelectedNode == null)
                        return;
                    _selectedNode = new SceneSelectedEntity(_currentSelectedNode);
                }
            }
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                TopAbsShapeEnum.TopAbs_SOLID);
        }

        private void PrePushItems()
        {
            var prePusher = Inputs[InputNames.CommandLinePrePusher];
            var result = (List<object>) prePusher.GetData(NotificationNames.GetValue).Data;
            if (result.Count > 0)
                _selectedNode = (SceneSelectedEntity) (result[0]);
            prePusher.Send(NotificationNames.Reset);
        }

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            base.OnMouseUpAction(mouseData);

                var entities = Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
                if (entities.Count <= 0)
                    return;
                _selectedNode = new SceneSelectedEntity(entities[0].Node);
                ApplyCut();
            
        }

        private void ResetWorkingPlane()
        {
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, new DataPackage(null));
        }

        private void ApplyCut()
        {
            var cutType = cutBuilder[2].Integer;
            var cutDepth = cutBuilder[1].Real;
            Document.Transact();
            var sketchNode = AutoGroupLogic.FindSketchNode(_selectedNode.Node);
            // Apply Cut on it
            cutBuilder = new NodeBuilder(TreeUtils.Cut(Document, sketchNode, cutDepth, cutType == 0? CutTypes.ToDepth:CutTypes.ThroughAll));
            if (cutBuilder == null)
                Document.Revert();
            else
            {
                cutBuilder.ExecuteFunction();
                NodeUtils.SetSketchTransparency(Document, sketchNode, ObjectVisibility.Hidden);
                // Commit
                Document.Commit("Apply Cut");
                UpdateView();
                AddNodeToTree(cutBuilder.Node);
                ResetWorkingPlane();
            }
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
            BackToNeutralModifier();
            //Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
            
        }
    }
}