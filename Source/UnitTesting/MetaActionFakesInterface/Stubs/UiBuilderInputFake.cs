#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using NaroUiBuilder;

#endregion

namespace MetaActionFakesInterface.Stubs
{
    internal class UiBuilderInputFake : InputBase
    {
        private UiBuilder _builder;

        public UiBuilderInputFake() : base(InputNames.UiBuilderInput)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            _builder = new UiBuilderFake(ActionsGraph);

            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_builder);
        }
    }
}