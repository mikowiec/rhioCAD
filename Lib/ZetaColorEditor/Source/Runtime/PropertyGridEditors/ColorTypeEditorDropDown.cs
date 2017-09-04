namespace ZetaColorEditor.Runtime.PropertyGridEditors
{
	using System;
	using System.ComponentModel;
	using System.Drawing;
	using System.Drawing.Design;
	using System.Windows.Forms.Design;

	public class ColorTypeEditorDropDown :
		UITypeEditor
	//ColorEditor
	{
		private ColorUI _colorUI;

		public override object EditValue( 
			ITypeDescriptorContext context, 
			IServiceProvider provider,
			object value )
		{
			if ( provider != null )
			{
				var edSvc = 
					(IWindowsFormsEditorService)provider.GetService(
					typeof( IWindowsFormsEditorService ) );

				if ( edSvc == null )
				{
					return value;
				}
				if ( _colorUI == null )
				{
					_colorUI = new ColorUI( this );
				}
				_colorUI.Start( edSvc, value );
				edSvc.DropDownControl( _colorUI );

				// --

				if ( (_colorUI.Value != null) && (((Color)_colorUI.Value) != Color.Empty) )
				{
					value = _colorUI.Value;
				}

				_colorUI.End();
			}
			return value;
		}

		public override UITypeEditorEditStyle GetEditStyle( 
			ITypeDescriptorContext context )
		{
			return UITypeEditorEditStyle.DropDown;
		}

		public override bool GetPaintValueSupported( 
			ITypeDescriptorContext context )
		{
			return true;
		}

		public override void PaintValue( 
			PaintValueEventArgs e )
		{
			if ( e.Value is Color )
			{
				var color = (Color)e.Value;
				var brush = new SolidBrush( color );
				e.Graphics.FillRectangle( brush, e.Bounds );
				brush.Dispose();
			}
		}
	}
}