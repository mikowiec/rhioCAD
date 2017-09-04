#region Usings

using System;
using System.Windows;
using System.Windows.Controls;
using AppShell.Services.ToolBar;
using Microsoft.Windows.Controls.Ribbon;
using NUnit.Framework;

#endregion

namespace NaroCAD.AppShell.Tests.Toolbar
{
    [TestFixture]
    internal class RibbonTabUIAdapterFactoryTest : Naro.UnitTest.Shared.UnitTest
    {
        private RibbonTabUIAdapterFactory _ribbonUIAdapterFactory;

        protected override void SetUpCore()
        {
            base.SetUpCore();
            _ribbonUIAdapterFactory = new RibbonTabUIAdapterFactory();
        }

        [Test]
        public void Supports_ShouldReturnTrueOnlyForToolBarTrays()
        {
            Assert.IsFalse(_ribbonUIAdapterFactory.Supports(new TextBlock()));
            Assert.IsFalse(_ribbonUIAdapterFactory.Supports(new TextBox()));
            Assert.IsFalse(_ribbonUIAdapterFactory.Supports(new DependencyObject()));
            Assert.IsTrue(_ribbonUIAdapterFactory.Supports(new RibbonButton()));
        }

        [Test]
        [ExpectedException(typeof (ArgumentException),
            ExpectedMessage = "uiElement is not a RibbonTab.\r\nParameter name: uiElement")]
        public void GetAdapter_ShouldThrowIfNotSupported()
        {
            _ribbonUIAdapterFactory.GetAdapter(new TextBlock());
        }

        [Test]
        public void GetAdapter_ShouldReturnToolBarTrayUIAdapterIfToolBarTray()
        {
            Assert.IsInstanceOfType(typeof (RibbonTabUIAdapter), _ribbonUIAdapterFactory.GetAdapter(new RibbonTab()));
        }
    }
}