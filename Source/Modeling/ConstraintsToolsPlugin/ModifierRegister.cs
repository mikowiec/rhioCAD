#region Usings

using ConstraintsToolsPlugin;
using MetaActionsInterface;
using Microsoft.Practices.CompositeUI;
using Naro.Infrastructure.Interface.Constants;
using NaroPipes.Actions;
using NaroUiBuilder;
using PluginInterface;

#endregion

public class ModifierRegister : IPluginModifierBase
{
    public void Register(ActionsGraph actionsGraph, WorkItem workItem, CommandList commandList)
    {
        var uiBuilder =
            actionsGraph.InputContainer[InputNames.UiBuilderInput].GetData(NotificationNames.GetValue).Get<UiBuilder>();
        RegisterPluginUi.Register(uiBuilder);
    }
}