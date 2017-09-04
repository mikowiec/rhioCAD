#region Usings

using System.Collections.Generic;
using TreeData.Utils;

#endregion

namespace NaroPipes.Actions
{
    public class ActionBase
    {
        public string Name { get; private set; }

        #region Constructor

        protected ActionBase(string name)
        {
            Name = name;
            Inputs = new SortedDictionary<string, InputBase>();
            _dependencies = new SortedDictionary<string, int>();
            SourceDataHandlers = new SortedDictionary<string, InputBase.DataPackageHandler>();
        }

        #endregion

        #region Public methods

        protected SortedDictionary<string, InputBase> Inputs { get; private set; }
        public ActionsGraph ActionsGraph { get; set; }
        private SortedDictionary<string, InputBase.DataPackageHandler> SourceDataHandlers { get; set; }

        protected void DependsOn(string input)
        {
            Ensure.IsTrue(!_dependencies.ContainsKey(input),
                          string.Format("You should not add input that is already used. Input name: {0}", input));
            _dependencies[input] = 1;
        }

        protected void DependsOn(string inputName, InputBase.DataPackageHandler packageHandler)
        {
            if (!_dependencies.ContainsKey(inputName))
                DependsOn(inputName);
            AddSourceHandler(inputName, packageHandler);
        }

        public virtual void OnActivate()
        {
        }

        public virtual void OnDeactivate()
        {
        }

        internal void DisconnectInputs()
        {
            foreach (var input in Inputs.Values)
            {
                input.OnDisconnect();
                input.Disconnect();
            }
            Inputs.Clear();
        }

        public virtual void OnRegister()
        {
        }

        private void ConnectInputs()
        {
            var inputFactory = ActionsGraph.InputContainer;
            foreach (var dependencyName in _dependencies.Keys)
                ActionsGraph[dependencyName].Disconnect();

            //Ensure.AreEqual(Inputs.Count, 0);
            if (Inputs.Count > 0)
                DisconnectInputs();
            foreach (var dependencyName in _dependencies.Keys)
            {
                Ensure.IsTrue(!Inputs.ContainsKey(dependencyName),
                              "Inputs should be cleared before repopulating");
                var input = ActionsGraph[dependencyName];
                input.HasDataNotify += OnReceiveInputData;
                Inputs[dependencyName] = input;
                if (input is PipeBase)
                    inputFactory.ConnectPipe(input.Name);
            }
            Ensure.AreEqual(Inputs.Count, _dependencies.Count);
            foreach (var dependencyName in _dependencies.Keys)
                ActionsGraph[dependencyName].OnConnect();
        }

        public void Setup()
        {
            ConnectInputs();
        }

        protected void AddSourceHandler(string inputName, InputBase.DataPackageHandler handler)
        {
            SourceDataHandlers[inputName] = null;
            SourceDataHandlers[inputName] += handler;
        }

        private void IsInputHandled(string inputName, DataPackage data)
        {
            InputBase.DataPackageHandler handler;
            if (SourceDataHandlers.TryGetValue(inputName, out handler))
                handler(data);
        }

        protected virtual void OnReceiveInputData(string inputName, DataPackage data)
        {
            IsInputHandled(inputName, data);
        }

        protected string GetData(string inputName, string objectName)
        {
            Ensure.IsTrue(Inputs.ContainsKey(inputName), "Input Should Exist");
            var input = Inputs[inputName];
            return input.GetData(objectName).Text;
        }


        protected T GetData<T>(string inputName, string objectName)
        {
            Ensure.IsTrue(Inputs.ContainsKey(inputName), "Input Should Exist");
            var input = Inputs[inputName];
            return input.GetData(objectName).Get<T>();
        }

        protected void Send(string inputName, string name, string dataText)
        {
            Ensure.IsTrue(Inputs.ContainsKey(inputName), "Input Should Exist");
            var input = Inputs[inputName];
            input.Send(name, dataText);
        }

        protected void Send(string inputName, string name)
        {
            Ensure.IsTrue(Inputs.ContainsKey(inputName), "Input Should Exist");
            var input = Inputs[inputName];
            input.Send(name);
        }

        #endregion

        #region Data members

        private readonly SortedDictionary<string, int> _dependencies;

        #endregion
    }
}