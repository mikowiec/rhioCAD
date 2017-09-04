#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using PartModellingUi.Layout;

#endregion

namespace PartModellingLogic.Inputs.Naro.Infrastructure
{
    public class CommandLineInput : InputBase
    {
        private readonly CommandLineView _commandLineView;

        public CommandLineInput(CommandLineView commandLineView)
            : base(InputNames.CommandLineView)
        {
            _commandLineView = commandLineView;
            _commandLineView.OnTextEnter += OnTextEvent;
        }

        public override void OnRegister()
        {
            AddNotificationHandler(CoordinatateParserNames.SetHint, SetHintNotification);
            AddNotificationHandler(CoordinatateParserNames.SetEditingText, SetEditingTextNotification);
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_commandLineView);
        }

        public override void OnConnect()
        {
            //AddData(CommandLineDataNames.Text, _commandLineView.editTextBox.Text);
        }

        private void OnTextEvent(string text)
        {
            AddData(CommandLineDataNames.TextEnter, text);
        }

        private void SetEditingTextNotification(DataPackage dataPackage)
        {
            _commandLineView.SetEditingText(dataPackage.Text);
        }

        private void SetHintNotification(DataPackage dataPackage)
        {
            _commandLineView.SetHintText(dataPackage.Text);
        }
    }
}