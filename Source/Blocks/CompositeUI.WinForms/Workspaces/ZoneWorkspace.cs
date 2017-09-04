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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.Utility;
using Glass;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Implements a Workspace that can contain named zones where 
	/// controls can be shown.
	/// </summary>
	/// <remarks>
	/// This workspace is intended to be used in a designer. If programmatic manipulation of zone definition 
	/// is required, instead of directly adding zones to the <see cref="Zones"/> property, the following 
	/// operations should be performed in order to get proper behavior:
	/// <para>
	/// 1 - The control must be added as a child control of the workspace, probably inside a splitter container.
	/// </para>
	/// <para>
	/// 2 - The <see cref="SetZoneName"/> must be called passing the control and the desired zone name.
	/// </para>
	/// </remarks>
	[DesignerCategory("Code")]
	public partial class ZoneWorkspace : GlassPanel, IComposableWorkspace<Control, ZoneSmartPartInfo>, ISupportInitialize
	{
		private Dictionary<Control, string> zonesByControl = new Dictionary<Control, string>();
		private Dictionary<string, Control> zonesByName = new Dictionary<string, Control>();
		private Control defaultZone = null;
		private WorkspaceComposer<Control, ZoneSmartPartInfo> composer;

		/// <summary>
		/// Initializes a new instance of the <see cref="ZoneWorkspace"/> class
		/// </summary>
		public ZoneWorkspace()
		{
			composer = new WorkspaceComposer<Control, ZoneSmartPartInfo>(this);
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
		/// Dictionary of zones that have been given names. 
		/// </summary>
		[Browsable(false)]
		public ReadOnlyDictionary<string, Control> Zones
		{
			get { return new ReadOnlyDictionary<string, Control>(zonesByName); }
		}

		#region Private Methods

		private void RemoveControlFromDictionaries(Control control)
		{
			if (this.zonesByControl.ContainsKey(control))
			{
				this.zonesByName.Remove(GetZoneName(control));
				this.zonesByControl.Remove(control);
			}
			else
			{
				Control[] keys = new Control[zonesByControl.Keys.Count];
				zonesByControl.Keys.CopyTo(keys, 0);

				foreach (Control key in keys)
				{
					if (IsDescendant(control, key) == true)
					{
						this.zonesByName.Remove(GetZoneName(key));
						this.zonesByControl.Remove(key);
						key.ParentChanged -= OnZoneParentChanged;

						foreach (Control sp in key.Controls)
						{
							Close(sp);
						}
					}
				}

			}
		}

		private void SmartPartEntered(object sender, EventArgs e)
		{
			Control control = sender as Control;
			if (control != null)
			{
				((IComposableWorkspace<Control, ZoneSmartPartInfo>)this).Activate(control);
			}
			else
			{
				composer.SetActiveSmartPart(null);
			}
		}

		private void OnZoneParentChanged(object sender, EventArgs e)
		{
			Control control = sender as Control;
			if (control != null)
			{
				if (IsDescendant(control) == false)
				{
					if (zonesByControl.ContainsKey(control))
					{
						string name = zonesByControl[control];
						zonesByName.Remove(name);
						zonesByControl.Remove(control);
						foreach (Control sp in control.Controls)
						{
							Close(sp);
						}
						control.ParentChanged -= OnZoneParentChanged;
					}
				}
			}
		}

		private bool IsDescendant(Control target)
		{
			return IsDescendant(this, target);
		}

		private bool IsDescendant(Control parent, Control child)
		{
			Control childParent = child.Parent;
			while (childParent != null && childParent != parent)
			{
				childParent = childParent.Parent;
			}

			return childParent == parent;
		}

		private Control GetTargetZone(ZoneSmartPartInfo info)
		{
			Control zone = defaultZone;
			if (info != null && info.ZoneName != null)
			{
				if (zonesByName.ContainsKey(info.ZoneName) == false)
				{
					throw new ArgumentOutOfRangeException("ZoneName", String.Format(
						CultureInfo.CurrentCulture,
						Properties.Resources.NoZoneWithName,
						info.ZoneName));
				}

				zone = zonesByName[info.ZoneName];
			}

			if (zone == null)
			{
				foreach (KeyValuePair<string, Control> pair in zonesByName)
				{
					zone = pair.Value;
					break;
				}
			}
			return zone;
		}

		private void AddControlToZone(Control control, ZoneSmartPartInfo info)
		{
			Control zone = GetTargetZone(info);
			if (info.Dock != null)
			{
				control.Dock = info.Dock.Value;
			}

			zone.Controls.Add(control);
		}

		private void ControlDisposed(object sender, EventArgs e)
		{
			Control control = sender as Control;
			if (control != null)
			{
				composer.ForceClose(control);
			}
		}

		#endregion

		#region Virtual implementation members

		/// <summary>
		/// Activates the smart part.
		/// </summary>
		protected virtual void OnActivate(Control smartPart)
		{
			smartPart.Show();
			smartPart.Enter -= SmartPartEntered;
			try
			{
				smartPart.Focus();
			}
			finally
			{
				smartPart.Enter += SmartPartEntered;
			}
		}

		/// <summary>
		/// Applies the smart part display information to the smart part.
		/// </summary>
		protected virtual void OnApplySmartPartInfo(Control smartPart, ZoneSmartPartInfo smartPartInfo)
		{
			AddControlToZone(smartPart, smartPartInfo);
		}

		/// <summary>
		/// Closes the smart part.
		/// </summary>
		protected virtual void OnClose(Control smartPart)
		{
			smartPart.Disposed -= ControlDisposed;
			smartPart.Enter -= SmartPartEntered;

			if (smartPart.Parent != null)
			{
				smartPart.Parent.Controls.Remove(smartPart);
			}
		}

		/// <summary>
		/// Hides the smart part.
		/// </summary>
		protected virtual void OnHide(Control smartPart)
		{
			smartPart.Hide();
		}

		/// <summary>
		/// Shows the control.
		/// </summary>
		protected virtual void OnShow(Control smartPart, ZoneSmartPartInfo smartPartInfo)
		{
			if (zonesByName.Count == 0)
			{
				throw new InvalidOperationException(
					Properties.Resources.NoZonesInZoneWorkspace);
			}
			smartPart.Disposed += ControlDisposed;
			AddControlToZone(smartPart, smartPartInfo);
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
		protected virtual ZoneSmartPartInfo OnConvertFrom(ISmartPartInfo source)
		{
			return SmartPartInfo.ConvertTo<ZoneSmartPartInfo>(source);
		}

		#endregion

		#region IComposableWorkspace<Control,ZoneSmartPartInfo> Members

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnActivate"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, ZoneSmartPartInfo>.OnActivate(Control smartPart)
		{
			OnActivate(smartPart);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnApplySmartPartInfo"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, ZoneSmartPartInfo>.OnApplySmartPartInfo(Control smartPart, ZoneSmartPartInfo smartPartInfo)
		{
			OnApplySmartPartInfo(smartPart, smartPartInfo);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnShow"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, ZoneSmartPartInfo>.OnShow(Control smartPart, ZoneSmartPartInfo smartPartInfo)
		{
			OnShow(smartPart, smartPartInfo);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnHide"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, ZoneSmartPartInfo>.OnHide(Control smartPart)
		{
			OnHide(smartPart);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.OnClose"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, ZoneSmartPartInfo>.OnClose(Control smartPart)
		{
			OnClose(smartPart);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.RaiseSmartPartActivated"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, ZoneSmartPartInfo>.RaiseSmartPartActivated(WorkspaceEventArgs e)
		{
			OnSmartPartActivated(e);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.RaiseSmartPartClosing"/> for more information.
		/// </summary>
		void IComposableWorkspace<Control, ZoneSmartPartInfo>.RaiseSmartPartClosing(WorkspaceCancelEventArgs e)
		{
			OnSmartPartClosing(e);
		}

		/// <summary>
		/// See <see cref="IComposableWorkspace{TSmartPart, TSmartPartInfo}.ConvertFrom"/> for more information.
		/// </summary>
		ZoneSmartPartInfo IComposableWorkspace<Control, ZoneSmartPartInfo>.ConvertFrom(ISmartPartInfo source)
		{
			return OnConvertFrom(source);
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
		public ReadOnlyCollection<object> SmartParts
		{
			get { return composer.SmartParts; }
		}

		/// <summary>
		/// See <see cref="IWorkspace.ActiveSmartPart"/> for more information.
		/// </summary>
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

		#region ISupportInitialize Members

		void ISupportInitialize.BeginInit()
		{
			OnBeginInit();
		}

		void ISupportInitialize.EndInit()
		{
			OnEndInit();
		}

		/// <summary>
		/// Begins the initialization of the workspace in a designer-generated 
		/// block of code (typically InitializeComponent method).
		/// </summary>
		protected virtual void OnBeginInit()
		{
		}

		/// <summary>
		/// Ends the initialization of the workspace in a designer-generated 
		/// block of code (typically InitializeComponent method).
		/// </summary>
		protected virtual void OnEndInit()
		{
			// Treat top-level controls inside named zones as smart parts too.
			foreach (KeyValuePair<string, Control> zone in zonesByName)
			{
				foreach (Control child in zone.Value.Controls)
				{
					// Only set the zone name, so that the remaining information stays the same
					// as specified at design-time. ZoneName is required so that the Show is 
					// performed on the proper zone (should be a no-op).
					ZoneSmartPartInfo zoneInfo = new ZoneSmartPartInfo(zone.Key);
					Show(child, zoneInfo);
				}
			}
		}

		#endregion
	}
}