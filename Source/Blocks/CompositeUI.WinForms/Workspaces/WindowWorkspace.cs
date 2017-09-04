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

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Implements a Workspace that shows smartparts in windows.
	/// </summary>
	public class WindowWorkspace : Workspace<Control, WindowSmartPartInfo>
	{
		private Dictionary<Control, Form> windowDictionary = new Dictionary<Control, Form>();
		private bool fireActivatedFromForm = true;
		IWin32Window ownerForm;

		/// <summary>
		/// Initializes the workspace with no owner form to use to show new 
		/// windows.
		/// </summary>
		public WindowWorkspace()
		{
		}

		/// <summary>
		/// Initializes the workspace with the form to use as the owner of 
		/// all windows shown through the workspace.
		/// </summary>
		/// <param name="ownerForm">The owner of windows shown through the workspace</param>
		public WindowWorkspace(IWin32Window ownerForm)
		{
			this.ownerForm = ownerForm;
		}

		/// <summary>
		/// Read-only view of WindowDictionary.
		/// </summary>
		[Browsable(false)]
		public ReadOnlyDictionary<Control, Form> Windows
		{
			get { return new ReadOnlyDictionary<Control, Form>(windowDictionary); }
		}

		#region Protected

		/// <summary>
		/// Creates a form if it does not already exist and adds the given control.
		/// </summary>
		/// <param name="control"></param>
		/// <returns></returns>
		protected Form GetOrCreateForm(Control control)
		{
			WindowForm form;
			if (this.windowDictionary.ContainsKey(control))
			{
				form = (WindowForm)this.windowDictionary[control];
			}
			else
			{
				form = new WindowForm();
				this.windowDictionary.Add(control, form);
				form.Controls.Add(control);
				CalculateSize(control, form);
				control.Disposed += ControlDisposed;
				WireUpForm(form);
			}

			return form;
		}

		/// <summary>
		/// Sets specific properties for the given form.
		/// </summary>
		protected void SetWindowProperties(Form form, WindowSmartPartInfo info)
		{
			form.Text = info.Title;
			form.Width = info.Width != 0 ? info.Width : form.Width;
			form.Height = info.Height != 0 ? info.Height : form.Height;
			form.ControlBox = info.ControlBox;
			form.MaximizeBox = info.MaximizeBox;
			form.MinimizeBox = info.MinimizeBox;
			form.Icon = info.Icon;
			form.Location = info.Location;
		}

		/// <summary>
		/// Sets the location information for the given form.
		/// </summary>
		protected void SetWindowLocation(Form form, WindowSmartPartInfo info)
		{
			form.Location = info.Location;
		}

		#endregion

		#region Private

		private void ControlDisposed(object sender, EventArgs e)
		{
			Control control = sender as Control;
			if (control != null && base.SmartParts.Contains(sender))
			{
				CloseInternal(control);
				//this.windowDictionary[control].Close();
				//this.windowDictionary.Remove(control);
			}
		}

		private void WireUpForm(WindowForm form)
		{
			form.WindowFormClosing += new EventHandler<WorkspaceCancelEventArgs>(WindowFormClosing);
			form.WindowFormClosed += new EventHandler<WorkspaceEventArgs>(WindowFormClosed);
			form.WindowFormActivated += new EventHandler<WorkspaceEventArgs>(WindowFormActivated);
		}

		private void WindowFormActivated(object sender, WorkspaceEventArgs e)
		{
			if (fireActivatedFromForm)
			{
				RaiseSmartPartActivated(e.SmartPart);
				base.SetActiveSmartPart(e.SmartPart);
			}
		}

		private void WindowFormClosed(object sender, WorkspaceEventArgs e)
		{
			RemoveEntry((Control)e.SmartPart);
			base.InnerSmartParts.Remove((Control)e.SmartPart);
		}

		private void WindowFormClosing(object sender, WorkspaceCancelEventArgs e)
		{
			base.RaiseSmartPartClosing(e);
		}

		private void CalculateSize(Control smartPart, Form form)
		{
			form.Size = new Size(smartPart.Size.Width, smartPart.Size.Height + 20);
		}

		private void RemoveEntry(Control spcontrol)
		{
			this.windowDictionary.Remove(spcontrol);
		}

		private void ShowForm(Form form, WindowSmartPartInfo smartPartInfo)
		{
			SetWindowProperties(form, smartPartInfo);

			if (smartPartInfo.Modal == true)
			{
				SetWindowLocation(form, smartPartInfo);
				// Argument can be null. It's the default for the other overload.
				form.ShowDialog(ownerForm);
			}
			else
			{
				// Call changes if no owner is specified.
				if (ownerForm != null)
				{
					form.Show(ownerForm);
				}
				else
				{
					form.Show();
				}
				SetWindowLocation(form, smartPartInfo);
				form.BringToFront();
			}
		}

		#endregion

		#region Private Form Class

		/// <summary>
		/// WindowForm class
		/// </summary>
		private class WindowForm : Form
		{
			/// <summary>
			/// Fires when form is closing
			/// </summary>
			public event EventHandler<WorkspaceCancelEventArgs> WindowFormClosing;

			/// <summary>
			/// Fires when form is closed
			/// </summary>
			public event EventHandler<WorkspaceEventArgs> WindowFormClosed;

			/// <summary>
			/// Fires when form is activated
			/// </summary>
			public event EventHandler<WorkspaceEventArgs> WindowFormActivated;

			/// <summary>
			/// Handles Activated Event.
			/// </summary>
			/// <param name="e"></param>
			protected override void OnActivated(EventArgs e)
			{
				if (this.Controls.Count > 0)
				{
					this.WindowFormActivated(this, new WorkspaceEventArgs(this.Controls[0]));
				}

				base.OnActivated(e);
			}


			/// <summary>
			/// Handles the Closing Event
			/// </summary>
			/// <param name="e"></param>
			protected override void OnClosing(CancelEventArgs e)
			{
				if (this.Controls.Count > 0)
				{
					WorkspaceCancelEventArgs cancelArgs = FireWindowFormClosing(this.Controls[0]);
					e.Cancel = cancelArgs.Cancel;

					if (cancelArgs.Cancel == false)
					{
						this.Controls[0].Hide();
					}
				}

				base.OnClosing(e);
			}

			/// <summary>
			/// Handles the Closed Event
			/// </summary>
			/// <param name="e"></param>
			protected override void OnClosed(EventArgs e)
			{
				if ((this.WindowFormClosed != null) &&
					(this.Controls.Count > 0))
				{
					this.WindowFormClosed(this, new WorkspaceEventArgs(this.Controls[0]));
				}

				base.OnClosed(e);
			}

			private WorkspaceCancelEventArgs FireWindowFormClosing(object smartPart)
			{
				WorkspaceCancelEventArgs cancelArgs = new WorkspaceCancelEventArgs(smartPart);

				if (this.WindowFormClosing != null)
				{
					this.WindowFormClosing(this, cancelArgs);
				}

				return cancelArgs;
			}
		}

		#endregion

		#region Behavior overrides

		/// <summary>
		/// Shows the form for the smart part and brings it to the front.
		/// </summary>
		protected override void OnActivate(Control smartPart)
		{
			// Prevent double firing from composer Workspace class and from form.
			try
			{
				fireActivatedFromForm = false;
				Form form = windowDictionary[smartPart];
				form.BringToFront();
				form.Show();
			}
			finally
			{
				fireActivatedFromForm = true;
			}
		}

		/// <summary>
		/// Sets the properties on the window based on the information.
		/// </summary>
		protected override void OnApplySmartPartInfo(Control smartPart, WindowSmartPartInfo smartPartInfo)
		{
			Form form = windowDictionary[smartPart];
			SetWindowProperties(form, smartPartInfo);
			SetWindowLocation(form, smartPartInfo);
		}

		/// <summary>
		/// Shows a form for the smart part and sets its properties.
		/// </summary>
		protected override void OnShow(Control smartPart, WindowSmartPartInfo smartPartInfo)
		{
			Form form = GetOrCreateForm(smartPart);
			smartPart.Show();
			ShowForm(form, smartPartInfo);
		}

		/// <summary>
		/// Hides the form where the smart part is being shown.
		/// </summary>
		protected override void OnHide(Control smartPart)
		{
			Form form = windowDictionary[smartPart];
			form.Hide();
		}

		/// <summary>
		/// Closes the form where the smart part is being shown.
		/// </summary>
		protected override void OnClose(Control smartPart)
		{
			Form form = windowDictionary[smartPart];
			smartPart.Disposed -= ControlDisposed;

			// Remove the smartPart from the form to avoid disposing it.
			form.Controls.Remove(smartPart);

			form.Close();
			windowDictionary.Remove(smartPart);
		}

		#endregion
	}
}