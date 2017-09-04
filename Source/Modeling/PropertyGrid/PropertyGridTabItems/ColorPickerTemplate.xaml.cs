#region Usings

using System.Windows;

#endregion

namespace PropertyGridTabItems
{
    /// <summary>
    ///   Interaction logic for ColorPickerTemplate.xaml
    /// </summary>
    public partial class ColorPickerTemplate
    {
        public ColorPickerTemplate()
        {
            InitializeComponent();
            Margin = new Thickness(26, 0, 7, 0);
        }

        public void OnFocus()
        {
            customColorPicker.cbxColor.Focus();
        }
    }
}