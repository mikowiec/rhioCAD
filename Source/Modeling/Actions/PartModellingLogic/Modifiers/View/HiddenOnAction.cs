#region Usings

using MetaActionsInterface;
using NaroCppCore.Occ.AIS;
using NaroPipes.Constants;


#endregion

namespace PartModellingLogic.Modifiers.View
{
    internal class HiddenOnAction : DrawingAction3D
    {
        public HiddenOnAction() : base(ModifierNames.HiddenOn)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Context.SetDisplayMode(AISDisplayMode.AIS_Shaded, true);
            BackToNeutralModifier();
        }
    }
}