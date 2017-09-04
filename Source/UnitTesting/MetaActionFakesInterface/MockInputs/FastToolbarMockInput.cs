using System;
using System.Windows.Controls;
using NaroConstants.Names;
using NaroPipes.Actions;

namespace MetaActionFakesInterface.MockInputs
{
    class FastToolbarMockInput : InputBase
    {

        public FastToolbarMockInput() : base(InputNames.FastToolbarInput)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(null);
        }
    }
}
