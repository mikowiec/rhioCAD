#region Usages

using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using ApiCommon.Generator;

#endregion

namespace ApiCommon
{
    public static class DataNodeLoader
    {
        public static DataNode FromFile(string fileName)
        {
            var xmlDoc = new XmlDocument();
            fileName = Util.ToPlatformPath(fileName);
            Debug.Assert(File.Exists(fileName));
            try
            {
                xmlDoc.Load(fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            var result = new DataNode("Root");
            foreach (XmlNode xmlNode in xmlDoc.ChildNodes)
                UpdateData(result, xmlNode);
            return result;
        }

        private static void UpdateData(DataNode result, XmlNode node)
        {
            result.NodeType = node.Name;
            foreach (XmlNode xmlNode in node.ChildNodes)
            {
                UpdateData(result.Add(xmlNode.Name), xmlNode);
            }
            var attributes = node.Attributes;
            if (attributes == null)
                return;
            foreach (XmlAttribute attribute in attributes)
            {
                result[attribute.Name] = attribute.Value;
            }
        }

        public static bool ToFile(DataNode data, string fileName)
        {
            var xmlDoc = new XmlDocument();

            var xmlelem = CreateXmlElement(xmlDoc, data);
            xmlDoc.AppendChild(xmlelem);
            xmlDoc.Save(fileName);
            return true;
        }

        private static XmlElement CreateXmlElement(XmlDocument xmlDoc, DataNode data)
        {
            try
            {
                var xmlelem = xmlDoc.CreateElement("", data.NodeType, "");
                foreach (var attribute in data.Attributes)
                {
                    var attr = xmlDoc.CreateAttribute(attribute.Key);
                    attr.Value = attribute.Value;
                    xmlelem.Attributes.Append(attr);
                }
                foreach (var child in data.Children)
                {
                    var childNode = CreateXmlElement(xmlDoc, child);
                    if (childNode != null)
                        xmlelem.AppendChild(childNode);
                }
                return xmlelem;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}