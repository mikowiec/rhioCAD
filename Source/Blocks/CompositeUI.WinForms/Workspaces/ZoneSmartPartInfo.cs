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
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Provides infomation to show smartparts in the <see cref="ZoneWorkspace"/>.
	/// </summary>
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(ZoneSmartPartInfo), "ZoneSmartPartInfo")]
	public class ZoneSmartPartInfo : SmartPartInfo
	{
		private string zoneName;
		private DockStyle? dock = null;

		/// <summary>
		/// Initializes the ZonedSmartPartInfo with no zone name.
		/// </summary>
		public ZoneSmartPartInfo()
		{
		}

		/// <summary>
		/// Creates the information for the smart part specifying the name of the zone.
		/// </summary>
		/// <param name="zoneName">Name of the zone assigned to a smart part.</param>
		public ZoneSmartPartInfo(string zoneName)
		{
			this.zoneName = zoneName;
		}

		/// <summary>
		/// Creates the information for the smart part specifying its title and the name of the zone.
		/// </summary>
		/// <param name="zoneName">Name of the zone assigned to a smart part.</param>
		/// <param name="title">Title of the smart part.</param>
		public ZoneSmartPartInfo(string title, string zoneName)
		{
			base.Title = title;
			this.zoneName = zoneName;
		}

		/// <summary>
		/// Name of the zone where the smart part should be shown.
		/// </summary>
		/// <remarks>
		/// If a zone with the given name does not exist in the <see cref="ZoneWorkspace"/> 
		/// where the smart part is being shown, an exception will be thrown.
		/// </remarks>
		[Category("Layout")]
		[DefaultValue(null)]
		public string ZoneName
		{
			get { return zoneName; }
			set { zoneName = value; }
		}

		/// <summary>
		/// Sets the dockstyle of the control to show in the zone.
		/// </summary>
		[DefaultValue(null)]
		[Category("Layout")]
		public DockStyle? Dock
		{
			get { return dock; }
			set { dock = value; }
		}
	}
}