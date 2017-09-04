#region Usings

using NaroBasicPipes.Actions;
using NaroCppCore.Occ.V3d;
using NaroPipes.Constants;


#endregion

namespace PartModellingLogic.Modifiers.View
{
    public class Right : HandlingAction3D
    {
        public Right()
            : base(ModifierNames.Right)
        {
        }

        public override void OnActivate()
        {
            View.SetProj(V3dTypeOfOrientation.V3d_Yneg);
            BackToNeutralModifier();
        }
    }
}