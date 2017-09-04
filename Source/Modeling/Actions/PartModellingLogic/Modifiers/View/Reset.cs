#region Usings

using NaroBasicPipes.Actions;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.View
{
    public class Reset : HandlingAction3D
    {
        public Reset() : base(ModifierNames.Reset)
        {
        }

        public override void OnActivate()
        {
            View.Reset(true);
            BackToNeutralModifier();
        }
    }
}