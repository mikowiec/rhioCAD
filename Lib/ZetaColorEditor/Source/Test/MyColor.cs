namespace Test
{
	using System.ComponentModel;
	using System.Drawing;
	using System.Drawing.Design;
	using ZetaColorEditor.Runtime.PropertyGridEditors;

	/// <summary>
	/// 
	/// </summary>
	public class MyColor
	{
		private Color _colorWithOwnEditorDropDown = SystemColors.ControlDark;
		private Color _colorWithOwnEditorDialog = SystemColors.ControlDark;
		private Color _color = SystemColors.ControlDark;

		/// <summary>
		/// Gets or sets the color with own editor.
		/// </summary>
		/// <value>The color with own editor.</value>
		[TypeConverter( typeof( ColorTypeDropDownConverter ) )]
		[Editor( @"ZetaColorEditor.Runtime.PropertyGridEditors.ColorTypeEditorDropDown, ZetaColorEditor", typeof( UITypeEditor ) )]
		public Color ColorWithOwnEditorDropDown
		{
			get
			{
				return _colorWithOwnEditorDropDown;
			}
			set
			{
				_colorWithOwnEditorDropDown = value;
			}
		}

		/// <summary>
		/// Gets or sets the color with own editor.
		/// </summary>
		/// <value>The color with own editor.</value>
		[TypeConverter( typeof( ColorTypeDialogConverter ) )]
		[Editor( @"ZetaColorEditor.Runtime.PropertyGridEditors.ColorTypeEditorDialog, ZetaColorEditor", typeof( UITypeEditor ) )]
		public Color ColorWithOwnEditorDialog
		{
			get
			{
				return _colorWithOwnEditorDialog;
			}
			set
			{
				_colorWithOwnEditorDialog = value;
			}
		}

		/// <summary>
		/// Gets or sets the color.
		/// </summary>
		/// <value>The color.</value>
		public Color Color
		{
			get
			{
				return _color;
			}
			set
			{
				_color = value;
			}
		}
	}
}