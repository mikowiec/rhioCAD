#region Usings

using NaroPipes.Actions;

#endregion

namespace NaroTestSuite.NaroPipeTests.ProducerConsumer
{
    internal class DecrementPipeToFloat : PipeBase
    {
        public DecrementPipeToFloat()
            : base(DataBlockName.DecrementPipeToFloat)
        {
        }

        public override void OnRegister()
        {
            DependsOn(DataBlockName.ConsecutiveNumberInput);
        }

        protected override void SourceOnData(string inputName, DataPackage data)
        {
            AddData<double>(data.Get<int>() - 1);
        }
    }
}