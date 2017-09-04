#region Usings

using NUnit.Framework;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class ComputeDiffTests
    {
        private Node _fromNode;
        private Node _toNode;
        private NodeDiff _diff;
        private NodeDiff _redoDiff;

        private void SetUp()
        {
            _fromNode = new Node();
            _toNode = new Node();
            _diff = new NodeDiff(null);
            _redoDiff = new NodeDiff(null);
        }

        [Test]
        public void ModifyInteegr()
        {
            SetUp();

            _fromNode.Set<IntegerInterpreter>().Value = 2;
            _toNode.Set<IntegerInterpreter>().Value = 3;

            var fromSerialTree = Document.ReflectTreeMirror(_fromNode);
            var toSerialTree = Document.ReflectTreeMirror(_toNode);
            NodeDiff.ComputeDiff(fromSerialTree, toSerialTree, _diff, _redoDiff);

            Assert.AreEqual(_diff.ModifiedAttributeData.Count, 1);
            Assert.AreEqual(_redoDiff.ModifiedAttributeData.Count, 1);
        }

        [Test]
        public void OneInteger()
        {
            SetUp();
            _toNode.Set<IntegerInterpreter>().Value = 1;

            Assert.AreEqual(_diff.RemovedAttributes.Count, 0);
            Assert.AreEqual(_redoDiff.ModifiedAttributeData.Count, 0);

            var fromSerialTree = Document.ReflectTreeMirror(_fromNode);
            var toSerialTree = Document.ReflectTreeMirror(_toNode);
            NodeDiff.ComputeDiff(fromSerialTree, toSerialTree, _diff, _redoDiff);

            Assert.AreEqual(1, _diff.RemovedAttributes.Count);
            Assert.AreEqual(1, _redoDiff.ModifiedAttributeData.Count);
        }

        [Test]
        public void OneNode()
        {
            SetUp();
            _toNode.AddNewChild();

            Assert.AreEqual(_diff.RemovedNodes.Count, 0);
            Assert.AreEqual(_redoDiff.Children.Count, 0);

            var fromSerialTree = Document.ReflectTreeMirror(_fromNode);
            var toSerialTree = Document.ReflectTreeMirror(_toNode);
            NodeDiff.ComputeDiff(fromSerialTree, toSerialTree, _diff, _redoDiff);

            Assert.AreEqual(_diff.RemovedNodes.Count, 1);
            Assert.AreEqual(_redoDiff.Children.Count, 1);
        }
    }
}