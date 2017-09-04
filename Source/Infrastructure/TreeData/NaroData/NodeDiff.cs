#region Usings

using System;
using System.Collections.Generic;
using log4net;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.NaroData
{
    public class NodeDiff
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (NodeDiff));

        public NodeDiff(NodeDiff parent)
        {
            InitialSetup();
            Parent = parent;
        }

        public List<int> RemovedAttributes { get; private set; }

        public SortedDictionary<int, AttributeData> ModifiedAttributeData { get; private set; }
        public List<int> RemovedNodes { get; private set; }
        public SortedDictionary<int, NodeDiff> Children { get; private set; }

        private NodeDiff Parent { get; set; }
        private bool Applied { get; set; }

        public NodeDiff Clone
        {
            get
            {
                var result = new NodeDiff(null) {Children = new SortedDictionary<int, NodeDiff>()};

                foreach (var child in Children)
                {
                    result.Children[child.Key] = child.Value.Clone;
                    result.Children[child.Key].Parent = result;
                }

                foreach (var removed in RemovedNodes)
                    result.RemovedNodes.Add(removed);

                foreach (var attr in ModifiedAttributeData)
                    result.ModifiedAttributeData[attr.Key] = attr.Value;

                foreach (var attr in RemovedAttributes)
                    result.RemovedAttributes.Add(attr);
                return result;
            }
        }

        public bool Empty
        {
            get
            {
                return (Children == null || Children.Count == 0)
                       && (ModifiedAttributeData == null || ModifiedAttributeData.Count == 0)
                       && (RemovedAttributes == null || RemovedAttributes.Count == 0)
                       && (RemovedNodes == null || RemovedNodes.Count == 0);
            }
        }

        private void InitialSetup()
        {
            ModifiedAttributeData = new SortedDictionary<int, AttributeData>();
            RemovedAttributes = new List<int>();

            RemovedNodes = new List<int>();
            Children = new SortedDictionary<int, NodeDiff>();
        }

        private static bool DiffContainsChanges(NodeDiff diff)
        {
            var nodeChanged = (diff.RemovedAttributes.Count != 0) || (diff.RemovedNodes.Count != 0) ||
                              (diff.ModifiedAttributeData.Count != 0);
            if (nodeChanged)
                return true;

            foreach (var childDiff in diff.Children.Values)
            {
                var subDiffChanged = DiffContainsChanges(childDiff);
                if (subDiffChanged)
                    return true;
            }

            return false;
        }

        private static void ComputeDiffChild(SerializedNode fromTree, SerializedNode toTree, NodeDiff diff)
        {
            ProcessNodeDifferences(fromTree, toTree, diff);
            //compute the difference between attributes
            ProcessAttributesNodeDifferences(toTree, fromTree, diff);
            foreach (var toNode in fromTree.Children.Values)
            {
                if (!toTree.Children.ContainsKey(toNode.Index)) continue;
                var subUndoDiff = new NodeDiff(diff);
                ComputeDiffChild(fromTree.Children[toNode.Index], toTree.Children[toNode.Index], subUndoDiff);
                if (!DiffContainsChanges(subUndoDiff)) continue;
                diff.Children[toNode.Index] = subUndoDiff;
                diff.Children[toNode.Index].Parent = diff;
            }
        }

        private static AttributeData GetSerializedAttribute(SerializedNode node, int attributeNameId)
        {
            return node.Interpreters[attributeNameId];
        }

        private static void ProcessAttributesNodeDifferences(SerializedNode fromTree, SerializedNode toTree,
                                                             NodeDiff applyDiff)
        {
            var fromInterpreters = fromTree.Interpreters;
            var toInterpreters = toTree.Interpreters;
            foreach (var attributeName in fromInterpreters.Keys)
            {
                if (false == toInterpreters.ContainsKey(attributeName))
                {
                    applyDiff.RemovedAttributes.Add(attributeName);
                }
                else
                {
                    var fromData = GetSerializedAttribute(fromTree, attributeName);
                    var toData = GetSerializedAttribute(toTree, attributeName);

                    if (false == fromData.IsSame(toData))
                        applyDiff.ModifiedAttributeData[attributeName] = toData;
                }
            }
            foreach (var attributeName in toInterpreters.Keys)
            {
                if (false == fromTree.Interpreters.ContainsKey(attributeName))
                    applyDiff.ModifiedAttributeData[attributeName] = GetSerializedAttribute(toTree, attributeName);
            }
        }

        private static void ReflectTreeAttributesToDiff(SerializedNode node, NodeDiff diff)
        {
            foreach (var attribute in node.Interpreters.Keys)
            {
                diff.ModifiedAttributeData[attribute] = GetSerializedAttribute(node, attribute);
            }
        }

        private static NodeDiff ReflectTreeAsDiff(SerializedNode node)
        {
            var result = new NodeDiff(null);
            ReflectTreeAttributesToDiff(node, result);
            foreach (var child in node.Children.Values)
            {
                result.Children[child.Index] = ReflectTreeAsDiff(child);
                result.Children[child.Index].Parent = result;
            }

            return result;
        }

        private static void ProcessNodeDifferences(SerializedNode fromTree, SerializedNode toTree, NodeDiff diff)
        {
            foreach (var sourceChild in fromTree.Children)
            {
                if (toTree.Children.ContainsKey(sourceChild.Key)) continue;
                diff.Children[sourceChild.Key] = ReflectTreeAsDiff(sourceChild.Value);
                diff.Children[sourceChild.Key].Parent = diff;
            }
            foreach (var destChild in toTree.Children)
            {
                if (!fromTree.Children.ContainsKey(destChild.Key))
                    diff.RemovedNodes.Add(destChild.Key);
            }
        }

        public static void ComputeDiff(SerializedNode fromTree, SerializedNode toTree, NodeDiff diff, NodeDiff redoDiff)
        {
            ComputeDiffChild(fromTree, toTree, diff);
            ComputeDiffChild(toTree, fromTree, redoDiff);
        }

        public void ComputeMarkingDiff(SerializedNode fromTree, Node toTree)
        {
            //compute the difference between attributes
            var fromInterpreters = fromTree.Interpreters;
            var toInterpreters = toTree.Interpreters;
            foreach (var attributeNameId in fromInterpreters.Keys)
            {
                if (false == toInterpreters.ContainsKey(attributeNameId))
                {
                    RemovedAttributes.Add(attributeNameId);
                }
                else
                {
                    var fromData = GetSerializedAttribute(fromTree, attributeNameId);
                    var toData = toTree.Interpreters[attributeNameId].Serialize();

                    if (false == fromData.IsSame(toData))
                        ModifiedAttributeData[attributeNameId] = toData;
                }
            }
            foreach (var attributeNameId in toInterpreters.Keys)
            {
                if (fromTree.Interpreters.ContainsKey(attributeNameId)) continue;
                var toData = toTree.Interpreters[attributeNameId].Serialize();
                ModifiedAttributeData[attributeNameId] = toData;
            }

            if (toTree.Markings == null) return;
            foreach (var childIndex in toTree.Markings.Keys)
            {
                if (!toTree.Children.ContainsKey(childIndex))
                {
                    if (fromTree.Children.ContainsKey(childIndex))
                    {
                        RemovedNodes.Add(childIndex);
                    }
                }
                else if (!fromTree.Children.ContainsKey(childIndex))
                {
                    if (toTree.Children.ContainsKey(childIndex))
                    {
                        Children[childIndex] = ReflectTreeAsDiff(Document.ReflectTreeMirror(toTree.Children[childIndex]));
                    }
                }
                else
                {
                    var childRedoDiff = new NodeDiff(this);

                    childRedoDiff.ComputeMarkingDiff(
                        fromTree.Children[childIndex],
                        toTree.Children[childIndex]);
                    if (!childRedoDiff.Empty)
                    {
                        Children[childIndex] = childRedoDiff;
                    }
                }
            }
            toTree.ClearMarkings();
        }

        public static void ApplyDiff(Node fromTree, NodeDiff diff)
        {
            ModifyNodeWithDiff(diff, fromTree);
        }

        /// <summary>
        ///   Apply a specific diff to a tree
        /// </summary>
        /// <param name = "treeNode"></param>
        /// <param name = "diff">The diff data that needs to be applied</param>
        /// <returns>Undo diff tree</returns>
        public static NodeDiff ApplyDiffToSerializedNode(SerializedNode treeNode, NodeDiff diff)
        {
            var returnValue = new NodeDiff(null);

            foreach (var modifiedNode in diff.Children.Keys)
            {
                if (treeNode.Children.ContainsKey(modifiedNode)) continue;
                treeNode.Children[modifiedNode] = new SerializedNode(modifiedNode);
                returnValue.RemovedNodes.Add(modifiedNode);
            }

            foreach (var removedNode in diff.RemovedNodes)
            {
                returnValue.Children[removedNode] = ReflectTreeAsDiff(treeNode.Children[removedNode]);
                treeNode.Children.Remove(removedNode);
            }

            foreach (var modifiedNode in diff.Children.Keys)
            {
                var childDiff = diff.Children[modifiedNode];
                if (!treeNode.Children.ContainsKey(modifiedNode))
                    continue;
                var childNode = treeNode.Children[modifiedNode];

                var undoDiffChildNode = ApplyDiffToSerializedNode(childNode, childDiff);
                if (undoDiffChildNode.Empty == false)
                    returnValue.Children[modifiedNode] = undoDiffChildNode;
            }

            foreach (var modifiedAttr in diff.ModifiedAttributeData)
            {
                if (!treeNode.Interpreters.ContainsKey(modifiedAttr.Key))
                {
                    returnValue.RemovedAttributes.Add(modifiedAttr.Key);
                }
                else
                {
                    returnValue.ModifiedAttributeData[modifiedAttr.Key] = treeNode.Interpreters[modifiedAttr.Key];
                }
                treeNode.Interpreters[modifiedAttr.Key] = modifiedAttr.Value;
            }

            foreach (var removedAttr in diff.RemovedAttributes)
            {
                returnValue.ModifiedAttributeData[removedAttr] = treeNode.Interpreters[removedAttr];
                treeNode.Interpreters.Remove(removedAttr);
            }
            return returnValue;
        }

        private static void ModifyNodeWithDiff(NodeDiff diff, Node result)
        {
            if (diff.Applied)
                return;
            diff.Applied = true;

            foreach (var removedNode in diff.RemovedNodes)
            {
                if (diff.Children.ContainsKey(removedNode))
                    diff.Children.Remove(removedNode);
                result.Remove(removedNode);
            }

            foreach (var modifiedNode in diff.Children.Keys)
            {
                var childDiff = diff.Children[modifiedNode];
                if (!result.Children.ContainsKey(modifiedNode))
                    result.AddChild(modifiedNode);
                var childNode = result.Children[modifiedNode];

                ModifyNodeWithDiff(childDiff, childNode);
            }
            AttributeInterpreterBase functionInterpreter = null;
            AttributeData attrData = null;
            foreach (var modifiedAttr in diff.ModifiedAttributeData)
            {
                AttributeInterpreterBase interpreter;
                var key = AttributeInterpreterFactory.GetTypeId(modifiedAttr.Value.Name);
                if (!result.Interpreters.ContainsKey(key))
                {
                    interpreter = AttributeInterpreterFactory.GetInterpreter(key, result);
                    result.Interpreters[key] = interpreter;
                }
                else
                    interpreter = result.Interpreters[modifiedAttr.Key];
                try
                {
                    if (modifiedAttr.Value.Name == "Function")
                    {
                        functionInterpreter = interpreter;
                        attrData = modifiedAttr.Value;
                        continue;
                    }
                    if (modifiedAttr.Key == typeof (ReferenceInterpreter).GetHashCode())
                    {
                        interpreter.Disable();
                        interpreter.Deserialize(modifiedAttr.Value);
                        var refNode = result.Get<ReferenceInterpreter>().Node;
                        DeserializeTargetNode(diff, result, refNode);
                        interpreter.Enable();
                    }

                    if (modifiedAttr.Key == typeof (ReferenceListInterpreter).GetHashCode())
                    {
                        interpreter.Disable();
                        interpreter.Deserialize(modifiedAttr.Value);
                        var refNodes = new List<SceneSelectedEntity>();
                        foreach (var refnode in result.Get<ReferenceListInterpreter>().Nodes)
                            refNodes.Add(refnode);

                        foreach (var refNode in refNodes)
                            DeserializeTargetNode(diff, result, refNode.Node);
                        interpreter.Enable();
                    }
                    interpreter.Deserialize(modifiedAttr.Value);
                }
                catch (Exception ex)
                {
                    var path = AttributeData.RelativeReferencePath(result.Root, result);
                    var interpreterName = AttributeInterpreterFactory.GetName(modifiedAttr.Key);
                    Log.Info("Error on node: (" + path + ") interpreter: " + interpreterName
                             + Environment.NewLine + " Message: " + ex.Message
                             + Environment.NewLine + " Stack: " + ex.StackTrace);
                 //   throw;
                }
            }

            if (functionInterpreter != null)
                functionInterpreter.Deserialize(attrData);
            
            foreach (var removedAttr in diff.RemovedAttributes)
            {
                result.RemoveInterpreter(removedAttr);
            }
        }

        private static void DeserializeTargetNode(NodeDiff diff, Node result, Node refNode)
        {
            var diffPath = AttributeData.RelativeReferencePath(result, refNode);
            var destDiff = diff;
            var pathItems = diffPath.Split(':');
            var destNode = result;
            foreach (var item in pathItems)
            {
                if (string.IsNullOrEmpty(item))
                {
                    destNode = destNode.Parent;
                    destDiff = destDiff.Parent;
                }
                else
                {
                    var index = Convert.ToInt32(item);
                    if (!destDiff.Children.ContainsKey(index))
                    {
                        return;
                    }
                    destNode = destNode.Children[index];
                    destDiff = destDiff.Children[index];
                }
            }
            ModifyNodeWithDiff(destDiff, destNode);
        }
    }
}