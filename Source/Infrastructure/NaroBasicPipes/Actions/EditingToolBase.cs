#region Usings

using Naro.Infrastructure.Interface;
using NaroBasicPipes.Inputs;
using NaroPipes.Actions;

#endregion

namespace NaroBasicPipes.Actions
{
    public abstract class EditingToolBase
    {
        protected ActionsGraph ActionsGraph { get; private set; }
        protected ViewInfo ViewInfo { get; private set; }
        public abstract void SetEditor(SelectionContainer selectedEntity, ActionsGraph actionsGraph);

        protected virtual void OnSetViewInfo()
        {
        }

        protected void ViewUpdate()
        {
            ViewInfo.Redraw();
        }

        public void SetViewInfo(ViewInfo viewInfo, ActionsGraph actionsGraph)
        {
            ViewInfo = viewInfo;
            ActionsGraph = actionsGraph;
            OnSetViewInfo();
        }

        public virtual void OnCleanup()
        {
        }
    }
}