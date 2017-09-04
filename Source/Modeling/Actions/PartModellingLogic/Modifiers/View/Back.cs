#region Usings

using NaroBasicPipes.Actions;
using NaroCppCore.Occ.V3d;
using NaroPipes.Constants;


#endregion

namespace PartModellingLogic.Modifiers.View
{
    public class Back : HandlingAction3D
    {
        public Back()
            : base(ModifierNames.Back)
        {
        }

        public override void OnActivate()
        {
            View.SetProj(V3dTypeOfOrientation.V3d_Xneg);
            BackToNeutralModifier();
        }
    }
}