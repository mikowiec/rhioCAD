#region Usings

using System.Collections.Generic;
using NUnit.Framework;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeDataTests.Interpreters
{
    internal class DummyListIntInterpreter : AttributeInterpreterBase
    {
        public DummyListIntInterpreter()
        {
            Data = new List<int>();
        }

        public List<int> Data { get; private set; }

        public override void Serialize(AttributeData data)
        {
            data.WriteAttribute("data", Data);
        }

        public override void Deserialize(AttributeData data)
        {
            Data = data.ReadAttributeListInteger("data");
        }
    }

    [TestFixture]
    public class IntegerInterpreterListTest
    {
        private static void DeserializeAndTestValues(Node node, AttributeData serializedData)
        {
            node.Set<DummyListIntInterpreter>().Deserialize(serializedData);
            var dataPtr = node.Get<DummyListIntInterpreter>().Data;
            Assert.AreEqual(dataPtr[0], 2);
            Assert.AreEqual(dataPtr[1], 5);
            Assert.AreEqual(dataPtr[2], 6);
        }

        private static AttributeData SerializeAndCleanInterpreter(Node node)
        {
            var serializedData = new AttributeData(0);
            node.Get<DummyListIntInterpreter>().Serialize(serializedData);
            node.Remove<DummyListIntInterpreter>();
            return serializedData;
        }

        private static void SetupNodeInterpreter(Node node, IEnumerable<int> data)
        {
            var dataPtr = node.Set<DummyListIntInterpreter>().Data;
            dataPtr.Clear();
            dataPtr.AddRange(data);
        }

        [Test]
        public void CreateInterpreterAndSerializeDeserialize()
        {
            AttributeInterpreterFactory.Register<DummyListIntInterpreter>();
            var node = new Node();
            var data = new List<int> {2, 5, 6};
            SetupNodeInterpreter(node, data);

            var serializedData = SerializeAndCleanInterpreter(node);

            DeserializeAndTestValues(node, serializedData);
        }
    }
}