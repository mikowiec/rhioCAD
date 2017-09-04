#region Usings

using System.Collections.Generic;

#endregion

namespace TreeData.NaroData
{
    public class SerializedNode
    {
        public SortedDictionary<int, SerializedNode> Children = new SortedDictionary<int, SerializedNode>();
        public SortedDictionary<int, AttributeData> Interpreters = new SortedDictionary<int, AttributeData>();

        public SerializedNode(int index)
        {
            Index = index;
        }

        public int Index { get; private set; }

        public NodeDiff Diff
        {
            set { SetByDiff(value); }
            get { return CreateDiff(); }
        }


        public void ApplyOnNode(Node node)
        {
            NodeDiff.ApplyDiff(node, Diff);
        }

        private NodeDiff CreateDiff()
        {
            var result = new NodeDiff(null);
            foreach (var child in Children)
            {
                var childDiff = child.Value.Diff;
                result.Children[child.Key] = childDiff;
            }
            foreach (var interpreter in Interpreters)
                result.ModifiedAttributeData[interpreter.Key] = interpreter.Value;
            return result;
        }

        private void SetByDiff(NodeDiff value)
        {
            Clear();
            foreach (var child in value.Children)
            {
                Children[child.Key] = new SerializedNode(child.Key) {Diff = child.Value};
            }
            foreach (var interpreter in value.ModifiedAttributeData)
            {
                Interpreters[interpreter.Key] = interpreter.Value;
            }
        }

        private void Clear()
        {
            Children = new SortedDictionary<int, SerializedNode>();
            Interpreters = new SortedDictionary<int, AttributeData>();
        }
    }
}