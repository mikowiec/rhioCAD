#region Usings

using System;
using System.Collections.Generic;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    public class BlockPlane : DrawingLiveShape
    {
        ////HACK: This member should not exist here. A document interpreter must keep this value
        private readonly List<Node> _selectedNodes = new List<Node>();
        private gpAx1 _axis = new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));


        public BlockPlane()
            : base(ModifierNames.BlockPlane)
        {
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
            OnShapePicked(entities[entities.Count - 1].Node);
        }


        private static bool IsNodeValid(int dependencyIndex)
        {
            return dependencyIndex != 1;
        }

        private void OnShapePicked(Node node)
        {
            if (!IsNodeValid(_selectedNodes.Count))
                return;
            if (_selectedNodes.Count > 0 && _selectedNodes[0].Index == node.Index)
                return;
            SelectShape(node);
            _selectedNodes.Add(node);
            UpdateShapeSelection(node);
        }

        private void UpdateShapeSelection(Node node)
        {
            if (_selectedNodes.Count != 1) return;
            var axis = new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
            if (ExtractAxis(node, ref axis))
                _axis = axis;
            if (SetAxis()) return;
            base.OnDeactivate();
            BackToNeutralModifier();
        }

        private static bool ExtractAxis(Node node, ref gpAx1 axis)
        {
            var builder = new NodeBuilder(node);
            try
            {
                axis = GeomUtils.ExtractAxis2(builder.Shape).Axis;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool SetAxis()
        {
            try
            {
                Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
                Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane,
                                                          new gpPln(_axis.Location, _axis.Direction));
                Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Suspend);
            }
            catch
            {
            }
            var plane = new gpPln(_axis.Location, _axis.Direction);

            if (IfParallelWithPlaneSwitchAction(plane, PlaneFromAx2(gp.XOY), ModifierNames.Top)) return true;
            if (IfParallelWithPlaneSwitchAction(plane, PlaneFromAx2(gp.ZOX), ModifierNames.Left)) return true;
            return IfParallelWithPlaneSwitchAction(plane, PlaneFromAx2(gp.YOZ), ModifierNames.Front);
        }

        private static gpPln PlaneFromAx2(gpAx2 oCgpAx2)
        {
            return new gpPln(new gpAx3(oCgpAx2));
        }

        private bool IfParallelWithPlaneSwitchAction(gpPln plane, gpPln planeToCompare, string actionName)
        {
            var distance = Math.Abs(plane.Distance(planeToCompare));
            if (plane.Position.IsCoplanar(planeToCompare.Position, 1e-6, 1e-5) || distance > 1e-5)
            {
                ActionsGraph.SwitchAction(actionName);
                return true;
            }
            return false;
        }


        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Reset();
        }

        private void Reset()
        {
            Context.Select(true);
            _selectedNodes.Clear();
        }
    }
}