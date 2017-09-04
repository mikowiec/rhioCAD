#region Usings

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using PropertyDescriptorsInterface;

#endregion

namespace PropertyGridTabItems
{
    public class ColorPropertyTabItem : PropertyTabItemBase
    {
        private ColorPickerTemplate _colorPicker = new ColorPickerTemplate();

        public int SetTabOrder(int tabIndex)
        {
            _colorPicker.TabIndex = tabIndex;
            return 1;
        }

        public override void FillControlEvents(DockPanel parentControl)
        {
            _colorPicker = new ColorPickerTemplate();
            _colorPicker.customColorPicker.ColorChanged += ColorChanged;
            parentControl.Children.Add(_colorPicker);
            UpdateFieldValue();
        }

        private void ColorChanged(Color color)
        {
            OnSetValue(color);
        }

        public override void Focus()
        {
            _colorPicker.customColorPicker.cbxColor.Focus();
        }

        private void UpdateFieldValue()
        {
            object result = null;
            OnGetValue(ref result);
            var comboBox = _colorPicker.customColorPicker.cbxColor;
            var color = (Color) result;
            comboBox.Background = new SolidColorBrush(color);
            comboBox.SelectedValue = new Canvas
                                         {
                                             Background = new SolidColorBrush(color),
                                             Height = 20,
                                             Width = 90,
                                             HorizontalAlignment = HorizontalAlignment.Left,
                                             VerticalAlignment = VerticalAlignment.Center
                                         };
        }
    }
}