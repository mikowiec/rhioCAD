#region Usings

using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroPipes.Actions;

#endregion

namespace InteractiveEditor.Views.FloatingTool
{
    public class FloatingToolbarEditingTool : EditingToolBase
    {
        public override void SetEditor(SelectionContainer selectedEntity, ActionsGraph actionsGraph)
        {
            ToolsFloatingWindow.Instance.Show(selectedEntity);
            ToolsFloatingWindow.Instance.Setup(actionsGraph);
        }

        protected override void OnSetViewInfo()
        {
            ToolsFloatingWindow.Instance.UpdateViewInfo(ViewInfo);
        }

        public override void OnCleanup()
        {
            ToolsFloatingWindow.Instance.Show(null);
        }
    }
}