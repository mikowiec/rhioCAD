#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using NaroUiBuilder;

#endregion

namespace PartModellingLogic.Inputs.Naro.Factories
{
    public class UiBuilderInput : InputBase
    {
        private UiBuilder _uiBuilder;

        public UiBuilderInput() : base(InputNames.UiBuilderInput)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            _uiBuilder = new UiBuilder(ActionsGraph);
            AddNotificationHandler(NotificationNames.GetValue, GetBuilder);
        }

        private void GetBuilder(DataPackage data)
        {
            ReturnData = new DataPackage(_uiBuilder);
        }
    }
}