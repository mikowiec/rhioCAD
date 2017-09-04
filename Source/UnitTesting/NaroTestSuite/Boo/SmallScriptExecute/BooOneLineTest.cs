#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Interface.Boo;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroSetup;
using NUnit.Framework;
using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.Boo.SmallScriptExecute
{
    [TestFixture]
    public class BooOneLineTest
    {
        #region Setup/Teardown

        [SetUp]
        public void SetupTest()
        {
            DefaultsSetup();

            var document = new Document();
            document.Root.Set<ActionGraphInterpreter>().ActionsGraph = _actionsGraph;
            var documentInput = new DocumentInput(document);
            _actionsGraph.Register(documentInput);
            documentInput.OnConnect();
            _document =
                _actionsGraph.InputContainer[InputNames.Document].GetData(NotificationNames.GetValue).Get<Document>();

            _document.Transact();
        }

        #endregion

        private void DefaultsSetup()
        {
            DefaultInterpreters.Setup();
            _actionsGraph = new ActionsGraph();
            _actionsGraph.Register(new FunctionFactoryInput());
            _actionsGraph.Register(new OptionsSetupInput());
            DefaultFunctions.Setup(_actionsGraph);
        }

        private Document _document;
        private ActionsGraph _actionsGraph;

        [Test]
        public void BuildScript()
        {
            var scriptLines = new List<string> {"Line(0, 0, 0, 100, 100, 0);"};

            var context = BooUtil.CompileScript(scriptLines);
            var assembly = context.GeneratedAssembly;

            var instance = BooUtil.CallMethodFromAssembly(assembly, BooUtil.BooScrptClassName, "SetInternalData",
                                                          new object[] {_actionsGraph});
            BooUtil.CallInstanceMethod(assembly, BooUtil.BooScrptClassName, instance, "Do");

            _document.Commit(" Script execute");
        }
    }
}