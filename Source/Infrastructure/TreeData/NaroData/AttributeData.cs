#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Xml;
using NaroCppCore.Occ.gp;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.NaroData
{
    public class AttributeData
    {
        public AttributeData(int nameId)
        {
            NameId = nameId;
            Attributes = new SortedDictionary<int, string>();
            Hashes = new SortedDictionary<string, int>();
        }

        public string Name
        {
            get { return AttributeInterpreterFactory.GetName(NameId); }
        }

        private int NameId { get; set; }

        /// <summary>
        /// </summary>
        private SortedDictionary<int, string> Attributes { get; set; }

        private SortedDictionary<string, int> Hashes { get; set; }

        public int AttributesCount
        {
            get { return Attributes.Count; }
        }

        public SortedDictionary<string, string> AttributesMap
        {
            get
            {
                var result = new SortedDictionary<string, string>();
                foreach (var attribute in Hashes)
                    result[attribute.Key] = Attributes[attribute.Value];
                return result;
            }
        }

        private string GetAttribute(string attributeName)
        {
            int hashCode;
            if (!Hashes.TryGetValue(attributeName, out hashCode)) return string.Empty;
            string value;
            return !Attributes.TryGetValue(hashCode, out value) ? string.Empty : value;
        }

        /// <summary>
        ///   Convenience method to read easy an an attrbute value as integer
        /// </summary>
        /// <param name = "attributeName"></param>
        /// <returns></returns>
        public int ReadAttributeInteger(string attributeName)
        {
            var attributeValue = GetAttribute(attributeName);
            return string.IsNullOrEmpty(attributeValue)
                       ? 0
                       : Convert.ToInt32(attributeValue, CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///   Convenience method to write the attribute value as string
        /// </summary>
        /// <param name = "attributeName"></param>
        /// <param name = "value"></param>
        public void WriteAttribute(string attributeName, string value)
        {
            if (value == null)
                return;
            var hashCode = value.GetHashCode();
            Hashes[attributeName] = hashCode;
            Attributes[hashCode] = value;
        }

        /// <summary>
        ///   Convenience method to read easy an an attrbute value as string
        /// </summary>
        /// <param name = "attributeName"></param>
        /// <returns></returns>
        public string ReadAttributeString(string attributeName)
        {
            return GetAttribute(attributeName);
        }

        public void WriteAttribute(string attributeName, List<int> values)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < values.Count - 1; i++)
            {
                sb.Append(Convert.ToString(values[i], CultureInfo.InvariantCulture));
                sb.Append(' ');
            }
            if (values.Count != 0)
                sb.Append(Convert.ToString(values[values.Count - 1], CultureInfo.InvariantCulture));
            WriteAttribute(attributeName, sb.ToString());
        }


        public void WriteAttribute(string attributeName, int values)
        {
            WriteAttribute(attributeName, Convert.ToString(values, CultureInfo.InvariantCulture));
        }

        public void WriteAttribute(string attributeName, double values)
        {
            WriteAttribute(attributeName, Convert.ToString(values, CultureInfo.InvariantCulture));
        }

        public void WriteAttribute(string attributeName, double[] values)
        {
            var sb = DoubleArrayToString(values);
            WriteAttribute(attributeName, sb);
        }

        public static String DoubleArrayToString(double[] values)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < values.Length - 1; i++)
            {
                sb.Append(Convert.ToString(values[i], CultureInfo.InvariantCulture));
                sb.Append(' ');
            }
            if (values.Length != 0)
                sb.Append(Convert.ToString(values[values.Length - 1], CultureInfo.InvariantCulture));
            return sb.ToString();
        }


        public void WriteAttribute(string attributeName, bool value)
        {
            WriteAttribute(attributeName, value ? 1 : 0);
        }


        public void WriteAttribute(string attributeName, List<string> values)
        {
            WriteAttribute(attributeName + ".Count", values.Count);

            var pos = 0;
            foreach (var value in values)
            {
                WriteAttribute(attributeName + "_" + pos, value);
                pos++;
            }
        }

        public void WriteAttribute(string attributeName, List<Color> values)
        {
            WriteAttribute(attributeName + ".Count", values.Count);

            var pos = 0;
            foreach (var value in values)
            {
                WriteAttribute(attributeName + ".Red_" + pos, value.R);
                WriteAttribute(attributeName + ".Green_" + pos, value.G);
                WriteAttribute(attributeName + ".Blue_" + pos, value.B);
                pos++;
            }
        }

        public void WriteAttribute(string attributeName, gpPnt point)
        {
            var coordinate = new double[3];
            coordinate[0] = point.X;
            coordinate[1] = point.Y;
            coordinate[2] = point.Z;
            WriteAttribute(attributeName, coordinate);
        }

        public void WriteAttribute(string attributeName, Point3D point)
        {
            WriteAttribute(attributeName, point.GpPnt);
        }

        public Point3D ReadAttributePoint3D(string attributeName)
        {
            var point = ReadAttributeListDouble(attributeName);
            return new Point3D(point[0], point[1], point[2]);
        }

        public List<int> ReadAttributeListInteger(string attributeName)
        {
            var dataString = ReadAttributeString(attributeName);
            var result = new List<int>();
            if (!String.IsNullOrEmpty(dataString))
            {
                var words = dataString.Split(' ');
                foreach (var word in words)
                    result.Add(Convert.ToInt32(word, CultureInfo.InvariantCulture));
            }
            return result;
        }

        /// <summary>
        ///   Convenience method to read easy an an attrbute value as integer
        /// </summary>
        /// <param name = "attributeName"></param>
        /// <returns></returns>
        public List<double> ReadAttributeListDouble(string attributeName)
        {
            var dataString = ReadAttributeString(attributeName);
            var result = new List<double>();
            if (!String.IsNullOrEmpty(dataString))
            {
                var words = dataString.Split(' ');
                foreach (var word in words)
                    result.Add(Convert.ToDouble(word, CultureInfo.InvariantCulture));
            }
            return result;
        }

        /// <summary>
        ///   Convenience method to read easy an an attrbute value as integer
        /// </summary>
        /// <param name = "attributeName"></param>
        /// <returns></returns>
        public List<string> ReadAttributeListString(string attributeName)
        {
            var result = new List<string>();
            var itemCount = ReadAttributeInteger(attributeName + ".Count");
            for (var pos = 0; pos < itemCount; pos++)
                result.Add(ReadAttributeString(attributeName + "_" + pos));
            return result;
        }

        /// <summary>
        ///   Convenience method to read easy an an attrbute value as integer
        /// </summary>
        /// <param name = "attributeName"></param>
        /// <returns></returns>
        public List<Color> ReadAttributeListColor(string attributeName)
        {
            var result = new List<Color>();
            var itemCount = ReadAttributeInteger(attributeName + ".Count");
            for (var pos = 0; pos < itemCount; pos++)
                result.Add(Color.FromArgb(
                    ReadAttributeInteger(attributeName + ".Red_" + pos),
                    ReadAttributeInteger(attributeName + ".Green_" + pos),
                    ReadAttributeInteger(attributeName + ".Blue_" + pos)));
            return result;
        }


        private static LinkedList<int> GetNodePath(Node path)
        {
            var result = new LinkedList<int>();

            var parent = path;
            while (parent.Parent != null)
            {
                result.AddFirst(parent.Index);
                parent = parent.Parent;
            }
            return result;
        }

        public void WriteAttribute(string attributeName, Node parentNode, Node referencedNode)
        {
            var value = RelativeReferencePath(parentNode, referencedNode);
            WriteAttribute(attributeName, value);
        }

        public static string RelativeReferencePath(Node parentNode, Node referencedNode)
        {
            var pathParent = GetNodePath(parentNode);
            var pathReference = GetNodePath(referencedNode);
            var firstNodeParent = pathParent.First;
            var firstNodeReference = pathReference.First;
            while (firstNodeParent != null && firstNodeReference != null &&
                   firstNodeParent.Value == firstNodeReference.Value)
            {
                pathParent.RemoveFirst();
                firstNodeParent = pathParent.First;
                pathReference.RemoveFirst();
                firstNodeReference = pathReference.First;
            }
            var value = string.Empty;
            for (var i = 0; i < pathParent.Count; i++)
                value += ":";
            foreach (var node in pathReference)
                value += node + ":";
            if (!string.IsNullOrEmpty(value))
                value = value.Remove(value.Length - 1, 1);
            return value;
        }

        public bool HasAttribute(string attributeName)
        {
            return Hashes.ContainsKey(attributeName);
        }

        public Node ReadAttributeReference(string attributeName, Node parentNode)
        {
            var referenceLocation = GetAttribute(attributeName);
            if (String.IsNullOrEmpty(referenceLocation))
            {
                return null;
            }
            var pathItems = referenceLocation.Split(':');
            var result = parentNode;
            foreach (var item in pathItems)
            {
                if (string.IsNullOrEmpty(item))
                {
                    result = result.Parent;
                }
                else
                {
                    var index = Convert.ToInt32(item, CultureInfo.InvariantCulture);
                    if (!result.Children.ContainsKey(index))
                        result.AddChild(index);
                    result = result.Children[index];
                }
            }
            return result;
        }

        /// <summary>
        ///   Convenience method to read easy an an attrbute value as double
        /// </summary>
        /// <param name = "attributeName"></param>
        /// <returns></returns>
        public double ReadAttributeDouble(string attributeName)
        {
            return Convert.ToDouble(GetAttribute(attributeName), CultureInfo.InvariantCulture);
        }


        /// <summary>
        /// </summary>
        /// <param name = "otherData"></param>
        /// <returns></returns>
        public bool IsSame(AttributeData otherData)
        {
            if (Name != otherData.Name)
                return false;
            if (Attributes.Count != otherData.Attributes.Count)
                return false;
            var sourceHashEnumerator = Hashes.GetEnumerator();
            var otherHashEnumerator = otherData.Hashes.GetEnumerator();
            while (sourceHashEnumerator.MoveNext())
            {
                otherHashEnumerator.MoveNext();
                if (sourceHashEnumerator.Current.Key != otherHashEnumerator.Current.Key) return false;
                if (sourceHashEnumerator.Current.Value != otherHashEnumerator.Current.Value) return false;
            }
            return true;
        }

        public XmlElement CreateXmlNode(XmlDocument xmlDoc)
        {
            var xmlelem = xmlDoc.CreateElement("", "Interpterer", "");
            var attrName = xmlDoc.CreateAttribute("Name");
            attrName.Value = Name;
            xmlelem.Attributes.Append(attrName);
            foreach (var nodeattr in Hashes)
            {
                var attr = xmlDoc.CreateAttribute(nodeattr.Key);
                attr.Value = Attributes[nodeattr.Value];
                xmlelem.Attributes.Append(attr);
            }
            return xmlelem;
        }
    }
}