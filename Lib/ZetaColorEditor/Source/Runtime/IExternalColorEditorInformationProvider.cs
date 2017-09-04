namespace ZetaColorEditor.Runtime
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System.Collections.Generic;
	using System.Drawing;
	using ColorSchemes;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Externally provide additional functions.
	/// </summary>
	public interface IExternalColorEditorInformationProvider
	{
		#region Color related.
		// ------------------------------------------------------------------

		/// <summary>
		/// Gets the color schemes.
		/// </summary>
		/// <value>The color schemes. Return NULL or empty to disable 
		/// color schemes.</value>
		IColorScheme[] ColorSchemes
		{
			get;
		}

		/// <summary>
		/// Gets a value indicating whether [allow no color selectable].
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [allow no color selectable]; otherwise, <c>false</c>.
		/// </value>
		bool AllowNoColorSelectable
		{
			get;
		}

		/// <summary>
		/// Formats the display text.
		/// Allows externally to configure what to display.
		/// Simply do nothing when you want the default behavior.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <param name="displayText">The display text.</param>
		void FormatDisplayText(
			Color color,
			ref string displayText );

		/// <summary>
		/// Gives implementors of this interface a chance to adjust the
		/// order where colors are looked up when setting the initial
		/// color for the color editor control/form.
		/// </summary>
		/// <param name="lookupOrder">The lookup order.</param>
		void AdjustColorSettingLookupOrder(
			IList<ColorLookupElement> lookupOrder );

		// ------------------------------------------------------------------
		#endregion

		#region Persistance.
		// ------------------------------------------------------------------

		/// <summary>
		/// Saves a per user per workstation value.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="value">The value.</param>
		void SavePerUserPerWorkstationValue(
			string name,
			string value );

		/// <summary>
		/// Restores a per user per workstation value.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="fallBackTo">The fall back to.</param>
		/// <returns></returns>
		string RestorePerUserPerWorkstationValue(
			string name,
			string fallBackTo );

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}