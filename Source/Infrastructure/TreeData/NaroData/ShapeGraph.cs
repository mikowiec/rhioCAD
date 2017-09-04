#region Usings

using System.Collections.Generic;
using System.Linq;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeData.NaroData
{
    public class ShapeGraph
    {
        public readonly SortedDictionary<int, List<int>> ReferrencedBy;
        public readonly SortedDictionary<int, List<int>> ReferringTo;
        private Node _root;

        public ShapeGraph()
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
            if (_root == null)
                return;
            ReferringTo.Clear();
            ReferrencedBy.Clear();
            foreach (var node in _root.ChildrenList)
            {
               
                var children = node.Children;
                foreach (var childNode in children)
                {
                    var refInterpreter = childNode.Value.Get<ReferenceInterpreter>();
                    if (refInterpreter != null)
                        AddLink(node.Index, refInterpreter.Node.Index);
                    var refListInterpreter = childNode.Value.Get<ReferenceListInterpreter>();
                    if (refListInterpreter == null) continue;
                    foreach (var refListNode in refListInterpreter.Nodes)
                        if (refListNode.Node != null)
                            AddLink(node.Index, refListNode.Node.Index);
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

        public List<int> GetDeleteCandidates(IEnumerable<int> shapeList)//, Document document)
        {
            var nodes = new List<int>();
            var firstNode = shapeList.First();

            var shapeGraph = this;
            var shapeNodes = new List<int>();
            if (shapeGraph.ReferringTo.ContainsKey(firstNode))
            {
                var nodeChildren = shapeGraph.ReferringTo[firstNode];
                foreach (var child in nodeChildren)
                {
                    // if only the parent node references the node, add it to the list
                    if (shapeGraph.ReferrencedBy[child].Count == 1)
                    {
                        nodes.Add(child);
                        shapeNodes.Add(child);
                    }
                }
            }
            
            foreach(var node in shapeNodes)
            {
                if (shapeGraph.ReferringTo.ContainsKey(node))
                {
                    var nodeChildren = shapeGraph.ReferringTo[node];
                    foreach (var child in nodeChildren)
                    {
                        // if only the parent node references the node, add it to the list
                        if (shapeGraph.ReferrencedBy[child].Count == 1)
                            nodes.Add(child);
                    }
                }
            }
            if (shapeGraph.ReferrencedBy.ContainsKey(firstNode))
            {
                var referencedBy = shapeGraph.ReferrencedBy[firstNode];
                foreach (var node in referencedBy)
                {
                    nodes.Add(node);
                    if (shapeGraph.ReferrencedBy.ContainsKey(node))
                    {
                        var refref = shapeGraph.ReferrencedBy[node];
                        nodes.AddRange(refref);
                    }
                }
            }

            nodes.Add(firstNode);
            return nodes;
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