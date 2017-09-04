#region Usings

using NaroPipes.Actions;
using NUnit.Framework;
using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class UndoRedoTests
    {
        private static void Setup()
        {
            DefaultInterpreters.Setup();
            var actionsGraph = new ActionsGraph();
            actionsGraph.Register(new FunctionFactoryInput());
            DefaultFunctions.Setup(actionsGraph);
        }

        [Test]
        public void UndoAppliedAgainstChildAndItsAttribute()
        {
            Setup();
            var doc = new Document();
            doc.Root.FindChild(2, true).Set<IntegerInterpreter>().Value = 2;

            doc.Transact();
            doc.Root.FindChild(3, true).Set<IntegerInterpreter>().Value = 3;
            doc.Commit("Apply 3 on label");

            Assert.AreEqual(3, doc.Root.FindChild(3, true).Get<IntegerInterpreter>().Value);

            doc.Undo();
            Assert.IsNull(doc.Root.FindChild(3, false));

            doc.Redo();
            Assert.AreEqual(3, doc.Root.FindChild(3, true).Get<IntegerInterpreter>().Value);
        }

        [Test]
        public void UndoAppliedEmpty()
        {
            Setup();
            var doc = new Document();
            Assert.AreEqual(doc.Root.Interpreters.Count, 0);
            doc.Transact();
            doc.Root.Set<IntegerInterpreter>().Value = 2;
            Assert.AreEqual(doc.Root.Interpreters.Count, 1);
            doc.Commit("Apply 2 on Root label");
            Assert.AreEqual(doc.Root.Interpreters.Count, 1);
            doc.Undo();
            Assert.AreEqual(0, doc.Root.Interpreters.Count);
            doc.Redo();
            Assert.AreEqual(1, doc.Root.Interpreters.Count);
        }

        [Test]
        public void UndoAppliedRevertReferenceChild()
        {
            Setup();
            var doc = new Document();
            doc.Root.FindChild(2, true).Set<IntegerInterpreter>().Value = 2;

            doc.Transact();
            doc.Root.FindChild(3, true).Set<ReferenceInterpreter>().Node = doc.Root.FindChild(2, true);
            doc.Commit("Apply on label");

            doc.Undo();
            Assert.IsNull(doc.Root.FindChild(3, true).Get<ReferenceInterpreter>());
            Assert.AreEqual(2, doc.Root.FindChild(2, true).Get<IntegerInterpreter>().Value);

            doc.Redo();
            Assert.IsNotNull(doc.Root.FindChild(3, true).Get<ReferenceInterpreter>());
            Assert.IsNotNull(doc.Root.FindChild(3, true).Get<ReferenceInterpreter>().Node.Get<IntegerInterpreter>());
            Assert.AreEqual(2,
                            doc.Root.FindChild(3, true).Get<ReferenceInterpreter>().Node.Get<IntegerInterpreter>().Value);
        }

        [Test]
        public void UndoAppliedRevertValue()
        {
            Setup();
            var doc = new Document();
            doc.Root.Set<IntegerInterpreter>().Value = 2;

            doc.Transact();
            doc.Root.Set<IntegerInterpreter>().Value = 3;
            doc.Commit("Apply 3 on Root label");

            doc.Undo();
            Assert.IsNotNull(doc.Root.Get<IntegerInterpreter>());
            Assert.AreEqual(2, doc.Root.Get<IntegerInterpreter>().Value);

            doc.Redo();
            Assert.IsNotNull(doc.Root.Get<IntegerInterpreter>());
            Assert.AreEqual(3, doc.Root.Get<IntegerInterpreter>().Value);
        }

        [Test]
        public void UndoAppliedRevertValueChild()
        {
            Setup();
            var doc = new Document();
            doc.Root.FindChild(2, true).Set<IntegerInterpreter>().Value = 2;

            doc.Transact();
            doc.Root.FindChild(2, true).Set<IntegerInterpreter>().Value = 3;
            doc.Commit("Apply 3 on label");

            doc.Undo();
            Assert.IsNotNull(doc.Root.FindChild(2, true).Get<IntegerInterpreter>());
            Assert.AreEqual(2, doc.Root.FindChild(2, true).Get<IntegerInterpreter>().Value);

            doc.Redo();
            Assert.IsNotNull(doc.Root.FindChild(2, true).Get<IntegerInterpreter>());
            Assert.AreEqual(3, doc.Root.FindChild(2, true).Get<IntegerInterpreter>().Value);
        }
    }
}