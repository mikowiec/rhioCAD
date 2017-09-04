#region Usings

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using PropertyDescriptorsInterface;

#endregion

namespace PropertyGridTabItems
{
    public class DoubleSliderPropertyTabItem : PropertyTabItemBase
    {
        private readonly double _maxValue;
        private readonly double _minValue;
        private Slider _slider;

        public DoubleSliderPropertyTabItem(double minValue, double maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public override void FillControlEvents(DockPanel parentControl)
        {
            var grid = new Grid();
            var row1 = new RowDefinition {Height = new GridLength(25, GridUnitType.Pixel)};
            var col1 = new ColumnDefinition {Width = new GridLength(0.10, GridUnitType.Star), MaxWidth = 136};
            grid.RowDefinitions.Add(row1);
            grid.ColumnDefinitions.Add(col1);

            _slider = new Slider
                          {
                              Minimum = _minValue,
                              Maximum = _maxValue,
                              Height = 22,
                              Foreground = new SolidColorBrush(Colors.Black),
                              Margin = new Thickness(26, 0, 7, 0),
                              MaxWidth = 110,
                              MinWidth = 50
                          };

            Grid.SetColumn(_slider, 0);
            Grid.SetRow(_slider, 0);
            grid.Children.Add(_slider);

            parentControl.Children.Add(grid);
            _slider.LostMouseCapture += MouseValueSet;
            _slider.LostFocus += delegate { ApplyValue(); };
            UpdateFieldValue();
        }

        private void MouseValueSet(object sender, MouseEventArgs e)
        {
            ApplyValue();
        }

        private void ApplyValue()
        {
            if (OnSetValue == null)
                return;
            OnSetValue(_slider.Value);
        }

        public override void Focus()
        {
            _slider.Focus();
        }

        private void UpdateFieldValue()
        {
            object result = null;
            OnGetValue(ref result);
            _slider.Value = (double) result;
        }

        public int SetTabOrder(int tabIndex)
        {
            _slider.TabIndex = tabIndex;
            return 1;
        }
    }
}