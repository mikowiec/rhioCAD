#region Usings

using NaroConstants.Names;
using NaroPipes.Constants;

#endregion

namespace NaroPipes.Actions
{
    public class ActionsGraph
    {
        #region Delegates

        public delegate void OnSwitchActionEvent();

        #endregion

        public OnSwitchActionEvent OnSwitchAction;

        public ActionsGraph()
        {
            InputContainer = new InputFactory(this);
            ModifierContainer = new ModifiersFactory(this);
        }

        public InputFactory InputContainer { get; private set; }
        public ModifiersFactory ModifierContainer { get; private set; }

        public ActionBase CurrentAction { get; private set; }
        public ActionBase PendingAction { get; private set; }

        private ActionsGraph Parent
        {
            get
            {
                if (!InputContainer.Inputs.ContainsKey(InputNames.ParentActionGraphInput)) return null;
                var input = InputContainer.Inputs[InputNames.ParentActionGraphInput];
                var parentActionGraph = input.GetData(NotificationNames.GetValue).Get<ActionsGraph>();
                return parentActionGraph;
            }
        }

        public InputBase this[string inputName]
        {
            get
            {
                if (InputContainer.Inputs.ContainsKey(inputName))
                    return InputContainer.Inputs[inputName];
                var parentGraph = Parent;
                return parentGraph == null ? null : parentGraph[inputName];
            }
        }

        public void SwitchAction(string actionName)
        {
            
            //if (PendingAction != null)
            //{
            //    PendingAction.OnDeactivate();
            //    PendingAction.DisconnectInputs();
            //}
            if (CurrentAction != null)
            {
                CurrentAction.OnDeactivate();
                CurrentAction.DisconnectInputs();
            }

            CurrentAction = ModifierContainer.Get(actionName);
            CurrentAction.Setup();
            CurrentAction.OnActivate();

            if (OnSwitchAction != null)
                OnSwitchAction();
            if (actionName == ModifierNames.None && PendingAction != null && PendingAction.Name != ModifierNames.None)
            {
                if (CurrentAction != null)
                {
                    CurrentAction.OnDeactivate();
                    CurrentAction.DisconnectInputs();
                }
                PendingAction.Setup();
                PendingAction.OnActivate();

                if (OnSwitchAction != null)
                    OnSwitchAction();
                PendingAction = ModifierContainer.Get(ModifierNames.None);
                //return;
            }
        }

        private void ActivateAction(ActionBase action, string actionName)
        {
            //if (action != null)
            //{
            //    action.OnDeactivate();
            //    action.DisconnectInputs();
            //}

            action = ModifierContainer.Get(actionName);
            action.Setup();
            action.OnActivate();

            if (OnSwitchAction != null)
                OnSwitchAction();
        }

        public void SwitchAction(string actionName, string pendingActionName)
        {
            if (CurrentAction != null)
            {
                CurrentAction.OnDeactivate();
                CurrentAction.DisconnectInputs();
            }
            

            CurrentAction = ModifierContainer.Get(actionName);
            PendingAction = ModifierContainer.Get(pendingActionName);
            CurrentAction.Setup();
            CurrentAction.OnActivate();

            if (OnSwitchAction != null)
                OnSwitchAction();
        }

        public void Register(InputBase input)
        {
            InputContainer.Register(input);
            input.ActionsGraph = this;
            input.OnRegister();
        }

        public void RemoveInput(string inputName)
        {
            InputContainer.Remove(inputName);
        }

        public void RegisterPipe(string sourceInput, string pipeName)
        {
            InputContainer.RegisterPipe(sourceInput, pipeName);
        }
    }
}