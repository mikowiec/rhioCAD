namespace ZetaColorEditor.Runtime.InternalControls.CustomColors
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Drawing;
	using System.Windows.Forms;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// 
	/// </summary>
	public partial class ColorSliderUserControl :
		UserControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ColorSliderUserControl"/> class.
		/// </summary>
		public ColorSliderUserControl()
		{
			InitializeComponent();

			SetStyle(
				ControlStyles.Selectable,
				true );
		}

		/// <summary>
		/// Occurs when the user changed the light.
		/// </summary>
		public event EventHandler LightChanged;

		/// <summary>
		/// Occurs when a value has been changed.
		/// </summary>
		public event EventHandler ValueChangedByUser;

		private void notifyLightChanged()
		{
			if ( LightChanged != null )
			{
				LightChanged( this, EventArgs.Empty );
			}
		}

		/// <summary>
		/// Notifies the value changed.
		/// </summary>
		private void notifyValueChangedByUser()
		{
			if ( ValueChangedByUser != null )
			{
				ValueChangedByUser( this, EventArgs.Empty );
			}
		}

		/// <summary>
		/// Gets the color.
		/// </summary>
		/// <returns></returns>
		public Color GetSelectedColor()
		{
			return colorPanel.GetColorAtY( arrowControl.Location.Y );
		}

		/// <summary>
		/// Sets the hue saturation.
		/// </summary>
		/// <param name="h">The h.</param>
		/// <param name="s">The s.</param>
		public void SetHueSaturation( double h, double s )
		{
			colorPanel.SetHueSaturation( h, s );

			notifyLightChanged();
		}

		public void SetLight( double l )
		{
			colorPanel.SetLight( l );

			int caretPositionY;
			colorPanel.TranslateLightToCaretPositionY( out caretPositionY, l );

			repositionArrow( caretPositionY );
			notifyLightChanged();
		}

		/// <summary>
		/// Repositions the arrow.
		/// </summary>
		/// <param name="offsetY">The offset Y.</param>
		private void repositionArrow( int offsetY )
		{
			offsetY = Math.Max( 0, offsetY );
			offsetY = Math.Min( ClientSize.Height - 1, offsetY );

			arrowControl.Location = new Point(
				arrowControl.Location.X,
				offsetY - (arrowControl.Height / 2) );

			double l;
			colorPanel.TranslateCaretPositionYToLight( offsetY, out l );

			colorPanel.SetLight( l );
		}

		private void colorSliderUserControl_MouseClick( object sender, MouseEventArgs e )
		{
			repositionArrow( e.Location.Y );
			notifyValueChangedByUser();
		}

		private void arrowControl_MouseClick( object sender, MouseEventArgs e )
		{
			repositionArrow( PointToClient( arrowControl.PointToScreen( e.Location ) ).Y );
			notifyValueChangedByUser();
		}

		private void colorPanel_MouseClick( object sender, MouseEventArgs e )
		{
			repositionArrow( PointToClient( colorPanel.PointToScreen( e.Location ) ).Y );
			notifyValueChangedByUser();
		}

		private void colorSliderUserControl_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				repositionArrow( e.Location.Y );
				notifyValueChangedByUser();
			}
		}

		private void arrowControl_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				repositionArrow( PointToClient( arrowControl.PointToScreen( e.Location ) ).Y );
				notifyValueChangedByUser();
			}
		}

		private void colorPanel_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				repositionArrow( PointToClient( colorPanel.PointToScreen( e.Location ) ).Y );
				notifyValueChangedByUser();
			}
		}

		private void colorSliderUserControl_MouseDown( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				repositionArrow( e.Location.Y );
				notifyValueChangedByUser();
			}
		}

		private void colorPanel_MouseDown( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				repositionArrow( PointToClient( colorPanel.PointToScreen( e.Location ) ).Y );
				notifyValueChangedByUser();
			}
		}

		private void arrowControl_MouseDown( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				repositionArrow( PointToClient( arrowControl.PointToScreen( e.Location ) ).Y );
				notifyValueChangedByUser();
			}
		}

		private void colorPanel_ValueChangedByUser( object sender, EventArgs e )
		{
			notifyValueChangedByUser();
		}
	}

	/////////////////////////////////////////////////////////////////////////
}