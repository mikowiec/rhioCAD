#region Usings

using MetaActionsInterface;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.V3d;
using NaroPipes.Actions;


#endregion

namespace MetaActions.View
{
    public abstract class ViewMetaAction : MetaActionBase
    {
        protected V3dView View;

        protected override void FillUiDependencies()
        {
            var dependency = Dependency;
            Dependency.SelectionMode = TopAbsShapeEnum.TopAbs_SOLID;
            Dependency.FacePickerActivate = false;
            ConnectInput(dependency, InputNames.View);
            dependency.OnStepsCompletedHandler += OnStepsCompletedHandler;
            DisconnectInput(Dependency, InputNames.View);
        }

        protected abstract void OnStepsCompleted();

        private void OnStepsCompletedHandler()
        {
            OnStepsCompleted();
            Dependency.OnStepsCompletedHandler -= OnStepsCompletedHandler;
        }

        protected override void OnReceiveInputData(string inputName, object data)
        {
            var dataPackage = (DataPackage) data;
            switch (inputName)
            {
                case InputNames.View:
                    var viewItems = dataPackage.Get<ViewInput.Items>();
                    View = viewItems.View;
                    break;
            }
        }
    }
}