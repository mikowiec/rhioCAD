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
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using System.Collections.ObjectModel;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Implements a workspace which shows <see cref="Control"/> layered as in a deck.
	/// </summary>
	[DesignerCategory("Code")]
	public partial class DeckWorkspace : Control, IComposableWorkspace<Control, SmartPartInfo>
	{
		private WorkspaceComposer<Control, SmartPartInfo> composer;
        private bool isDisposing = false;

		/// <summary>
		/// Initializes a new instance of the <see cref="DeckWorkspace"/> class.
		/// </summary>
		public DeckWorkspace()
		{
			composer = new WorkspaceComposer<Control, SmartPartInfo>(this);
		}

		/// <summary>
		/// The controls that the deck currently contains.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ReadOnlyCollection<Control> SmartParts
		{
			get
			{
				Control[] controls = new Control[composer.SmartParts.Count];
				composer.SmartParts.CopyTo(controls, 0);
				return new ReadOnlyCollection<Control>(controls);
			}
		}

		/// <summary>
		/// The currently active smart part.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Control ActiveSmartPart
		{
			get { return (Control)composer.ActiveSmartPart; }
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

        /// <summary>
        /// Overriden to control when the workspace is being disposed to disable the control activation logic.
        /// </summary>
        /// <param name="disposing">A flag that indicates if <see cref="IDisposable.Dispose"/> was called.</param>
        protected override void Dispose(bool disposing)
        {
            isDisposing = disposing;
            base.Dispose(disposing);
        }


		#region Private

        private void ControlDisposed(object sender, EventArgs e)
        {
			Control control = sender as Control;
			if (this.isDisposing == false && control != null)
            {
				composer.ForceClose(control);
            }
        }

		private void FireSmartPartActivated(object smartPart)
		{
			if (this.SmartPartActivated != null)
			{
				this.SmartPartActivated(this, new WorkspaceEventArgs(smartPart));
			}
		}

		private void ActivateTopmost()
		{
			if (this.Controls.Count != 0)
			{
				Activate(this.Controls[0]);
			}
		}

		#endregion

		#region Protected virtual implementation

		/// <summary>
		/// Activates the smart part.
		/// </summary>
		protected virtual void OnActivate(Control smartPart)
		{
			//this.Controls.SetChildIndex(smartPart, this.Controls.Count - 1);
			smartPart.BringToFront();
			smartPart.Show();
		}

		/// <summary>
		/// Applies the smart part display information to the smart part.
		/// </summary>
		protected virtual void OnApplySmartPartInfo(Control smartPart, SmartPartInfo smartPartInfo)
		{
			// No op. We do not use the SPI for anything actually.
		}

		/// <summary>
		/// Closes the smart part.
		/// </summary>
		protected virtual void OnClose(Control smartPart)
		{
			this.Controls.Remove(smartPart);

			smartPart.Disposed -= ControlDisposed;

			ActivateTopmost();
		}

		/// <summary>
		/// Hides the smart part.
		/// </summary>
		protected virtual void OnHide(Control smartPart)
		{
			smartPart.SendToBack();

			ActivateTopmost();
		}

		/// <summary>
		/// Shows the control.
		/// </summary>
		protected virtual void OnShow(Control smartPart, SmartPartInfo smartPartInfo)
		{
			smartPart.Dock = DockStyle.Fill;

			this.Controls.Add(smartPart);

			smartPart.Disposed += ControlDisposed;
			Activate(smartPart);
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
		protected void OnSmartPartClosing(WorkspaceCancelEventArgs e)
		{
			if (SmartPartClosing != null)
			{
				SmartPartClosing(this, e);
			}
		}

		/// <summary>
		/// Converts a smart part information to a compatible one for the workspace.
		/// </summary>
		protected virtual SmartPartInfo OnConvertFrom(ISmartPartInfo source)
		{
			return SmartPartInfo.ConvertTo<SmartPartInfo>(source);
		}

		#endregion

		#region IComposableWorkspace<Control,SmartPartInfo> Members

		void IComposableWorkspace<Control, SmartPartInfo>.OnActivate(Control smartPart)
		{
			OnActivate(smartPart);
		}

		void IComposableWorkspace<Control, SmartPartInfo>.OnApplySmartPartInfo(Control smartPart, SmartPartInfo smartPartInfo)
		{
			OnApplySmartPartInfo(smartPart, smartPartInfo);
		}

		void IComposableWorkspace<Control, SmartPartInfo>.OnClose(Control smartPart)
		{
			OnClose(smartPart);
		}

		void IComposableWorkspace<Control, SmartPartInfo>.OnHide(Control smartPart)
		{
			OnHide(smartPart);
		}

		void IComposableWorkspace<Control, SmartPartInfo>.OnShow(Control smartPart, SmartPartInfo smartPartInfo)
		{
			OnShow(smartPart, smartPartInfo);
		}

		void IComposableWorkspace<Control, SmartPartInfo>.RaiseSmartPartActivated(WorkspaceEventArgs e)
		{
			OnSmartPartActivated(e);
		}

		void IComposableWorkspace<Control, SmartPartInfo>.RaiseSmartPartClosing(WorkspaceCancelEventArgs e)
		{
			OnSmartPartClosing(e);
		}

		SmartPartInfo IComposableWorkspace<Control, SmartPartInfo>.ConvertFrom(ISmartPartInfo source)
		{
			return OnConvertFrom(source);
		}

		#endregion

		#region IWorkspace Members

		/// <summary>
		/// See <see cref="IWorkspace.SmartPartClosing"/>.
		/// </summary>
		public event EventHandler<WorkspaceCancelEventArgs> SmartPartClosing;

		/// <summary>
		/// See <see cref="IWorkspace.SmartPartActivated"/>.
		/// </summary>
		public event EventHandler<WorkspaceEventArgs> SmartPartActivated;

		/// <summary>
		/// See <see cref="IWorkspace.SmartParts"/>.
		/// </summary>
		ReadOnlyCollection<object> IWorkspace.SmartParts
		{
			get { return composer.SmartParts; }
		}

		/// <summary>
		/// See <see cref="IWorkspace.ActiveSmartPart"/>.
		/// </summary>
		object IWorkspace.ActiveSmartPart
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