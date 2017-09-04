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
using Microsoft.Practices.CompositeUI.SmartParts;
using System.Drawing;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Specifies the position of the tab page on a <see cref="TabWorkspace"/>.
	/// </summary>
	public enum TabPosition
	{
		/// <summary>
		/// Place tab page at begining.
		/// </summary>
		Beginning,
		/// <summary>
		/// Place tab page at end.
		/// </summary>
		End,
	}

	/// <summary>
	/// A <see cref="SmartPartInfo"/> that describes how a specific smartpart
	/// will be shown in a tab workspace.
	/// </summary>
	[ToolboxBitmap(typeof(TabSmartPartInfo), "TabSmartPartInfo")]
	public class TabSmartPartInfo : SmartPartInfo
	{
		private TabPosition position = TabPosition.End;
		private bool activateTab = true;

		/// <summary>
		/// Specifies whether the tab will get focus when shown.
		/// </summary>
		[Category("Layout")]
		[DefaultValue(true)]
		public bool ActivateTab
		{
			get { return activateTab; }
			set { activateTab = value; }
		}

		/// <summary>
		/// Specifies the position of the tab page.
		/// </summary>
		[Category("Layout")]
		[DefaultValue(TabPosition.End)]
		public TabPosition Position
		{
			get { return position; }
			set { position = value; }
		}


	}
}