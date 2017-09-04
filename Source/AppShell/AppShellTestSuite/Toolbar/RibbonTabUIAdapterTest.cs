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
    public class RibbonTabUIAdapterTest : Naro.UnitTest.Shared.UnitTest
    {
        private RibbonTab _ribbon;
        private RibbonTabUIAdapter _ribbonUIAdapter;

        protected override void SetUpCore()
        {
            base.SetUpCore();
            _ribbon = new RibbonTab();
            var group = new RibbonGroup();
            _ribbon.Groups.Add(group);
            _ribbonUIAdapter = new RibbonTabUIAdapter(_ribbon);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Constructor_ShouldThrowIfToolBarTrayIsNull()
        {
            _ribbonUIAdapter = new RibbonTabUIAdapter(null);
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
            var toolBar = new RibbonButton();
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
            var toolBar1 = new RibbonButton();
            var toolBar2 = new RibbonButton();
            _ribbon.Groups[0].Controls.Add(toolBar1);

            Assert.IsTrue(_ribbon.Groups[0].Controls.Contains(toolBar1));
            Assert.IsFalse(_ribbon.Groups[0].Controls.Contains(toolBar2));

            _ribbonUIAdapter.Remove(toolBar2);
            Assert.IsTrue(_ribbon.Groups[0].Controls.Contains(toolBar1));
            Assert.IsFalse(_ribbon.Groups[0].Controls.Contains(toolBar2));

            _ribbonUIAdapter.Remove(toolBar1);
            Assert.IsFalse(_ribbon.Groups[0].Controls.Contains(toolBar1));
            Assert.IsFalse(_ribbon.Groups[0].Controls.Contains(toolBar2));
        }
    }
}