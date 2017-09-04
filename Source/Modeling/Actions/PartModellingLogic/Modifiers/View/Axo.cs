#region Usings

using NaroBasicPipes.Actions;
using NaroCppCore.Occ.V3d;
using NaroPipes.Constants;


#endregion

namespace PartModellingLogic.Modifiers.View
{
    /// <summary>
    ///   Rotates the drawn shapes as an axonometric projection.
    /// </summary>
    public class Axo : HandlingAction3D
    {
        public Axo() : base(ModifierNames.Axo)
        {
        }

        public override void OnActivate()
        {
            View.SetProj(V3dTypeOfOrientation.V3d_XposYnegZpos);
            BackToNeutralModifier();
        }
    }
}