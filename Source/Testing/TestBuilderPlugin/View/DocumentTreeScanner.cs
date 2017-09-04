#region Usings

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TestBuilderPlugin.View
{
    public class DocumentTreeScanner
    {
        private readonly SortedDictionary<string, int> _shapeHiddenInterpreters = new SortedDictionary<string, int>();

        public DocumentTreeScanner()
        {
            DefineHiddenInterpreter("Function");
            DefineHiddenInterpreter("Integer");
            DefineHiddenInterpreter("String");
        }

        private void DefineHiddenInterpreter(string interpreterName)
        {
            _shapeHiddenInterpreters[interpreterName] = 1;
        }

        private static string GetInterpreterName(int nameId)
        {
            return AttributeInterpreterFactory.GetName(nameId);
        }

        private static string GetBaseInterpreterName(int nameId)
        {
            var name = GetInterpreterName(nameId);
            return AttributeInterpreterFactory.ComputeShorthand(name);
        }


        private static string ShapeName(Node shapeNode)
        {
            return shapeNode.Get<StringInterpreter>() == null ? string.Empty : shapeNode.Get<StringInterpreter>().Value;
        }

        private static bool IsShapeNode(Node shapeNode)
        {
            return shapeNode.Get<FunctionInterpreter>() != null;
        }

        private static string ShapeDescription(Node shapeNode)
        {
            if (!IsShapeNode(shapeNode))
                return string.Empty;
            var description = "Name: " + ShapeName(shapeNode) + " Type: " + shapeNode.Get<FunctionInterpreter>().Name;
            if (shapeNode.Get<IntegerInterpreter>() != null)
            {
                if (shapeNode.Get<IntegerInterpreter>().Value == 4)
                    description += " - Invisible";
            }
            return description;
        }

        public void PopulateTreeNodes(Node childLabel, TreeNodeCollection parentNode)
        {
            string nodeDescription;
            if (IsShapeNode(childLabel))
            {
                nodeDescription = childLabel.Path + ": " + ShapeDescription(childLabel);
            }
            else
            {
                nodeDescription = childLabel.Path;
            }
            var childNode = parentNode;

            if (childLabel.Parent != null)
            {
                var child = new TreeNode(nodeDescription);
                parentNode.Add(child);
                childNode = child.Nodes;
            }


            ShowInterpreters(childLabel, childNode);

            // Add child labels
            foreach (var node in childLabel.Children.Values)
                PopulateTreeNodes(node, childNode);
        }

        private bool SkipNodeInterpreter(string name)
        {
            return _shapeHiddenInterpreters.ContainsKey(name);
        }

        private void ShowInterpreters(Node childLabel, TreeNodeCollection childNode)
        {
            var isShapeNode = IsShapeNode(childLabel);
            if (childLabel.Interpreters.Count <= 0) return;
            // Store the label as info in the Node
            var emptyInterpreters = new List<string>();

            foreach (var mcc in childLabel.Interpreters)
            {
                var interpreterName = GetBaseInterpreterName(mcc.Key);
                if (isShapeNode && SkipNodeInterpreter(interpreterName))
                    continue;
                var description = interpreterName;
                var serializedData = mcc.Value.Serialize();
                if (serializedData.AttributesCount != 0)
                {
                    description += " - ";
                    foreach (var attr in serializedData.AttributesMap)
                    {
                        var key = attr.Key;
                        var val = attr.Value;
                        description += key + ":'" + val + "' ";
                    }
                    childNode.Add(description);
                }
                else
                    emptyInterpreters.Add(interpreterName);
            }
            ShowEmtpyInterpreters(childNode, emptyInterpreters);
        }

        private static void ShowEmtpyInterpreters(TreeNodeCollection childNode, ICollection<string> emptyInterpreters)
        {
            if (emptyInterpreters.Count <= 0) return;
            var sb = new StringBuilder();
            sb.Append("Empty interpreters: ");
            foreach (var interpreterName in emptyInterpreters)
            {
                sb.Append(interpreterName);
                sb.Append(" ");
            }
            childNode.Add(sb.ToString());
        }
    }
}