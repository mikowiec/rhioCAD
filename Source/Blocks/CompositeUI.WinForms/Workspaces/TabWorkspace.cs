//===============================================================================
// Microsoft patterns & practices
// CompositeUI Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.Utility;
using System.Collections.ObjectModel;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Implements a Workspace that shows smartparts in a <see cref="TabControl"/>.
	/// </summary>
	[DesignerCategory("Code")]
	[ToolboxBitmap(typeof(TabWorkspace), "TabWorkspace")]
	public class TabWorkspace : TabControl, IComposableWorkspace<Control, TabSmartPartInfo>
	{
		private Dictionary<Control, TabPage> pages = new Dictionary<Control, TabPage>();
		private WorkspaceComposer<Control, TabSmartPartInfo> composer;
		private bool callComposerActivateOnIndexChange = true;
		private bool populatingPages = false;

		/// <summary>
		/// Initializes a new instance of the <see cref="TabWorkspace"/> class
		/// </summary>
		public TabWorkspace()
		{
			composer = new WorkspaceComposer<Control, TabSmartPartInfo>(this);
		}

		/// <summary>
		/// Dependency injection setter property to get the <see cref="WorkItem"/> where the 
		/// object is contained.
		/// </summary>
		[ServiceDependency]
		public WorkItem WorkItem
		{
			set { composer.WorkItem = value; }
		}

		#region Properties

		/// <summary>
		/// Gets the collection of pages that the tab workspace uses.
		/// </summary>
		public ReadOnlyDictionary<Control, TabPage> Pages
		{
			get { return new ReadOnlyDictionary<Control, TabPage>(pages); }
		}

		#endregion

		#region Private

		private void SetTabProperties(TabPage page, TabSmartPartInfo smartPartInfo)
		{
			page.Text = String.IsNullOrEmpty(smartPartInfo.Title) ? page.Text : smartPartInfo.Title;

			try
			{
				TabPage currentSelection = this.SelectedTab;
				callComposerActivateOnIndexChange = false;
				if (smartPartInfo.Position == TabPosition.Beginning)
				{
					TabPage[] pages = GetTabPages();
					this.TabPages.Clear();

					this.TabPages.Add(page);
					this.TabPages.AddRange(pages);
				}
				else if (this.TabPages.Contains(page) == false)
				{
					this.TabPages.Add(page);
				}

				// Preserve selection through the operation.
				this.SelectedTab = currentSelection;
			}
			finally
			{
				callComposerActivateOnIndexChange = true;
			}
		}

		private TabPage[] GetTabPages()
		{
			TabPage[] pages = new TabPage[this.TabPages.Count];
			for (int i = 0; i < pages.Length; i++)
			{
				pages[i] = this.TabPages[i];
			}

			return pages;
		}

		private void ShowExistingTab(Control smartPart)
		{
			string key = pages[smartPart].Name;
			this.TabPages[key].Show();
		}

		private TabPage GetOrCreateTabPage(Control smartPart)
		{
			TabPage page = null;

			// If the tab was added with the control at design-time, it will have a parent control, 
			// and somewhere up its containment chain we'll find one of our tabs.
			Control current = smartPart;
			while (current != null && page == null)
			{
				current = current.Parent;
				page = current as TabPage;
			}

			if (page == null)
			{
				page = new TabPage();
				page.Controls.Add(smartPart);
				smartPart.Dock = DockStyle.Fill;
				page.Name = Guid.NewGuid().ToString();

				pages.Add(smartPart, page);
			}
			else if (pages.ContainsKey(smartPart) == false)
			{
				pages.Add(smartPart, page);
			}

			return page;
		}

		private void PopulatePages()
		{
			// If the page count matches don't waste the 
			// time repopulating the pages collection
			if (!populatingPages && pages.Count != this.TabPages.Count)
			{
				foreach (TabPage page in this.TabPages)
				{
					if (this.pages.ContainsValue(page) == false)
					{
						Control control = GetControlFromPage(page);
						if (control != null && composer.SmartParts.Contains(control) == false)
						{
							TabSmartPartInfo tabinfo = new TabSmartPartInfo();
							tabinfo.ActivateTab = false;
							// Avoid circular calls to this method.
							populatingPages = true;
							try
							{
								Show(control, tabinfo);

							}
							finally
							{
								populatingPages = false;
							}
						}
					}
				}
			}
		}

		private void ControlDisposed(object sender, EventArgs e)
		{
			Control control = sender as Control;
			if (control != null && this.pages.ContainsKey(control))
			{
				composer.ForceClose(control);
			}
		}

		private Control GetControlFromSelectedPage()
		{
			return GetControlFromPage(this.SelectedTab);
		}

		private Control GetControlFromPage(TabPage page)
		{
			Control control = null;
			if (page.Controls.Count > 0)
			{
				control = page.Controls[0];
			}

			return control;
		}

		#endregion

		#region Internal implementation

		/// <summary>
		/// Fires the <see cref="SmartPartActivated"/> event whenever 
		/// the selected tab index changes.
		/// </summary>
		/// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
		protected override void OnSelectedIndexChanged(EventArgs e)
		{
			base.OnSelectedIndexChanged(e);
			if (callComposerActivateOnIndexChange && TabPages.Count != 0)
			{
				// Locate the smart part corresponding to the page.
				foreach (KeyValuePair<Control, TabPage> pair in pages)
				{
					if (pair.Value == this.SelectedTab)
					{
						((IComposableWorkspace<Control, TabSmartPartInfo>)this).Activate(pair.Key);
						return;
					}
				}

				// If we got here, we couldn't find a corresponding smart part for the 
				// currently active tab, hence we reset the ActiveSmartPart value.
				composer.SetActiveSmartPart(null);
			}
		}

		/// <summary>
		/// Hooks up tab pages added at design-time.
		/// </summary>
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			PopulatePages();
		}

		private void ActivateSiblingTab()
		{
			if (this.SelectedIndex > 0)
			{
				this.SelectedIndex = this.SelectedIndex - 1;
			}
			else if (this.SelectedIndex < this.TabPages.Count - 1)
			{
				this.SelectedIndex = this.SelectedIndex + 1;
			}
			else
			{
				composer.SetActiveSmartPart(null);
			}
		}

		private void ResetSelectedIndexIfNoTabs()
		{
			// First control to come in is special. We need to 
			// set the selected index to a non-zero index so we 
			// get the appropriate behavior for activation.
			if (this.TabPages.Count == 0)
			{
				try
				{
					callComposerActivateOnIndexChange = false;
					this.SelectedIndex = -1;
				}
				finally
				{
					callComposerActivateOnIndexChange = true;
				}
			}
		}

		#endregion

		#region Protected virtual implementations

		/// <summary>
		/// Activates the smart part.
		/// </summary>
		protected virtual void OnActivate(Control smartPart)
		{
			PopulatePages();

			string key = pages[smartPart].Name;

			try
			{
				callComposerActivateOnIndexChange = false;
				SelectedTab = TabPages[key];
				TabPages[key].Show();
			}
			finally
			{
				callComposerActivateOnIndexChange = true;
			}
		}

		/// <summary>
		/// Applies the smart part display information to the smart part.
		/// </summary>
		protected virtual void OnApplySmartPartInfo(Control smartPart, TabSmartPartInfo smartPartInfo)
		{
			PopulatePages();
			string key = pages[smartPart].Name;
			SetTabProperties(TabPages[key], smartPartInfo);
			if (smartPartInfo.ActivateTab)
			{
				Activate(smartPart);
			}
		}

		/// <summary>
		/// Closes the smart part.
		/// </summary>
		protected virtual void OnClose(Control smartPart)
		{
			PopulatePages();
			TabPages.Remove(pages[smartPart]);
			pages.Remove(smartPart);

			smartPart.Disposed -= ControlDisposed;
			//smartPart.Dispose();
		}

		/// <summary>
		/// Hides the smart part.
		/// </summary>
        protected virtual void OnHide(Control smartPart)
        {
            if (smartPart.Visible)
            {
                PopulatePages();
                string key = pages[smartPart].Name;
                TabPages[key].Hide();
                ActivateSiblingTab();
            }
        }

		/// <summary>
		/// Shows the control.
		/// </summary>
		protected virtual void OnShow(Control smartPart, TabSmartPartInfo smartPartInfo)
		{
			PopulatePages();
			ResetSelectedIndexIfNoTabs();

			TabPage page = GetOrCreateTabPage(smartPart);
			SetTabProperties(page, smartPartInfo);

			if (smartPartInfo.ActivateTab)
			{
				Activate(smartPart);
			}

			smartPart.Disposed += ControlDisposed;
		}

		/// <summary>
		/// Raises the <see cref="SmartPartActivated"/> event.
		/// </summary>
		protected virtual void OnSmartPartActivated(WorkspaceEventArgs e)
		{
			if (SmartPartActivated != null)
			{
				SmartPartActivated(this, e);
			}
		}

		/// <summary>
		/// Raises the <see cref="SmartPartClosing"/> event.
		/// </summary>
		protected virtual void OnSmartPartClosing(WorkspaceCancelEventArgs e)
		{
			if (SmartPartClosing != null)
			{
				SmartPartClosing(this, e);
			}
		}

		/// <summary>
		/// Converts a smart part information to a compatible one for the workspace.
		/// </summary>
		protected virtual TabSmartPartInfo ConvertFrom(ISmartPartInfo source)
		{
			return SmartPartInfo.ConvertTo<TabSmartPartInfo>(source);
		}

		#endregion

		#region IComposableWorkspace<Control,TabSmartPartInfo> Members

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnActivate"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, TabSmartPartInfo>.OnActivate(Control smartPart)
		{
			OnActivate(smartPart);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnApplySmartPartInfo"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, TabSmartPartInfo>.OnApplySmartPartInfo(Control smartPart, TabSmartPartInfo smartPartInfo)
		{
			OnApplySmartPartInfo(smartPart, smartPartInfo);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnShow"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, TabSmartPartInfo>.OnShow(Control smartPart, TabSmartPartInfo smartPartInfo)
		{
			OnShow(smartPart, smartPartInfo);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnHide"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, TabSmartPartInfo>.OnHide(Control smartPart)
		{
			OnHide(smartPart);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnClose"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, TabSmartPartInfo>.OnClose(Control smartPart)
		{
			OnClose(smartPart);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.RaiseSmartPartActivated"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, TabSmartPartInfo>.RaiseSmartPartActivated(WorkspaceEventArgs e)
		{
			OnSmartPartActivated(e);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.RaiseSmartPartClosing"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, TabSmartPartInfo>.RaiseSmartPartClosing(WorkspaceCancelEventArgs e)
		{
			OnSmartPartClosing(e);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.ConvertFrom"/> for more information.
		/// </summary>
		TabSmartPartInfo IComposableWorkspace<Control, TabSmartPartInfo>.ConvertFrom(ISmartPartInfo source)
		{
			return SmartPartInfo.ConvertTo<TabSmartPartInfo>(source);
		}

		#endregion

		#region IWorkspace Members

		/// <summary>
		/// See <see cref="IWorkspace.SmartPartClosing"/> for more information.
		/// </summary>
		public event EventHandler<WorkspaceCancelEventArgs> SmartPartClosing;

		/// <summary>
		/// See <see cref="IWorkspace.SmartPartActivated"/> for more information.
		/// </summary>
		public event EventHandler<WorkspaceEventArgs> SmartPartActivated;

		/// <summary>
		/// See <see cref="IWorkspace.SmartParts"/> for more information.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ReadOnlyCollection<object> SmartParts
		{
			get { return composer.SmartParts; }
		}

		/// <summary>
		/// See <see cref="IWorkspace.ActiveSmartPart"/> for more information.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public object ActiveSmartPart
		{
			get { return composer.ActiveSmartPart; }
		}

		/// <summary>
		/// Shows the smart part in a new tab with the given information.
		/// </summary>
		public void Show(object smartPart, ISmartPartInfo smartPartInfo)
		{
			composer.Show(smartPart, smartPartInfo);
		}

		/// <summary>
		/// Shows the smart part in a new tab.
		/// </summary>
		public void Show(object smartPart)
		{
			composer.Show(smartPart);
		}

		/// <summary>
		/// Hides the smart part and its tab.
		/// </summary>
		public void Hide(object smartPart)
		{
		    composer.Hide(smartPart);
		}

		/// <summary>
		/// Closes the smart part and removes its tab.
		/// </summary>
		public void Close(object smartPart)
		{
			composer.Close(smartPart);
		}

		/// <summary>
		/// Activates the tab the smart part is contained in.
		/// </summary>
		/// <param name="smartPart"></param>
		public void Activate(object smartPart)
		{
			composer.Activate(smartPart);
		}

		/// <summary>
		/// Applies new layout information on the tab of the smart part.
		/// </summary>
		public void ApplySmartPartInfo(object smartPart, ISmartPartInfo smartPartInfo)
		{
			composer.ApplySmartPartInfo(smartPart, smartPartInfo);
		}

		#endregion
	}
}