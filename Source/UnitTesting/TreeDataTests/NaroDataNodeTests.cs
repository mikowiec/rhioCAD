#region Usings

using NUnit.Framework;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class NaroDataNodeTests
    {
        [Test]
        public void TestMethodAddChild()
        {
            var root = new Node();
            Assert.AreEqual(root.Children.Count, 0);
            root.AddNewChild();
            Assert.AreEqual(root.Children.Count, 1);
        }

        [Test]
        public void TestMethodNodeAttributeInterpreter()
        {
            var root = new Node();
            Assert.AreEqual(root.Children.Count, 0);
            root.AddNewChild();
            Assert.AreEqual(root.Interpreters.Count, 0);
            root.Set<IntegerInterpreter>().Value = 2;
            Assert.AreEqual(root.Interpreters.Count, 1);

            var intInterpreter = root.Get<IntegerInterpreter>();
            Assert.IsNotNull(intInterpreter);
            Assert.AreEqual(2, intInterpreter.Value);
        }

        [Test]
        public void TestMethodZero()
        {
            var root = new Node();
            Assert.AreEqual(root.Children.Count, 0);
        }
    }
}