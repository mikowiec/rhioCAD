#region Usings

using NaroPipes.Actions;
using NUnit.Framework;

#endregion

namespace NaroTestSuite.NaroPipeTests.ProducerConsumer
{
    [TestFixture]
    public class TestProducerConsumer
    {
        [Test]
        public void TestProducerConsumerTest()
        {
            var factory = new ActionsGraph();
            var sourceGenerator = new ConsecutiveNumberInput();
            factory.Register(sourceGenerator);
            factory.Register(new DecrementPipeToFloat());

            var consumer = new ModifierConsumer();
            factory.ModifierContainer.RegisterAction(consumer);
            consumer.ActionsGraph = factory;
            consumer.Setup();
            consumer.OnActivate();

            sourceGenerator.Tick();
            Assert.AreEqual(-1, consumer.Value, "Invalid data was sent");
            sourceGenerator.Tick();
            Assert.AreEqual(0, consumer.Value, "Invalid data was sent");
        }
    }
}