namespace ZetaColorEditor.Runtime.PropertyGridEditors
{
	using System.Drawing;
	using System.Windows.Forms.Design;

	/// <summary>
	/// 
	/// </summary>
	public partial class ColorUI :
		ColorEditorUserControl
	{
		private IWindowsFormsEditorService _edSvc;
		private object _value;
		private ColorTypeEditorDropDown _editor;

		public ColorUI( ColorTypeEditorDropDown editor )
		{
			_editor = editor;
			InitializeComponent();
		}

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <value>The value.</value>
		public object Value
		{
			get
			{
				//return _value;
				return SelectedColor;
			}
		}

		private void adjustColorUIHeight()
		{
			Size = MinimumSize;
		}

		public void Start(
			IWindowsFormsEditorService edSvc,
			object value )
		{
			_edSvc = edSvc;
			_value = value;
			adjustColorUIHeight();

			if ( value != null )
			{
				var color = (Color)value;
				SelectedColor = color;
			}
		}

		public void End()
		{
			_edSvc = null;
			_value = null;
		}
	}
}