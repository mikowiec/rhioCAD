#region Usings

using System.Collections.Generic;
using TreeData.Utils;

#endregion

namespace NaroPipes.Actions
{
    public class InputFactory
    {
        private readonly ActionsGraph _actionsGraph;
        private readonly SortedDictionary<string, InputBase> _inputs = new SortedDictionary<string, InputBase>();

        private readonly SortedDictionary<string, SortedDictionary<string, int>> _pipeInputs =
            new SortedDictionary<string, SortedDictionary<string, int>>();

        public InputFactory(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
        }

        public InputBase this[string inputName]
        {
            get { return Get(inputName); }
        }

        public SortedDictionary<string, InputBase> Inputs
        {
            get { return _inputs; }
        }

        internal void Register<T>(T instance)
            where T : InputBase
        {
            Ensure.IsTrue(!Inputs.ContainsKey(instance.Name), "Try to hijack existing input");
            Inputs[instance.Name] = instance;
        }

        private InputBase Get(string name)
        {
            return false == Inputs.ContainsKey(name) ? null : Inputs[name];
        }

        internal void RegisterPipe(string sourceInput, string pipeName)
        {
            if (!_pipeInputs.ContainsKey(pipeName))
                _pipeInputs[pipeName] = new SortedDictionary<string, int>();
            _pipeInputs[pipeName][sourceInput] = 0;
        }

        public void ConnectPipe(string pipeName)
        {
            if (false == _pipeInputs.ContainsKey(pipeName))
                return;
            var pipe = (PipeBase) Inputs[pipeName];
            foreach (var sourcePipe in _pipeInputs[pipeName].Keys)
            {
                var input = _actionsGraph[sourcePipe];
                pipe.ConnectTo(input);
                if (input is PipeBase)
                    ConnectPipe(input.Name);
            }
        }

        public void Remove(string inputName)
        {
            Ensure.IsTrue(Inputs.ContainsKey(inputName), "Try to remove non existing input");
            _inputs.Remove(inputName);
        }
    }
}