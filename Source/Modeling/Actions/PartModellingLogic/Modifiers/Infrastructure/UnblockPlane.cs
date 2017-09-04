#region Usings

using MetaActionsInterface;
using NaroConstants.Names;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    public class UnblockPlane : DrawingLiveShape
    {
        public UnblockPlane()
            : base(ModifierNames.UnblockPlane)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
            BackToNeutralModifier();
        }
    }
}