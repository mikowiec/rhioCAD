#region Usings

using System;
using System.Threading;
using NaroConstants.Names;
using NaroUiBuilder;
using NUnit.Framework;
using PluginTests.Common;
using ViewInterfacePlugin;
using ViewInterfacePlugin.Constraints;
using ViewInterfacePlugin.Orientation;
using ViewInterfacePlugin.View;

#endregion

namespace PluginTests.ViewInterfacePluginTest
{
    [TestFixture]
    public class ModifierRegisterTest : ModifierRegisterBase
    {
        private readonly ModifierRegister _sut = new ModifierRegister();

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

            CheckRibbonButton(uiBuilder, "Ribbon/View/Orientation", typeof (OrientationToolsMapping));
            CheckRibbonButton(uiBuilder, "Ribbon/View/View/Zoom", typeof (ZoomToolsSplitButton));
            CheckRibbonButton(uiBuilder, "Ribbon/View/View/Pan", typeof (PanningToolsSplitButton));
            CheckRibbonButton(uiBuilder, "Ribbon/View/View/Rotation", typeof (RotationToolButton));

            CheckRibbonButton(uiBuilder, "Ribbon/Constraints/Constraints/ConstraintShapes",
                              typeof (ConstraintShapesToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Constraints/Constraints/PointToPoint",
                              typeof (PointToPointConstraintToolButton));
        }
    }
}