#region Usings

using NaroPipes.Actions;

#endregion

namespace NaroTestSuite.NaroPipeTests.ProducerConsumer
{
    internal class ConsecutiveNumberInput : InputBase
    {
        private int _counter;

        public ConsecutiveNumberInput()
            : base(DataBlockName.ConsecutiveNumberInput)
        {
        }

        public void Tick()
        {
            AddData(_counter++);
        }
    }
}