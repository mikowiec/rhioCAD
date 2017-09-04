#region Usings

using Naro.Infrastructure.Interface;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace PartModellingLogic.Inputs.Naro.Factories
{
    public class ViewInfoInput : InputBase
    {
        private readonly ViewInfo _viewInfo;

        public ViewInfoInput(ViewInfo viewInfo)
            : base(InputNames.ViewInfoInput)
        {
            _viewInfo = viewInfo;
        }

        public override void OnRegister()
        {
            AddNotificationHandler(NotificationNames.GetValue, OnDataGet);
        }

        private void OnDataGet(DataPackage data)
        {
            ReturnData = new DataPackage(_viewInfo);
        }
    }
}