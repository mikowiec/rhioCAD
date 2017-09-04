#region Usings

using NaroConstants.Names;
using NaroPipes.Constants;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Fuses two shapes.
    /// </summary>
    public class Sew : ModifierTwoShapesCommon
    {
        public Sew()
            : base(ModifierNames.Sew)
        {
            FirstMessage = ModelingResources.SewStep1;
            SecondMessage = ModelingResources.SewStep2;
        }

        protected override bool ApplyFunction()
        {
            var builder = new NodeBuilder(Document, FunctionNames.Sewing);
            builder[0].Reference = FirstShape;
            builder[1].Reference = SecondShape;
            if (builder.ExecuteFunction())
            {
                AddNodeToTree(builder.Node);
                return true;
            }
            return false;
        }

        protected override void DocumentCommitReason()
        {
            Document.Commit("Apply Pipe");
        }
    }
}