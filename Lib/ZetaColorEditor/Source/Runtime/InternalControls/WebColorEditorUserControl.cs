namespace ZetaColorEditor.Runtime.InternalControls
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Drawing;
	using System.Reflection;
	using System.Windows.Forms;

	public partial class WebColorEditorUserControl :
		UserControl
	{
		private ListViewItem _needEnsureVisibleListViewItem;

		public WebColorEditorUserControl()
		{
			InitializeComponent();
		}

		private void colorsListView_Click(
			object sender,
			EventArgs e )
		{

		}

		/// <summary>
		/// Gets the color of the selected.
		/// </summary>
		/// <value>The color of the selected.</value>
		[Browsable( false )]
		public Color SelectedColor
		{
			get
			{
				if ( colorsListView.SelectedItems.Count == 1 )
				{
					return (Color)colorsListView.SelectedItems[0].Tag;
				}
				else
				{
					return Color.Empty;
				}
			}
			set
			{
				if ( !DesignMode )
				{
					foreach ( ListViewItem listViewItem in colorsListView.Items )
					{
						var color = (Color)listViewItem.Tag;

						if ( color == value )
						{
							doSelectItem( listViewItem );
							return;
						}
					}

					// Not found.
					colorsListView.SelectedItems.Clear();
				}
			}
		}

		/// <summary>
		/// Does the select item.
		/// </summary>
		/// <param name="listViewItem">The list view item.</param>
		private void doSelectItem(
			ListViewItem listViewItem )
		{
			colorsListView.SelectedItems.Clear();

			listViewItem.Selected = true;
			listViewItem.Focused = true;

			listViewItem.EnsureVisible();

			_needEnsureVisibleListViewItem = listViewItem;

			colorsListView.Select();
			colorsListView.Focus();
		}

		/// <summary>
		/// Occurs when the parent needs to update command states.
		/// </summary>
		public event EventHandler NeedUpdateUI;

		private void colorsListView_DoubleClick(
			object sender,
			EventArgs e )
		{

		}

		private void colorsListView_DrawColumnHeader(
			object sender,
			DrawListViewColumnHeaderEventArgs e )
		{
			e.DrawDefault = true;
		}

		private void colorsListView_DrawItem(
			object sender,
			DrawListViewItemEventArgs e )
		{
			e.DrawDefault = false;
		}

		private void colorsListView_DrawSubItem(
			object sender,
			DrawListViewSubItemEventArgs e )
		{
			e.DrawDefault = false;

			var color = (Color)e.Item.Tag;

			Brush backgroundBrush;
			Brush textBrush;

			if ( e.Item.Selected )
			{
				backgroundBrush = SystemBrushes.Highlight;
				textBrush = SystemBrushes.HighlightText;
			}
			else
			{
				backgroundBrush = SystemBrushes.Window;
				textBrush = SystemBrushes.WindowText;
			}

			e.Graphics.FillRectangle(
				backgroundBrush,
				e.Bounds );

			const int squareDistance = 1;
			var squareWidth = (e.Bounds.Height - 2) * 2 * squareDistance;
			var squareHeight = e.Bounds.Height - 2 * squareDistance;

			var offsetX = e.Bounds.Left + squareDistance;
			var offsetY = e.Bounds.Top + squareDistance;

			var r = new Rectangle(
				offsetX, offsetY,
				squareWidth,
				squareHeight );

			using ( Brush brush = new SolidBrush( color ) )
			{
				e.Graphics.FillRectangle( brush, r );
			}

			var r2 = new Rectangle(
				r.Left, r.Top, r.Width - 1, r.Height - 1 );
			var pen = SystemPens.ControlDarkDark;
			e.Graphics.DrawRectangle( pen, r2 );

			offsetX += squareWidth + squareDistance * 2;

			var rf = new RectangleF(
				offsetX, e.Bounds.Top,
				e.Bounds.Width - offsetX,
				e.Bounds.Height );

			e.Graphics.DrawString( e.Item.Text, e.Item.Font, textBrush, rf );
		}

		private void webColorEditorUserControl_Load( object sender, EventArgs e )
		{
			if ( !DesignMode )
			{
				checkEnsureFilled();

				if ( _needEnsureVisibleListViewItem != null )
				{
					doSelectItem( _needEnsureVisibleListViewItem );
				}

				// --

				colorsListView_SizeChanged( null, null );
			}
		}

		private void colorsListView_SizeChanged( object sender, EventArgs e )
		{
			colorsListView.Columns[0].Width =
				colorsListView.ClientSize.Width - 1;
		}

		private void colorsListView_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( NeedUpdateUI != null )
			{
				NeedUpdateUI( this, EventArgs.Empty );
			}
		}

		public bool ContainsColor( Color value )
		{
			checkEnsureFilled();

			foreach ( ListViewItem listViewItem in colorsListView.Items )
			{
				var color = (Color)listViewItem.Tag;

				if ( color == value )
				{
					return true;
				}
			}

			return false;
		}

		private void checkEnsureFilled()
		{
			if ( colorsListView.Items.Count <= 0 )
			{
				var colors = new List<Color>();

				var members =
					typeof( Color ).GetProperties(
						BindingFlags.Public | BindingFlags.Static );

				foreach ( var member in members )
				{
					if ( member.PropertyType == typeof( Color ) )
					{
						var color = (Color)member.GetValue( null, null );

						colors.Add( color );
					}
				}

				Trace.WriteLine( @"About to sort colors." );

				var index = 0;

				colors.Sort(
					delegate( Color c1, Color c2 )
					{
						Trace.WriteLine( string.Format(
							@"[{0}.] Sorting color '{1}' and '{2}'.",
							index + 1,
							c1,
							c2 ) );

						index++;

						if ( c1 == c2 || c1.Equals( c2 ) )
						{
							return 0;
						}
						else
						{
							if ( c1.A < c2.A )
							{
								return -1;
							}
							if ( c1.A > c2.A )
							{
								return 1;
							}
							if ( c1.GetHue() < c2.GetHue() )
							{
								return -1;
							}
							if ( c1.GetHue() > c2.GetHue() )
							{
								return 1;
							}
							if ( c1.GetSaturation() < c2.GetSaturation() )
							{
								return -1;
							}
							if ( c1.GetSaturation() > c2.GetSaturation() )
							{
								return 1;
							}
							if ( c1.GetBrightness() < c2.GetBrightness() )
							{
								return -1;
							}
							if ( c1.GetBrightness() > c2.GetBrightness() )
							{
								return 1;
							}
							return 0;
						}
					} );

				Trace.WriteLine( @"Finished sorting colors." );

				// --

				foreach ( var color in colors )
				{
					var lvi =
						new ListViewItem
						{
							Text = color.Name,
							Tag = color
						};

					colorsListView.Items.Add( lvi );
				}
			}
		}
	}
}