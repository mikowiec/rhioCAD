#region Usings

using Naro.Infrastructure.Library.Geometry;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Tools.AutoTools
{
    internal class SyncronizeToolValues : ModifierTwoShapesCommon
    {
        public SyncronizeToolValues()
            : base(ModifierNames.SynchronizeToolValues)
        {
        }

        protected override bool IsNodeValid(int dependencyIndex, Node node)
        {
            if (dependencyIndex < 1)
                return true;
            var firstBuilder = new NodeBuilder(FirstShape);
            var secondBuilder = new NodeBuilder(node);

            return firstBuilder.FunctionName == secondBuilder.FunctionName;
        }

        protected override bool ApplyFunction()
        {
            var secondBuilder = new NodeBuilder(SecondShape);
            return NodeUtils.SyncronizeNodeFunctions(FirstShape, ref secondBuilder);
        }

        protected override void DocumentCommitReason()
        {
            Document.Commit("Apply Revolve");
        }
    }
}