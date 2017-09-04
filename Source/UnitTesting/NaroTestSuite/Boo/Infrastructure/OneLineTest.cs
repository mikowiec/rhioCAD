#region Usings

using NaroBasicPipes.Actions;
using NaroPipes.Actions;
using NaroSetup;
using NUnit.Framework;
using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using TestsShared;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.Boo.Infrastructure
{
    [TestFixture]
    internal class OneLineTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            DefaultInterpreters.Setup();
            _actionsGraph = new ActionsGraph();
            _actionsGraph.Register(new FunctionFactoryInput());
            _actionsGraph.Register(new OptionsSetupInput());
            _document = TestUtils.DefaultsSetup();
            DefaultFunctions.Setup(_actionsGraph);
            var documentInput = new DocumentInput(_document);
            documentInput.OnConnect();
            _actionsGraph.Register(documentInput);
            _document.Transact();
        }

        #endregion

        private Document _document;
        private ActionsGraph _actionsGraph;

        [Test]
        public void OneLineScriptTest()
        {
            var script = new OneLineBooScript();
            script.SetInternalData(_actionsGraph);
            script.Do();
            _document.Commit("Executed script");

            Assert.AreEqual(1, _document.Root.Children.Count);
        }
    }
}