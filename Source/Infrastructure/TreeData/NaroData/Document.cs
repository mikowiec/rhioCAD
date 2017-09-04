#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using ErrorReportCommon.Messages;
using NaroConstants.Names;
using log4net;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;
using TreeData.NaroXmlSerializer;

#endregion

namespace TreeData.NaroData
{
    /// <summary>
    ///   Document stores a Node and encasulate a document live cycle means: load/save, transact/commit, undo/redo
    /// </summary>
    public class Document
    {
        #region Members

        #region Delegates

        /// <summary>
        ///   Event that notifies that the commit happens
        /// </summary>
        public delegate void CommitEvenentHandler();

        #endregion

        private static readonly ILog Log = LogManager.GetLogger(typeof (Document));
        public CommitEvenentHandler BeforeChanged;
        public CommitEvenentHandler Changed;
        private List<NodeDiff> _historyList;
        private int _historyPos;
        private List<string> _reasonList;

        private bool _transactStarted;

        /// <summary>
        ///   snapshot of entire Root node, used to process Undo/Redo lists
        /// </summary>
        private SerializedNode _treeMirror;

        /// <summary>
        ///   Stored tree structure that keeps an entire document data.
        /// </summary>
        public Node Root { get; private set; }

        public int HistoryCount
        {
            get { return _historyList.Count; }
        }

        #endregion

        #region Constructor code

        /// <summary>
        ///   Default constructor
        /// </summary>
        public Document()
        {
            InitialSetup();
        }

        private void InitialSetup()
        {
            Root = new Node();
            ResetHistory();
        }

        public void ResetHistory()
        {
            _historyList = new List<NodeDiff>();
            _reasonList = new List<string>();
            _historyPos = -1;
        }

        #endregion

        #region Methods

        /// <summary>
        ///   Creates a snapshot to be compared with pair Commit call.
        ///   It is used to create undo/redo points
        /// </summary>
        public void Transact()
        {
            if (_transactStarted)
                Revert();

            _transactStarted = true;
            if (_treeMirror != null) return;
            _treeMirror = ReflectTreeMirror(Root);
            Root.ClearMarkings();
        }

        /// <summary>
        ///   Makes changes permanently and let them to be affected by Undo/Redo commands
        /// </summary>
        /// <param name = "reason">The reason of comit. It can be used to see cause of the commit.
        ///   empty string for reason is used in revert or commits with no important reason to get notify</param>
        /// <returns> Returns true in case that there are changes to the previous Transact call</returns>
        public bool Commit(string reason)
        {
            NotifyPreChanges();
            if (!_transactStarted)
            {
                _transactStarted = true;
                if (_treeMirror == null)
                    _treeMirror = ReflectTreeMirror(Root);
                Revert();
                return false;
            }
            var redo = new NodeDiff(null);
            redo.ComputeMarkingDiff(_treeMirror, Root);
            var undo = NodeDiff.ApplyDiffToSerializedNode(_treeMirror, redo);

            if (!undo.Empty)
            {
                _historyPos++;
                RemoveInvalidUndoRedoItems();
                AddUndoRedoDiffs(reason, undo);
            }
            else
            {
                return false;
            }

            _transactStarted = false;
            //empty string for reason is used in revert or commits with no important reason to get notify
            NotifyChanges(reason);
            return true;
        }

        private void NotifyChanges(string reason)
        {
            if (Changed != null && !string.IsNullOrEmpty(reason))
                Changed();
        }

        private void NotifyPreChanges()
        {
            if (BeforeChanged != null)
                BeforeChanged();
        }

        private void AddUndoRedoDiffs(string reason, NodeDiff undo)
        {
            _reasonList.Add(reason);
            foreach (var removedNodeId in undo.RemovedNodes)
            {
                undo.Children.Remove(removedNodeId);
            }
            _historyList.Add(undo);
        }

