#region Usings

using System;
using AppShell.Services.ToolBar;
using Microsoft.Windows.Controls.Ribbon;
using NUnit.Framework;
using WPF = System.Windows.Controls;

#endregion

namespace NaroCAD.AppShell.Tests.Toolbar
{
    [TestFixture]
    public class RibbonControlUIAdapterTest : Naro.UnitTest.Shared.UnitTest
    {
        private Ribbon _ribbon;
        private RibbonControlUIAdapter _ribbonUIAdapter;

        protected override void SetUpCore()
        {
            base.SetUpCore();
            _ribbon = new Ribbon();
            _ribbonUIAdapter = new RibbonControlUIAdapter(_ribbon);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Constructor_ShouldThrowIfToolBarTrayIsNull()
        {
            _ribbonUIAdapter = new RibbonControlUIAdapter(null);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Add_ShouldThrowIfItemIsNull()
        {
            _ribbonUIAdapter.Add(null);
        }

        [Test]
        public void Add_ShouldAddToolBarToToolBarTray()
        {
            var toolBar = new RibbonTab();
            _ribbonUIAdapter.Add(toolBar);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Remove_ShouldThrowIfItemIsNull()
        {
            _ribbonUIAdapter.Remove(null);
        }

        [Test]
        public void Remove_ShouldRemoveToolBarFromToolBarTray()
        {
            var toolBar1 = new RibbonTab();
            var toolBar2 = new RibbonTab();
            _ribbon.Tabs.Add(toolBar1);

            Assert.IsTrue(_ribbon.Tabs.Contains(toolBar1));
            Assert.IsFalse(_ribbon.Tabs.Contains(toolBar2));

            _ribbonUIAdapter.Remove(toolBar2);
            Assert.IsTrue(_ribbon.Tabs.Contains(toolBar1));
            Assert.IsFalse(_ribbon.Tabs.Contains(toolBar2));

            _ribbonUIAdapter.Remove(toolBar1);
            Assert.IsFalse(_ribbon.Tabs.Contains(toolBar1));
            Assert.IsFalse(_ribbon.Tabs.Contains(toolBar2));
        }
    }
}