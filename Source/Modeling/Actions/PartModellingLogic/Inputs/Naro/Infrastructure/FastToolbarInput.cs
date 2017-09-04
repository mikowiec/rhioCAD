#region Usings

using System.Windows.Controls;
using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Inputs.Naro.Infrastructure
{
    internal class FastToolbarInput : InputBase
    {
        private readonly StackPanel _stackPanel;

        public FastToolbarInput(StackPanel stackPanel)
            : base(InputNames.FastToolbarInput)
        {
            Ensure.IsNotNull(stackPanel);
            _stackPanel = stackPanel;
        }

        public override void OnDisconnect()
        {
            _stackPanel.Children.Clear();
            base.OnDisconnect();
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_stackPanel);
        }
    }
}