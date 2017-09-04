#region Usings

using BooGearPlugin.Views;
using NaroUiBuilder;

#endregion

namespace BooGearPlugin
{
    internal static class RegisterPluginUi
    {
        public static void Register(UiBuilder uiBuilder)
        {
            uiBuilder.AddMapping("Ribbon/Extra/Boo/ScriptedShapes", new BooShapeList());
        }
    }
}