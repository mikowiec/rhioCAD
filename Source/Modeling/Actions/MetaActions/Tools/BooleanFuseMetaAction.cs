#region Usings

using Resources.PartModelling;

#endregion

namespace MetaActions.Tools
{
    public class BooleanFuseMetaAction : BooleanMetaActionBase
    {
        protected override void CustomUiCode()
        {
            Dependency.Steps[2].Integer = 1;
            Dependency.Steps[2].IsDefaultValue = true;
            Dependency.Steps[0].HintText = ModelingResources.BooleanFuseStep1;
            Dependency.Steps[1].HintText = ModelingResources.BooleanFuseStep2;
        }
    }
}