#region Usings

using System;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeData.Capabilities
{
    public struct ConceptBuilder
    {
        private ConceptInterpreter _concept;
        private Node _node;

        public ConceptBuilder(Node node)
        {
            _node = node;
            _concept = _node != null ? _node.Set<ConceptInterpreter>() : null;
        }

        public Node Node
        {
            get { return _node; }
            private set { _node = value; }
        }

        private ConceptInterpreter Concept
        {
            get { return _concept; }
            set { _concept = value; }
        }

        private string Name
        {
            get { return Concept.Value; }
        }

        public bool HasCapability(string capability)
        {
            if (Concept.BlackList.ContainsKey(capability))
            {
                return false;
            }
            if (Concept.HasCapability(capability))
            {
                return true;
            }
            foreach (var child in Node.Children.Values)
            {
                var ri = child.Get<ReferenceInterpreter>();
                if (ri == null) continue;
                var cb = new ConceptBuilder(ri.Node);
                if (cb.HasCapability(capability))
                    return true;
            }
            return false;
        }

        public bool IsRelatedWith(string relatedConceptName)
        {
            return GetRelatedConcept(relatedConceptName)._node != null;
        }

        public ConceptBuilder GetRelatedConcept(string relatedConcept)
        {
            if (Name == relatedConcept)
            {
                return this;
            }
            foreach (var child in Node.Children.Values)
            {
                var ri = child.Get<ReferenceInterpreter>();
                if (ri == null) continue;
                var cb = new ConceptBuilder(ri.Node);
                var result = cb.GetRelatedConcept(relatedConcept);
                if (result._node != null)
                {
                    return result;
                }
            }
            return new ConceptBuilder(null);
        }

        public void RemoveBlackistedCapability(string capability)
        {
            Concept.RemoveBlackListedCapability(capability);
        }

        public void SetCapability(string capability, string value)
        {
            if (Concept.BlackList.ContainsKey(capability))
                Concept.RemoveBlackListedCapability(capability);
            Concept.Data[capability] = value;
            return;
        }

        public void AddBlacklistedCapability(string capability)
        {
            if (Concept == null)
                throw new NullReferenceException("Concept should be defined");
            Concept.BlackListCapability(capability);
        }

        public string GetCapability(string capability)
        {
            string value;
            if (Concept.BlackList.ContainsKey(capability))
            {
                return string.Empty;
            }

            if (Concept.Data.TryGetValue(capability, out value))
            {
                return value;
            }
            foreach (var child in Node.Children.Values)
            {
                var ri = child.Get<ReferenceInterpreter>();
                if (ri == null) continue;
                var cb = new ConceptBuilder(ri.Node);
                var childCapability = cb.GetCapability(capability);
                if (!string.IsNullOrEmpty(childCapability))
                {
                    return childCapability;
                }
            }
            return string.Empty;
        }

        public void AddRelatedConcept(ConceptBuilder relatedConcept)
        {
            if (GetRelatedConcept(relatedConcept.Name).Node != null) return;
            Node.AddNewChild().Set<ReferenceInterpreter>().Node = relatedConcept.Node;
        }
    }
}