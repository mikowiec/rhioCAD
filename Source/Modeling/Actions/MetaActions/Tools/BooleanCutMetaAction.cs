#region Usings

using Resources.PartModelling;

#endregion

namespace MetaActions.Tools
{
    public class BooleanCutMetaAction : BooleanMetaActionBase
    {
        protected override void CustomUiCode()
        {
            Dependency.Steps[2].Integer = 0;
            Dependency.Steps[2].IsDefaultValue = true;
            Dependency.Steps[0].HintText = ModelingResources.BooleanCutStep1;
            Dependency.Steps[1].HintText = ModelingResources.BooleanCutStep2;
        }
    }
}