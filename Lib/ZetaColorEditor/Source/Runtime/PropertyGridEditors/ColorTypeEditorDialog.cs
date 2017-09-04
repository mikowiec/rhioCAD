namespace ZetaColorEditor.Runtime.PropertyGridEditors
{
	using System;
	using System.ComponentModel;
	using System.Drawing;
	using System.Drawing.Design;
	using System.Windows.Forms;

	public class ColorTypeEditorDialog :
		UITypeEditor
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Edits the specified object's value using the editor style indicated 
		/// by the <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle"></see> 
		/// method.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"></see> 
		/// that can be used to gain additional context information.</param>
		/// <param name="provider">An <see cref="T:System.IServiceProvider"></see> 
		/// that this editor can use to obtain services.</param>
		/// <param name="value">The object to edit.</param>
		/// <returns>
		/// The new value of the object. If the value of the object has not 
		/// changed, this should return the same object it was passed.
		/// </returns>
		public override object EditValue(
			ITypeDescriptorContext context,
			IServiceProvider provider,
			object value )
		{
			Color color;

			if ( value == null )
			{
				color = Color.Empty;
			}else 
			{
				color = (Color)value;
			}

			using ( var form = new ColorEditorForm() )
			{
				form.SelectedColor = color;

				if ( form.ShowDialog() == DialogResult.OK )
				{
						value = form.SelectedColor;
				}
			}

			return value;
		}

		/// <summary>
		/// Gets the editor style used by the 
		/// <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)"></see> 
		/// method.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"></see>
		/// that can be used to gain additional context information.</param>
		/// <returns>
		/// A <see cref="T:System.Drawing.Design.UITypeEditorEditStyle"></see> 
		/// value that indicates the style of editor used by the 
		/// <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)"></see> 
		/// method. If the <see cref="T:System.Drawing.Design.UITypeEditor"></see> 
		/// does not support this method, then 
		/// <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle"></see> 
		/// will return <see cref="F:System.Drawing.Design.UITypeEditorEditStyle.None"></see>.
		/// </returns>
		public override UITypeEditorEditStyle GetEditStyle(
			ITypeDescriptorContext context )
		{
			return UITypeEditorEditStyle.Modal;
		}

		/// <summary>
		/// Indicates whether the specified context supports painting a 
		/// representation of an object's value within the specified context.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"></see> 
		/// that can be used to gain additional context information.</param>
		/// <returns>
		/// true if <see cref="M:System.Drawing.Design.UITypeEditor.PaintValue(System.Object,System.Drawing.Graphics,System.Drawing.Rectangle)"></see> 
		/// is implemented; otherwise, false.
		/// </returns>
		public override bool GetPaintValueSupported(
			ITypeDescriptorContext context )
		{
			return true;
		}

		/// <summary>
		/// Paints a representation of the value of an object using the specified 
		/// <see cref="T:System.Drawing.Design.PaintValueEventArgs"></see>.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Drawing.Design.PaintValueEventArgs"></see> 
		/// that indicates what to paint and where to paint it.</param>
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

		// ------------------------------------------------------------------
		#endregion
	}
}