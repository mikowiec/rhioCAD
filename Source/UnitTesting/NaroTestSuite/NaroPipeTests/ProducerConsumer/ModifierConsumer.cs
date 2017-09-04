#region Usings

using NaroPipes.Actions;

#endregion

namespace NaroTestSuite.NaroPipeTests.ProducerConsumer
{
    internal class ModifierConsumer : ActionBase
    {
        public ModifierConsumer()
            : base(DataBlockName.ModifierConsumer)
        {
        }

        public int Value { get; private set; }

        public override void OnRegister()
        {
            DependsOn(DataBlockName.DecrementPipeToFloat);
            AddSourceHandler(DataBlockName.DecrementPipeToFloat, HandleInputData);
        }

        private void HandleInputData(DataPackage data)
        {
            var intValue = (int) data.Get<double>();
            Value = intValue;
        }
    }
}