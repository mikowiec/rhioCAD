#region Usings

using NUnit.Framework;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class DocumentTests
    {
        [Test]
        public void CommitShouldDoRevertAndNotCrash()
        {
            var doc = new Document();
            doc.Commit("No reason");
        }

        [Test]
        public void EmptyDocumentRevertTest()
        {
            var doc = new Document();
            doc.Transact();
            doc.Root.AddNewChild();
            doc.Revert();
            Assert.AreEqual(0, doc.Root.Children.Count);
        }

        [Test]
        public void EmptyDocumentTest()
        {
            var doc = new Document();
            Assert.AreEqual(doc.Root.Children.Count, 0);
        }

        [Test]
        public void EmptyDocumentWithAttributesRevertTest()
        {
            var doc = new Document();
            doc.Transact();
            doc.Root.Set<IntegerInterpreter>().Value = 2;
            Assert.AreEqual(1, doc.Root.Interpreters.Count);
            doc.Revert();
            Assert.AreEqual(0, doc.Root.Interpreters.Count);
        }
    }
}