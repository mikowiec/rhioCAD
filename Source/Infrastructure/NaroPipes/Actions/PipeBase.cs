#region Usings

using System.Collections.Generic;

#endregion

namespace NaroPipes.Actions
{
    /// <summary>
    ///   Class that is able to connect to other pipe and to filter it's data
    /// </summary>
    public abstract class PipeBase : InputBase
    {
        protected PipeBase(string name)
            : base(name)
        {
            Inputs = new SortedDictionary<string, InputBase>();
            SourceDataHandlers = new SortedDictionary<string, DataPackageHandler>();
        }

        protected SortedDictionary<string, InputBase> Inputs { get; private set; }
        private SortedDictionary<string, DataPackageHandler> SourceDataHandlers { get; set; }
        public abstract override void OnRegister();

        private void OnData(string name, DataPackage data)
        {
            SourceOnData(name, data);
        }

        protected void DependsOn(string inputName)
        {
            ActionsGraph.RegisterPipe(inputName, Name);
        }

        protected void DependsOn(string inputName, DataPackageHandler packageHandler)
        {
            DependsOn(inputName);
            AddSourceHandler(inputName, packageHandler);
        }

        private void AddSourceHandler(string inputName, DataPackageHandler packageHandler)
        {
            SourceDataHandlers[inputName] = null;
            SourceDataHandlers[inputName] += packageHandler;
        }

        private void IsInputHandled(string inputName, DataPackage data)
        {
            DataPackageHandler packageHandler;
            if (SourceDataHandlers.TryGetValue(inputName, out packageHandler))
                packageHandler(data);
        }

        protected virtual void SourceOnData(string inputName, DataPackage data)
        {
            IsInputHandled(inputName, data);
        }

        public void ConnectTo(InputBase input)
        {
            if (Inputs.ContainsKey(input.Name))
                return;
            Inputs[input.Name] = input;
            input.HasDataNotify += OnData;
            input.OnConnect();
        }

        internal override void Disconnect()
        {
            foreach (var input in Inputs.Values)
                input.Disconnect();
            Inputs.Clear();

            base.Disconnect();
        }

        public override void OnDisconnect()
        {
        }
    }
}