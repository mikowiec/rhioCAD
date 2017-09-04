#region Usings

using System;
using System.Collections.Generic;
using log4net;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using OccCode;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.Capabilities;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class Pattern : DrawingLiveShape
    {
        protected static readonly ILog Log = LogManager.GetLogger("NaroCad");

        protected readonly List<Node> _selectedNodes = new List<Node>();
        protected gpAx1 _axis;
        protected NodeBuilder _builder;
        protected CapabilitiesCollection _collection;


        protected Pattern(string modifierName)
            : base(modifierName)
        {
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

        protected void OnShapePicked(Node node)
        {
            if (!IsNodeValid(_selectedNodes.Count, node))
                return;
            if (_selectedNodes.Count > 0 && _selectedNodes[0].Index == node.Index)
                return;
            SelectShape(node);
            _selectedNodes.Add(node);
            UpdateShapeSelection();
        }

        protected virtual void UpdateShapeSelection()
        {
        }

        protected virtual void BuildDialog(string dialogTitle)
        {
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

        public override void OnDeactivate()
        {
            base.OnDeactivate();
        }
    }
}