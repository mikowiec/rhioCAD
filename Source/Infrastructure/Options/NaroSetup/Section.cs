#region Usings

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Controls;
using BooEvaluator.Boo;
using log4net;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroSetup
{
    public class Section
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (Section));
        private readonly Document _document;

        public Section(string name, Document document)
        {
            _document = document;
            foreach (var node in document.Root.Children.Values)
            {
                if (node.Set<StringInterpreter>().Value != name) continue;
                SetNode(node);
                return;
            }
            var sectionNode = _document.Root.AddNewChild();
            sectionNode.Set<StringInterpreter>().Value = name;
            SetNode(sectionNode);
        }

        public Section(Node node, Document document)
        {
            SetNode(node);
            _document = document;
        }

        public Node Node { get; private set; }

        public string Name
        {
            get { return Node.Set<StringInterpreter>().Value; }
        }

        private void SetNode(Node node)
        {
            Node = node;
        }

        public void SetValue(int nodeId, CheckBox checkBox)
        {
            SetValue(nodeId, checkBox.IsChecked ?? false);
        }

        public void SetValue(int nodeId, bool boolValue)
        {
            var val = 0;
            if (boolValue)
                val = 1;

            Node[nodeId].Set<IntegerInterpreter>().Value = val;
        }

        public void SetValue(int nodeId, int value)
        {
            Node[nodeId].Set<IntegerInterpreter>().Value = value;
        }

        public void SetValue(int nodeId, double doubleValue)
        {
            Node[nodeId].Set<RealInterpreter>().Value = doubleValue;
        }

        public void SetDouble(int nodeId, string doubleValue)
        {
            Node[nodeId].Set<RealInterpreter>().Value = BooEval.GetDouble(doubleValue, CultureInfo.InvariantCulture);
        }

        public void SetDouble(int nodeId, TextBox textBox)
        {
            SetDouble(nodeId, textBox.Text);
        }

        public bool GetBoolValue(int nodeId)
        {
            return Node[nodeId].Set<IntegerInterpreter>().Value != 0;
        }

        public int GetIntegerValue(int nodeId)
        {
            try
            {
                return Node[nodeId].Get<IntegerInterpreter>().Value;
            }
            catch (Exception e)
            {
                Log.InfoFormat("Exception on accessing option section: {0} {1}", e.InnerException, e.StackTrace);
                return 0;
            }
        }

        public double GetDoubleValue(int nodeId)
        {
            try
            {
                return Node[nodeId].Get<RealInterpreter>().Value;
            }
            catch (Exception e)
            {
                Log.InfoFormat("Exception on accessing option section: {0} {1}", e.InnerException, e.StackTrace);
                return 0;
            }
        }


        public void SetValue(int nodeId, Color color)
        {
            Node[nodeId].Set<DrawingAttributesInterpreter>().Color = color;
        }

        public void SetValue(int nodeId, System.Windows.Media.Color color)
        {
            Node[nodeId].Set<DrawingAttributesInterpreter>().Color = Color.FromArgb(color.R, color.G, color.B);
        }

        public Color GetColorValue(int nodeId)
        {
            return Node[nodeId].Set<DrawingAttributesInterpreter>().Color;
        }
    }
}