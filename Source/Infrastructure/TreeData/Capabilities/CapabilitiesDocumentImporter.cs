#region Usings

using System.Collections.Generic;
using System.IO;
using System.Text;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeData.Capabilities
{
    public static class CapabilitiesDocumentImporter
    {
        public static void LoadFileCapabilities(string xmlSourceFileName, string fileName)
        {
            var document = new Document();
            document.LoadFromXml(xmlSourceFileName);

            LoadFileCapabilities(document, fileName);
        }

        private static void LoadFileCapabilities(Document document, string fileName)
        {
            var lines = new List<string>();
            foreach (var node in document.Root.Children.Values)
            {
                var concept = node.Get<ConceptInterpreter>();
                WriteConceptName(node, concept, lines);
                ExtractConceptKeys(concept, lines);
                ExtractExcludedCapabilities(concept, lines);
                lines.Add("End");
            }
            File.WriteAllLines(fileName, lines.ToArray());
        }

        private static void ExtractExcludedCapabilities(ConceptInterpreter concept, ICollection<string> lines)
        {
            if (concept.BlackList.Count <= 0) return;
            var textBuilder = new StringBuilder();
            textBuilder.Append(" Section Excluded");
            foreach (var key in concept.BlackList.Keys)
            {
                textBuilder.AppendLine();
                textBuilder.Append("  ");
                textBuilder.Append(key);
            }
            lines.Add(textBuilder.ToString());
            lines.Add(" End");
        }

        private static void ExtractConceptKeys(ConceptInterpreter concept, ICollection<string> lines)
        {
            if (concept.Data.Count <= 0) return;
            var textBuilder = new StringBuilder();
            textBuilder.Append(" Section Keys");
            foreach (var conceptKey in concept.Data)
            {
                textBuilder.AppendLine();
                textBuilder.Append("  ");
                textBuilder.Append(conceptKey.Key);
                textBuilder.Append(" = \"");
                textBuilder.Append(conceptKey.Value);
                textBuilder.Append("\"");
            }
            lines.Add(textBuilder.ToString());

            lines.Add(" End");
        }

        private static void WriteConceptName(Node node, StringInterpreter concept, ICollection<string> lines)
        {
            var conceptName = concept.Value;

            var textBuilder = new StringBuilder();
            textBuilder.Append("Concept \"");
            textBuilder.Append(conceptName);
            textBuilder.Append("\"");
            DescribeRelatedConcepts(node, textBuilder);
            lines.Add(textBuilder.ToString());
        }

        private static void DescribeRelatedConcepts(Node node, StringBuilder textBuilder)
        {
            var firstRelated = true;
            foreach (var referencedConcept in node.Children.Values)
            {
                var refNodeInterpreter =
                    referencedConcept.Get<ReferenceInterpreter>().Node.Get<ConceptInterpreter>();
                if (firstRelated)
                {
                    textBuilder.Append(" is ");
                    firstRelated = false;
                }
                else
                {
                    textBuilder.Append(", ");
                }
                textBuilder.Append("\"");
                textBuilder.Append(refNodeInterpreter.Value);
                textBuilder.Append("\"");
            }
        }
    }
}