        private void RemoveInvalidUndoRedoItems()
        {
            if (_historyPos == _historyList.Count) return;
            var length = _historyList.Count - _historyPos;
            _reasonList.RemoveRange(_historyPos, length);
            _historyList.RemoveRange(_historyPos, length);
        }

        /// <summary>
        ///   Returns to Transact state.
        /// </summary>
        public void Revert()
        {
            if (!Commit(string.Empty)) return;
            Undo();
            RemoveTrailUndos();
        }

        private void RemoveTrailUndos()
        {
            var length = _historyList.Count - _historyPos - 1;
            _reasonList.RemoveRange(_historyPos + 1, length);
            _historyList.RemoveRange(_historyPos + 1, length);
        }

        private NodeDiff GetHistoryItem(int position)
        {
            var result = _historyList[position];
            var cloneDiff = result.Clone;
            foreach (var removedNodeId in cloneDiff.RemovedNodes)
            {
                cloneDiff.Children.Remove(removedNodeId);
            }
            return cloneDiff;
        }

        private void SetHistoryItem(int position, NodeDiff nodeDiff)
        {
            _historyList[position] = nodeDiff;
            //nodeDiff.Pack();
        }

        /// <summary>
        ///   Goes back to previous Transact call
        /// </summary>
        public void Undo()
        {
            if (_historyPos < 0) return;
            try
            {
                var undoDiff = GetHistoryItem(_historyPos);
                NodeDiff.ApplyDiff(Root, undoDiff);

                var redo = NodeDiff.ApplyDiffToSerializedNode(_treeMirror, undoDiff);
                SetHistoryItem(_historyPos, redo);
                _historyPos--;
                NotifyChanges("Undo");
            }
            catch (Exception e)
            {
                Log.Info("Exception on Undo:" + e.Message + Environment.NewLine + e.StackTrace);
                _historyList.Clear();
                _historyPos = -1;
                _reasonList = new List<string>();
                _transactStarted = false;
            }
        }

        /// <summary>
        ///   Goes to next Transact call in a history list
        /// </summary>
        public void Redo()
        {
            if (_historyPos < -1 || _historyPos >= _historyList.Count - 1) return;
            var redoDiff = GetHistoryItem(_historyPos + 1);
            NodeDiff.ApplyDiff(Root, redoDiff);

            var redo = new NodeDiff(null);
            redo.ComputeMarkingDiff(_treeMirror, Root);

            var undo = NodeDiff.ApplyDiffToSerializedNode(_treeMirror, redoDiff);

            SetHistoryItem(_historyPos + 1, undo);
            _historyPos++;
            NotifyChanges("Redo");
        }

        /// <summary>
        ///   Creates a snapshot of a Node
        /// </summary>
        /// <param name = "tree">a Node item</param>
        /// <returns>A node snapshot that can be serialized and compared later</returns>
        public static SerializedNode ReflectTreeMirror(Node tree)
        {
            return AddReflectNodes(tree);
        }


        private static SerializedNode AddReflectNodes(Node node)
        {
            var result = new SerializedNode(node.Index);
            foreach (var child in node.Children)
            {
                result.Children[child.Key] = AddReflectNodes(child.Value);
            }
            foreach (var aib in node.Interpreters)
            {
                var data = new AttributeData(aib.Key);
                aib.Value.Serialize(data);
                result.Interpreters[aib.Key] = data;
            }
            return result;
        }

        private static bool NodeIsDeleted(Node node)
        {
            var integerInterpreter = node.Set<DrawingAttributesInterpreter>();
            return integerInterpreter.Visibility == ObjectVisibility.ToBeDeleted;
        }

        /// <summary>
        ///   Searches if a node is referenced by some other node form data tree
        /// </summary>
        /// <param name = "node"></param>
        /// <returns></returns>
        private static IEnumerable<Node> NodeIsReferenced(Node node)
        {
            var root = node.Root;
            foreach (var shapeNode in root.Children.Values)
            {
                if (NodeReferences(shapeNode, node))
                    yield return shapeNode;
            }
        }

