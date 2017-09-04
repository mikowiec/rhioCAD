#region Usings

using System.Windows.Controls;
using InteractiveEditor.Constants;
using InteractiveEditor.Views.FloatingTool;
using NaroBasicPipes.Inputs;
using NaroPipes.Actions;

#endregion

namespace InteractiveEditor.Views.Tools
{
    internal class SolidFloatingTool : FloatingToolBase
    {
        public SolidFloatingTool()
            : base(FloatingToolNames.SolidTools)
        {
        }

        public override bool AcceptEntity(SelectionContainer entity)
        {
            return false;
        }

        public override void PopulateView(StackPanel panel, SelectionContainer entity, ActionsGraph actionsGraph)
        {
            panel.Children.Add(new CopyView(ViewInfo));
        }
    }
}