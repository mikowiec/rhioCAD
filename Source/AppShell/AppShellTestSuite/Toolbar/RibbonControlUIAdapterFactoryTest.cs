#region Usings

using System;
using System.Windows;
using System.Windows.Controls;
using AppShell.Services.ToolBar;
using Microsoft.Windows.Controls.Ribbon;
using Naro.UnitTest.Shared;
using NUnit.Framework;

#endregion

namespace NaroCAD.AppShell.Tests.Toolbar
{
    [TestFixture]
    public sealed class RibbonControlUIAdapterFactoryTest : UnitTest
    {
        private RibbonControlUIAdapterFactory _ribbonUIAdapterFactory;

        protected override void SetUpCore()
        {
            base.SetUpCore();
            _ribbonUIAdapterFactory = new RibbonControlUIAdapterFactory();
        }

        [Test]
        public void Supports_ShouldReturnTrueOnlyForToolBarTrays()
        {
            Assert.IsFalse(_ribbonUIAdapterFactory.Supports(new TextBlock()));
            Assert.IsFalse(_ribbonUIAdapterFactory.Supports(new TextBox()));
            Assert.IsFalse(_ribbonUIAdapterFactory.Supports(new DependencyObject()));
            Assert.IsTrue(_ribbonUIAdapterFactory.Supports(new Ribbon()));
        }

        [Test]
        [ExpectedException(typeof (ArgumentException),
            ExpectedMessage = "uiElement is not a Ribbon.\r\nParameter name: uiElement")]
        public void GetAdapter_ShouldThrowIfNotSupported()
        {
            _ribbonUIAdapterFactory.GetAdapter(new TextBlock());
        }

        [Test]
        public void GetAdapter_ShouldReturnToolBarTrayUIAdapterIfToolBarTray()
        {
            Assert.IsInstanceOfType(typeof (RibbonControlUIAdapter), _ribbonUIAdapterFactory.GetAdapter(new Ribbon()));
        }
    }
}