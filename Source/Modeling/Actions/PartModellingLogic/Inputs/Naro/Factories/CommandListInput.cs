#region Usings

using MetaActionsInterface;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace PartModellingLogic.Inputs.Naro.Factories
{
    public class CommandListInput : PipeBase
    {
        private readonly CommandList _commandList;

        public CommandListInput(CommandList commandList)
            : base(InputNames.ListCommandInput)
        {
            _commandList = commandList;
        }

        public override void OnRegister()
        {
            DependsOn(InputNames.CommandParser);
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_commandList);
        }
    }
}