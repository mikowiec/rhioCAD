namespace ZetaColorEditor.Runtime.InternalControls.CustomColors
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Drawing;
	using System.Drawing.Drawing2D;
	using System.Windows.Forms;
	using Colors;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// 
	/// </summary>
	public partial class ColorAreaUserControl :
		UserControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ColorAreaUserControl"/> 
		/// class.
		/// </summary>
		public ColorAreaUserControl()
		{
			InitializeComponent();

			SetStyle(
				ControlStyles.UserPaint |
					ControlStyles.DoubleBuffer |
						ControlStyles.Selectable |
							ControlStyles.AllPaintingInWmPaint,
				true );
		}

		private double _h;
		private double _s;
		private Bitmap _colorBitmap;

		public void SetHueSaturation( double h, double s )
		{
			_h = h;
			_s = s;

			// --

			Invalidate();

			notifyHueSaturationChanged();
		}

		public void GetHueSaturation( out double h, out double s )
		{
			h = _h;
			s = _s;
		}

		private void translateCaretPositionToHueSaturation(
			Point caretPosition,
			out double h,
			out double s )
		{
			double facXBmpToScreen = 360.0 / ClientSize.Width;
			double facYBmpToScreen = 100.0 / ClientSize.Height;

			Point p = caretPosition;

			p.X = Math.Max( 0, p.X );
			p.X = Math.Min( ClientSize.Width - 1, p.X );
			p.Y = Math.Max( 0, p.Y );
			p.Y = Math.Min( ClientSize.Height - 1, p.Y );

			p.Y = ClientSize.Height - p.Y;

			h = (p.X * facXBmpToScreen);
			s = (p.Y * facYBmpToScreen);

			h = Math.Max( 0.0, h );
			h = Math.Min( 360.0, h );
			s = Math.Max( 0.0, s );
			s = Math.Min( 100.0, s );
		}

		private void translateHueSaturationToCaretPosition(
			out Point caretPosition,
			double h,
			double s )
		{
			double facXBmpToScreen = 360.0 / ClientSize.Width;
			double facYBmpToScreen = 100.0 / ClientSize.Height;

			h = Math.Max( 0.0, h );
			h = Math.Min( 360.0, h );
			s = Math.Max( 0.0, s );
			s = Math.Min( 100.0, s );

			double pX = (h / facXBmpToScreen);
			double pY = (s / facYBmpToScreen);

			pX = Math.Max( 0, pX );
			pX = Math.Min( ClientSize.Width - 1, pX );
			pY = Math.Max( 0, pY );
			pY = Math.Min( ClientSize.Height - 1, pY );

			pY = ClientSize.Height - pY;

			caretPosition = new Point( (int)pX, (int)pY );
		}

		/// <summary>
		/// Handles the Paint event of the <see cref="ColorAreaUserControl"/> control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> 
		/// instance containing the event data.</param>
		private void colorAreaUserControl_Paint(
			object sender,
			PaintEventArgs e )
		{
			if ( _colorBitmap == null )
			{
				_colorBitmap = drawColorBitmap();
			}

			double facXBmpToScreen = (double)_colorBitmap.Width / ClientSize.Width;
			double facYBmpToScreen = (double)_colorBitmap.Height / ClientSize.Height;

			Rectangle destinationRect =
				e.ClipRectangle;

			var sourceRect = new Rectangle(
				(int)(facXBmpToScreen * destinationRect.Left),
				(int)(facYBmpToScreen * destinationRect.Top),
				(int)(facXBmpToScreen * destinationRect.Width),
				(int)(facYBmpToScreen * destinationRect.Height) );

			e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

			e.Graphics.DrawImage(
				_colorBitmap,
				destinationRect,
				sourceRect,
				GraphicsUnit.Pixel );

			drawCaret( e.Graphics );
		}

		private readonly Brush _blackBrush = new SolidBrush( Color.Black );
		private readonly Brush _whiteBrush = new SolidBrush( Color.White );

		/// <summary>
		/// Draws the caret.
		/// </summary>
		private void drawCaret()
		{
			Invalidate();
		}

		/// <summary>
		/// Draws the caret.
		/// </summary>
		/// <param name="g">The g.</param>
		private void drawCaret(
			Graphics g )
		{
			Brush b1, b2;

			if ( Focused )
			{
				b1 = _blackBrush;
				b2 = _whiteBrush;
			}
			else
			{
				b1 = _whiteBrush;
				b2 = _blackBrush;
			}

			// --

			Point p;
			translateHueSaturationToCaretPosition( out p, _h, _s );

			int x = p.X;
			int y = p.Y;

			// --
			// Outer.

			g.FillRectangle( b2,
				x - 2,
				y - 11,
				5,
				8 );

			g.FillRectangle( b2,
				x - 2,
				y + 3 + 1,
				5,
				8 );

			g.FillRectangle( b2,
				x - 11,
				y - 2,
				8,
				5 );

			g.FillRectangle( b2,
				x + 3 + 1,
				y - 2,
				8,
				5 );

			// --
			// Inner.

			g.FillRectangle( b1,
				x - 1,
				y - 10,
				3,
				6 );

			g.FillRectangle( b1,
				x - 1,
				y + 4 + 1,
				3,
				6 );

			g.FillRectangle( b1,
				x - 10,
				y - 1,
				6,
				3 );

			g.FillRectangle( b1,
				x + 4 + 1,
				y - 1,
				6,
				3 );
		}

		/// <summary>
		/// Draws the color bitmap.
		/// </summary>
		/// <returns></returns>
		private static Bitmap drawColorBitmap()
		{
			const int width = 360 + 1;
			const int height = 100 + 1;

			var bmp = new Bitmap( width, height );

			for ( int y = 0; y < height; ++y )
			{
				for ( int x = 0; x < width; ++x )
				{
					double h = x;
					double s = 100 - y;
					double l = 100 - y;

					Color color = new HslColor( h, s, l ).ToColor();

					bmp.SetPixel( x, y, color );
				}
			}

			return bmp;
		}

		/// <summary>
		/// Occurs when the user changed the hue and/or saturation.
		/// </summary>
		public event EventHandler HueSaturationChanged;

		/// <summary>
		/// Occurs when a value has been changed.
		/// </summary>
		public event EventHandler ValueChangedByUser;

		private void notifyHueSaturationChanged()
		{
			if ( HueSaturationChanged != null )
			{
				HueSaturationChanged( this, EventArgs.Empty );
			}
		}

		private void notifyValueChangedByUser()
		{
			if ( ValueChangedByUser != null )
			{
				ValueChangedByUser( this, EventArgs.Empty );
			}
		}

		private void colorAreaUserControl_Enter( object sender, EventArgs e )
		{
			drawCaret();
		}

		private void colorAreaUserControl_Leave( object sender, EventArgs e )
		{
			drawCaret();
		}

		private void colorAreaUserControl_MouseClick( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				translateCaretPositionToHueSaturation( e.Location, out _h, out _s );
				drawCaret();

				notifyValueChangedByUser();
				notifyHueSaturationChanged();
			}
		}

		private void colorAreaUserControl_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				translateCaretPositionToHueSaturation( e.Location, out _h, out _s );
				drawCaret();

				notifyValueChangedByUser();
				notifyHueSaturationChanged();
			}
		}

		private void colorAreaUserControl_MouseDown( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				translateCaretPositionToHueSaturation( e.Location, out _h, out _s );
				drawCaret();

				notifyValueChangedByUser();
				notifyHueSaturationChanged();
			}
		}
	}

	/////////////////////////////////////////////////////////////////////////
}