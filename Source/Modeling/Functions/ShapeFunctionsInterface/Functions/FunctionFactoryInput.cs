#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace ShapeFunctionsInterface.Functions
{
    public class FunctionFactoryInput : InputBase
    {
        public FunctionFactoryInput()
            : base(InputNames.FunctionFactoryInput)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(FunctionFactory.Instance);
        }
    }
}