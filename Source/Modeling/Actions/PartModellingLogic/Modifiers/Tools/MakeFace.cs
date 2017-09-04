#region Usings

using System.Collections.Generic;
using MetaActionsInterface;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Constants;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class MakeFace : DrawingAction3D
    {
        public MakeFace() : base(ModifierNames.MakeFace)
        {
        }

        public override void OnActivate()
        {
            // Get the selected shapes
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            var nodes = entities;
            var selectedNodes = new List<SceneSelectedEntity>();

            foreach (var entity in nodes)
            {
                if (entity.ShapeType == TopAbsShapeEnum.TopAbs_WIRE)
                {
                    selectedNodes.Add(entity);
                }
            }

            // To make a face there should be at least one wire selected
            if (selectedNodes.Count < 1)
            {
                return;
            }

            Document.Transact();

            var builder = new NodeBuilder(Document, FunctionNames.Face);
            builder[0].ReferenceList = selectedNodes;

            if (!builder.ExecuteFunction())
            {
                Document.Revert();
                BackToNeutralModifier();
                return;
            }
            // Finish the transaction
            Document.Commit("Apply make face");

            UpdateView();
            AddNodeToTree(builder.Node);

            // Change back to selection mode
            BackToNeutralModifier();
        }
    }
}