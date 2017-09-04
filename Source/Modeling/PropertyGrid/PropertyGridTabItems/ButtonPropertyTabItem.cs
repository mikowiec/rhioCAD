#region Usings

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using PropertyDescriptorsInterface;

#endregion

namespace PropertyGridTabItems
{
    public class ButtonPropertyTabItem : PropertyTabItemBase
    {
        private readonly string _message;
        private Button _button;

        public ButtonPropertyTabItem(string message)
        {
            _message = message;
        }

        public override void FillControlEvents(DockPanel parentControl)
        {
            var grid = new Grid();
            var row1 = new RowDefinition {Height = new GridLength(25, GridUnitType.Pixel)};
            var col1 = new ColumnDefinition
                           {
                               Width = new GridLength(0.10, GridUnitType.Star),
                               MaxWidth = 136
                           };
            grid.RowDefinitions.Add(row1);
            grid.ColumnDefinitions.Add(col1);

            _button = new Button
                          {
                              Height = 22,
                              Foreground = new SolidColorBrush(Colors.Black),
                              Margin = new Thickness(26, 0, 7, 0),
                              MaxWidth = 110
                          };

            Grid.SetColumn(_button, 0);
            Grid.SetRow(_button, 0);
            grid.Children.Add(_button);

            _button.Click += ButtonClick;
            _button.Content = new TextBlock {Text = _message, HorizontalAlignment = HorizontalAlignment.Left};
            parentControl.Children.Add(grid);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            OnSetValue(null);
        }

        public override void Focus()
        {
            _button.Focus();
        }
    }
}