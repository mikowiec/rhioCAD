#region Usings

using NaroPipes.Actions;
using PluginInterface;
using TreeData.Utils;

#endregion

namespace TestBuilderPlugin
{
    [NaroRegister]
    public class ModifierRegister
    {
        public void Register(ActionsGraph actionsGraph)
        {
            Ensure.ArgumentNotNull(actionsGraph, "actionsGraph");

            DebugToolsLaunch.Execute(actionsGraph);
        }
    }
}