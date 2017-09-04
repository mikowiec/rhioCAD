#region Usings

using System.Collections.Generic;
using TreeData.NaroData;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport
{
    internal class AttachedNodeData
    {
        private readonly Node _node;
        private AttachedNodeData _parent;

        public AttachedNodeData(Node node)
        {
            Data = new SortedDictionary<string, object>();
            _node = node;
            Children = new SortedDictionary<int, AttachedNodeData>();
        }

        public SortedDictionary<string, object> Data { get; private set; }

        public AttachedNodeData Parent
        {
            get { return _parent; }
            set
            {
                _parent = value;

                if (value != null)
                    value.Children[_node.Index] = this;
            }
        }

        public SortedDictionary<int, AttachedNodeData> Children { get; private set; }

        public Node Node
        {
            get { return _node; }
        }

        public AttachedNodeData Root
        {
            get { return Parent == null ? this : Parent.Root; }
        }
    }
}