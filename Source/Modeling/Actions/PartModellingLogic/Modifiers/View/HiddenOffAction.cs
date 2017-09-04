#region Usings

using MetaActionsInterface;
using NaroCppCore.Occ.AIS;
using NaroPipes.Constants;


#endregion

namespace PartModellingLogic.Modifiers.View
{
    internal class HiddenOffAction : DrawingAction3D
    {
        public HiddenOffAction() : base(ModifierNames.HiddenOff)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Context.SetDisplayMode(AISDisplayMode.AIS_WireFrame, true);
            BackToNeutralModifier();
        }
    }
}