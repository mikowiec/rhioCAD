#region Usings

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using AppShell.Services;
using AppShell.Services.Command;
using AppShell.Services.ToolBar;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.UIElements;
using NaroCAD.AppShell.Interface;
using NUnit.Framework;
using SCSFContrib.CompositeUI.WPF.CommandAdapters;
using SCSFContrib.CompositeUI.WPF.UIElements;
using WPFCABShell.UnitTest.Shared;

#endregion

namespace AppShellTestSuite.Toolbar
{
    [TestFixture]
    public sealed class ToolBarServiceTest : Naro.UnitTest.Shared.UnitTest
    {
        private ToolBarTray _toolBarTray;
        private TestableWorkItem _workItem;
        private ICommandService _commandService;
        private ToolBarService _toolBarService;
        private ToolBarEventArgs _toolBarAddedEventArgs;
        private ToolBarEventArgs _toolBarRemovedEventArgs;
        private ToolBarEventArgs _toolBarVisibilityChangedEventArgs;

        protected override void SetUpCore()
        {
            base.SetUpCore();

            ClearEventInfo();

            _workItem = new TestableWorkItem();
            _commandService = new CommandService();
            _toolBarService = new ToolBarService(_workItem);

            _workItem.OnBuiltUp(null);

            //make sure the work item can adapt menus etc
            var commandAdapterMapService = _workItem.Services.Get<ICommandAdapterMapService>();
            commandAdapterMapService.Register(typeof (UIElement), typeof (UIElementCommandAdapter));

            var uiElementAdapterFactoryCatalog =
                _workItem.Services.Get<IUIElementAdapterFactoryCatalog>();
            uiElementAdapterFactoryCatalog.RegisterFactory(new ItemsControlUIAdapterFactory());
            uiElementAdapterFactoryCatalog.RegisterFactory(new ToolBarTrayUIAdapterFactory());

            //make sure the root tool bar tray exists and is registered in the work item
            _toolBarTray = new ToolBarTray();
            _workItem.UIExtensionSites.RegisterSite(ExtensionSites.ToolBar.Name, _toolBarTray);

            _toolBarService.ToolBarAdded += delegate(object sender, ToolBarEventArgs e) { _toolBarAddedEventArgs = e; };

            _toolBarService.ToolBarRemoved +=
                delegate(object sender, ToolBarEventArgs e) { _toolBarRemovedEventArgs = e; };

            _toolBarService.ToolBarVisibilityChanged +=
                delegate(object sender, ToolBarEventArgs e) { _toolBarVisibilityChangedEventArgs = e; };
        }

        [Test]
        public void ToolBarSiteNamesShouldYieldAllSiteNames()
        {
            Assert.IsFalse(_toolBarService.ToolBarSiteNames.GetEnumerator().MoveNext());
            const string site1Name = "site1";
            const string site2Name = "site2";
            var cabCommand1 = new Command();
            var cabCommand2 = new Command();
            var command1 = _commandService.CreateCommand(cabCommand1, "command1", null);
            var command2 = _commandService.CreateCommand(cabCommand2, "command2", null);

            _toolBarService.AddButtonItem(site1Name, command1, null, null);
            _toolBarService.AddButtonItem(site1Name, command2, null, null);
            var item = _toolBarService.AddButtonItem(site2Name, command1, null, null);
            var enumerator = _toolBarService.ToolBarSiteNames.GetEnumerator();
            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual("site1", enumerator.Current);
            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual("site2", enumerator.Current);
            Assert.IsFalse(enumerator.MoveNext());

            _toolBarService.Remove(item);
            enumerator = _toolBarService.ToolBarSiteNames.GetEnumerator();
            Assert.IsTrue(enumerator.MoveNext());
            Assert.AreEqual("site1", enumerator.Current);
            Assert.IsFalse(enumerator.MoveNext());
        }

        [Test]
        public void ToolBarAddedShouldBeRaisedWhenAddingToolBar()
        {
            Assert.IsNull(_toolBarAddedEventArgs);
            const string siteName1 = "siteName1";
            const string siteName2 = "siteName2";
            var cabCommand1 = new Command();
            var cabCommand2 = new Command();
            var command1 = _commandService.CreateCommand(cabCommand1, "command1", null);
            var command2 = _commandService.CreateCommand(cabCommand2, "command2", null);

            _toolBarService.AddButtonItem(siteName1, command1, null, null);
            Assert.IsNotNull(_toolBarAddedEventArgs);
            Assert.AreEqual("siteName1", _toolBarAddedEventArgs.ToolBarSiteName);

            ClearEventInfo();
            _toolBarService.AddButtonItem(siteName1, command2, null, null);
            Assert.IsNull(_toolBarAddedEventArgs);

            ClearEventInfo();
            _toolBarService.AddButtonItem(siteName2, command1, null, null);
            Assert.IsNotNull(_toolBarAddedEventArgs);
            Assert.AreEqual("siteName2", _toolBarAddedEventArgs.ToolBarSiteName);
        }

