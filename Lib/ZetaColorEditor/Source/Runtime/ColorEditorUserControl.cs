namespace ZetaColorEditor.Runtime
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Drawing;
	using System.Windows.Forms;

	/// <summary>
	/// 
	/// </summary>
	public partial class ColorEditorUserControl :
		UserControl
	{
		private bool _tabSet;

		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="ColorEditorUserControl"/> class.
		/// </summary>
		public ColorEditorUserControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Occurs when the parent needs to update command states.
		/// </summary>
		public event EventHandler NeedUpdateUI;

		/// <summary>
		/// Gets or sets the external provider.
		/// </summary>
		/// <value>The external provider.</value>
		[Browsable( false )]
		public IExternalColorEditorInformationProvider ExternalColorEditorInformationProvider
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the selected color.
		/// </summary>
		/// <value>The color of the selected.</value>
		[Browsable( false )]
		public Color SelectedColor
		{
			get
			{
				if ( DesignMode )
				{
					return Color.Empty;
				}
				else
				{
					if ( tabControl.SelectedTab == customColorsTabPage )
					{
						return customColorEditorControl.SelectedColor;
					}
					else if ( tabControl.SelectedTab == browserSafeColorsTabPage )
					{
						return browserSafeColorEditorControl.SelectedColor;
					}
					else if ( tabControl.SelectedTab == webColorsTabPage )
					{
						return webColorEditorControl.SelectedColor;
					}
					else if ( tabControl.SelectedTab == systemColorsTabPage )
					{
						return systemColorEditorControl.SelectedColor;
					}
					else if ( tabControl.SelectedTab == schemeColorsTabPage )
					{
						return schemesColorEditorControl.SelectedColor;
					}
					else
					{
						Debug.Assert( false );
						return Color.Empty;
					}
				}
			}
			set
			{
				if ( !DesignMode )
				{
					customColorEditorControl.SelectedColor = value;
					webColorEditorControl.SelectedColor = value;
					browserSafeColorEditorControl.SelectedColor = value;
					systemColorEditorControl.SelectedColor = value;
					schemesColorEditorControl.SelectedColor = value;

					tryToSetCorrectTabPage( value );
				}
			}
		}

		private static readonly ColorLookupElement[] _defaultLookupOrder =
			new[]
			{
				ColorLookupElement.BrowserSafeColors,
				ColorLookupElement.WebColors,
				ColorLookupElement.SystemColors,
				ColorLookupElement.SchemeColors,
				ColorLookupElement.CustomColors
			};

		/// <summary>
		/// Tries to set correct tab page.
		/// </summary>
		private void tryToSetCorrectTabPage(
			Color color )
		{
			TabPage tabPage = null;

			if ( color == Color.Empty )
			{
				color = Color.Transparent;
			}

			// http://bugs.zeta-sw.com/view.php?id=2018
			if ( color == Color.Transparent )
			{
				if ( webColorEditorControl.ContainsColor( color ) )
				{
					tabPage = webColorsTabPage;
				}
			}
			else
			{
				var lookupOrder = new List<ColorLookupElement>( _defaultLookupOrder );

				if ( ExternalColorEditorInformationProvider != null )
				{
					ExternalColorEditorInformationProvider.AdjustColorSettingLookupOrder(
						lookupOrder );

					// Add again to be safe if the call should have removed some.
					lookupOrder.AddRange( _defaultLookupOrder );
				}

				// --

				foreach ( var element in lookupOrder )
				{
					switch ( element )
					{
						case ColorLookupElement.BrowserSafeColors:
							if ( browserSafeColorEditorControl.ContainsColor( color ) )
							{
								tabPage = browserSafeColorsTabPage;
							}
							break;

						default:
							tabPage = customColorsTabPage;
							break;

						case ColorLookupElement.SchemeColors:
							if ( allowColorSchemes &&
								schemesColorEditorControl.ContainsColor( color ) )
							{
								tabPage = schemeColorsTabPage;
							}
							break;

						case ColorLookupElement.SystemColors:
							if ( systemColorEditorControl.ContainsColor( color ) )
							{
								tabPage = systemColorsTabPage;
							}
							break;

						case ColorLookupElement.WebColors:
							if ( webColorEditorControl.ContainsColor( color ) )
							{
								tabPage = webColorsTabPage;
							}
							break;
					}

					if ( tabPage != null )
					{
						break;
					}
				}
			}

			if ( tabPage == null )
			{
				tabPage = customColorsTabPage;
			}


			tabControl.SelectedTab = tabPage;
			_tabSet = true;
		}

		/// <summary>
		/// Gets the store ID.
		/// </summary>
		/// <value>The store ID.</value>
		internal string StoreID
		{
			get
			{
				return string.Format(
					@"{0}.{1}.{2}.{3}",
					((ColorEditorForm)Parent).StoreID,
					GetType().Name,
					Name,
					Text );
			}
		}

		/// <summary>
		/// Gets a value indicating whether [allow color schemes].
		/// </summary>
		/// <value><c>true</c> if [allow color schemes]; otherwise, <c>false</c>.</value>
		private bool allowColorSchemes
		{
			get
			{
				if ( ExternalColorEditorInformationProvider == null )
				{
					return false;
				}
				else
				{
					var colorSchemes =
						ExternalColorEditorInformationProvider.ColorSchemes;

					if ( colorSchemes == null || colorSchemes.Length <= 0 )
					{
						return false;
					}
					else
					{
						return true;
					}
				}
			}
		}

		/// <summary>
		/// Handles the Load event of the <see cref="ColorEditorUserControl"/> control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void colorEditorUserControl_Load(
			object sender,
			EventArgs e )
		{
			if ( ExternalColorEditorInformationProvider != null && !_tabSet )
			{
				tabControl.SelectedIndex = Convert.ToInt32(
					ExternalColorEditorInformationProvider.RestorePerUserPerWorkstationValue(
						StoreID + @".TabControl.SelectedIndex",
						tabControl.SelectedIndex.ToString() ) );
			}

			if ( !allowColorSchemes )
			{
				tabControl.TabPages.Remove( schemeColorsTabPage );
			}
		}

		private void tabControl_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( ExternalColorEditorInformationProvider != null )
			{
				ExternalColorEditorInformationProvider.SavePerUserPerWorkstationValue(
					StoreID + @".TabControl.SelectedIndex",
					tabControl.SelectedIndex.ToString() );
			}

			if ( NeedUpdateUI != null )
			{
				NeedUpdateUI( this, EventArgs.Empty );
			}
		}

		private void customColorEditorControl_NeedUpdateUI( object sender, EventArgs e )
		{
			if ( NeedUpdateUI != null )
			{
				NeedUpdateUI( this, EventArgs.Empty );
			}
		}

		private void systemColorEditorControl_NeedUpdateUI( object sender, EventArgs e )
		{
			// Redirect.
			customColorEditorControl_NeedUpdateUI( null, null );
		}

		private void schemesColorEditorControl_NeedUpdateUI( object sender, EventArgs e )
		{
			// Redirect.
			customColorEditorControl_NeedUpdateUI( null, null );
		}

		private void webColorEditorControl_NeedUpdateUI( object sender, EventArgs e )
		{
			// Redirect.
			customColorEditorControl_NeedUpdateUI( null, null );
		}

		private void browserSafeColorEditorControl_NeedUpdateUI( object sender, EventArgs e )
		{
			// Redirect.
			customColorEditorControl_NeedUpdateUI( null, null );
		}
	}
}