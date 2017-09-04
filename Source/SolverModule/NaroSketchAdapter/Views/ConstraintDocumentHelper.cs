#region Usings

using System;
using System.Collections.Generic;
using ConstraintsModule.Views;
using NaroConstants.Names;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter.Views
{
    public class ConstraintDocumentHelper
    {
        private readonly ConstraintHighLevelDependencyMapping _constraintMapper;
        private readonly Document _document;
        private readonly Node _sketchNode;
        private Point3D _origin;
        private int _mousePointIndex;

        public readonly List<List<string>> MutuallyExclusiveConstraints = new List<List<string>>
                        {
                            new List<string>() {Constraint2DNames.ParallelFunction, Constraint2DNames.PerpendicularFunction},
                            new List<string>() {Constraint2DNames.HorizontalFunction,Constraint2DNames.VerticalFunction}
                        };
        public ConstraintDocumentHelper(Document document, Node sketchNode)
        {
            _document = document;
            _sketchNode = sketchNode;

            _constraintMapper = new ConstraintHighLevelDependencyMapping();
            DefaultConstraintsMapping.SetupDependencies(_constraintMapper);
        }

        public ConstraintHighLevelDependencyMapping ConstraintMapper
        {
            get { return _constraintMapper; }
        }

        public Document Document
        {
            get { return _document; }
        }

        public bool IsApplied(List<Node> selection, string constraintFunctionName)
        {
            var result = CheckAppliedConstraints(selection);
            var appliedFunctions = new List<string>();
            foreach (var node in result)
                appliedFunctions.Add(new NodeBuilder(node).FunctionName);
            return appliedFunctions.Contains(constraintFunctionName);
        }


        public List<string> GetPossibleConstraints(IEnumerable<Node> selection)
        {
            var usedFunctions = GetUsedFunctions(selection);
            return ConstraintMapper.AccessibleConstraints(usedFunctions);
        }

        public List<string> GetAvailableConstraints(List<Node> selectedNodes, IEnumerable<string> existingConstraints)
        {
            var constraintList = GetPossibleConstraints(selectedNodes);
            foreach (var existing in existingConstraints)
            {
                if (constraintList.Contains(existing))
                    constraintList.Remove(existing);
                foreach (var list in MutuallyExclusiveConstraints)
                {
                    if (list.Contains(existing))
                        foreach (var item in list)
                            if (constraintList.Contains(item))
                                constraintList.Remove(item);
                }
            }
            return constraintList;
        }

        public IList<Node> CheckAppliedConstraints(IList<Node> selection)
        {
            var shapesGraph = Document.Root.Get<DocumentContextInterpreter>().ShapesGraph;
            Document.Root.Get<DocumentContextInterpreter>().ShapesGraph.Update();
            var startWithList = shapesGraph.GetReferredBy(selection[0]);
            for (var i = 1; i < selection.Count; i++)
            {
                var nextList = shapesGraph.GetReferredBy(selection[i]);
                bool toRemove;
                do
                {
                    var itemToRemove = -1;
                    toRemove = false;
                    foreach (var item in startWithList)
                    {
                        if (nextList.Contains(item)) continue;
                        toRemove = true;
                        itemToRemove = item;
                        break;
                    }
                    if (toRemove)
                        startWithList.Remove(itemToRemove);
                } while (toRemove);
            }
            return IntToNodeList(startWithList);
        }

        private IList<Node> IntToNodeList(IEnumerable<int> startWithList)
        {
            var result = new List<Node>();
            foreach (var item in startWithList)
                result.Add(Document.Root[item]);
            return result;
        }

        public static List<string> GetUsedFunctions(IEnumerable<Node> selection)
        {
            var usedFunctions = new List<string>();
            foreach (var node in selection)
            {
                var builder = new NodeBuilder(node);
                var functionName = builder.FunctionName;
                usedFunctions.Add(functionName);
            }
            var functionArray = usedFunctions.ToArray();
            Array.Sort(functionArray);
            usedFunctions.Clear();
            usedFunctions.AddRange(functionArray);
            return usedFunctions;
        }

        public NodeBuilder ApplyConstraint(Node node, string constraintFunction)
        {
            return ApplyConstraint(new List<Node> {node}, constraintFunction);
        }

        public NodeBuilder ApplyConstraint(Node node1, Node node2, string constraintFunction)
        {
            return ApplyConstraint(new List<Node> {node1, node2}, constraintFunction);
        }

        public NodeBuilder ApplyConstraint(List<Node> nodes, string constraintFunction)
        {
            var descriptor = ConstraintMapper.GetConstraintDescription(constraintFunction);
            if (descriptor.DependencyList.Count != nodes.Count)
                return new NodeBuilder(null);
            var result = new NodeBuilder(Document, constraintFunction);
            GetSoftConstraints(nodes);
            for (var index = 0; index < nodes.Count; index++)
            {
                result[index].Reference = nodes[index];
            }
            result.ExecuteFunction();
            result.Node.Set<TreeViewVisibilityInterpreter>();
            var sourceNode = nodes[0];
            var error = ImpactAndSolve(sourceNode);
            return error != 0 ? new NodeBuilder(null) : result;
        }

        public void GetSoftConstraints(List<Node> nodes)
        {}

        public int ImpactAndSolve(Node sourceNode)
        {
            var docSolverAdapter = new DocumentToSolverAdapter(Document, _sketchNode);
            docSolverAdapter.ImpactedNodes(sourceNode, _mousePointIndex);
            return docSolverAdapter.Solve();
        }

        public void Remove(List<Node> nodes, string constraintFunctionName)
        {
            var appliedConstraints = CheckAppliedConstraints(nodes);
            var constraints = new List<Node>();
            foreach (var constraint in appliedConstraints)
            {
                var builder = new NodeBuilder(constraint);
                if (constraintFunctionName != builder.FunctionName) continue;
                constraints.Add(builder.Node);
            }
            if (constraints.Count == 0)
                return;
            foreach (var constraint in constraints)
            {
                _document.Root.Remove(constraint.Index);
            }
        }

        public void ComputeSolverOnImpactedNodes(SortedDictionary<string, bool> constraintNames)
        {
            var impactedNodes = _document.ImpactedRootNodes();
            foreach (var impactedNode in impactedNodes)
            {
                var builder = new NodeBuilder(impactedNode);
                if (!constraintNames.ContainsKey(builder.FunctionName)) continue;
                ImpactAndSolve(builder[0].Reference);
                return;
            }
        }

        public void Remove(Node node1, Node node2, string functionName)
        {
            Remove(new List<Node> {node1, node2}, functionName);
        }

        public void Remove(Node node1, string functionName)
        {
            Remove(new List<Node> {node1}, functionName);
        }

        public void SetOrigin(Point3D origin)
        {
            _origin = origin;
        }

        public void SetMousePosition(int mousePointIndex)
        {
            _mousePointIndex = mousePointIndex;
        }
    }
}