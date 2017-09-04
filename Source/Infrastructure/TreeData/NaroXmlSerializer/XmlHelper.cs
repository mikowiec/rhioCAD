#region Usings

using System;
using System.IO;
using System.Xml;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.NaroXmlSerializer
{
    public static class XmlHelper
    {
        /// <summary>
        /// </summary>
        /// <param name = "node"></param>
        /// <param name = "fileName"></param>
        public static void SaveToXml(SerializedNode node, string fileName)
        {
            var xmldoc = CreateXmlDocument();

            var xmlelem = CreateXmlNode(node, xmldoc);
            xmldoc.AppendChild(xmlelem);

            if (fileName != null)
            {
                xmldoc.Save(fileName);
            }
        }

        private static XmlDocument CreateXmlDocument()
        {
            var xmldoc = new XmlDocument();

            var xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);
            return xmldoc;
        }

        private static XmlElement CreateXmlNode(SerializedNode node, XmlDocument xmldoc)
        {
            var xmlelem = xmldoc.CreateElement("", "Item", "");
            if (node.Index != -1)
            {
                var attr = xmldoc.CreateAttribute("id");
                attr.Value = node.Index.ToString();
                xmlelem.Attributes.Append(attr);
            }

            foreach (var child in node.Children)
            {
                var childElem = CreateXmlNode(child.Value, xmldoc);
                xmlelem.AppendChild(childElem);
            }

            foreach (var interpreter in node.Interpreters)
            {
                var childElem = xmldoc.CreateElement("", "Interpterer", "");
                var attr = xmldoc.CreateAttribute("Name");
                attr.Value = AttributeInterpreterFactory.GetName(interpreter.Key);
                childElem.Attributes.Append(attr);
                var data = interpreter.Value;

                xmlelem.AppendChild(data.CreateXmlNode(xmldoc));
            }

            return xmlelem;
        }

        private static void FillSerializedNodes(XmlNode node, SerializedNode resultNode)
        {
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.Name == "Item")
                    if (child.Attributes != null)
                    {
                        var childId = Convert.ToInt32(child.Attributes["id"].Value);
                        resultNode.Children[childId] = new SerializedNode(childId);
                        FillSerializedNodes(child, resultNode.Children[childId]);
                    }
                if (child.Name != "Interpterer") continue;
                if (child.Attributes == null) continue;
                var name = child.Attributes["Name"].Value;
                var data = new AttributeData(AttributeInterpreterFactory.GetTypeId(name));
                foreach (XmlAttribute attribute in child.Attributes)
                {
                    if (attribute.Name != "Name")
                        data.WriteAttribute(attribute.Name, attribute.Value);
                }
                var typeId = AttributeInterpreterFactory.GetTypeId(name);
                resultNode.Interpreters[typeId] = data;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name = "fileName"></param>
        /// <returns></returns>
        public static SerializedNode LoadFromXml(string fileName)
        {
            if (!File.Exists(fileName))
                return null;
            var doc = new XmlDocument();
            try
            {
                doc.Load(fileName);
            }
            catch
            {
                return null;
            }
            var node = doc.ChildNodes[0];
            if (node.Value != "Item")
            {
                node = doc.ChildNodes[1];
            }
            var result = new SerializedNode(-1);
            FillSerializedNodes(node, result);
            return result;
        }
    }
}