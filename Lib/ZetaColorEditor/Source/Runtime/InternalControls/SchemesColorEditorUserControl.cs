namespace ZetaColorEditor.Runtime.InternalControls
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Drawing;
	using System.Windows.Forms;
	using ColorSchemes;

	public partial class SchemesColorEditorUserControl :
		UserControl
	{
		private bool _ignoreListViewChanges;
		private bool _ignoreComboBoxChanges = true;
		private IColorScheme[] _cacheFor_ColorSchemes;
		private ListViewItem _needEnsureVisibleListViewItem;

		public SchemesColorEditorUserControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Occurs when the parent needs to update command states.
		/// </summary>
		public event EventHandler NeedUpdateUI;

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
					checkEnsureFilled();

					// First, look in the currently selected scheme.
					foreach ( ListViewItem listViewItem in colorsListView.Items )
					{
						var color = (Color)listViewItem.Tag;

						if ( color == value )
						{
							colorsListView.SelectedItems.Clear();

							doSelectItem( listViewItem );
							return;
						}
					}

					var selectedSchemeIndex = schemesComboBox.SelectedIndex;

					// --

					// Not found, try other schemes.

					for ( var i = 0; i < schemesComboBox.Items.Count; ++i )
					{
						if ( i != selectedSchemeIndex )
						{
							var scheme = (IColorScheme)schemesComboBox.Items[i];

							foreach ( var color in scheme.Colors )
							{
								if ( color == value )
								{
									// Found. Select the scheme, then the color.
									schemesComboBox.SelectedItem = scheme;

									// Now the colors are filled, select.
									foreach ( ListViewItem listViewItem in colorsListView.Items )
									{
										var c = (Color)listViewItem.Tag;

										if ( c == value )
										{
											doSelectItem( listViewItem );
											return;
										}
									}

									// Never should reach here.
									Debug.Assert( false );
								}
							}
						}
					}

					// --

					// Still not found.
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
		/// Gets the external provider.
		/// </summary>
		/// <value>The external provider.</value>
		private IExternalColorEditorInformationProvider externalColorEditorInformationProvider
		{
			get
			{
				var c = Parent;
				while ( c != null && !(c is ColorEditorUserControl) )
				{
					c = c.Parent;
				}

				if ( c == null )
				{
					return null;
				}
				else
				{
					var ceuc = (ColorEditorUserControl)c;

					return ceuc.ExternalColorEditorInformationProvider;
				}
			}
		}

		/// <summary>
		/// Gets the color schemes.
		/// </summary>
		/// <value>The color schemes.</value>
		private IColorScheme[] colorSchemes
		{
			get
			{
				if ( _cacheFor_ColorSchemes == null )
				{
					var informationProvider =
						externalColorEditorInformationProvider;

					if ( informationProvider == null ||
						informationProvider.ColorSchemes == null )
					{
						_cacheFor_ColorSchemes = null;
					}
					else
					{
						_cacheFor_ColorSchemes = informationProvider.ColorSchemes;
					}
				}

				return _cacheFor_ColorSchemes;
			}
		}

		private void colorsListView_Click( object sender, EventArgs e )
		{

		}

		private void colorsListView_DoubleClick( object sender, EventArgs e )
		{

		}

		private void colorsListView_DrawColumnHeader( object sender, DrawListViewColumnHeaderEventArgs e )
		{
			e.DrawDefault = true;
		}

		private void colorsListView_DrawItem( object sender, DrawListViewItemEventArgs e )
		{
			e.DrawDefault = false;
		}

		private void colorsListView_DrawSubItem( object sender, DrawListViewSubItemEventArgs e )
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

		private void colorsListView_SizeChanged( object sender, EventArgs e )
		{
			colorsListView.Columns[0].Width =
				colorsListView.ClientSize.Width - 1;
		}

		private void schemesColorEditorUserControl_Load( object sender, EventArgs e )
		{
			checkEnsureFilled();

			if ( _needEnsureVisibleListViewItem != null )
			{
				doSelectItem( _needEnsureVisibleListViewItem );
			}
			else
			{
				// None selected, restore saved selected index.

				if ( externalColorEditorInformationProvider != null )
				{
					schemesComboBox.SelectedIndex = Convert.ToInt32(
						externalColorEditorInformationProvider.RestorePerUserPerWorkstationValue(
							storeID + @".SchemesComboBox.SelectedIndex",
							schemesComboBox.SelectedIndex.ToString() ) );
				}
			}

			saveState();
			_ignoreComboBoxChanges = false;

			colorsListView_SizeChanged( null, null );
		}

		/// <summary>
		/// Gets the store ID.
		/// </summary>
		/// <value>The store ID.</value>
		private string storeID
		{
			get
			{
				return string.Format(
					@"{0}.{1}.{2}.{3}",
					((ColorEditorUserControl)Parent.Parent.Parent).StoreID,
					GetType().Name,
					Name,
					Text );
			}
		}


		/// <summary>
		/// Handles the SelectedIndexChanged event of the schemesComboBox 
		/// control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance 
		/// containing the event data.</param>
		private void schemesComboBox_SelectedIndexChanged(
			object sender,
			EventArgs e )
		{
			if ( !_ignoreComboBoxChanges )
			{
				saveState();
			}

			colorsListView.BeginUpdate();
			_ignoreListViewChanges = true;
			try
			{
				colorsListView.Items.Clear();

				if ( schemesComboBox.SelectedItem != null )
				{
					var colorScheme =
						(IColorScheme)schemesComboBox.SelectedItem;

					var schemeColors = colorScheme.Colors;

					if ( schemeColors != null && schemeColors.Length > 0 )
					{
						var colors = new List<Color>( schemeColors );

						// --

						var ep = externalColorEditorInformationProvider;

						foreach ( var color in colors )
						{
							var displayText = ConvertColorToHtmlColor( color );

							// Allow externally to reformat.
							if ( ep != null )
							{
								ep.FormatDisplayText(
									color,
									ref displayText );
							}

							var lvi =
								new ListViewItem
								{
									Text = displayText,
									Tag = color
								};

							colorsListView.Items.Add( lvi );
						}
					}
				}

				colorsListView_SizeChanged( null, null );
			}
			finally
			{
				colorsListView.EndUpdate();
				_ignoreListViewChanges = false;
			}

			if ( NeedUpdateUI != null )
			{
				NeedUpdateUI( this, EventArgs.Empty );
			}
		}

		private void saveState()
		{
			if ( externalColorEditorInformationProvider != null )
			{
				externalColorEditorInformationProvider.SavePerUserPerWorkstationValue(
					storeID + @".SchemesComboBox.SelectedIndex",
					schemesComboBox.SelectedIndex.ToString() );
			}
		}

		private void colorsListView_SelectedIndexChanged(
			object sender,
			EventArgs e )
		{
			if ( !_ignoreListViewChanges )
			{
				if ( NeedUpdateUI != null )
				{
					NeedUpdateUI( this, EventArgs.Empty );
				}
			}
		}

		public bool ContainsColor( Color value )
		{
			var schemes = colorSchemes;

			if ( schemes != null )
			{
				foreach ( var colorScheme in colorSchemes )
				{
					foreach ( var color in colorScheme.Colors )
					{
						if ( color == value )
						{
							return true;
						}
					}
				}
			}

			return false;
		}

		private void checkEnsureFilled()
		{
			var schemes = colorSchemes;

			if ( schemes != null )
			{
				if ( schemesComboBox.Items.Count <= 0 )
				{
					schemesComboBox.DisplayMember = @"Name";
					schemesComboBox.Items.AddRange( schemes );

					if ( schemesComboBox.Items.Count > 0 )
					{
						schemesComboBox.SelectedIndex = 0;
					}
				}
			}
		}

		#region Color methods.
		// ------------------------------------------------------------------

		public static bool IsNamedHtmlColor(
			Color color )
		{
			return color == Color.Transparent || knownColorValues.ContainsKey( color );
		}

		public static string GetNamedHtmlColor(
			Color color )
		{
			if ( color == Color.Transparent )
			{
				return @"transparent";
			}
			else
			{
				if ( IsNamedHtmlColor( color ) )
				{
					return knownColorValues[color];
				}
				else
				{
					return ConvertColorToHtmlColor( color );
				}
			}
		}

		/// <summary>
		/// Converts the color to a HTML color.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <returns>Returns a format "#RRGGBB".</returns>
		public static string ConvertColorToHtmlColor(
			Color color )
		{
			if ( color == Color.Transparent )
			{
				return @"transparent";
			}
			else if ( knownColorValues.ContainsKey( color ) )
			{
				return knownColorValues[color];
			}
			else
			{
				// Not found or non-matching.
				return
					@"#" +
						color.R.ToString( @"X2" ) +
							color.G.ToString( @"X2" ) +
								color.B.ToString( @"X2" );
			}
		}

		private static Dictionary<string, Color> _knownColorNames;
		private static Dictionary<Color, string> _knownColorValues;

		private static Dictionary<string, Color> knownColorNames
		{
			get
			{
				if ( _knownColorNames == null )
				{
					_knownColorNames = new Dictionary<string, Color>();

					_knownColorNames[@"aqua"] = Color.Aqua;
					_knownColorNames[@"black"] = Color.Black;
					_knownColorNames[@"blue"] = Color.Blue;
					_knownColorNames[@"fuchsia"] = Color.Fuchsia;
					_knownColorNames[@"gray"] = Color.Gray;
					_knownColorNames[@"green"] = Color.Green;
					_knownColorNames[@"lime"] = Color.Lime;
					_knownColorNames[@"maroon"] = Color.Maroon;
					_knownColorNames[@"navy"] = Color.Navy;
					_knownColorNames[@"olive"] = Color.Olive;
					_knownColorNames[@"orange"] = Color.Orange;
					_knownColorNames[@"purple"] = Color.Purple;
					_knownColorNames[@"red"] = Color.Red;
					_knownColorNames[@"silver"] = Color.Silver;
					_knownColorNames[@"teal"] = Color.Teal;
					_knownColorNames[@"white"] = Color.White;
					_knownColorNames[@"yellow"] = Color.Yellow;

					// The reverse lookup.
					_knownColorValues = new Dictionary<Color, string>();

					foreach ( var pair in _knownColorNames )
					{
						_knownColorValues[pair.Value] = pair.Key;
					}
				}

				return _knownColorNames;
			}
		}

		private static Dictionary<Color, string> knownColorValues
		{
			get
			{
				if ( _knownColorValues == null )
				{
					// Just access once.
					var n = knownColorNames;
					Debug.Assert( n != null );
				}

				return _knownColorValues;
			}
		}

		/// <summary>
		/// Converts a HTML color to a color structure.
		/// </summary>
		/// <param name="htmlColor">the HTML color.</param>
		/// <returns>Returns the color structure.</returns>
		public static Color? ConvertHtmlColorToColor(
			string htmlColor )
		{
			if ( string.IsNullOrEmpty( htmlColor ) )
			{
				return null;
			}
			else if ( htmlColor == @"transparent" )
			{
				return Color.Transparent;
			}
			else if ( knownColorNames.ContainsKey( htmlColor ) )
			{
				return knownColorNames[htmlColor];
			}
			else
			{
				htmlColor = htmlColor.Trim().Trim( '#' ).Trim();

				if ( htmlColor.Length != 6 )
				{
					return null;
				}
				else
				{
					var r = Convert.ToInt32( htmlColor.Substring( 0, 2 ), 16 );
					var g = Convert.ToInt32( htmlColor.Substring( 2, 2 ), 16 );
					var b = Convert.ToInt32( htmlColor.Substring( 4, 2 ), 16 );

					return Color.FromArgb( r, g, b );
				}
			}
		}

		/// <summary>
		/// Gets the color of the complementary.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <returns></returns>
		/// <remarks>
		/// http://www.markus-keppeler.de/programme/komplement/
		/// </remarks>
		public static Color GetComplementaryColor(
			Color color )
		{
			return Color.FromArgb(
				255 - color.R,
				255 - color.G,
				255 - color.B );
		}

		// ------------------------------------------------------------------
		#endregion
	}
}
