#region Usings

using System;
using System.Windows;
using System.Windows.Controls;
using AppShell.Services.ToolBar;
using NUnit.Framework;

#endregion

namespace WPFCABShell.UnitTest.Shell.Services.ToolBar
{
    [TestFixture]
    public sealed class ToolBarTrayUIAdapterFactoryTest : Naro.UnitTest.Shared.UnitTest
    {
        private ToolBarTrayUIAdapterFactory _toolBarTrayUIAdapterFactory;

        protected override void SetUpCore()
        {
            base.SetUpCore();
            _toolBarTrayUIAdapterFactory = new ToolBarTrayUIAdapterFactory();
        }

        [Test]
        public void Supports_ShouldReturnTrueOnlyForToolBarTrays()
        {
            Assert.IsFalse(_toolBarTrayUIAdapterFactory.Supports(new TextBlock()));
            Assert.IsFalse(_toolBarTrayUIAdapterFactory.Supports(new TextBox()));
            Assert.IsFalse(_toolBarTrayUIAdapterFactory.Supports(new DependencyObject()));
            Assert.IsTrue(_toolBarTrayUIAdapterFactory.Supports(new ToolBarTray()));
        }

        [Test]
        [ExpectedException(typeof (ArgumentException),
            ExpectedMessage = "uiElement is not a ToolBarTray.\r\nParameter name: uiElement")]
        public void GetAdapter_ShouldThrowIfNotSupported()
        {
            _toolBarTrayUIAdapterFactory.GetAdapter(new TextBlock());
        }

        [Test]
        public void GetAdapter_ShouldReturnToolBarTrayUIAdapterIfToolBarTray()
        {
            Assert.IsInstanceOfType(typeof (ToolBarTrayUIAdapter),
                                    _toolBarTrayUIAdapterFactory.GetAdapter(new ToolBarTray()));
        }
    }
}