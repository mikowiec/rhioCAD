#region Usings

using System.Collections.Generic;
using System.Text;
using BooDocumentImportExport.Modifiers.BooExport;
using BooDocumentImportExport.Views;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroConstants.Names;

#endregion

namespace BooDocumentImportExport.Modifiers
{
    internal class BooDocumentExport : DocumentActionBase
    {
        public BooDocumentExport()
            : base(BooModifier.BooDocumentExport)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            SaveToFile();
            BackToNeutralModifier();
        }

        private void SaveToFile()
        {
            var lines = new List<string>();
            var node = Document.Root;
            var data = new AttachedNodeData(node);
            VisitChildren(data, lines);
            var builder = new StringBuilder();
            foreach (var line in lines)
                builder.AppendLine(line);

            Inputs[InputNames.UiElementsItem].Send(NotificationNames.SetBooEditorText, builder.ToString());
        }

        private static void VisitChildren(AttachedNodeData data, List<string> lines)
        {
            var node = data.Node;
            foreach (var interpreter in node.Interpreters.Values)
                BooExportInterpreterFactory.Instance.PreHandle(interpreter, data, lines);
            foreach (var childNode in node.Children.Values)
            {
                var childData = new AttachedNodeData(childNode) {Parent = data};
                VisitChildren(childData, lines);
            }
            foreach (var interpreter in node.Interpreters.Values)
                BooExportInterpreterFactory.Instance.PostHandle(interpreter, data, lines);
        }
    }
}