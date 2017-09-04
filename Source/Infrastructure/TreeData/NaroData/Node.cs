#region Usings

using System.Collections.Generic;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.NaroData
{
    public class Node
    {
        #region Constructors

        /// <summary>
        ///   Constructors of a child node. It will setup as a specific child at a specified index
        /// </summary>
        /// <param name = "parent">Parent of current node</param>
        /// <param name = "childIndex">The index in the children of parents</param>
        private Node(Node parent, int childIndex)
        {
            SetupNode(parent, childIndex);
        }

        /// <summary>
        /// </summary>
        public Node()
        {
            SetupNode(null, -1);
        }

        /// <summary>
        ///   Defines a child node of a parent at the specified index
        /// </summary>
        /// <param name = "parent"></param>
        /// <param name = "index"></param>
        private void SetupNode(Node parent, int index)
        {
            MaxChild = -1;
            Parent = parent;
            Index = index;
            Children = new SortedDictionary<int, Node>();
            OnModified += OnModifiedEvent;
            Interpreters = new Dictionary<int, AttributeInterpreterBase>();
            Mark();
        }

        #endregion

        #region Private data

        private bool _invalidMaxChild;
        private int _maxChild;

        #endregion

        #region Properties

        public Node this[int childId]
        {
            get { return FindChild(childId, true); }
        }

        public string Path
        {
            get { return AttributeData.RelativeReferencePath(Root, this); }
        }

        /// <summary>
        ///   The index that locate the ndoe in paren'ts children list
        /// </summary>
        public int Index { get; private set; }

        /// <summary>
        ///   Children attached to the node
        /// </summary>
        public SortedDictionary<int, Node> Children { get; private set; }

        public ICollection<Node> ChildrenList
        {
            get { return Children.Values; }
        }

        /// <summary>
        ///   Interpreters attached to the node
        /// </summary>
        public Dictionary<int, AttributeInterpreterBase> Interpreters { get; private set; }

        /// <summary>
        ///   index of maximum child id. It can be used for easily locate the last added child in current tree
        /// </summary>
        private int MaxChild
        {
            get
            {
                if (!_invalidMaxChild) return _maxChild;
                foreach (var key in Children)
                    _maxChild = key.Key;
                return _maxChild;
            }
            set
            {
                _invalidMaxChild = false;
                _maxChild = value;
            }
        }

        /// <summary>
        ///   The parent of the current node
        /// </summary>
        public Node Parent { get; private set; }

        /// <summary>
        ///   Gets the root node in the current tree of nodes that contains the this node
        /// </summary>
        public Node Root
        {
            get { return Parent != null ? Parent.Root : this; }
        }

        #endregion

        #region Methods

        #region Children nodes management

        /// <summary>
        /// </summary>
        /// <param name = "childId"></param>
        /// <param name = "add"></param>
        /// <returns></returns>
        public Node FindChild(int childId, bool add)
        {
            if (Children.ContainsKey(childId))
                return Children[childId];
            return add ? AddChild(childId) : null;
        }

        /// <summary>
        /// </summary>
        /// <param name = "childId"></param>
        /// <returns></returns>
        public Node AddChild(int childId)
        {
            if (Children.ContainsKey(childId))
                return Children[childId];
            var result = new Node(this, childId);
            if (childId > MaxChild)
                MaxChild = childId;
            Children[childId] = result;
            return result;
        }


        /// <summary>
        ///   Add a new child at the end of the children list
        /// </summary>
        /// <returns>the new added child node</returns>
        public Node AddNewChild()
        {
            ++MaxChild;
            var result = new Node(this, MaxChild);
            Children[MaxChild] = result;
            return result;
        }

        /// <summary>
        ///   Remove a child at a specified child index
        /// </summary>
        /// <param name = "childIndex"></param>
        public void Remove(int childIndex)
        {
            Mark(childIndex);
            if (!Children.ContainsKey(childIndex))
                return;
            var child = Children[childIndex];

            child.RemoveAllInterpreters();
            child.RemoveAllChildren();

            Children.Remove(childIndex);
            _invalidMaxChild = true;
            if (Children.Count == 0)
                MaxChild = -1;
        }

        public void RemoveAllChildren()
        {
            var childList = new List<int>();
            foreach (var child in Children.Keys)
                childList.Add(child);
            foreach (var child in childList)
                Remove(child);
            MaxChild = -1;
        }

        #endregion

        #region Markings

        public SortedDictionary<int, int> Markings { get; private set; }

        /// <summary>
        ///   Clear all markings that say which children were modified
        /// </summary>
        public void ClearMarkings()
        {
            if (Markings == null)
                return;
            foreach (var markNode in Markings.Keys)
            {
                var child = FindChild(markNode, false);
                if (child != null)
                    child.ClearMarkings();
            }
            Markings = null;
        }

        /// <summary>
        ///   Mark a specific child as modified
        /// </summary>
        /// <param name = "index"></param>
        private void Mark(int index)
        {
            if (Markings == null)
            {
                Markings = new SortedDictionary<int, int>();
            }
            Markings[index] = 1;
            Mark();
        }

        /// <summary>
        ///   Mark a node as modified and notify all parents line of this
        /// </summary>
        public void Mark()
        {
            if (Parent != null)
            {
                Parent.Mark(Index);
            }
        }

        #endregion

        #region Interpreters Management

        private void OnModifiedEvent(Node node, AttributeInterpreterBase attributeName)
        {
            Mark();
        }


        public void RemoveAllInterpreters()
        {
            if (Interpreters.Count == 0) return;
            var attrNames = new List<int>();
            foreach (var attr in Interpreters.Keys)
            {
                attrNames.Add(attr);
            }
            foreach (var attr in attrNames)
            {
                Interpreters[attr].OnRemove();
            }
            Interpreters.Clear();
            Mark();
        }


        public void RemoveInterpreter(int nameId)
        {
            AttributeInterpreterBase removedInterpreter;
            if (!Interpreters.TryGetValue(nameId, out removedInterpreter))
                return;
            Interpreters.Remove(nameId);
            removedInterpreter.OnRemove();
            OnModified(this, removedInterpreter);
            return;
        }

        #endregion

        #region Interpreters retrieval

        /// <summary>
        ///   Get the string identifier of a specified interpreter type
        /// </summary>
        /// <returns>Gets the interpreter string name that is identified in the interpreters factory</returns>
        private static int GetInterpreterTypeNameId<T>()
            where T : AttributeInterpreterBase
        {
            var typeId = typeof (T).GetHashCode();

#if DEBUG
            //Should throw exception
            AttributeInterpreterFactory.GetName(typeId);
#endif
            return typeId;
        }


        private T GetId<T>(int id)
            where T : AttributeInterpreterBase
        {
            AttributeInterpreterBase interpreter;
            if (Interpreters.TryGetValue(id, out interpreter))
            {
                return (T) interpreter;
            }
            return null;
        }

        private T UpdateId<T>(int id)
            where T : AttributeInterpreterBase, new()
        {
            var result = GetId<T>(id);
            if (result == null)
            {
                result = new T();
                result.SetupInternal(this);
                Interpreters[id] = result;
            }
            return result;
        }

        /// <summary>
        ///   Gets the corresponding interpreter if exists.
        /// </summary>
        /// <returns>Node's interpreter if exists. It not, it returns null</returns>
        public T Get<T>()
            where T : AttributeInterpreterBase
        {
            return GetId<T>(GetInterpreterTypeNameId<T>());
        }

        /// <summary>
        ///   Creates or return an intepreter of a specified node
        /// </summary>
        /// <returns>Node's interpreter if exists. It not, it creates one</returns>
        public T Set<T>()
            where T : AttributeInterpreterBase, new()
        {
            return UpdateId<T>(GetInterpreterTypeNameId<T>());
        }

        /// <summary>
        ///   Removes an intepreter of a specified node
        /// </summary>
        /// <returns></returns>
        public void Remove<T>()
            where T : AttributeInterpreterBase, new()
        {
            RemoveInterpreter(GetInterpreterTypeNameId<T>());
        }

        #endregion

        #endregion

        #region Events

        #region Delegates

        /// <summary>
        ///   Event that is called at node changes
        /// </summary>
        public delegate void OnModifiedAttributeNode(Node node, AttributeInterpreterBase atttributeType);

        #endregion

        public OnModifiedAttributeNode OnModified;

        #endregion
    }
}