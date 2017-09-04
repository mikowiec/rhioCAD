#region Usings

using NaroBasicPipes.Actions;
using NaroCppCore.Occ.V3d;
using NaroPipes.Constants;


#endregion

namespace PartModellingLogic.Modifiers.View
{
    public class Left : HandlingAction3D
    {
        public Left() : base(ModifierNames.Left)
        {
        }

        public override void OnActivate()
        {
            View.SetProj(V3dTypeOfOrientation.V3d_Ypos);
            BackToNeutralModifier();
        }
    }
}