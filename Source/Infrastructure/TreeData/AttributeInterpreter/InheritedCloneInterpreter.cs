#region Usings

using System.Collections.Generic;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class InheritedCloneInterpreter : AttributeInterpreterBase
    {
        public Node Node
        {
            get { return _node; }
            set
            {
                if (_node != null)
                {
                    _node.OnModified -= OnReferencedModified;
                }
                _node = value;
                _node.OnModified += OnReferencedModified;
                Parent.OnModified += OnParentModified;
                if (_blackListAttributes == null)
                    _blackListAttributes = new List<int>();
                foreach (var interpreter in _node.Interpreters)
                {
                    if (_blackListAttributes.Contains(interpreter.Key)) continue;
                    var data = interpreter.Value.Serialize();
                    var destInterpreter =
                        AttributeInterpreterFactory.GetInterpreter(interpreter.Key, Parent);
                    Parent.Interpreters[interpreter.Key] = destInterpreter;
                    destInterpreter.Deserialize(data);
                }
                OnModified();
            }
        }

        private void OnReferencedModified(Node node, AttributeInterpreterBase atttributeName)
        {
            var attrId = atttributeName.GetType().GetHashCode();
            if (_blackListAttributes.Contains(attrId))
                return;
            _lockParent = true;
            var data = _node.Interpreters[attrId].Serialize();
            if (!Parent.Interpreters.ContainsKey(attrId))
                Parent.Interpreters[attrId] = AttributeInterpreterFactory.GetInterpreter(attrId, Parent);
            Parent.Interpreters[attrId].Deserialize(data);
            _lockParent = false;

            OnModified();
        }

        private void OnParentModified(Node node, AttributeInterpreterBase atttributeName)
        {
            if (_lockParent)
                return;
            var attrId = atttributeName.GetHashCode();
            if (_blackListAttributes.Contains(attrId))
                _blackListAttributes.Add(attrId);
        }

        public override void OnRemove()
        {
            if (_node == null) return;
            _node.OnModified -= OnReferencedModified;
            _node = null;
        }

        public override void Serialize(AttributeData data)
        {
            if (_node == null)
            {
                data.WriteAttribute("Value", "");
            }
            else
            {
                data.WriteAttribute("Value", Parent, _node);
                data.WriteAttribute("BlackList", _blackListAttributes);
            }
        }

        public override void Deserialize(AttributeData data)
        {
            _blackListAttributes = data.ReadAttributeListInteger("BlackList");
            Node = data.ReadAttributeReference("Value", Parent);
        }

        #region Data members

        private List<int> _blackListAttributes;
        private bool _lockParent;
        private Node _node;

        #endregion
    }
}