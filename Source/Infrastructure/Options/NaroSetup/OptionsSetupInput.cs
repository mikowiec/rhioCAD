#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace NaroSetup
{
    public class OptionsSetupInput : InputBase
    {
        private readonly OptionsSetup _instance = OptionsSetup.Instance;

        public OptionsSetupInput()
            : base(InputNames.OptionsSetupInput)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_instance);
        }
    }
}