        /// <summary>
        ///   Searches if a node is referenced by some other node form data tree
        /// </summary>
        /// <param name = "node"></param>
        /// <returns></returns>
        private static bool NodeIsReferenced(Node node, Node root)
        {
            foreach (var shapeNode in root.Children.Values)
            {
                if (NodeReferences(shapeNode, node) || NodeReferences(node, shapeNode))
                {
                    if (shapeNode.Get<StringInterpreter>().Value.StartsWith("Sketch"))
                        continue;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        ///   Verfies if the node is refered by the parent node
        /// </summary>
        /// <param name = "parentNode"></param>
        /// <param name = "node"></param>
        /// <returns></returns>
        public static bool NodeReferences(Node parentNode, Node node)
        {
            // Verfies if the node is referenced by the parent node
            // e.g. try to delete point (=node) which is referenced by a line (=parentNode)
            foreach (var childNode in parentNode.Children.Values)
            {
                var refInterpreter = childNode.Get<ReferenceInterpreter>();
                if (refInterpreter != null)
                    if (refInterpreter.Node == node)
                        return true;
                var refListInterpreter = childNode.Get<ReferenceListInterpreter>();
                if (refListInterpreter == null) continue;
                foreach (var refListNode in refListInterpreter.Nodes)
                    if (refListNode.Node == node)
                        return true;
            }

            var inheritedCloneInterpreter = parentNode.Get<InheritedCloneInterpreter>();
            if (inheritedCloneInterpreter != null)
                if (inheritedCloneInterpreter.Node == node)
                    return true;

            return false;
        }

        public bool OptimizeTree()
        {
            List<int> deletedNodesIndexes = new List<int>();
            foreach (var shapeNode in Root.Children.Values)
                if (NodeIsDeleted(shapeNode))
                {
                    var shapeGraph = new ShapeGraph();
                    shapeGraph.SetDocument(this);
                    shapeGraph.Update();
                    var toDelete = shapeGraph.GetDeleteCandidates(new List<int>() { shapeNode.Index });
                  
                    foreach(var node in toDelete)
                        if(!deletedNodesIndexes.Contains(node))
                            deletedNodesIndexes.Add(node);
                }

            foreach (var removedNode in deletedNodesIndexes)
                Root.Remove(removedNode);
            return deletedNodesIndexes.Count != 0;
        }

        /// <summary>
        ///   Save a file to a specific location as XML content
        /// </summary>
        /// <param name = "fileName">Filename location</param>
        public void SaveToXml(string fileName)
        {
            //if (_reasonList.Count > 0)
            //{
            //    Transact();
            //    var isOptimized = OptimizeData();
            //    if (isOptimized)
            //        Commit("Document optimized");
            //    else
            //        Revert();
            //}

            DumpToXml(fileName);
        }


        public void DumpToXml(string fileName)
        {
            if (_treeMirror == null)
                _treeMirror = ReflectTreeMirror(Root);
            XmlHelper.SaveToXml(_treeMirror, fileName);
        }

        public bool OptimizeData()
        {
           return OptimizeTree();
        }

        /// <summary>
        ///   Save a file from a specific location as XML content
        /// </summary>
        /// <param name = "fileName">Filename location</param>
        public bool LoadFromXml(string fileName)
        {
            try
            {
                var oldTree = _treeMirror;
                _treeMirror = XmlHelper.LoadFromXml(fileName);
                if (_treeMirror == null)
                {
                    _treeMirror = oldTree;
                    NaroMessage.Show("Invalid NaroXML file. NaroCAD cannot open this file");
                    return false;
                }
                Transact();
                var undo = new NodeDiff(null);
                var redo = new NodeDiff(null);
                var currentTreeMirror = ReflectTreeMirror(Root);

                NodeDiff.ComputeDiff(currentTreeMirror, _treeMirror, undo, redo);
                try
                {
                    NodeDiff.ApplyDiff(Root, redo);
                }
                catch (Exception ex)
                {
                    Log.Info(string.Format("Exception loading file: {0} with message: {1} with stack: {2}", fileName,
                                           ex.Message, ex.StackTrace));
                    NaroMessage.Show(string.Format("Cannot load file {0}", fileName));

                    var brokenTreeMirror = ReflectTreeMirror(Root);
                    NodeDiff.ComputeDiff(brokenTreeMirror, currentTreeMirror, undo, redo);
                    NodeDiff.ApplyDiff(Root, undo);
                }

                Commit("Loaded file: " + fileName);
                return true;
            }
            catch (Exception e)
            {
                Revert();
                Log.Info("Error on loading xml: " + e.Message + Environment.NewLine + "Stack: " + e.StackTrace);
                return false;
            }
        }

        public static void CopyPasteRef(Node source, Node destination)
        {
            destination.RemoveAllChildren();
            destination.RemoveAllInterpreters();
            foreach (var childNode in source.Children.Values)
            {
                CopyPasteRef(childNode, destination[childNode.Index]);
            }
            destination.Set<InheritedCloneInterpreter>().Node = source;
        }

        public static Node CopyPaste(Node source)
        {
            var childrenList = new List<Node>();
            var newNodesIndexes = new Dictionary<int, Node>();
            foreach (var childNode in source.Children)
            {
               if (childNode.Value.Get<ReferenceInterpreter>() != null && !childNode.Value.Get<ReferenceInterpreter>().Node.Get<StringInterpreter>().Value.StartsWith(FunctionNames.Sketch))
               {
                   childrenList.Add(childNode.Value.Get<ReferenceInterpreter>().Node);
               }
            }
            foreach(var child in childrenList)
            {
                var destinationChild = source.Root.AddNewChild();
                CopyPaste(child, destinationChild);
            
                destinationChild.Set<StringInterpreter>().Value = destinationChild.Get<StringInterpreter>().Value +" Copy";
                newNodesIndexes.Add(child.Index, destinationChild);
            }
            var destination = source.Root.AddNewChild();
            CopyPaste(source, destination);
            foreach (var childNode in destination.Children)
            {
                if (childNode.Value.Get<ReferenceInterpreter>() != null && !childNode.Value.Get<ReferenceInterpreter>().Node.Get<StringInterpreter>().Value.StartsWith(FunctionNames.Sketch))
                {
                    if(newNodesIndexes.ContainsKey(childNode.Value.Get<ReferenceInterpreter>().Node.Index))
                    {
                        childNode.Value.Set<ReferenceInterpreter>().Node =
                            newNodesIndexes[childNode.Value.Get<ReferenceInterpreter>().Node.Index];
                    }
                }
            }
           
            return destination;
        }

        private static void CopyPaste(Node source, Node destination)
        {
            destination.RemoveAllChildren();
            destination.RemoveAllInterpreters();
            foreach (var childNode in source.Children)
            {
                CopyPaste(childNode.Value, destination.FindChild(childNode.Key, true));
            }
            foreach (var childInterpreter in source.Interpreters)
            {
                destination.Interpreters[childInterpreter.Key] = AttributeInterpreterFactory.GetInterpreter(
                    childInterpreter.Key,
                    destination);
            }
            foreach (var childInterpreter in source.Interpreters)
            {
                var data = new AttributeData(childInterpreter.Key);
                childInterpreter.Value.Serialize(data);
                destination.Interpreters[childInterpreter.Key].Deserialize(data);
            }
        }

        public IEnumerable<Node> ImpactedRootNodes()
        {
            var root = Root;
            if (root.Markings == null)
                return new List<Node>();
            var result = new List<Node>();

            var marked = root.Markings.Keys;
            foreach (var item in marked)
            {
                var impactedNode = root.FindChild(item, false);
                if (impactedNode != null)
                    result.Add(impactedNode);
            }
            return result;
        }

        #endregion
    }
}