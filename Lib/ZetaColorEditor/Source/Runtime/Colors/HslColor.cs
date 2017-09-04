namespace ZetaColorEditor.Runtime.Colors
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System.Diagnostics;
	using System.Drawing;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Represents a HSL color space.
	/// http://en.wikipedia.org/wiki/HSV_color_space
	/// </summary>
	public sealed class HslColor
	{
		#region Public static methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Creates from a given color.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <returns></returns>
		public static HslColor FromColor( 
			Color color )
		{
			return ColorConverting.RgbToHsl( 
				ColorConverting.ColorToRgb( color ) );
		}

		/// <summary>
		/// Creates from a given color.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <returns></returns>
		public static HslColor FromRgbColor( 
			RgbColor color )
		{
			return color.ToHslColor();
		}

		/// <summary>
		/// Creates from a given color.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <returns></returns>
		public static HslColor FromHslColor( 
			HslColor color )
		{
			return new HslColor( 
				color.PreciseHue, 
				color.PreciseSaturation,
				color.PreciseLight );
		}

		/// <summary>
		/// Creates from a given color.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <returns></returns>
		public static HslColor FromHsbColor( 
			HsbColor color )
		{
			return FromRgbColor( color.ToRgbColor() );
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Initializes a new instance of the <see cref="HslColor"/> class.
		/// </summary>
		/// <param name="hue">The hue. Values from 0 to 360.</param>
		/// <param name="saturation">The saturation. Values from 0 to 100.</param>
		/// <param name="light">The light. Values from 0 to 100.</param>
		public HslColor( 
			double hue, 
			double saturation, 
			double light )
		{
			_hue = hue;
			_saturation = saturation;
			_light = light;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="HslColor"/> class.
		/// </summary>
		/// <param name="hue">The hue. Values from 0 to 360.</param>
		/// <param name="saturation">The saturation. Values from 0 to 100.</param>
		/// <param name="light">The light. Values from 0 to 100.</param>
		public HslColor( 
			int hue, 
			int saturation, 
			int light )
		{
			_hue = hue;
			_saturation = saturation;
			_light = light;
		}

		/// <summary>
		/// Returns a <see cref="T:System.String"/> that represents the current 
		/// <see cref="T:System.Object"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> that represents the current 
		/// <see cref="T:System.Object"/>.
		/// </returns>
		public override string ToString()
		{
			return string.Format(
				@"Hue: {0}; saturation: {1}; light: {2}.",
				Hue,
				Saturation,
				Light );
		}

		/// <summary>
		/// Returns the underlying .NET color.
		/// </summary>
		/// <returns></returns>
		public Color ToColor()
		{
			return ColorConverting.HslToRgb( this ).ToColor();
		}

		/// <summary>
		/// Returns the RGB color.
		/// </summary>
		/// <returns></returns>
		public RgbColor ToRgbColor()
		{
			return ColorConverting.HslToRgb( this );
		}

		/// <summary>
		/// Returns the HSL color.
		/// </summary>
		/// <returns></returns>
		public HslColor ToHslColor()
		{
			return this;
		}

		/// <summary>
		/// Returns the HSB color.
		/// </summary>
		/// <returns></returns>
		public HsbColor ToHsbColor()
		{
			return ColorConverting.RgbToHsb( ToRgbColor() );
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is 
		/// equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">The <see cref="T:System.Object"/> to compare with 
		/// the current <see cref="T:System.Object"/>.</param>
		/// <returns>
		/// true if the specified <see cref="T:System.Object"/> is equal to the 
		/// current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		/// <exception cref="T:System.NullReferenceException">The 
		/// <paramref name="obj"/> parameter is null.</exception>
		public override bool Equals( 
			object obj )
		{
			var equal = false;

			if ( obj is HslColor )
			{
				var hsb = (HslColor)obj;

				if ( Hue == hsb.PreciseHue && Saturation == hsb.PreciseSaturation &&
					Light == hsb.PreciseLight )
				{
					equal = true;
				}
			}

			return equal;
		}

		/// <summary>
		/// Serves as a hash function for a particular type.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			Debug.Assert( 1 == 1 );
			return base.GetHashCode();
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// Gets or sets the hue. Values from 0 to 360.
		/// </summary>
		/// <value>The hue.</value>
		public int Hue
		{
			get
			{
				return (int)_hue;
			}
			set
			{
				_hue = value;
			}
		}

		/// <summary>
		/// Gets or sets the precise hue. Values from 0 to 360.
		/// </summary>
		/// <value>The precise hue.</value>
		public double PreciseHue
		{
			get
			{
				return _hue;
			}
			set
			{
				_hue = value;
			}
		}

		/// <summary>
		/// Gets or sets the saturation. Values from 0 to 100.
		/// </summary>
		/// <value>The saturation.</value>
		public int Saturation
		{
			get
			{
				return (int)_saturation;
			}
			set
			{
				_saturation = value;
			}
		}

		/// <summary>
		/// Gets or sets the precise saturation. Values from 0 to 100.
		/// </summary>
		/// <value>The precise saturation.</value>
		public double PreciseSaturation
		{
			get
			{
				return _saturation;
			}
			set
			{
				_saturation = value;
			}
		}

		/// <summary>
		/// Gets or sets the light. Values from 0 to 100.
		/// </summary>
		/// <value>The light.</value>
		public int Light
		{
			get
			{
				return (int)_light;
			}
			set
			{
				_light = value;
			}
		}

		/// <summary>
		/// Gets or sets the precise light. Values from 0 to 100.
		/// </summary>
		/// <value>The precise light.</value>
		public double PreciseLight
		{
			get
			{
				return _light;
			}
			set
			{
				_light = value;
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private variables.
		// ------------------------------------------------------------------

		private double _hue;
		private double _saturation;
		private double _light;

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}