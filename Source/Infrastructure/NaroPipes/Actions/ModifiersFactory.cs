#region Usings

using System.Collections.Generic;

#endregion

namespace NaroPipes.Actions
{
    public class ModifiersFactory
    {
        public ModifiersFactory(ActionsGraph actionsGraph)
        {
            ActionsGraph = actionsGraph;
        }

        #region Public members

        public ActionBase this[string actionType]
        {
            get { return Get(actionType); }
        }

        public void Register<T>() where T : ActionBase, new()
        {
            var action = new T();
            RegisterAction(action);
        }

        public void RegisterAction(ActionBase action)
        {
            _actions[action.Name] = action;
            action.ActionsGraph = ActionsGraph;
            action.OnRegister();
        }

        public ActionBase Get(string actionType)
        {
            return _actions.ContainsKey(actionType) ? _actions[actionType] : null;
        }

        #endregion

        #region Data members

        private readonly SortedDictionary<string, ActionBase> _actions = new SortedDictionary<string, ActionBase>();

        #endregion

        private ActionsGraph ActionsGraph { get; set; }
    }
}