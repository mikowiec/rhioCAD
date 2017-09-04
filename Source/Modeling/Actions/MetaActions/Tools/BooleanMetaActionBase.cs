#region Usings

using MetaActionsInterface;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace MetaActions.Tools
{
    public abstract class BooleanMetaActionBase : MetaActionBase
    {
        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            dependency.FunctionName = FunctionNames.Boolean;

            Dependency.SelectionMode = TopAbsShapeEnum.TopAbs_SOLID;
            Dependency.FacePickerActivate = false;

            CustomUiCode();
            Dependency.Inputs.Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
            Dependency.Inputs.Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
        }

        protected abstract void CustomUiCode();
    }
}