#region Usings

using System;
using System.Threading;
using NaroConstants.Names;
using NaroUiBuilder;
using NUnit.Framework;
using PluginTests.Common;
using ShapeFunctionsInterface.Functions;
using TwoPointLinePlugin;

#endregion

namespace PluginTests.TwoPointLinePluginTest
{
    [TestFixture]
    public class ModifierRegisterTest : ModifierRegisterBase
    {
        private readonly ModifierRegister _sut = new ModifierRegister();

        [Test]
        public void RegisterFunction()
        {
            Assert.AreEqual(ApartmentState.STA, Thread.CurrentThread.GetApartmentState());

            var actionsGraph = Setup.ActionGraph;
            Assert.IsNotNull(actionsGraph);
            var input = actionsGraph.InputContainer[InputNames.FunctionFactoryInput];
            Assert.IsNotNull(input);
            var dataPackage = input.GetData(NotificationNames.GetValue);
            Assert.IsNotNull(dataPackage);
            var functionFactory = dataPackage.Get<IFunctionFactory>();
            Assert.IsNotNull(functionFactory);

            _sut.Register(actionsGraph);

            const string functionName = "TwoPointLineFunction";
            var functionBase = functionFactory.Get(functionName.GetHashCode());
            Assert.AreEqual(functionBase.Name, functionName);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void RegisterNullArgument()
        {
            _sut.Register(null);
        }

        [Test]
        public void RegisterUi()
        {
            Assert.AreEqual(ApartmentState.STA, Thread.CurrentThread.GetApartmentState());

            var actionsGraph = Setup.ActionGraph;
            Assert.IsNotNull(actionsGraph);
            var uiBuilderInput = actionsGraph[InputNames.UiBuilderInput];
            var dataPackage = uiBuilderInput.GetData(NotificationNames.GetValue);
            Assert.IsNotNull(dataPackage);
            var uiBuilder = dataPackage.Get<UiBuilder>();
            Assert.IsNotNull(uiBuilder);

            _sut.Register(actionsGraph);

            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/TwoPointLine", typeof (TwoPointRibbonButton));
        }
    }
}