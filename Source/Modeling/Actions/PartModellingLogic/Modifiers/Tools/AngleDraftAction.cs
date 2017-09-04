#region Usings

using System;
using System.Collections.Generic;
using ErrorReportCommon.Messages;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Constants;
using NaroUiControls.Values;
using OccCode;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.gp;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    internal class AngleDraftAction : DrawingLiveShape
    {
        private readonly gpAx1 _axis;
        private readonly List<SceneSelectedEntity> _entities;
        private SceneSelectedEntity _selectedNode;

        private ToolRangeValuesWindow _sizeWindow;
        private Stages _stage;

        public AngleDraftAction()
            : base(ModifierNames.AngleDraftEnhanced)
        {
            _entities = new List<SceneSelectedEntity>();
            _axis = gp.OZ;
        }

        private void NextStage()
        {
            _stage++;
        }

        /// <summary>
        ///   Called when notified that the FacPicker detected a new face selected.
        /// </summary>
        protected override void FacePicked(TopoDSFace face)
        {
            base.FacePicked(face);
            if (face == null) return;

            _selectedNode = GeomUtils.IdentifyNode(Document.Root, face);
            //var selectedNodes = ActionsGraph[InputNames.SelectionContainerPipe].Get<List<SceneSelectedEntity>>();
            //if (selectedNodes.Count == 0)
            //{
            //    if(_stage == Stages.None) 
            //        BackToNeutralModifier();
            //    return;
            //}
            //_selectedNode = selectedNodes[0];
        }

        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            if (!mouseData.MouseDown)
                return;
            if (_stage >= Stages.SecondShape) return;
            if (_selectedNode == null) return;
            if (_entities.Count != 0 && _selectedNode.ShapeCount == _entities[0].ShapeCount) return;
            _entities.Add(_selectedNode);
            NextStage();

            if (_stage != Stages.SecondShape) return;
            if (_sizeWindow != null)
                return;

            var referenceShapeDirection = GeomUtils.ExtractDirection(_entities[1].TargetShape());
            if(referenceShapeDirection == null)
            {
                NaroMessage.Show("Invalid face selected!");
                return;
            }
            _axis.Direction = referenceShapeDirection;

            ActionsGraph[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
            ActionsGraph[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                 TopAbsShapeEnum.TopAbs_SOLID);

            //_sizeWindow = new ToolRangeValuesWindow(-Math.PI/2, Math.PI/2, "Angle Draft");
            _sizeWindow = new ToolRangeValuesWindow(-90, 90, "Angle Draft");
            _sizeWindow.OnValueChange += PreviwFillet;
            _sizeWindow.OnDialogClosed += OnClosed;
            _sizeWindow.Show();
        }

        public override void OnActivate()
        {
            base.OnActivate();
            var sketchBuilder = new SketchCreator(Document, false);
            var sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode != null)
            {
                ActionsGraph.SwitchAction(ModifierNames.EndSketch, ModifierNames.AngleDraftEnhanced);
                return;
            }
            _sizeWindow = null;
            _stage = Stages.None;
            _entities.Clear();
            ActionsGraph[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                 TopAbsShapeEnum.TopAbs_FACE);
            ActionsGraph[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
        }

        public override void OnDeactivate()
        {
            InitSession();
            ActionCleanup();
            base.OnDeactivate();
        }

        private void OnClosed()
        {
            InitSession();
            if (_sizeWindow.Result)
            {
                var nodeBuilder = BuildPreview();
                Document.Commit("Applied Angle Draft");
                UpdateView();
                ActionsGraph[InputNames.UiElementsItem].Send(NotificationNames.AddNewNodeToTree, nodeBuilder.Node);
            }
            ActionCleanup();
            BackToNeutralModifier();
        }

        private void ActionCleanup()
        {
            ActionsGraph[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
            ActionsGraph[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                 TopAbsShapeEnum.TopAbs_SOLID);
            _sizeWindow = null;
        }

        private void PreviwFillet()
        {
            InitSession();
            BuildPreview();
            UpdateView();
        }

        private NodeBuilder BuildPreview()
        {
            var builder = new NodeBuilder(Document, FunctionNames.AngleDraft);
            builder[0].ReferenceData = _entities[0];
            builder[1].ReferenceData = _entities[1];
            builder[2].Axis3D = new Axis(_axis);
            builder[3].Real = _sizeWindow.Value*Math.PI / 180;
            builder.ExecuteFunction();
            return builder;
        }

        #region Nested type: Stages

        private enum Stages
        {
            None,
            FirstShape,
            SecondShape,
            Angle
        }

        #endregion
    }
}