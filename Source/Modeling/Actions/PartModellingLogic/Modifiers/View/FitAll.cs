#region Usings

using NaroBasicPipes.Actions;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.View
{
    /// <summary>
    ///   Fits the drawn objects into the visiblea viewer area.
    /// </summary>
    public class FitAll : HandlingAction3D
    {
        public FitAll() : base(ModifierNames.FitAll)
        {
        }

        public override void OnActivate()
        {
            View.FitAll(0.01, false, true);
            View.ZFitAll(1);
        }
    }
}