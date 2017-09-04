namespace ZetaColorEditor.Runtime
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.ComponentModel;
	using System.Drawing;
	using System.Windows.Forms;

	// ----------------------------------------------------------------------
	#endregion

	/// <summary>
	/// 
	/// </summary>
	public partial class ColorEditorForm :
		Form
	{
		private Color _selectedColor;

#if DEBUG
		public static void Test()
		{
			Color c1 = Color.OrangeRed;
			Color c2 = Color.GreenYellow;
			Color c3 = ColorTranslator.FromHtml( @"#0066CC" );
			Color c4 = ColorTranslator.FromHtml( @"#FF0000" );

			RgbColor color01 = new RgbColor( 255, 0, 0 );
			RgbColor color02 = new RgbColor( 0, 255, 0 );
			RgbColor color03 = new RgbColor( 0, 0, 255 );

			RgbColor color04 = new RgbColor( 255, 255, 0 );
			RgbColor color05 = new RgbColor( 255, 0, 255 );
			RgbColor color06 = new RgbColor( 0, 255, 255 );

			RgbColor color07 = new RgbColor( 0, 0, 0 );
			RgbColor color08 = new RgbColor( 255, 255, 255 );

			// --

			//HsbColor hsb01 = HsbColor.FromColor( color01 );
			//HsbColor hsb02 = new HsbColor( 
				//(int)color01.GetHue(), 
				//(int)(color01.GetSaturation()*100), 
				//(int)(color01.GetBrightness()*100) );

			HslColor hsl02 = HslColor.FromRgbColor( color02 );
			HsbColor hsb01 = HsbColor.FromRgbColor( color01 );

			//HslColor hsl02 = new HslColor( 
			//    (int)color01.GetHue(), 
			//    (int)(color01.GetSaturation() * 100), 
			//    (int)(color01.GetBrightness() * 100) );

			RgbColor r = hsl02.ToRgbColor();

			RgbColor o1 = new RgbColor( 115, 72, 50 );
			HslColor o2 = o1.ToHslColor();
			RgbColor o3 = o2.ToRgbColor();

			// --

			int i = 0;
		}
#endif

		/// <summary>
		/// Initializes a new instance of the <see cref="ColorEditorForm"/> class.
		/// </summary>
		public ColorEditorForm()
		{
			InitializeComponent();
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
				return _selectedColor;
			}
			set
			{
				_selectedColor = value;
				if ( !DesignMode )
				{
					colorEditorControl.SelectedColor = value;
				}
			}
		}

		/// <summary>
		/// Gets or sets the external provider.
		/// </summary>
		/// <value>The external provider.</value>
		[Browsable( false )]
		public IExternalColorEditorInformationProvider ExternalColorEditorInformationProvider
		{
			get
			{
				return colorEditorControl.ExternalColorEditorInformationProvider;
			}
			set
			{
				colorEditorControl.ExternalColorEditorInformationProvider = value;
			}
		}

		private void buttonOK_Click( object sender, EventArgs e )
		{
			_selectedColor = colorEditorControl.SelectedColor;
		}

		private void buttonNoColor_Click( object sender, EventArgs e )
		{
			_selectedColor = Color.Empty;
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
					@"{0}.{1}.{2}",
					GetType().Name,
					Name,
					Text );
			}
		}

		/// <summary>
		/// Handles the Load event of the <see cref="ColorEditorForm"/> control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance 
		/// containing the event data.</param>
		private void colorEditorForm_Load( object sender, EventArgs e )
		{
			if ( ExternalColorEditorInformationProvider != null )
			{
				Width = Convert.ToInt32(
					ExternalColorEditorInformationProvider.RestorePerUserPerWorkstationValue(
						StoreID + @".Width",
						Width.ToString() ) );
				Height = Convert.ToInt32(
					ExternalColorEditorInformationProvider.RestorePerUserPerWorkstationValue(
						StoreID + @".Height",
						Height.ToString() ) );
			}
			CenterToParent();

			buttonNoColor.Visible =
				ExternalColorEditorInformationProvider == null ||
				ExternalColorEditorInformationProvider.AllowNoColorSelectable;
		}

		/// <summary>
		/// Handles the FormClosing event of the <see cref="ColorEditorForm"/> control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> 
		/// instance containing the event data.</param>
		private void colorEditorForm_FormClosing(
			object sender,
			FormClosingEventArgs e )
		{
			if ( ExternalColorEditorInformationProvider != null )
			{
				ExternalColorEditorInformationProvider.SavePerUserPerWorkstationValue(
					StoreID + @".Width",
					Width.ToString() );
				ExternalColorEditorInformationProvider.SavePerUserPerWorkstationValue(
					StoreID + @".Height",
					Height.ToString() );
			}
		}

		private void colorEditorUserControl1_NeedUpdateUI( 
			object sender, 
			EventArgs e )
		{
			updateUI();
		}

		/// <summary>
		/// Updates the UI.
		/// </summary>
		private void updateUI()
		{
			buttonOK.Enabled =
				colorEditorControl.SelectedColor != Color.Empty;
		}
	}
}