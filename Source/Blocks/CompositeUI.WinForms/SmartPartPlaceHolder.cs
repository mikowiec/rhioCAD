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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// A <see cref="Control"/> that acts as a placeholder for a smartpart.
	/// </summary>
	[DesignerCategory("Code")]
	[ToolboxBitmap(typeof(SmartPartPlaceholder), "SmartPartPlaceholder")]
	public class SmartPartPlaceholder : Control, ISmartPartPlaceholder
	{
		private string smartPartName;
		private object smartPart;

		/// <summary>
		/// Fires when a smartpart is shown in the placeholder.
		/// </summary>
		public event EventHandler<SmartPartPlaceHolderEventArgs> SmartPartShown;

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="SmartPartPlaceholder"/> class.
		/// </summary>
		public SmartPartPlaceholder()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.Transparent;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets the name of SmartPart that will be placed in the placeholder.
		/// </summary>
		public string SmartPartName
		{
			get { return smartPartName; }
			set
			{
				smartPartName = value;
				this.Refresh();
			}
		}

		/// <summary>
		/// Gets or sets a reference to the smartpart after it has been added.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public object SmartPart
		{
			get { return smartPart; }
			set
			{
				Guard.ArgumentNotNull(value, "value");
				if (value is Control == false)
				{
					throw new ArgumentException(Properties.Resources.SmartPartNotControl);
				}

				smartPart = value;
				Control spcontrol = (Control) smartPart;
				spcontrol.Dock = DockStyle.Fill;
				spcontrol.Show();
				this.Controls.Clear();
				this.Controls.Add(spcontrol);
				OnSmartPartShown(spcontrol);
			}
		}

		#endregion

		private void OnSmartPartShown(object smartPartShown)
		{
			if (this.SmartPartShown != null)
			{
				this.SmartPartShown(this, new SmartPartPlaceHolderEventArgs(smartPartShown));
			}
		}

		#region Protected

		/// <summary>
		/// Paints a border at design time.
		/// </summary>
		/// <param name="e">A <see cref="PaintEventArgs"/> that contains the event data</param>
		protected override void OnPaint(PaintEventArgs e)
		{
			if (!this.DesignMode)
				return;

			using (Pen p = new Pen(this.ForeColor))
			using (Brush b = new SolidBrush(this.ForeColor))
			{
				Rectangle r = this.ClientRectangle;
				r.Height -= 1;
				r.Width -= 1;

				p.DashStyle = DashStyle.Dash;
				e.Graphics.DrawRectangle(p, r);
				e.Graphics.DrawString(this.SmartPartName, this.Font, b, r.X + 2, r.Y + 2);
			}
		}

		#endregion
	}
}