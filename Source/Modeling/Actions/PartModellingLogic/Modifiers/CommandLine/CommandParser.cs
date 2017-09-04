#region Usings

using System.Collections.Generic;
using System.Text;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Actions;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.CommandLine
{
    public class CommandParser : PipeBase
    {
        #region Constructor

        public CommandParser(CommandList listCommands)
            : base(InputNames.CommandParser)
        {
            ListCommands = listCommands;
        }

        public override void OnRegister()
        {
            DependsOn(InputNames.CoordinateParser, OnParserData);
        }

        #endregion

        private void OnParserData(DataPackage data)
        {
            switch (data.Text)
            {
                case CoordinatateParserNames.ChangeCommand:
                    HandleChangeCommand(data.Get<string>());
                    return;
                case CoordinatateParserNames.ParsedValue:
                    UpdateStageFromDependency(Dependency);
                    if (data.Data is Point3D)
                        Inputs[InputNames.CoordinateParser].Send(NotificationNames.SetLastPoint, data.Data);
                    AddData(CoordinatateParserNames.ParsedValue, data.Data);
                    return;
                default:
                    break;
            }
        }


        protected override void OnNotification(string name, DataPackage dataPackage)
        {
            switch (name)
            {
                case NotificationNames.HandleChangeCommand:
                    HandleChangeCommand(dataPackage.Text);
                    break;
                case NotificationNames.UpdateParserStage:
                    UpdateParserStage();
                    break;
                case NotificationNames.UpdateCommand:
                    UpdateCommand(dataPackage.Get<MetaActionBase>());
                    break;
                case NotificationNames.GetValue:
                    ReturnData = new DataPackage(ListCommands);
                    break;
            }
        }

        private void UpdateCommand(MetaActionBase command)
        {
            Dependency = command == null ? null : command.Dependency;
            UpdateParserStage();
        }

        public bool HasCommand(string commandName)
        {
            return ListCommands.NameMapping.ContainsKey(commandName);
        }

        private List<string> GetCommandList(string prefix)
        {
            var result = new List<string>();
            foreach (var keyName in ListCommands.NameMapping.Keys)
            {
                if (keyName.StartsWith(prefix))
                    result.Add(keyName);
            }
            return result;
        }

        private static bool IsPrefix(IEnumerable<string> commands, string prefix)
        {
            foreach (var command in commands)
            {
                if (!command.StartsWith(prefix))
                    return false;
            }
            return true;
        }

        private static string CommonPrefix(IList<string> commands)
        {
            if (commands.Count == 0)
                return string.Empty;
            var firstCommand = commands[0];
            var result = firstCommand[0].ToString();
            var prevResult = string.Empty;
            var index = 0;
            while (IsPrefix(commands, result))
            {
                prevResult = result;
                if (index >= firstCommand.Length - 1)
                    return prevResult;
                index++;
                result += firstCommand[index];
            }
            return prevResult;
        }

        private static string CommandNameBasedOnPrefix(string commandName, string prefixName)
        {
            if (prefixName.Length == 0)
                return commandName;
            var result = new StringBuilder();
            result.Append(prefixName[0].ToString().ToUpper());
            result.Append(prefixName.Remove(0, 1));
            var remaining = commandName.Remove(0, prefixName.Length);
            if (remaining.Length > 0)
            {
                result.Append("[");
                result.Append(remaining[0]);
                result.Append("]");
                result.Append(remaining.Remove(0, 1));
            }
            return result.ToString();
        }

        private static string GetCombinedName(IList<string> commands)
        {
            if (commands.Count == 0)
                return string.Empty;
            if (commands.Count == 1)
                return commands[0];
            var commandPrefix = CommonPrefix(commands);
            var result = new StringBuilder();
            foreach (var command in commands)
            {
                result.Append(CommandNameBasedOnPrefix(command, commandPrefix));
                result.Append(" ");
            }
            return result.ToString();
        }

        public void UpdateCommandLine(string partialCommandName)
        {
            var listCommands = GetCommandList(partialCommandName);
            var combinedName = GetCombinedName(listCommands);
            ActionsGraph[InputNames.CommandLineView].Send(CoordinatateParserNames.SetHint, combinedName);
            var prefix = CommonPrefix(listCommands);
            if (prefix != string.Empty)
                ActionsGraph[InputNames.CommandLineView].Send(CoordinatateParserNames.SetEditingText, prefix);
        }

        public void HandleChangeCommand(string partialCommandName)
        {
            if (string.IsNullOrEmpty(partialCommandName))
            {
                AddData(CoordinatateParserNames.Stop);
                return;
            }
            var listCommands = GetCommandList(partialCommandName);
            if (listCommands.Count == 0)
                return;
            var commandName = listCommands[0];
            var currentAction = ListCommands.GetAction(ListCommands.NameMapping[commandName]);

            if (currentAction != null)
                ActionsGraph.SwitchAction(currentAction.Name);
            else
                AddData(CoordinatateParserNames.Stop);
        }

        private void UpdateParserStage()
        {
            var dependency = Dependency;
            UpdateStageFromDependency(dependency);
        }

        private void UpdateStageFromDependency(MetaActionDependencies dependency)
        {
            if (dependency == null)
            {
                Stage = ParserStage.None;
                return;
            }
            var stepCount = dependency.Steps.Count;
            var stepIndex = dependency.StepIndex;
            var stepName = dependency.StepName;
            UpdateStageFromDependency(stepCount, stepIndex, stepName);
            Inputs[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetHint, Dependency.StepHint);
        }


        private void UpdateStageFromDependency(int stepCount, int stepIndex, string stepName)
        {
            if (stepCount == stepIndex) return;
            ParserStage stage;
            switch (stepName)
            {
                case InterpreterNames.Point3D:
                    stage = ParserStage.PointAsked;
                    break;
                case InterpreterNames.Real:
                    stage = ParserStage.RealAsked;
                    break;
                case InterpreterNames.Integer:
                    stage = ParserStage.IntegerAsked;
                    break;
                case InterpreterNames.Axis3D:
                    stage = ParserStage.AxisAsked;
                    break;
                default:
                    stage = ParserStage.Unknown;
                    break;
            }
            Inputs[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, stage);
        }

        #region Members

        private ParserStage _stage;

        private ParserStage Stage
        {
            set
            {
                _stage = value;
                Inputs[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, _stage);
            }
        }

        #endregion

        #region Properties

        //words used to cut the keywords
        private CommandList ListCommands { get; set; }

        private MetaActionDependencies Dependency { get; set; }

        #endregion
    }
}