namespace ZetaColorEditor.Runtime.ColorSchemes
{
	using System.Drawing;

	/// <summary>
	/// 
	/// </summary>
	public interface IColorScheme
	{
		/// <summary>
		/// Gets the colors.
		/// </summary>
		/// <value>The colors.</value>
		Color[] Colors
		{
			get;
		}

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		string Name
		{
			get;
		}
	}
}