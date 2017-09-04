#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using PropertyDescriptorsInterface;

#endregion

namespace PartModellingLogic.Inputs.Naro.Factories
{
    public class DescriptorsFactoryInput : InputBase
    {
        public DescriptorsFactoryInput()
            : base(InputNames.DescriptorsFactoryInput)
        {
        }

        public override void OnRegister()
        {
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(DescriptorsFactory.Instance);
        }
    }
}