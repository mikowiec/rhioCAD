#region Usings

using MetaActionsInterface;

#endregion

namespace TwoPointLinePlugin
{
    public class TwoPointLineAction : MetaActionBase
    {
        protected override void FillUiDependencies()
        {
            Dependency.FunctionName = Names.FunctionName;
        }
    }
}