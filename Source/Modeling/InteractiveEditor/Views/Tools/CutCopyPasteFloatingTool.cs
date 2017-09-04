#region Usings

using System.Windows.Controls;
using InteractiveEditor.Constants;
using InteractiveEditor.Views.FloatingTool;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace InteractiveEditor.Views.Tools
{
    internal class CutCopyPasteFloatingTool : FloatingToolBase
    {
        public CutCopyPasteFloatingTool()
            : base(FloatingToolNames.CutCopyPaste)
        {
        }


        public override bool AcceptEntity(SelectionContainer entity)
        {
            return true;
        }

        public override void PopulateView(StackPanel panel, SelectionContainer entity, ActionsGraph actionsGraph)
        {
            panel.Children.Add(new CopyView(ViewInfo));

            var selected =
                actionsGraph[InputNames.ClipboardManager].GetData(NotificationNames.GetValue).Data;
            if (selected != null)
                panel.Children.Add(new PasteView(ViewInfo));
        }
    }
}