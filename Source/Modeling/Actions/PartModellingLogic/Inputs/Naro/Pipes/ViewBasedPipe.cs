#region Usings

using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    public abstract class ViewBasedPipe : PipeBase
    {
        protected ViewInput.Items ViewItems;

        protected ViewBasedPipe(string name) : base(name)
        {
        }

        public override void OnRegister()
        {
            DependsOn(InputNames.View, SourceViewHandler);
        }

        private void SourceViewHandler(DataPackage data)
        {
            ViewItems = data.Get<ViewInput.Items>();
        }

        protected void ViewRedraw()
        {
            Inputs[InputNames.View].Send(NotificationNames.RefreshView);
        }
    }
}