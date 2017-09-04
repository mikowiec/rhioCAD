#region Usings

using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroPipes.Constants;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Make one shape to be extruded to entire path of the second shape
    /// </summary>
    public class Pipe : ModifierTwoShapesCommon
    {
        public Pipe()
            : base(ModifierNames.Pipe)
        {
            FirstMessage = ModelingResources.PipeStep1;
            SecondMessage = ModelingResources.PipeStep2;
        }

        protected override bool ApplyFunction()
        {
            var builder = new NodeBuilder(Document, FunctionNames.Pipe);
            builder[0].Reference = FirstShape;
            builder[1].Reference = SecondShape;
            if (builder.ExecuteFunction())
            {
                NodeUtils.Hide(FirstShape);
                var referenceTransformation = FirstShape.Set<TransformationInterpreter>();
                var pipeTransformation = builder.Node.Set<TransformationInterpreter>();
                pipeTransformation.Translate = referenceTransformation.Translate;
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