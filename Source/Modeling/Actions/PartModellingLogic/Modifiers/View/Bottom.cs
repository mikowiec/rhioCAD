#region Usings

using NaroBasicPipes.Actions;
using NaroCppCore.Occ.V3d;
using NaroPipes.Constants;


#endregion

namespace PartModellingLogic.Modifiers.View
{
    public class Bottom : HandlingAction3D
    {
        public Bottom() : base(ModifierNames.Bottom)
        {
        }

        public override void OnActivate()
        {
            View.SetProj(V3dTypeOfOrientation.V3d_Zneg);
            BackToNeutralModifier();
        }
    }
}