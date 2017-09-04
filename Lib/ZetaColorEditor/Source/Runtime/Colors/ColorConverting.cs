namespace ZetaColorEditor.Runtime.Colors
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Drawing;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Provides color conversion functionality.
	/// </summary>
	/// <remarks>
	/// http://en.wikipedia.org/wiki/HSV_color_space
	/// http://www.easyrgb.com/math.php?MATH=M19#text19
	/// </remarks>
	internal static class ColorConverting
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Converts a Color to <see cref="RgbColor"/>.
		/// </summary>
		/// <param name="color">A Color object representing the color that is
		/// to be converted to <see cref="RgbColor"/>.</param>
		/// <returns>A <see cref="RgbColor"/> equivalent.</returns>
		public static RgbColor ColorToRgb( 
			Color color )
		{
			return new RgbColor( color.R, color.G, color.B );
		}

		/// <summary>
		/// Converts a <see cref="RgbColor"/> color structure to a Color object.
		/// </summary>
		/// <param name="rgb">A <see cref="RgbColor"/> object representing the color that is to be
		/// converted.</param>
		/// <returns>A Color equivalent.</returns>
		public static Color RgbToColor( 
			RgbColor rgb )
		{
			return Color.FromArgb( rgb.Red, rgb.Green, rgb.Blue );
		}

		/// <summary>
		/// Converts <see cref="RgbColor"/> to <see cref="HsbColor"/>.
		/// </summary>
		/// <param name="rgb">A <see cref="RgbColor"/> object containing the <see cref="RgbColor"/> values that are to
		/// be converted to <see cref="HsbColor"/> values.</param>
		/// <returns>A <see cref="HsbColor"/> equivalent.</returns>
		public static HsbColor RgbToHsb(
			RgbColor rgb )
		{
			// _NOTE #1: Even though we're dealing with a very small range of
			// numbers, the accuracy of all calculations is fairly important.
			// For this reason, I've opted to use double data types instead
			// of float, which gives us a little bit extra precision (recall
			// that precision is the number of significant digits with which
			// the result is expressed).

			double r = rgb.Red / 255d;
			double g = rgb.Green / 255d;
			double b = rgb.Blue / 255d;

			double minValue = getMinimumValue( r, g, b );
			double maxValue = getMaximumValue( r, g, b );
			double delta = maxValue - minValue;

			double hue = 0;
			double saturation;
			double brightness = maxValue * 100;

			if ( maxValue == 0 || delta == 0 )
			{
				hue = 0;
				saturation = 0;
			}
			else
			{
				// _NOTE #2: FXCop insists that we avoid testing for floating 
				// point equality (CA1902). Instead, we'll perform a series of
				// tests with the help of Double.Epsilon that will provide 
				// a more accurate equality evaluation.

				if ( minValue == 0 )
				{
					saturation = 100;
				}
				else
				{
					saturation = (delta / maxValue) * 100;
				}

				if ( Math.Abs( r - maxValue ) < Double.Epsilon )
				{
					hue = (g - b) / delta;
				}
				else if ( Math.Abs( g - maxValue ) < Double.Epsilon )
				{
					hue = 2 + (b - r) / delta;
				}
				else if ( Math.Abs( b - maxValue ) < Double.Epsilon )
				{
					hue = 4 + (r - g) / delta;
				}
			}

			hue *= 60;
			if ( hue < 0 )
			{
				hue += 360;
			}

			return new HsbColor(
				(int)Math.Round( hue ),
				(int)Math.Round( saturation ),
				(int)Math.Round( brightness ) );
		}

		/// <summary>
		/// RGB to HSL.
		/// </summary>
		/// <param name="rgb">The RGB.</param>
		/// <returns></returns>
		public static HslColor RgbToHsl(
			RgbColor rgb )
		{
			double varR = (rgb.Red / 255.0); //Where RGB values = 0 ÷ 255
			double varG = (rgb.Green / 255.0);
			double varB = (rgb.Blue / 255.0);

			double varMin = getMinimumValue( varR, varG, varB ); //Min. value of RGB
			double varMax = getMaximumValue( varR, varG, varB ); //Max. value of RGB
			double delMax = varMax - varMin; //Delta RGB value

			double h;
			double s;
			double l = (varMax + varMin) / 2;

			if ( delMax == 0 ) //This is a gray, no chroma...
			{
				h = 0; //HSL results = 0 ÷ 1
				//s = 0;
				// UK:
				s = 1.0;
			}
			else //Chromatic data...
			{
				if ( l < 0.5 )
				{
					s = delMax / (varMax + varMin);
				}
				else
				{
					s = delMax / (2.0 - varMax - varMin);
				}

				double delR = (((varMax - varR) / 6.0) + (delMax / 2.0)) / delMax;
				double delG = (((varMax - varG) / 6.0) + (delMax / 2.0)) / delMax;
				double delB = (((varMax - varB) / 6.0) + (delMax / 2.0)) / delMax;

				if ( varR == varMax )
				{
					h = delB - delG;
				}
				else if ( varG == varMax )
				{
					h = (1.0 / 3.0) + delR - delB;
				}
				else if ( varB == varMax )
				{
					h = (2.0 / 3.0) + delG - delR;
				}
				else
				{
					// Uwe Keim.
					h = 0.0;
				}

				if ( h < 0.0 )
				{
					h += 1.0;
				}
				if ( h > 1.0 )
				{
					h -= 1.0;
				}
			}

			// --

			return new HslColor(
				h * 360.0,
				s * 100.0,
				l * 100.0 );
		}

		/// <summary>
		/// Converts <see cref="HsbColor"/> to <see cref="RgbColor"/>.
		/// </summary>
		/// <param name="hsb">The <see cref="HsbColor"/>.</param>
		/// <returns>A <see cref="RgbColor"/> equivalent.</returns>
		public static RgbColor HsbToRgb( 
			HsbColor hsb )
		{
			double red = 0, green = 0, blue = 0;

			double h = hsb.Hue;
			double s = ((double)hsb.Saturation) / 100;
			double b = ((double)hsb.Brightness) / 100;

			if ( s == 0 )
			{
				red = b;
				green = b;
				blue = b;
			}
			else
			{
				// the color wheel has six sectors.

				double sectorPosition = h / 60;
				var sectorNumber = (int)Math.Floor( sectorPosition );
				double fractionalSector = sectorPosition - sectorNumber;

				double p = b * (1 - s);
				double q = b * (1 - (s * fractionalSector));
				double t = b * (1 - (s * (1 - fractionalSector)));

				// Assign the fractional colors to r, g, and b
				// based on the sector the angle is in.
				switch ( sectorNumber )
				{
					case 0:
						red = b;
						green = t;
						blue = p;
						break;

					case 1:
						red = q;
						green = b;
						blue = p;
						break;

					case 2:
						red = p;
						green = b;
						blue = t;
						break;

					case 3:
						red = p;
						green = q;
						blue = b;
						break;

					case 4:
						red = t;
						green = p;
						blue = b;
						break;

					case 5:
						red = b;
						green = p;
						blue = q;
						break;
				}
			}

			var nRed = (int)Math.Round( red * 255 );
			var nGreen = (int)Math.Round( green * 255 );
			var nBlue = (int)Math.Round( blue * 255 );

			return new RgbColor( nRed, nGreen, nBlue );
		}

		/// <summary>
		/// HSL to RGB.
		/// </summary>
		/// <param name="hsl">The HSL.</param>
		public static RgbColor HslToRgb(
			HslColor hsl )
		{
			double red, green, blue;

			double h = hsl.PreciseHue / 360.0;
			double s = hsl.PreciseSaturation / 100.0;
			double l = hsl.PreciseLight / 100.0;

			if ( s == 0.0 )
			{
				red = l;
				green = l;
				blue = l;
			}
			else
			{
				double var2;

				if ( l < 0.5 )
				{
					var2 = l * (1.0 + s);
				}
				else
				{
					var2 = (l + s) - (s * l);
				}

				double var1 = 2.0 * l - var2;

				red = hue_2_RGB( var1, var2, h + (1.0 / 3.0) );
				green = hue_2_RGB( var1, var2, h );
				blue = hue_2_RGB( var1, var2, h - (1.0 / 3.0) );
			}

			// --

			var nRed = (int)Math.Round( red * 255.0 );
			var nGreen = (int)Math.Round( green * 255.0 );
			var nBlue = (int)Math.Round( blue * 255.0 );

			return new RgbColor( nRed, nGreen, nBlue );
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private helper.
		// ------------------------------------------------------------------

		/// <summary>
		/// Helper function for converting.
		/// </summary>
		/// <param name="v1">The v1.</param>
		/// <param name="v2">The v2.</param>
		/// <param name="vH">The v H.</param>
		/// <returns></returns>
		private static double hue_2_RGB(
			double v1,
			double v2,
			double vH )
		{
			if ( vH < 0.0 )
			{
				vH += 1.0;
			}
			if ( vH > 1.0 )
			{
				vH -= 1.0;
			}
			if ( (6.0 * vH) < 1.0 )
			{
				return (v1 + (v2 - v1) * 6.0 * vH);
			}
			if ( (2.0 * vH) < 1.0 )
			{
				return (v2);
			}
			if ( (3.0 * vH) < 2.0 )
			{
				return (v1 + (v2 - v1) * ((2.0 / 3.0) - vH) * 6.0);
			}

			return (v1);
		}

		/// <summary>
		/// Determines the maximum value of all of the numbers provided in the
		/// variable argument list.
		/// </summary>
		/// <param name="values">An array of doubles.</param>
		/// <returns>The maximum value.</returns>
		private static double getMaximumValue(
			params double[] values )
		{
			var maxValue = values[0];

			if ( values.Length >= 2 )
			{
				for ( var i = 1; i < values.Length; i++ )
				{
					var num = values[i];
					maxValue = Math.Max( maxValue, num );
				}
			}

			return maxValue;
		}

		/// <summary>
		/// Determines the minimum value of all of the numbers provided in the
		/// variable argument list.
		/// </summary>
		/// <param name="values">An array of doubles.</param>
		/// <returns>The minimum value.</returns>
		private static double getMinimumValue(
			params double[] values )
		{
			var minValue = values[0];

			if ( values.Length >= 2 )
			{
				for ( var i = 1; i < values.Length; i++ )
				{
					var num = values[i];
					minValue = Math.Min( minValue, num );
				}
			}

			return minValue;
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}