namespace ZetaColorEditor.Runtime.PropertyGridEditors
{
	using System.ComponentModel;
	using System.Drawing;

	public class ColorTypeDialogConverter : ColorConverter
	{
		public override bool GetStandardValuesSupported( 
			ITypeDescriptorContext context )
		{
			return false;
		}
	}
}