#region Usings

using System;
using System.Collections.Generic;
using TreeData.NaroData;

#endregion

namespace TreeData.Capabilities
{
    public class CapabilitiesCollection
    {
        public CapabilitiesCollection()
        {
            _document = new Document();
            _document.Transact();
        }

        public IEnumerable<string> ConceptList
        {
            get
            {
                var result = new List<string>();
                foreach (var node in _document.Root.Children.Values)
                {
                    var conceptInterpreter = node.Get<ConceptInterpreter>();
                    if (conceptInterpreter == null)
                        throw new Exception("All nodes should be defined as concepts!");
                    result.Add(conceptInterpreter.Value);
                }
                return result;
            }
        }

        public void SaveAsDocument(string fileName)
        {
            _document.Commit("Commited to save to file: " + fileName);
            _document.SaveToXml(fileName);
        }

        public ConceptBuilder AddConcept(string concept)
        {
            var conceptBuilder = GetConcept(concept);
            if (conceptBuilder.Node != null)
            {
                return conceptBuilder;
            }
            var aNode = _document.Root.AddNewChild();
            aNode.Set<ConceptInterpreter>().Value = concept;
            return new ConceptBuilder(aNode);
        }

        public bool HasConcept(string concept)
        {
            return GetConcept(concept).Node != null;
        }

        public ConceptBuilder GetConcept(string concept)
        {
            foreach (var node in _document.Root.Children.Values)
            {
                if (node.Set<ConceptInterpreter>().Value == concept)
                {
                    return new ConceptBuilder(node);
                }
            }
            return new ConceptBuilder(null);
        }

        public bool IsRelatedWith(string concept, string relation)
        {
            var conceptBuilder = GetConcept(concept);
            var related = conceptBuilder.GetRelatedConcept(relation);
            return related.Node != null;
        }

        public void AddRelation(string concept, string relation)
        {
            var node = AddConcept(concept);
            var relationBuilder = AddConcept(relation);
            node.AddRelatedConcept(relationBuilder);
        }

        public void AddRelation(ConceptBuilder concept, string relation)
        {
            var relationBuilder = AddConcept(relation);
            concept.AddRelatedConcept(relationBuilder);
        }

        #region Data members

        private readonly Document _document;

        #endregion
    }
}