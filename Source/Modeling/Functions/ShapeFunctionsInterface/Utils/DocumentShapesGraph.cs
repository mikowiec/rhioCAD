#region Usings

using System.Collections.Generic;
using NaroConstants.Names;
using ShapeFunctionsInterface.Functions;
using TreeData.NaroData;

#endregion

namespace ShapeFunctionsInterface.Utils
{
    public class DocumentShapesGraph
    {
        public readonly SortedDictionary<int, List<int>> ReferrencedBy;
        public readonly SortedDictionary<int, List<int>> ReferringTo;
        private Node _root;

        public DocumentShapesGraph()
        {
            ReferringTo = new SortedDictionary<int, List<int>>();
            ReferrencedBy = new SortedDictionary<int, List<int>>();
        }

        public void SetDocument(Document document)
        {
            _root = document.Root;
            document.Changed += Update;
        }

        public void Update()
        {
            if(_root==null)
                return;
            ReferringTo.Clear();
            ReferrencedBy.Clear();
            foreach (var node in _root.ChildrenList)
            {
                if (node.Get<FunctionInterpreter>() == null) continue;
                var builder = new NodeBuilder(node);
                foreach (var dependencyNode in builder.Dependency.Children)
                {
                    if (dependencyNode.Name != InterpreterNames.Reference) continue;
                    if (dependencyNode.Reference == null) continue;
                    AddLink(node.Index, dependencyNode.Reference.Index);
                }
                foreach (var dependencyNode in builder.Dependency.Children)
                {
                    if (dependencyNode.Name != InterpreterNames.ReferenceList) continue;
                    var refList = dependencyNode.ReferenceList;
                    foreach (var entity in refList)
                        AddLink(node.Index, entity.Node.Index);
                }
            }
        }

        public List<int> GetReferredBy(Node node)
        {
            var result = new List<int>();
            var index = node.Index;
            List<int> referencingList;
            if (ReferrencedBy.TryGetValue(index, out referencingList))
                result.AddRange(referencingList);
            return result;
        }

        public List<Node> GetReferredByNodes(Node node)
        {
            var result = new List<Node>();
            var index = node.Index;
            var root = node.Root;
            List<int> referencingList;
            if (ReferrencedBy.TryGetValue(index, out referencingList))
                foreach (var item in referencingList)
                    result.Add(root[item]);

            return result;
        }

        private void AddLink(int from, int to)
        {
            UpdateLeftValue(ReferringTo, from);
            if (!ReferringTo[from].Contains(to))
                ReferringTo[from].Add(to);
            UpdateLeftValue(ReferrencedBy, to);
            if (!ReferrencedBy[to].Contains(from))
                ReferrencedBy[to].Add(from);
        }

        private static void UpdateLeftValue(IDictionary<int, List<int>> fromMap, int fromValue)
        {
            List<int> toList;
            if (fromMap.TryGetValue(fromValue, out toList)) return;
            toList = new List<int>();
            fromMap[fromValue] = toList;
        }
    }
}