#region Usings

using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace TreeData.Capabilities
{
    public static class CapabilitiesLoader
    {
        private static void InvalidData(string line, int lineIndex, string reason)
        {
            var textBuilder = new StringBuilder();
            textBuilder.Append(reason);
            textBuilder.Append(" (line: ");
            textBuilder.Append(lineIndex);
            textBuilder.AppendLine("):");
            textBuilder.Append("\"");
            textBuilder.Append(line);
            textBuilder.AppendLine("\"");
            throw new InvalidDataException(textBuilder.ToString());
        }

        public static CapabilitiesCollection LoadFileCapabilities(string fileName)
        {
            var collection = new CapabilitiesCollection();
            var lines = File.ReadAllLines(fileName);
            var parseContext = ParseContext.None;
            var lineIndex = 0;
            var concept = new ConceptBuilder(null);
            foreach (var codeLine in lines)
            {
                lineIndex++;
                var line = codeLine.TrimEnd();
                if (line.Contains("'"))
                {
                    var pos = line.IndexOf("'");
                    line = line.Remove(pos).TrimEnd();
                }
                if (string.IsNullOrEmpty(line.Trim()))
                    continue;
                switch (parseContext)
                {
                    case ParseContext.None:
                        ParseContextLine(collection, line, lineIndex, ref concept);
                        parseContext = ParseContext.Concept;
                        break;
                    case ParseContext.Concept:
                        ParseContextBody(line, lineIndex, ref parseContext);
                        break;
                    case ParseContext.Keys:
                        ParseSectionKeys(concept, line, lineIndex, ref parseContext);
                        break;
                    case ParseContext.Excluded:
                        ParseSectionExcluded(concept, line, lineIndex, ref parseContext);
                        break;
                }
            }
            return collection;
        }

        private static void ParseSectionKeys(ConceptBuilder concept, string line, int lineIndex,
                                             ref ParseContext parseContext)
        {
            if (line.Trim() == "End")
            {
                parseContext = ParseContext.Concept;
                return;
            }
            if (line.Contains("="))
            {
                var splitLineByEqual = line.Split('=');
                var capabilityName = splitLineByEqual[0].Trim();
                var splitByQuote = splitLineByEqual[1].Trim().Split('"');
                var conceptValue = splitByQuote[1];
                concept.SetCapability(capabilityName, conceptValue);
                return;
            }
            InvalidData(line, lineIndex, "Unknown code in section Keys");
        }

        private static void ParseSectionExcluded(ConceptBuilder concept, string line, int lineIndex,
                                                 ref ParseContext parseContext)
        {
            if (line.Trim() == "End")
            {
                parseContext = ParseContext.Concept;
                return;
            }
            if (line.Trim().Contains(" "))
            {
                InvalidData(line, lineIndex, "Key names should be indentifier based");
            }
            concept.AddBlacklistedCapability(line.Trim());
        }

        private static void ParseContextBody(string line, int lineIndex, ref ParseContext parseContext)
        {
            if (line.Trim() == "Section Keys")
            {
                parseContext = ParseContext.Keys;
                return;
            }
            if (line.Trim() == "Section Excluded")
            {
                parseContext = ParseContext.Excluded;
                return;
            }
            if (line.Trim() == "End")
            {
                parseContext = ParseContext.None;
                return;
            }
            InvalidData(line, lineIndex, "Unknown section or line sequence");
        }

        private static void ParseContextLine(CapabilitiesCollection collection, string line, int lineIndex,
                                             ref ConceptBuilder conceptBuilder)
        {
            if (!line.StartsWith("Concept"))
                InvalidData(line, lineIndex, "Invalid line to parse. Expected Concept keyword");
            var words = line.Split('\"');
            if (words.Length < 2)
                InvalidData(line, lineIndex, "Expected concept name to be defined");
            var conceptList = new List<string>();
            for (var i = 1; i < words.Length; i += 2)
                conceptList.Add(words[i]);
            if (conceptList.Count == 0)
                InvalidData(line, lineIndex, "Expected concept name between quotes");
            conceptBuilder = collection.AddConcept(conceptList[0]);
            conceptList.RemoveAt(0);
            foreach (var concept in conceptList)
            {
                collection.AddRelation(conceptBuilder, concept);
            }
        }

        #region Nested type: ParseContext

        private enum ParseContext
        {
            None = 0,
            Concept,
            Keys,
            Excluded
        }

        #endregion
    }
}