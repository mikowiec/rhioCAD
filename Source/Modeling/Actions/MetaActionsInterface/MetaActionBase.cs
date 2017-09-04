#region Usings

using System;
using NaroBasicPipes.Actions;

#endregion

namespace MetaActionsInterface
{
    public abstract class MetaActionBase
    {
        public MetaActionDependencies Dependency { get; private set; }

        public void SetupDependency(MetaActionDependencies dependency)
        {
            Dependency = dependency;
        }

        public void FillDependencies()
        {
            FillUiDependencies();
            Dependency.SkipDefaultSteps();
        }

        protected abstract void FillUiDependencies();

        protected virtual void OnReceiveInputData(String inputName, Object data)
        {
        }

        protected void ConnectInput(MetaActionDependencies dependency, string inputName)
        {
            var inputs = dependency.Inputs;
            var input = inputs[inputName];
            inputs.ConnectPipe(inputName);
            input.HasDataNotify += OnReceiveInputData;
            input.OnConnect();
        }

        protected void DisconnectInput(MetaActionDependencies dependency, string inputName)
        {
            var inputs = dependency.Inputs;
            var input = inputs[inputName];
            input.HasDataNotify -= OnReceiveInputData;
        }
    }
}