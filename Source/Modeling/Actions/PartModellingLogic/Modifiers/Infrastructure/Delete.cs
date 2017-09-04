#region Usings

using System.Collections.Generic;
using System.Linq;
using ErrorReportCommon.Messages;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    public class Delete : DrawingLiveShape
    {
        public Delete() : base(ModifierNames.Delete)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();

            // Hide the currently selected object and the objects that have references to it
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            var toDelete = (from entity in entities let nb = new NodeBuilder(entity.Node) where nb.FunctionName != FunctionNames.Plane select entity.Node).ToList();
            if (entities.Count <= 0)
            {
                var node = Inputs[InputNames.NodeSelect].GetData(NotificationNames.GetValue).Get<Node>();
                toDelete.Add(node);
            }
            RebuildTreeView();
            if (toDelete.Count == 0 || toDelete[0] == null)
                WarnNoSelectedAndBackToNone();
            else
                RemoveSelectedShapes(toDelete);
        }

        private void RemoveSelectedShapes(IEnumerable<Node> toDelete)
        {
            Document.Transact();

            foreach (var deletedItem in toDelete)
            {
                if (NodeUtils.NodeIsConstraint(deletedItem.Index, Document))
                {
                    NodeBuilderUtils.DeleteConstraintNode(Document, deletedItem);
                }
                else
                {
                    RemoveFromDocument(deletedItem);
                }
            }

            Document.OptimizeData();
            NodeUtils.RebuildAllSketchFaces(Document);
            Document.Commit("Delete object");
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Cleanup);
            UpdateView();
            RebuildTreeView();
            BackToNeutralModifier();
        }

        private void WarnNoSelectedAndBackToNone()
        {
            NaroMessage.Show("Please pick a shape to delete");
            BackToNeutralModifier();
        }

        private void RemoveFromDocument(Node referenceLabel)
        {
            NodeBuilderUtils.DeleteNode(referenceLabel, Document);
        }
    }
}