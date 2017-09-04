#region Usings

using NaroBasicPipes.Actions;
using NaroCppCore.Occ.V3d;
using NaroPipes.Constants;


#endregion

namespace PartModellingLogic.Modifiers.View
{
    public class Top : HandlingAction3D
    {
        public Top() : base(ModifierNames.Top)
        {
        }

        public override void OnActivate()
        {
            View.SetProj(V3dTypeOfOrientation.V3d_Zpos);
            BackToNeutralModifier();
        }
    }
}