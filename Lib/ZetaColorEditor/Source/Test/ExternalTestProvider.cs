namespace Test
{
	using System.Collections.Generic;
	using System.Drawing;
	using ZetaColorEditor.Runtime;
	using ZetaColorEditor.Runtime.ColorSchemes;

	internal class ExternalTestProvider :
		IExternalColorEditorInformationProvider
	{
		public IColorScheme[] ColorSchemes
		{
			get
			{
				var schemes = 
					new List<ColorScheme>
						{
							new ColorScheme("Scheme one!",
							                Color.Red, Color.Green, Color.Blue),
							new ColorScheme("Scheme 2",
							                Color.Black, Color.White, Color.Gray),
							new ColorScheme("Yet another scheme",
							                Color.OrangeRed, Color.YellowGreen, Color.LightBlue),
							new ColorScheme("A scheme with lots of colors",
							                Color.AliceBlue,
							                Color.AntiqueWhite,
							                Color.Aqua,
							                Color.Aquamarine,
							                Color.Azure,
							                Color.Beige,
							                Color.Bisque,
							                Color.Black,
							                Color.BlanchedAlmond,
							                ColorTranslator.FromHtml(@"#0066CC"),
							                Color.Blue,
							                Color.BlueViolet,
							                Color.Brown,
							                Color.Crimson,
							                Color.DeepPink,
							                Color.Indigo,
							                Color.MediumOrchid,
							                Color.Wheat
								)
						};

				return schemes.ToArray();
			}
		}

		/// <summary>
		/// Formats the display text.
		/// Allows externally to configure what to display.
		/// Simply do nothing when you want the default behavior.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <param name="displayText">The display text.</param>
		public void FormatDisplayText(
			Color color,
			ref string displayText )
		{
		}

		/// <summary>
		/// Gives implementors of this interface a chance to adjust the
		/// order where colors are looked up when setting the initial
		/// color for the color editor control/form.
		/// </summary>
		/// <param name="lookupOrder">The lookup order.</param>
		public void AdjustColorSettingLookupOrder(
			IList<ColorLookupElement> lookupOrder )
		{
			lookupOrder.Insert( 0, ColorLookupElement.SchemeColors );
		}

		/// <summary>
		/// Saves the per user per workstation value.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="value">The value.</param>
		public void SavePerUserPerWorkstationValue( string name, string value )
		{
			// TODO.
		}

		/// <summary>
		/// Restores the per user per workstation value.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="fallBackTo">The fall back to.</param>
		/// <returns></returns>
		public string RestorePerUserPerWorkstationValue( string name, string fallBackTo )
		{
			// TODO.
			return fallBackTo;
		}

		/// <summary>
		/// Gets a value indicating whether [allow no color selectable].
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [allow no color selectable]; otherwise, <c>false</c>.
		/// </value>
		public bool AllowNoColorSelectable
		{
			get
			{
				return true;
			}
		}
	}

	/// <summary>
	/// 
	/// </summary>
	internal class ColorScheme :
		IColorScheme
	{
		private readonly string _name;
		private readonly Color[] _colors;

		public ColorScheme(
			string name,
			params Color[] colors )
		{
			_name = name;
			_colors = colors;
		}

		public Color[] Colors
		{
			get
			{
				return _colors;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
		}
	}
}