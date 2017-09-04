#region Usings

using Naro.Infrastructure.Library.Geometry;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.Tools.AutoTools
{
    internal class ApplyOneToolOnAnotherModifier : ModifierTwoShapesCommon
    {
        public ApplyOneToolOnAnotherModifier()
            : base(ModifierNames.ApplyOneToolOnAnother)
        {
        }


        protected override void DocumentCommitReason()
        {
            Document.Commit("Apply list of tools");
        }

        protected override bool ApplyFunction()
        {
            var sourceTool = FirstShape;
            var destinationTool = SecondShape;
            var toolResult = NodeUtils.ApplyToolOnOtherShape(Document, sourceTool, destinationTool);
            if (toolResult.LastExecute)
            {
                AddNodeToTree(toolResult.Node);
                return true;
            }
            return false;
        }
    }
}