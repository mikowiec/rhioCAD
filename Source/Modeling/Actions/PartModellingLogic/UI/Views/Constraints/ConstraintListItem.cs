#region Usings

using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.UI.Views.Constraints
{
    internal class ConstraintListItem
    {
        private readonly Document _document;

        public ConstraintListItem(Document document, NodeBuilder node, string name, string description)
        {
            _document = document;
            Name = name;
            Description = description;
            Reference = node;
        }

        public string Name { get; set; }
        private string Description { get; set; }

        private NodeBuilder Reference { get; set; }

        public NodeBuilder Builder
        {
            get
            {
                var node = Reference.Node;
                var root = node.Root;
                foreach (var child in root.Children.Values)
                {
                    if (!Document.NodeReferences(child, node)) continue;
                    var childFunctionName = FunctionUtils.GetFunctionName(child);
                    if (childFunctionName != Name) continue;

                    return new NodeBuilder(child);
                }
                return new NodeBuilder(null);
            }
        }

        public bool IsSet()
        {
            return Reference.LastExecute;
        }

        public void GenerateBuilder()
        {
            if (Builder.LastExecute) return;
            var builder = new NodeBuilder(_document, Name);
            builder[0].Reference = Reference.Node;
        }

        public override string ToString()
        {
            return IsSet() ? "* " + Description : Description;
        }
    }
}