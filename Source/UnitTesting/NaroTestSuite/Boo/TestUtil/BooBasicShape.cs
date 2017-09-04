#region Usings

using NaroBasicPipes.Actions;
using NaroPipes.Actions;
using NUnit.Framework;
using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.Boo.TestUtil
{
    [TestFixture]
    internal class BooBasicShape
    {
        private ActionsGraph _actionsGraph;

        [TestFixtureSetUp]
        public void Init()
        {
            DefaultsSetup();
            _actionsGraph = new ActionsGraph();
            var documentInput = new DocumentInput(new Document());
            documentInput.OnConnect();
            _actionsGraph.Register(documentInput);
        }

        private static void DefaultsSetup()
        {
            DefaultInterpreters.Setup();
            var actionsGraph = new ActionsGraph();
            actionsGraph.Register(new FunctionFactoryInput());
            DefaultFunctions.Setup(actionsGraph);
        }

        [Test]
        public void TestBooCall()
        {
            BooTestUtil.ExecuteDirectory(@"..\..\bin\Debug\Boo", _actionsGraph);
        }
    }
}