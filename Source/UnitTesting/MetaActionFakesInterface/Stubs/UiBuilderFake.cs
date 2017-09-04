#region Usings

using NaroPipes.Actions;
using NaroUiBuilder;

#endregion

namespace MetaActionFakesInterface.Stubs
{
    internal class UiBuilderFake : UiBuilder
    {
        public UiBuilderFake(ActionsGraph actionsGraph) : base(actionsGraph)
        {
        }
    }
}