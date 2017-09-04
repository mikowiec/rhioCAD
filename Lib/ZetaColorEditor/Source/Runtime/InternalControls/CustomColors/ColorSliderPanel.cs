namespace ZetaColorEditor.Runtime.InternalControls.CustomColors
{
	using System;
	using System.Drawing;
	using System.Drawing.Drawing2D;
	using System.Windows.Forms;
	using Colors;

	public partial class ColorSliderPanel : Panel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ColorSliderPanel"/> class.
		/// </summary>
		public ColorSliderPanel()
		{
			InitializeComponent();

			SetStyle(
				ControlStyles.UserPaint |
					ControlStyles.DoubleBuffer |
						ControlStyles.Selectable |
							ControlStyles.AllPaintingInWmPaint,
				true );
		}

		public void SetHueSaturation( double h, double s )
		{
			_h = h;
			_s = s;

			_colorBitmap = drawColorBitmap();
			Invalidate();

			notifyValueChanged();
		}

		/// <summary>
		/// Occurs when a value has been changed.
		/// </summary>
		public event EventHandler ValueChangedByUser;

		/// <summary>
		/// Occurs when a value has been changed.
		/// </summary>
		public event EventHandler ValueChanged;

		//private void NotifyValueChangedByUser()
		//{
		//    if ( ValueChangedByUser != null )
		//    {
		//        ValueChangedByUser( this, EventArgs.Empty );
		//    }
		//}

		private void notifyValueChanged()
		{
			if ( ValueChanged != null )
			{
				ValueChanged( this, EventArgs.Empty );
			}
		}

		/// <summary>
		/// Draws the color bitmap.
		/// </summary>
		/// <returns></returns>
		private Bitmap drawColorBitmap()
		{
			const int width = 5;
			const int height = 100;

			double h = _h;
			double s = _s;

			var bmp = new Bitmap( width, height );

			for ( int y = 0; y < height; ++y )
			{
				double l = height - y;

				Color color = new HslColor( h, s, l ).ToColor();

				for ( int x = 0; x < width; ++x )
				{
					bmp.SetPixel( x, y, color );
				}
			}

			return bmp;
		}

		private Bitmap _colorBitmap;
		private double _h;
		private double _s;
		private double _l;

		private void colorSliderPanel_Paint( object sender, PaintEventArgs e )
		{
			if ( _colorBitmap == null )
			{
				_colorBitmap = drawColorBitmap();
			}

			var facYBmpToScreen = (double)_colorBitmap.Height / ClientSize.Height;

			var destinationRect =
				e.ClipRectangle;

			var sourceRect = new Rectangle(
				0,
				(int)(facYBmpToScreen * destinationRect.Top),
				1,
				(int)(facYBmpToScreen * destinationRect.Height) );

			e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

			e.Graphics.DrawImage(
				_colorBitmap,
				destinationRect,
				sourceRect,
				GraphicsUnit.Pixel );
		}

		/// <summary>
		/// Gets the color at Y.
		/// </summary>
		/// <param name="y">The y.</param>
		/// <returns></returns>
		public Color GetColorAtY(
			int y )
		{
			return new HslColor( _h, _s, _l ).ToColor();

			//if ( _colorBitmap == null )
			//{
			//    _colorBitmap = drawColorBitmap();
			//}

			//int height = ClientSize.Height;

			//y = Math.Max( 0, y );
			//y = Math.Min( height - 1, y );

			//double facYBmpToScreen = (double)_colorBitmap.Height / height;

			//return _colorBitmap.GetPixel(
			//    0,
			//    (int)(y * facYBmpToScreen) );
		}

		internal void TranslateCaretPositionYToLight(
			int caretPositionY,
			out double l )
		{
			double facYBmpToScreen = 100.0 / ClientSize.Height;

			double pY = caretPositionY;

			pY = Math.Max( 0, pY );
			pY = Math.Min( ClientSize.Height - 1, pY );

			pY = ClientSize.Height - pY;

			l = pY * facYBmpToScreen;

			l = Math.Max( 0.0, l );
			l = Math.Min( 100.0, l );
		}

		internal void TranslateLightToCaretPositionY(
			out int caretPositionY,
			double l )
		{
			double facYBmpToScreen = 100.0 / ClientSize.Height;

			l = Math.Max( 0, l );
			l = Math.Min( 100, l );

			double pY = (l / facYBmpToScreen);

			pY = Math.Max( 0.0, pY );
			pY = Math.Min( ClientSize.Height - 1, pY );

			pY = ClientSize.Height - pY;

			caretPositionY = toParentPositionY( (int)pY );
		}

		private int toParentPositionY( int y )
		{
			var p = new Point( 0, y );
			p = PointToScreen( p );

			return Parent.PointToClient( p ).Y;
		}

		public void SetLight( double l )
		{
			_l = l;
			notifyValueChanged();
		}

		public double GetLight()
		{
			return _l;
		}
	}
}