        [Test]
        public void ToolBarRemovedShouldBeRaisedWhenRemovingToolBar()
        {
            Assert.IsNull(_toolBarRemovedEventArgs);
            const string siteName1 = "siteName1";
            const string siteName2 = "siteName2";
            var cabCommand1 = new Command();
            var cabCommand2 = new Command();
            var command1 = _commandService.CreateCommand(cabCommand1, "command1", null);
            var command2 = _commandService.CreateCommand(cabCommand2, "command2", null);

            var item1 = _toolBarService.AddButtonItem(siteName1, command1, null, null);
            var item2 = _toolBarService.AddButtonItem(siteName1, command2, null, null);
            var item3 = _toolBarService.AddButtonItem(siteName2, command1, null, null);

            _toolBarService.Remove(item3);
            Assert.IsNotNull(_toolBarRemovedEventArgs);
            Assert.AreEqual("siteName2", _toolBarRemovedEventArgs.ToolBarSiteName);

            ClearEventInfo();
            _toolBarService.Remove(item1);
            Assert.IsNull(_toolBarRemovedEventArgs);

            ClearEventInfo();
            _toolBarService.Remove(item2);
            Assert.IsNotNull(_toolBarRemovedEventArgs);
            Assert.AreEqual("siteName1", _toolBarRemovedEventArgs.ToolBarSiteName);
        }

        [Test]
        public void ToolBarVisibilityChangedShouldBeRaisedWhenToolBarVisibilityChanges()
        {
            const string siteName = "siteName";
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);

            _toolBarService.AddButtonItem(siteName, command, null, null);
            Assert.IsNull(_toolBarVisibilityChangedEventArgs);

            _toolBarService.SetIsVisible(siteName, false);
            Assert.IsNotNull(_toolBarVisibilityChangedEventArgs);
            Assert.AreEqual(siteName, _toolBarVisibilityChangedEventArgs.ToolBarSiteName);

            ClearEventInfo();
            _toolBarService.SetIsVisible(siteName, false);
            Assert.IsNull(_toolBarVisibilityChangedEventArgs);

            ClearEventInfo();
            _toolBarService.SetIsVisible(siteName, true);
            Assert.IsNotNull(_toolBarVisibilityChangedEventArgs);
            Assert.AreEqual(siteName, _toolBarVisibilityChangedEventArgs.ToolBarSiteName);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void AddShouldThrowIfToolBarSiteNameIsNull()
        {
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);
            _toolBarService.AddButtonItem(null, command, 0, 0);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void AddShouldThrowIfCommandIsNull()
        {
            _toolBarService.AddButtonItem("toolBarSiteName", null, 0, 0);
        }

        [Test]
        [ExpectedException(typeof (InvalidOperationException),
            ExpectedMessage = "No root tool bar extension site with name 'site://ToolBar' has been registered.")]
        public void AddShouldThrowIfNoRootToolBarExtensionSite()
        {
            _workItem.UIExtensionSites.UnregisterSite(ExtensionSites.ToolBar.Name);
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);
            _toolBarService.AddButtonItem("SomeSite", command, null, null);
        }

        [Test]
        public void AddShouldConfigureToolBarButtonItemCorrectly()
        {
            var toolBar = new ToolBar();
            const string toolBarSiteName = "ToolBar";
            _workItem.UIExtensionSites.RegisterSite(toolBarSiteName, toolBar);
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);

