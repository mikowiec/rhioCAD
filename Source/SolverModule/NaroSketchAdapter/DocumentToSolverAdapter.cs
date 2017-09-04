#region Usings

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using NaroConstants.Names;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter
{
    public class DocumentToSolverAdapter
    {
        private readonly List<int> _constraints;
        private readonly Document _document;
        private readonly List<int> _relatedShapes;
        private int _freePointsCount;
        private readonly Node _sketchNode;
        private readonly NaroSketchSolveBuilder _solverBuilder;

        public DocumentToSolverAdapter(Document document, Node sketchNode)
        {
            _document = document;
            _sketchNode = sketchNode;
            _constraints = new List<int>();
            _relatedShapes = new List<int>();
            _solverBuilder = new NaroSketchSolveBuilder(_document, _sketchNode);
        }

        private void BuildShapeLists(IOrderedDictionary shapeList, IOrderedDictionary constraintList, int mousePointIndex)
        {
            if (mousePointIndex == 0)
                return;
            var root = _document.Root;
            var dci = root.Get<DocumentContextInterpreter>();
            var shapeGraph = dci.ShapesGraph;
            var relatedNodes = new List<int>();
            bool expanding;
          
            do
            {
                var shapeNodes = GetUnusedNodes(shapeList);
                var shapeNodesCount = shapeNodes.Count;
                var referrencedByNodes = GetReferrencedByNodes(shapeNodes, shapeGraph);
                var referingNodes = GetReferingNodes(shapeNodes, shapeGraph);
                var constraintNodes = GetUnusedNodes(constraintList);
                var constraintNodesCount = constraintNodes.Count;
                expanding = shapeNodesCount != 0 || constraintNodesCount != 0;
                var toMap = GetReferingNodes(constraintNodes, shapeGraph);

                ExpandDictionaryWithItems(shapeList, constraintList, referrencedByNodes);
                ExpandDictionaryWithItems(shapeList, constraintList, referingNodes);
                ExpandDictionaryWithItems(shapeList, constraintList, toMap);
            } while (expanding);

            if (relatedNodes.Count == 0)
            {
                relatedNodes = GetRelatedNodes(new []{mousePointIndex}, shapeGraph);
            }

            _freePointsCount = relatedNodes.Count * 2; 

            // exclude mouse position for closed shapes (e.g. rectangle)
            if (relatedNodes.Contains(mousePointIndex))
                _freePointsCount -= 2;

            var orderedList = relatedNodes.ToDictionary(node => node, node => true);

            foreach (var shape in shapeList.Keys)
            {
                if (!orderedList.ContainsKey((int)shape))
                    orderedList.Add((int)shape, true);
            }
            var newShapeList = new List<int>();

            // shapeList will contain all the points, ordered on levels from the mouse point, the mouse point
            // and after that all the constraints
            foreach (var value in orderedList.Keys)
            {
                if(NodeIsPoint(value))
                    if (!newShapeList.Contains(value))
                    {
                        newShapeList.Add(value);
                    }
                if(NodeIsCircle(value))
                {
                    var circleNode = new NodeBuilder(_document.Root[value]);
                    var circleIndex = circleNode.Dependency[0].ReferenceBuilder.Node.Index;
                    if (newShapeList.Contains(circleIndex))
                    {
                        int i = 0;
                        for (i = 0; i < newShapeList.Count - 1; i++)
                        {
                            if (newShapeList[i] == circleIndex)
                                break;
                            i++;
                        }
                        if (i < newShapeList.Count-1)
                        {
                            newShapeList.Insert(i+1, value);
                        }
                        else
                        {
                            newShapeList.Add(value);
                        }
                    }
                    else
                    {
                        newShapeList.Add(circleIndex);
                        newShapeList.Add(value);
                    }
                }
            }

            // move mouse point at the end of the points list
            if (newShapeList.Contains(mousePointIndex))
            {
                newShapeList.Remove(mousePointIndex);
                newShapeList.Add(mousePointIndex);
                foreach (var item in newShapeList)
                {
                    var nb = new NodeBuilder(_document.Root[item]);
                    if (nb.FunctionName == FunctionNames.Circle)
                    {
                        if (nb.Dependency[0].ReferenceBuilder.Node.Index == mousePointIndex)
                        {
                            newShapeList.Remove(item);
                            newShapeList.Add(item);
                            break;
                        }
                    }
                }
            }

            newShapeList.AddRange(orderedList.Keys.Where(value => !NodeIsPointOrCircle(value)));

            foreach (var constr in constraintList.Keys)
            {
                var nb = new NodeBuilder(_document.Root[(int)constr]);
                if (nb.FunctionName == Constraint2DNames.LineLengthFunction)
                    _freePointsCount += 2;
            }
            shapeList.Clear();
            foreach(var element in newShapeList)
                shapeList.Add(element, true);
        }

        private List<int> GetRelatedNodes(IEnumerable<int> shapeList, ShapeGraph shapeGraph)
        {
            var relatedNodes = new List<int>();
            var referingNodes = new List<int>();
            var nextLevel = new List<int>();
            var processed = new List<int>();

            referingNodes.AddRange(GetReferrencedByNodes(shapeList, shapeGraph));
            nextLevel.AddRange(referingNodes);

            while (nextLevel.Count > 0)
            {
                foreach (var node in nextLevel)
                {
                    if (!relatedNodes.Contains(node) && NodeIsPointOrCircle(node))
                        relatedNodes.Add(node);
                }
                var referencedBy = new List<int>();

                var referencedNodes = GetReferingNodes(referingNodes, shapeGraph).Distinct().ToList();
                referencedBy.AddRange(referencedNodes.Where(node => !NodeIsConstraint(node)));
               
                referingNodes.Clear();
                referingNodes.AddRange(GetReferrencedByNodes(nextLevel, shapeGraph).Where(p => p > 0));

                nextLevel.Clear();
                nextLevel.AddRange(referingNodes.Concat(referencedBy).Distinct());

                nextLevel.RemoveAll(processed.Contains);
                processed.AddRange(nextLevel);
            }
            return relatedNodes;
        }

        private bool NodeIsConstraint(int nodeIndex)
        {
            var nodeBuilder = new NodeBuilder(_document.Root[nodeIndex]);
            if (_solverBuilder.ConstraintMappingList.ShapeConstraintObjectMapping.ContainsKey(nodeBuilder.FunctionName))
                return true;
            return false;
        }

        private bool NodeIsPointOrCircle(int nodeIndex)
        {
            var nodeBuilder = new NodeBuilder(_document.Root[nodeIndex]);

            if (nodeBuilder.FunctionName == FunctionNames.Point || nodeBuilder.FunctionName == FunctionNames.Circle) 
                return true;
        
            return false;
        }

       private bool NodeIsPoint(int nodeIndex)
       {
           var nodeBuilder = new NodeBuilder(_document.Root[nodeIndex]);
           return nodeBuilder.FunctionName == FunctionNames.Point;
       }

       private bool NodeIsCircle(int nodeIndex)
       {
           var nodeBuilder = new NodeBuilder(_document.Root[nodeIndex]);
           return nodeBuilder.FunctionName == FunctionNames.Circle;
       }

        private void ExpandDictionaryWithItems(IOrderedDictionary shapeList, IOrderedDictionary constraintList,
                                               IEnumerable<int> fromMap)
        {
            foreach (var fromId in fromMap)
                UpdateListsWithItem(shapeList, constraintList, fromId);
        }

        private void UpdateListsWithItem(IOrderedDictionary shapeList, IOrderedDictionary constraintList,
                                         int fromId)
        {
            var root = _document.Root;
            var shapeSolverObjectMapping = _solverBuilder.ShapeSolverObjectMapping;
            var functionName = new NodeBuilder(root[fromId]).FunctionName;
            if (shapeSolverObjectMapping.ContainsKey(functionName))
            {
                if (!shapeList.Keys.Cast<int>().ToList().Contains(fromId)) shapeList[(object)fromId] = false;
            }
            if (!_solverBuilder.ConstraintMappingList.ShapeConstraintObjectMapping.ContainsKey(functionName)) return;
            if (constraintList.Keys.Cast<int>().ToList().Contains(fromId)) return;
            constraintList[(object)fromId] = false;
        }

        private static IEnumerable<int> GetReferrencedByNodes(IEnumerable<int> shapeNodes, ShapeGraph shapeGraph)
        {
            var fromMap = new List<int>();
            foreach (var sourceNode in shapeNodes)
            {
                List<int> value;
                if (!shapeGraph.ReferrencedBy.TryGetValue(sourceNode, out value)) continue;
                fromMap.AddRange(value);
            }
            return fromMap;
        }

        private static IEnumerable<int> GetReferingNodes(IEnumerable<int> shapeNodes, ShapeGraph shapeGraph)
        {
            var fromMap = new List<int>();
            foreach (var sourceNode in shapeNodes)
            {
                List<int> value;
                if (!shapeGraph.ReferringTo.TryGetValue(sourceNode, out value)) continue;
                fromMap.AddRange(value);
            }
            return fromMap;
        }

        private static ICollection<int> GetUnusedNodes(IOrderedDictionary shapeList)
        {
            var sourceNodes = new List<int>();
            foreach (DictionaryEntry item in shapeList)
            {
                if ((bool)item.Value) continue;
                sourceNodes.Add((int)item.Key);
            }
            foreach (var sourceNode in sourceNodes)
                shapeList[(object)sourceNode] = true;
           
                return sourceNodes;
        }

        public void ImpactedNodes(Node sourceNode, int mousePointIndex)
        {
            ShapeGraphUpdate();
            var shapeList = new OrderedDictionary {{sourceNode.Index, false}};
            var constraintList = new OrderedDictionary();
            BuildShapeLists(shapeList, constraintList, mousePointIndex);
            _relatedShapes.AddRange(shapeList.Keys.Cast<int>().ToList());
            _constraints.AddRange(constraintList.Keys.Cast<int>().ToList());
        }

        private void ShapeGraphUpdate()
        {
            var root = _document.Root;
            var dci = root.Get<DocumentContextInterpreter>();
            var shapeGraph = dci.ShapesGraph;
            shapeGraph.Update();
        }

        public int Solve()
        {
            _solverBuilder.PopulateData(_relatedShapes, _constraints);
            _solverBuilder.FreePointsCount = _freePointsCount;
            var result = _solverBuilder.Solve();
            return result;
        }
    }
}