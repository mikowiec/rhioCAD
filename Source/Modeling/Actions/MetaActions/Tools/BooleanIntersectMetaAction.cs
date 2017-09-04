#region Usings

using Resources.PartModelling;

#endregion

namespace MetaActions.Tools
{
    public class BooleanIntersectMetaAction : BooleanMetaActionBase
    {
        protected override void CustomUiCode()
        {
            Dependency.Steps[2].Integer = 2;
            Dependency.Steps[2].IsDefaultValue = true;
            Dependency.Steps[0].HintText = ModelingResources.BooleanIntersectStep1;
            Dependency.Steps[1].HintText = ModelingResources.BooleanIntersectStep2;
        }
    }
}