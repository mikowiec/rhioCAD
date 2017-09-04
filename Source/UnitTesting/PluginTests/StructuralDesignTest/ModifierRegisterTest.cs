#region Usings

using System;
using System.Threading;
using MetaActionsInterface;
using NaroCAD.Plugin.Structural.Design;
using NaroCAD.Plugin.Structural.Design.UI;
using NaroConstants.Names;
using NaroUiBuilder;
using NUnit.Framework;
using PluginTests.Common;
using PropertyDescriptorsInterface;
using ShapeFunctionsInterface.Functions;
using TreeData.Capabilities;

#endregion

namespace PluginTests.StructuralDesignTest
{
    [TestFixture]
    public class ModifierRegisterTest : ModifierRegisterBase
    {
        private readonly ModifierRegister _sut = new ModifierRegister();

        [Test]
        public void RegisterAction()
        {
            var actionsGraph = Setup.ActionGraph;
            Assert.IsNotNull(actionsGraph);
            var input = actionsGraph[InputNames.ListCommandInput];
            Assert.IsNotNull(input);
            var dataPackage = input.GetData(NotificationNames.GetValue);
            Assert.IsNotNull(dataPackage);
            var commandList = dataPackage.Get<CommandList>();
            Assert.IsNotNull(commandList);

            // Does not allways work, because the Setup.ResetSetupEnvironment doesn't remove the entries.
            var action = commandList.GetAction(Constant.ActionBeam);
            Assert.IsNull(action);

            _sut.Register(actionsGraph);

            action = commandList.GetAction(Constant.ActionBeam);
            Assert.IsNotNull(action);
        }

        [Test]
        public void RegisterFunction()
        {
            var actionsGraph = Setup.ActionGraph;
            Assert.IsNotNull(actionsGraph);
            var functionFactoryInput = actionsGraph[InputNames.FunctionFactoryInput];
            Assert.IsNotNull(functionFactoryInput);
            var dataPackage = functionFactoryInput.GetData(NotificationNames.GetValue);
            Assert.IsNotNull(dataPackage);
            var functionFactory = dataPackage.Get<IFunctionFactory>();
            Assert.IsNotNull(functionFactory);

            _sut.Register(actionsGraph);

            var functionBase = functionFactory.Get(Constant.FunctionBeam.GetHashCode());
            Assert.AreEqual(functionBase.Name, Constant.FunctionBeam);
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
            Assert.IsNotNull(uiBuilderInput);
            var dataPackage = uiBuilderInput.GetData(NotificationNames.GetValue);
            Assert.IsNotNull(dataPackage);
            var uiBuilder = dataPackage.Get<UiBuilder>();
            Assert.IsNotNull(uiBuilder);

            _sut.Register(actionsGraph);

            CheckRibbonButton(uiBuilder, "Ribbon/Structural/Design/Cursor", typeof (CursorToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Structural/Design/Point", typeof (PointToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Structural/Design/Beam", typeof (BeamToolButton));
        }

        [Test]
        public void SetIcon()
        {
            var actionsGraph = Setup.ActionGraph;
            Assert.IsNotNull(actionsGraph);
            var capabilitiesInput = actionsGraph[InputNames.GlobalCapabilitiesInput];
            Assert.IsNotNull(capabilitiesInput);
            var dataPackage = capabilitiesInput.GetData(NotificationNames.GetValue);
            Assert.IsNotNull(dataPackage);
            var capabilitiesCollection = dataPackage.Get<CapabilitiesCollection>();
            Assert.IsNotNull(capabilitiesCollection);

            // Does not allways work, because the Setup.ResetSetupEnvironment doesn't remove the entries.
            ////var conceptBuilder = capabilitiesCollection.GetConcept(Constant.FunctionBeam);
            ////Assert.IsNull(conceptBuilder);

            _sut.Register(actionsGraph);

            var conceptBuilder = capabilitiesCollection.GetConcept(Constant.FunctionBeam);
            Assert.IsNotNull(conceptBuilder);
            var resource = conceptBuilder.GetCapability(ShapeCapabilitiesNames.DefaultIcon);
            Assert.AreEqual(Constant.IconPathBeam, resource);
        }

        [Test]
        public void SetPropertyGrid()
        {
            var actionsGraph = Setup.ActionGraph;
            Assert.IsNotNull(actionsGraph);
            var descriptorsInput = actionsGraph[InputNames.DescriptorsFactoryInput];
            Assert.IsNotNull(descriptorsInput);
            var dataPackage = descriptorsInput.GetData(NotificationNames.GetValue);
            Assert.IsNotNull(dataPackage);
            var descriptorsFactory = dataPackage.Get<DescriptorsFactory>();
            Assert.IsNotNull(descriptorsFactory);

            // Does not allways work, because the Setup.ResetSetupEnvironment doesn't remove the entries.
            ////var gridTabBase = descriptorsFactory.GetFunctionTab(Constant.FunctionBeam);
            ////Assert.IsNull(gridTabBase);

            _sut.Register(actionsGraph);

            var gridTabBase = descriptorsFactory.GetFunctionTab(Constant.FunctionBeam);
            Assert.IsNotNull(gridTabBase);
            Assert.AreEqual(Constant.PropertyGridTitleBeam, gridTabBase.Title);
        }
    }
}