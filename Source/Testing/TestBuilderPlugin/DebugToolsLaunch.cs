#region Usings

using NaroPipes.Actions;
using TestBuilderPlugin.View;

#endregion

namespace TestBuilderPlugin
{
    internal static class DebugToolsLaunch
    {
        public static void Execute(ActionsGraph actionsGraph)
        {
            var window = new DebugToolsRemote(actionsGraph);
            window.Show();
        }
    }
}