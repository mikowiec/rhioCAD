namespace ZetaColorEditor.Runtime.InternalControls
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.ComponentModel;
	using System.Drawing;
	using System.Windows.Forms;
	using Colors;

	// ----------------------------------------------------------------------
	#endregion

	public partial class CustomColorEditorUserControl :
		UserControl
	{
		/// <summary>
		/// To get rid of rounding inaccuracies etc.
		/// </summary>
		private enum LeadingInputElement
		{
			Unknown,
			ColorAreaAndSlider,
			RgbInput,
			HslInput,
			HtmlInput
		}

		private bool _ignoreTextFieldChange;
		private bool _ignoreColorChangeEvents;

		private Control _changingControl;

		private LeadingInputElement _currentLeadingInputElement =
			LeadingInputElement.Unknown;

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomColorEditorUserControl"/> class.
		/// </summary>
		public CustomColorEditorUserControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Load event of the <see cref="CustomColorEditorUserControl"/> control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance 
		/// containing the event data.</param>
		private void customColorEditorUserControl_Load(
			object sender,
			EventArgs e )
		{
		}

		/// <summary>
		/// Handles the ColorChanged event of the colorSliderControl control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance 
		/// containing the event data.</param>
		private void colorControl_ColorChanged(
			object sender,
			EventArgs e )
		{
			if ( !_ignoreColorChangeEvents )
			{
				updateTextFields();

				if ( NeedUpdateUI != null )
				{
					NeedUpdateUI( this, EventArgs.Empty );
				}
			}
		}

		/// <summary>
		/// Occurs when the parent needs to update command states.
		/// </summary>
		public event EventHandler NeedUpdateUI;

		/// <summary>
		/// Updates the text fields.
		/// </summary>
		private void updateTextFields()
		{
			_ignoreTextFieldChange = true;
			try
			{
				currentColorPanel.BackColor = colorControl.SelectedColor;

				var color = colorControl.SelectedColor;
				var hslColor = HslColor.FromColor( color );

				if ( _currentLeadingInputElement != LeadingInputElement.HtmlInput )
				{
					if ( _changingControl != htmlTextBox )
					{
						htmlTextBox.Text = toHtml( color );
					}
				}

				if ( _currentLeadingInputElement != LeadingInputElement.RgbInput )
				{
					if ( _changingControl != rControl )
					{
						rControl.Value = color.R;
					}
					if ( _changingControl != gControl )
					{
						gControl.Value = color.G;
					}
					if ( _changingControl != bControl )
					{
						bControl.Value = color.B;
					}
				}

				if ( _currentLeadingInputElement != LeadingInputElement.HslInput )
				{
					if ( _changingControl != hControl )
					{
						hControl.Value = (decimal)hslColor.PreciseHue;
					}
					if ( _changingControl != sControl )
					{
						sControl.Value = (decimal)hslColor.PreciseSaturation;
					}
					if ( _changingControl != lControl )
					{
						lControl.Value = (decimal)hslColor.PreciseLight;
					}
				}
			}
			finally
			{
				_ignoreTextFieldChange = false;
			}
		}

		private static string toHtml( Color color )
		{
			return string.Format(
				@"#{0:X2}{1:X2}{2:X2}",
				color.R,
				color.G,
				color.B );
		}

		private void setColor( HslColor color )
		{
			setColor( color.ToRgbColor() );
		}

		private void setColor( RgbColor color )
		{
			Color c = color.ToColor();
			colorControl.SelectedColor = c;

			if ( NeedUpdateUI != null )
			{
				NeedUpdateUI( this, EventArgs.Empty );
			}
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
					switch ( _currentLeadingInputElement )
					{
						case LeadingInputElement.HtmlInput:
							{
								string html = htmlTextBox.Text.Trim( '#', ' ' );

								if ( html.Length == 6 )
								{
									return RgbColor.FromColor( ColorTranslator.FromHtml(
										@"#" + html ) ).ToColor();
								}
								else
								{
									// Fallback.
									return colorControl.SelectedColor;
								}
							}

						case LeadingInputElement.ColorAreaAndSlider:
							{
								return colorControl.SelectedColor;
							}

						case LeadingInputElement.HslInput:
							{
								return new HslColor(
									(double)hControl.Value,
									(double)sControl.Value,
									(double)lControl.Value ).ToColor();
							}

						default:
							{
								return new RgbColor(
									(int)rControl.Value,
									(int)gControl.Value,
									(int)bControl.Value ).ToColor();
							}
					}
				}
			}
			set
			{
				if ( !DesignMode )
				{
					_ignoreTextFieldChange = true;
					_ignoreColorChangeEvents = true;
					try
					{
						HslColor hslColor = HslColor.FromColor( value );

						rControl.Value = value.R;
						gControl.Value = value.G;
						bControl.Value = value.B;

						hControl.Value = (decimal)hslColor.PreciseHue;
						sControl.Value = (decimal)hslColor.PreciseSaturation;
						lControl.Value = (decimal)hslColor.PreciseLight;

						htmlTextBox.Text = toHtml( value );
						currentColorPanel.BackColor = value;

						setColor( RgbColor.FromColor( value ) );
					}
					finally
					{
						_ignoreColorChangeEvents = false;
						_ignoreTextFieldChange = false;
					}

					if ( NeedUpdateUI != null )
					{
						NeedUpdateUI( this, EventArgs.Empty );
					}

					//	setColor( RgbColor.FromColor( value ) );
				}
			}
		}

		private void rControl_ValueChanged( object sender, EventArgs e )
		{
			if ( !_ignoreTextFieldChange )
			{
				if ( rControl.Value >= 0 && rControl.Value <= 255 )
				{
					_changingControl = (Control)sender;
					notifyValueChangedByUser( LeadingInputElement.RgbInput );

					setColor(
						new RgbColor(
							(int)rControl.Value,
							(int)gControl.Value,
							(int)bControl.Value ) );
					_changingControl = null;
				}
			}
		}

		private void gControl_ValueChanged( object sender, EventArgs e )
		{
			if ( !_ignoreTextFieldChange )
			{
				if ( gControl.Value >= 0 && gControl.Value <= 255 )
				{
					_changingControl = (Control)sender;
					notifyValueChangedByUser( LeadingInputElement.RgbInput );

					setColor(
						new RgbColor(
							(int)rControl.Value,
							(int)gControl.Value,
							(int)bControl.Value ) );
					_changingControl = null;
				}
			}
		}

		private void bControl_ValueChanged( object sender, EventArgs e )
		{
			if ( !_ignoreTextFieldChange )
			{
				if ( bControl.Value >= 0 && bControl.Value <= 255 )
				{
					_changingControl = (Control)sender;
					notifyValueChangedByUser( LeadingInputElement.RgbInput );

					setColor(
						new RgbColor(
							(int)rControl.Value,
							(int)gControl.Value,
							(int)bControl.Value ) );
					_changingControl = null;
				}
			}
		}

		private void hControl_ValueChanged( object sender, EventArgs e )
		{
			if ( !_ignoreTextFieldChange )
			{
				if ( hControl.Value >= 0 && hControl.Value <= 360 )
				{
					_changingControl = (Control)sender;
					notifyValueChangedByUser( LeadingInputElement.HslInput );

					setColor(
						new HslColor(
							(double)hControl.Value,
							(double)sControl.Value,
							(double)lControl.Value ) );
					_changingControl = null;
				}
			}
		}

		private void sControl_ValueChanged( object sender, EventArgs e )
		{
			if ( !_ignoreTextFieldChange )
			{
				if ( sControl.Value >= 0 && sControl.Value <= 100 )
				{
					_changingControl = (Control)sender;
					notifyValueChangedByUser( LeadingInputElement.HslInput );

					setColor(
						new HslColor(
							(double)hControl.Value,
							(double)sControl.Value,
							(double)lControl.Value ) );
					_changingControl = null;
				}
			}
		}

		private void lControl_ValueChanged( object sender, EventArgs e )
		{
			if ( !_ignoreTextFieldChange )
			{
				if ( lControl.Value >= 0 && lControl.Value <= 100 )
				{
					_changingControl = (Control)sender;
					notifyValueChangedByUser( LeadingInputElement.HslInput );

					setColor(
						new HslColor(
							(double)hControl.Value,
							(double)sControl.Value,
							(double)lControl.Value ) );
					_changingControl = null;
				}
			}
		}

		private void htmlTextBox_TextChanged( object sender, EventArgs e )
		{
			if ( !_ignoreTextFieldChange )
			{
				string html = htmlTextBox.Text.Trim( '#', ' ' );

				if ( html.Length == 6 )
				{
					_changingControl = (Control)sender;
					notifyValueChangedByUser( LeadingInputElement.HtmlInput );

					setColor( RgbColor.FromColor( ColorTranslator.FromHtml(
						@"#" + html ) ) );
					_changingControl = null;
				}
			}
		}

		private void colorControl_ValueChangedByUser(
			object sender,
			EventArgs e )
		{
			notifyValueChangedByUser(
				LeadingInputElement.ColorAreaAndSlider );
		}

		/// <summary>
		/// Notifies that the value has been changed by the user.
		/// </summary>
		/// <param name="inputElement">The input element.</param>
		private void notifyValueChangedByUser(
			LeadingInputElement inputElement )
		{
			_currentLeadingInputElement = inputElement;
		}
	}
}