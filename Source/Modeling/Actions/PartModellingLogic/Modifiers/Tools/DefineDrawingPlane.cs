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
using TreeData.Capabilities;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Implements the DrawingPlane modifier.
    /// </summary>
    public class DefineDrawingPlane : DrawingLiveShape
    {
        private readonly List<Node> _selectedNodes = new List<Node>();
        private CapabilitiesCollection _collection;


        public DefineDrawingPlane()
            : base(ModifierNames.DefineDrawingPlane)
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
            OnShapePicked(entities[0].Node);
        }


        private bool IsNodeValid(int dependencyIndex)
        {
            if (dependencyIndex != 1)
                return true;
            return false;
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
            var axis = new gpAx1();
            if (ExtractAxis(node, ref axis))
            {
                SetAxis(axis);
            }
            base.OnDeactivate();
            BackToNeutralModifier();
        }

        private bool ExtractAxis(Node node, ref gpAx1 axis)
        {
            var builder = new NodeBuilder(node);
            try
            {
                axis = GeomUtils.ExtractAxis2(builder.Shape).Axis;
                //Ensure.IsNotNull(axis);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void SetAxis(gpAx1 axis)
        {
            try
            {
                //BlockPlane._axis= axis;

                /*Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, new gpPln(axis.Location, axis.Direction()));
                Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Suspend);*/
            }
            catch (Exception)
            {
            }
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
    }
}