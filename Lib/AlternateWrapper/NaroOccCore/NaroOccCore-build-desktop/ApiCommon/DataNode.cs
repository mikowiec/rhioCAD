#region Usages

using System.Collections.Generic;

#endregion

namespace ApiCommon
{
    public class DataNode
    {
        public DataNode(string name)
        {
            NodeType = name;
            Children = new List<DataNode>();
            Attributes = new SortedDictionary<string, string>();
        }

        public string NodeType { get; internal set; }
        public List<DataNode> Children { get; private set; }
        public SortedDictionary<string, string> Attributes { get; private set; }

        public string Name
        {
            get { return this[Consts.Name]; }
            set { this[Consts.Name] = value; }
        }

        public DataNode Parent { get; set; }

        public DataNode Root
        {
            get { return Parent != null ? Parent.Root : this; }
        }


        public string this[string attributeName]
        {
            get
            {
                string result;
                return !Attributes.TryGetValue(attributeName, out result) ? string.Empty : result;
            }
            set { Attributes[attributeName] = value; }
        }

        public DataNode Add(string childName)
        {
            var result = new DataNode(childName);
            Children.Add(result);
            result.Parent = this;
            return result;
        }

        public DataNode Set(string nodeType)
        {
            var result = Set(string.Empty, nodeType);
            result.Attributes.Remove(Consts.Name);
            return result;
        }

        public DataNode Set(string itemName, string nodeType)
        {
            var result = Get(itemName, nodeType);
            if (result == null)
            {
                result = Add(nodeType);
                result.Name = itemName;
            }
            return result;
        }

        public DataNode Get(string nodeType)
        {
            DataNode result = null;
            foreach (var dataNode in Children)
            {
                if (dataNode.NodeType != nodeType) continue;
                result = dataNode;
                break;
            }
            return result;
        }

        public DataNode Get(string itemName, string nodeType)
        {
            DataNode result = null;
            foreach (var dataNode in Children)
            {
                if (dataNode.NodeType != nodeType) continue;
                if (dataNode.Name != itemName) continue;
                result = dataNode;
                break;
            }
            return result;
        }

        public bool Is(string attributeName)
        {
            string value;
            if (!Attributes.TryGetValue(attributeName, out value)) return false;
            return !string.IsNullOrEmpty(value);
        }
    }
}