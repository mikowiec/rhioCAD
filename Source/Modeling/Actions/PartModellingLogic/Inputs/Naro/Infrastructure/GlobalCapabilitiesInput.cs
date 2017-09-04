#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.Capabilities;

#endregion

namespace PartModellingLogic.Inputs.Naro.Infrastructure
{
    public class GlobalCapabilitiesInput : InputBase
    {
        private readonly CapabilitiesCollection _globalCapabilities;

        public GlobalCapabilitiesInput()
            : base(InputNames.GlobalCapabilitiesInput)
        {
            _globalCapabilities = new CapabilitiesCollection();
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_globalCapabilities);
        }
    }
}