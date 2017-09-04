#region Usings



#endregion

using NaroCppCore.Occ.V3d;

namespace MetaActions.View
{
    public class LeftMetaAction : ViewMetaAction
    {
        protected override void OnStepsCompleted()
        {
            View.SetProj(V3dTypeOfOrientation.V3d_Ypos);
        }
    }
}