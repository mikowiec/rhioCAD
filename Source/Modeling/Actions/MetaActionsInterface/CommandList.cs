#region Usings

using System.Collections.Generic;
using NaroPipes.Actions;

#endregion

namespace MetaActionsInterface
{
    public class CommandList
    {
        private readonly ActionsGraph _actionsGraph;

        public CommandList(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
            ContainerActionMapping = new SortedDictionary<string, ActionBase>();
            ActionMapping = new SortedDictionary<string, MetaActionBase>();
            NameMapping = new SortedDictionary<string, string>();
        }

        private SortedDictionary<string, ActionBase> ContainerActionMapping { get; set; }
        public SortedDictionary<string, MetaActionBase> ActionMapping { get; private set; }
        public SortedDictionary<string, string> NameMapping { get; private set; }

        public void Register(string naroCommandName, string userCommandLine, MetaActionBase action)
        {
            var metaActionContainer = new MetaActionContainer(naroCommandName, action);
            ContainerActionMapping[naroCommandName] = metaActionContainer;
            ActionMapping[naroCommandName] = action;
            NameMapping[userCommandLine] = naroCommandName;
            _actionsGraph.ModifierContainer.RegisterAction(metaActionContainer);
        }

        public ActionBase GetAction(string commandLine)
        {
            ActionBase result;
            return !ContainerActionMapping.TryGetValue(commandLine, out result) ? null : result;
        }

        public void Register(string naroCommandName, string userCommandLine)
        {
            var metaActionContainer = _actionsGraph.ModifierContainer[naroCommandName];
            ContainerActionMapping[naroCommandName] = metaActionContainer;
            NameMapping[userCommandLine] = naroCommandName;
        }
    }
}