            var toolBarButtonItem = _toolBarService.AddButtonItem(toolBarSiteName, command, 13, 8);
            Assert.AreSame(command, toolBarButtonItem.Command);
            Assert.AreEqual(13, GroupingItemsControlUIAdapter.GetGroupIndex(toolBarButtonItem as DependencyObject));
            Assert.AreEqual(8, GroupingItemsControlUIAdapter.GetIndex(toolBarButtonItem as DependencyObject));
        }

        [Test]
        public void AddShouldAddToolBarButtonItemToTargetSite()
        {
            var toolBar = new ToolBar();
            const string toolBarSiteName = "ToolBar";
            _workItem.UIExtensionSites.RegisterSite(toolBarSiteName, toolBar);
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);

            var toolBarButtonItem = _toolBarService.AddButtonItem(toolBarSiteName, command, null, null);
            Assert.IsNotNull(toolBarButtonItem);
            Assert.IsTrue(toolBar.Items.Contains(toolBarButtonItem));
        }

        [Test]
        public void AddShouldAddToolBarIfExtensionSiteNotFound()
        {
            const string toolBarSiteName = "toolBar";
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);

            Assert.AreEqual(0, _toolBarTray.ToolBars.Count);
            Assert.IsFalse(_workItem.UIExtensionSites.Contains(toolBarSiteName));
            _toolBarService.AddButtonItem(toolBarSiteName, command, null, null);
            Assert.IsTrue(_workItem.UIExtensionSites.Contains(toolBarSiteName));
            Assert.AreEqual(1, _toolBarTray.ToolBars.Count);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void RemoveShouldThrowIfItemIsNull()
        {
            _toolBarService.Remove(null);
        }

        [Test]
        public void RemoveShouldRemoveToolBarItem()
        {
            const string toolBarSiteName = "ToolBar";
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);
            var toolBarButtonItem = _toolBarService.AddButtonItem(toolBarSiteName, command, null, null);
            var toolBar = _toolBarTray.ToolBars[0];

            Assert.AreEqual(1, toolBar.Items.Count);
            _toolBarService.Remove(toolBarButtonItem);
            Assert.AreEqual(0, toolBar.Items.Count);
        }

        [Test]
        public void RemoveShouldRemoveToolBarIfNoItemsLeft()
        {
            const string toolBarSiteName = "ToolBar";
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);

            var toolBarButtonItem1 = _toolBarService.AddButtonItem(toolBarSiteName, command, null, null);
            var toolBarButtonItem2 = _toolBarService.AddButtonItem(toolBarSiteName, command, null, null);
            var toolBar = _toolBarTray.ToolBars[0];

            Assert.AreEqual(1, _toolBarTray.ToolBars.Count);
            Assert.AreEqual(2, toolBar.Items.Count);
            Assert.IsTrue(_workItem.UIExtensionSites.Contains(toolBarSiteName));

            _toolBarService.Remove(toolBarButtonItem1);
            Assert.AreEqual(1, _toolBarTray.ToolBars.Count);
            Assert.AreEqual(1, toolBar.Items.Count);
            Assert.IsTrue(_workItem.UIExtensionSites.Contains(toolBarSiteName));

            _toolBarService.Remove(toolBarButtonItem2);
            Assert.AreEqual(0, _toolBarTray.ToolBars.Count);
            Assert.AreEqual(0, toolBar.Items.Count);
            Assert.IsFalse(_workItem.UIExtensionSites.Contains(toolBarSiteName));
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void GetIsVisibleShouldThrowIfToolBarSiteNameIsNull()
        {
            _toolBarService.GetIsVisible(null);
        }

        [Test]
        [ExpectedException(typeof (InvalidOperationException),
            ExpectedMessage = "No tool bar could be found under site name 'foo'.")]
        public void GetIsVisibleShouldThrowIfToolBarDoesntExist()
        {
            _toolBarService.GetIsVisible("foo");
        }

        [Test]
        public void GetIsVisibleShouldReturnTrueOnlyIfVisible()
        {
            const string siteName = "siteName";
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);

            _toolBarService.AddButtonItem(siteName, command, null, null);
            var toolBar =
                GetPrivateMemberValue<IDictionary<string, ToolBar>>(_toolBarService, "_toolBars")[siteName];

            Assert.IsTrue(_toolBarService.GetIsVisible(siteName));

            toolBar.Visibility = Visibility.Collapsed;
            Assert.IsFalse(_toolBarService.GetIsVisible(siteName));

            toolBar.Visibility = Visibility.Hidden;
            Assert.IsFalse(_toolBarService.GetIsVisible(siteName));

            toolBar.Visibility = Visibility.Visible;
            Assert.IsTrue(_toolBarService.GetIsVisible(siteName));
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void SetIsVisibleShouldThrowIfToolBarSiteNameIsNull()
        {
            _toolBarService.SetIsVisible(null, false);
        }

        [Test]
        [ExpectedException(typeof (InvalidOperationException),
            ExpectedMessage = "No tool bar could be found under site name 'foo'.")]
        public void SetIsVisibleShouldThrowIfToolBarDoesntExist()
        {
            _toolBarService.SetIsVisible("foo", false);
        }

        [Test]
        public void SetIsVisibleShouldSetVisibilityOfToolBar()
        {
            const string siteName = "siteName";
            var cabCommand = new Command();
            var command = _commandService.CreateCommand(cabCommand, "command", null);

            _toolBarService.AddButtonItem(siteName, command, null, null);
            var toolBar =
                GetPrivateMemberValue<IDictionary<string, ToolBar>>(_toolBarService, "_toolBars")[siteName];

            Assert.AreEqual(Visibility.Visible, toolBar.Visibility);

            _toolBarService.SetIsVisible(siteName, false);
            Assert.AreEqual(Visibility.Collapsed, toolBar.Visibility);

            _toolBarService.SetIsVisible(siteName, true);
            Assert.AreEqual(Visibility.Visible, toolBar.Visibility);
        }

        #region Supporting Methods

        private void ClearEventInfo()
        {
            _toolBarAddedEventArgs = null;
            _toolBarRemovedEventArgs = null;
            _toolBarVisibilityChangedEventArgs = null;
        }

        #endregion
    }
}