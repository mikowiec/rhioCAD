#region Usings

using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroPipes.Constants;
using NaroSetup;

#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    public class OptionsDialogManager : DocumentActionBase
    {
        public OptionsDialogManager()
            : base(ModifierNames.OptionsDialogManager)
        {
        }

        public override void OnActivate()
        {
            var optionsWindow = new OptionsWindow();
            optionsWindow.Show();
            optionsWindow.ShowInTaskbar = false;
            BackToNeutralModifier();
        }
    }
}