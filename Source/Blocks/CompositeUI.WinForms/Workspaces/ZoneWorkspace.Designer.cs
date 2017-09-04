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


using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	[ProvideProperty("ZoneName", typeof(ScrollableControl))]
	[ProvideProperty("IsDefaultZone", typeof(ScrollableControl))]
	[ToolboxBitmap(typeof(ZoneWorkspace), "ZoneWorkspace")]
	public partial class ZoneWorkspace : IExtenderProvider
	{
		/// <summary>
		/// Zone name assigned to a given control. Can only be assigned to controls that are 
		/// contained in the <see cref="ZoneWorkspace"/>.
		/// </summary>
		/// <param name="target">Control to retrieve the zone name for.</param>
		/// <returns>The name of the zone assigned to the control, or null.</returns>
		[Category("Layout")]
		[DefaultValue(null)]
		[DisplayName("ZoneName")]
		[Description("Zone name assigned to the control so that smart parts can be shown on it programmatically.")]
		public string GetZoneName(Control target)
		{
			if (!zonesByControl.ContainsKey(target))
			{
				return null;
			}
			else
			{
				return zonesByControl[target];
			}
		}

		/// <summary>
		/// Zone name assigned to a given control. Can only be assigned to controls that are 
		/// contained in the <see cref="ZoneWorkspace"/>.
		/// </summary>
		/// <param name="target">Control to set the zone name to.</param>
		/// <param name="name">The name of the zone to assign to the control.</param>
		/// <returns>The name of the zone to assign to the control.</returns>
		[DisplayName("ZoneName")]
		public void SetZoneName(Control target, string name)
		{
			if (IsDescendant(target))
			{
                if (zonesByControl.ContainsKey(target))
                {
                    string oldname = zonesByControl[target];
                    zonesByName.Remove(oldname);
                    zonesByControl.Remove(target);
                }
                else if (String.IsNullOrEmpty(name) == false)
                {
                    target.ParentChanged += OnZoneParentChanged;
                }

                if (String.IsNullOrEmpty(name) == false)
                {
                    zonesByControl[target] = name;
                    zonesByName[name] = target;
                }
			}
		}

		/// <summary>
		/// Determines whether the zone is the default one. Only one zone can be the default and 
		/// only controls that are contained in the <see cref="ZoneWorkspace"/> can be set as default zones.
		/// </summary>
		/// <param name="target">Control to specify as the default one.</param>
		/// <returns>true if the zone is the default one, false otherwise.</returns>
		[Category("Layout")]
		[DefaultValue(false)]
		[DisplayName("IsDefaultZone")]
		[Description("Specifies whether the zone is the default one for showing smart parts.")]
		public bool GetIsDefaultZone(Control target)
		{
			return defaultZone == target;
		}

		/// <summary>
		/// Determines whether the zone is the default one. Only one zone can be the default and 
		/// only controls that are contained in the <see cref="ZoneWorkspace"/> can be set as default zones.
		/// </summary>
		/// <param name="target">Control to specify as the default one.</param>
		/// <param name="isDefault">true if the zone is the default one, false otherwise.</param>
		[DisplayName("IsDefaultZone")]
		public void SetIsDefaultZone(Control target, bool isDefault)
		{
			if (isDefault)
			{
				defaultZone = target;
			}
			else
			{
				defaultZone = null;
			}
		}

		bool IExtenderProvider.CanExtend(object extendee)
		{
			return extendee is ScrollableControl && IsDescendant((Control)extendee);
		}

		// Fix design-time.
		/// <summary>
		/// Refreshes the values on the control at design-time.
		/// </summary>
		/// <param name="e">The control being modified.</param>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected override void OnControlAdded(ControlEventArgs e)
		{
			base.OnControlAdded(e);
			RefreshRecursive(e.Control);
		}

		/// <summary>
		/// Refreshes the values on the control at design-time.
		/// </summary>
		/// <param name="e">The control being modified.</param>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected override void OnControlRemoved(ControlEventArgs e)
		{
			base.OnControlRemoved(e);

			if (DesignMode == true)
			{
				RefreshRecursive(e.Control);
			}
			else
			{
				RemoveControlFromDictionaries(e.Control);
			}
		}

		private void RefreshRecursive(Control control)
		{
			if (DesignMode)
			{
				// If the refresh operations are not called explicitly, 
				// controls will never be properly parented.
				TypeDescriptor.Refresh(control);
				foreach (Control child in control.Controls)
				{
					RefreshRecursive(child);
				}
			}
		}
	}
}
