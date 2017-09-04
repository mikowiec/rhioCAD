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
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;

namespace Microsoft.Practices.CompositeUI.WinForms
{
	/// <summary>
	/// Used to support designer.
	/// </summary>
	[Designer(typeof(DeckWorkspace.DeckWorkspaceDesigner), typeof(IDesigner))]
	[Docking(DockingBehavior.Ask)]
	[ToolboxBitmap(typeof(DeckWorkspace), "DeckWorkspace")]
	public partial class DeckWorkspace
	{
		private class DeckWorkspaceDesigner : ControlDesigner
		{
			protected override void OnPaintAdornments(PaintEventArgs pe)
			{
				Bitmap bmp = new Bitmap(Control.Width, Control.Height);
				Graphics gr = Graphics.FromImage(bmp);

				using (Pen pen = new Pen(Control.ForeColor))
				{
					pen.DashStyle = DashStyle.Dash;
					using (Brush outerBrush = new SolidBrush(Control.ForeColor))
					{
						Rectangle r = Control.ClientRectangle;
						r.Height -= 1;
						r.Width -= 1;

						// Outer rectangle.
						gr.DrawRectangle(pen, r);

						Color[] oneNoteColours = new Color[]
							{
								Control.BackColor,
								Control.BackColor,
								Control.BackColor
							};

						pen.DashStyle = DashStyle.Solid;
						int scaleFactor = 10;
						int delta = scaleFactor * (oneNoteColours.Length + 1);
						Size deckSize = new Size(r.Width - delta, r.Height - delta);

						for (int i = 1; i < oneNoteColours.Length + 1; i++)
						{
							Rectangle deck = new Rectangle(new Point(r.X + scaleFactor * i, r.Y + scaleFactor * i), deckSize);
							gr.DrawRectangle(pen, deck);
							using (Brush fill = new SolidBrush(oneNoteColours[i - 1]))
							{
								gr.FillRectangle(fill,
												 new Rectangle(++deck.X, ++deck.Y, --deck.Width, --deck.Height));
							}
						}
					}
				}

				pe.Graphics.DrawImage(bmp, 0, 0);
			}

			protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
			{
				base.OnGiveFeedback(new GiveFeedbackEventArgs(DragDropEffects.None, e.UseDefaultCursors));
			}

			protected override void OnDragDrop(DragEventArgs de)
			{
				// Do not allow drops.
			}
		}
	}
}
