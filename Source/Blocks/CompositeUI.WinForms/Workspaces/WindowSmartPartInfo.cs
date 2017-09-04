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
using Microsoft.Practices.CompositeUI.SmartParts;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Provides information to show smartparts in the <see cref="WindowWorkspace"/>.
	/// </summary>
	[ToolboxBitmap(typeof(WindowSmartPartInfo), "WindowSmartPartInfo")]
	public class WindowSmartPartInfo : SmartPartInfo
	{
		private bool showModal = false;
		private bool controlBox = true;
		private bool maximizeButton = true;
		private bool minimizeButton = true;
		private int height = 0;
		private int width = 0;
		private Point location = default(Point);
		private Icon icon = null;

		/// <summary>
		/// Gets/Sets the location of the window.
		/// </summary>
		[Category("Layout")]
		[DefaultValue(null)]
		public Point Location
		{
			get { return location; }
			set { location = value; }
		}

		/// <summary>
		/// The Icon that will appear on the window.
		/// </summary>
		[DefaultValue(null)]
		[Category("Layout")]
		public Icon Icon
		{
			get { return icon; }
			set { icon = value; }
		}

		/// <summary>
		/// Width of the window.
		/// </summary>
		[Category("Layout")]
		[DefaultValue(0)]
		public int Width
		{
			get { return width; }
			set { width = value; }
		}

		/// <summary>
		/// Height of the window.
		/// </summary>
		[Category("Layout")]
		[DefaultValue(0)]
		public int Height
		{
			get { return height; }
			set { height = value; }
		}

		/// <summary>
		/// Make minimize button visible.
		/// </summary>
		[DefaultValue(true)]
		[Category("Layout")]
		public bool MinimizeBox
		{
			get { return minimizeButton; }
			set { minimizeButton = value; }
		}

		/// <summary>
		/// Make maximize button visible.
		/// </summary>
		[DefaultValue(true)]
		[Category("Layout")]
		public bool MaximizeBox
		{
			get { return maximizeButton; }
			set { maximizeButton = value; }
		}

		/// <summary>
		/// Whether the controlbox will be visible.
		/// </summary>
		[DefaultValue(true)]
		[Category("Layout")]
		public bool ControlBox
		{
			get { return controlBox; }
			set { controlBox = value; }
		}

		/// <summary>
		/// Whether the form should be shown as modal.
		/// </summary>
		[DefaultValue(false)]
		[Category("Layout")]
		public bool Modal
		{
			get { return showModal; }
			set { showModal = value; }
		}

	}
}