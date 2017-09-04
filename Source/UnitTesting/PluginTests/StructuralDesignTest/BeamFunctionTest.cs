#region Usings

using MetaActionFakesInterface;
using NaroCAD.Plugin.Structural.Design;
using NaroConstants.Names;
using NUnit.Framework;
using ShapeFunctionsInterface.Functions;

#endregion

namespace PluginTests.StructuralDesignTest
{
    [TestFixture]
    public class BeamFunctionTest
    {
        #region Setup/Teardown

        [SetUp]
        public void ConfigureTestEnvironment()
        {
            _setup = new SetupUtils();
            _setup.InitializeModifiersSetup();
            var actionsGraph = _setup.ActionGraph;
            var modifierRegister = new ModifierRegister();
            modifierRegister.Register(actionsGraph);
            var functionFactory =
                actionsGraph[InputNames.FunctionFactoryInput].GetData(NotificationNames.GetValue).Get<IFunctionFactory>();
            _sut = functionFactory.Get(Constant.FunctionBeam.GetHashCode());
        }

        [TearDown]
        public void TestModificationsCleanup()
        {
            _setup.ResetSetupEnvironment();
        }

        #endregion

        private SetupUtils _setup;
        private FunctionBase _sut;

        [Test]
        public void Constructor()
        {
            Assert.AreNotEqual(_sut, null);
        }

        [Test]
        public void PointReference0()
        {
            var dependency = _sut.Dependency[Constant.StepIndexBeamFirstNode];
            Assert.AreEqual(dependency.Name, InterpreterNames.Reference);
        }

        [Test]
        public void PointReference1()
        {
            var dependency = _sut.Dependency[Constant.StepIndexBeamSecondNode];
            Assert.AreEqual(dependency.Name, InterpreterNames.Reference);
        }

        [Test]
        public void PropertiesIndex()
        {
            var dependency = _sut.Dependency[Constant.StepIndexBeamProperty];
            Assert.AreEqual(dependency.Name, InterpreterNames.Integer);
        }
    }
}