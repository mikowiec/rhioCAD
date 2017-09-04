#region Usings

using System;
using System.Windows.Controls;
using AppShell.Services.ToolBar;
using NUnit.Framework;
using WPF = System.Windows.Controls;

#endregion

namespace WPFCABShell.UnitTest.Shell.Services.ToolBar
{
    [TestFixture]
    public sealed class ToolBarTrayUIAdapterTest : Naro.UnitTest.Shared.UnitTest
    {
        private ToolBarTray _toolBarTray;
        private ToolBarTrayUIAdapter _toolBarTrayUIAdapter;

        protected override void SetUpCore()
        {
            base.SetUpCore();
            _toolBarTray = new ToolBarTray();
            _toolBarTrayUIAdapter = new ToolBarTrayUIAdapter(_toolBarTray);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Constructor_ShouldThrowIfToolBarTrayIsNull()
        {
            _toolBarTrayUIAdapter = new ToolBarTrayUIAdapter(null);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Add_ShouldThrowIfItemIsNull()
        {
            _toolBarTrayUIAdapter.Add(null);
        }

        [Test]
        public void Add_ShouldAddToolBarToToolBarTray()
        {
            var toolBar = new WPF.ToolBar();
            _toolBarTrayUIAdapter.Add(toolBar);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Remove_ShouldThrowIfItemIsNull()
        {
            _toolBarTrayUIAdapter.Remove(null);
        }

        [Test]
        public void Remove_ShouldRemoveToolBarFromToolBarTray()
        {
            var toolBar1 = new WPF.ToolBar();
            var toolBar2 = new WPF.ToolBar();
            _toolBarTray.ToolBars.Add(toolBar1);

            Assert.IsTrue(_toolBarTray.ToolBars.Contains(toolBar1));
            Assert.IsFalse(_toolBarTray.ToolBars.Contains(toolBar2));

            _toolBarTrayUIAdapter.Remove(toolBar2);
            Assert.IsTrue(_toolBarTray.ToolBars.Contains(toolBar1));
            Assert.IsFalse(_toolBarTray.ToolBars.Contains(toolBar2));

            _toolBarTrayUIAdapter.Remove(toolBar1);
            Assert.IsFalse(_toolBarTray.ToolBars.Contains(toolBar1));
            Assert.IsFalse(_toolBarTray.ToolBars.Contains(toolBar2));
        }
    }
}