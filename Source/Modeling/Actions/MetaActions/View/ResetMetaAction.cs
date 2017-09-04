namespace MetaActions.View
{
    public class ResetMetaAction : ViewMetaAction
    {
        protected override void OnStepsCompleted()
        {
            View.Reset(true);
            View.Scale=21;
        }
    }
}