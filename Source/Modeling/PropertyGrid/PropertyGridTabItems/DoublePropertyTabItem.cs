#region Usings

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using BooEvaluator.Boo;
using PropertyDescriptorsInterface;

#endregion

namespace PropertyGridTabItems
{
    public class DoublePropertyTabItem : PropertyTabItemBase
    {
        #region Delegates

        public delegate void OnLockClickEvent(bool isLocked);

        #endregion

        public OnLockClickEvent OnLockClicked;
        private bool _isLocked;
        private bool _showLock;
        private TextBox _textBox;
        private double _value;

        public void ShowLockImage(bool isLocked)
        {
            _isLocked = isLocked;
            _showLock = true;
        }

        public override void FillControlEvents(DockPanel parentControl)
        {
            var grid = new Grid();
            var row1 = new RowDefinition {Height = new GridLength(25, GridUnitType.Pixel)};

            var col1 = new ColumnDefinition {Width = new GridLength(0.10, GridUnitType.Star), MaxWidth = 136};


            grid.RowDefinitions.Add(row1);
            grid.ColumnDefinitions.Add(col1);

            _textBox = new TextBox
                           {
                               Height = 22,
                               Foreground =
                                   _isLocked ? new SolidColorBrush(Colors.White) : new SolidColorBrush(Colors.Black),
                               Margin = new Thickness(26, 0, 7, 0),
                               MaxWidth = 110,
                               MinWidth = 50
                           };
            Grid.SetColumn(_textBox, 0);
            Grid.SetRow(_textBox, 0);
            grid.Children.Add(_textBox);

            if (_isLocked)
            {
                _textBox.Background = new SolidColorBrush(Colors.DarkGray);
                _textBox.IsEnabled = false;
            }
            _textBox.SetResourceReference(FrameworkElement.StyleProperty, "roundTextBox");
            if (_showLock)
            {
                var col2 = new ColumnDefinition {Width = new GridLength(0.10, GridUnitType.Star), MaxWidth = 25};
                grid.ColumnDefinitions.Add(col2);

                const string baseUrl = @"/Resources;component/Resources/";
                var uriName = _isLocked ? baseUrl + "lock.png" : baseUrl + "distance.png";
                var image = new Button
                                {
                                    Background = new SolidColorBrush(_isLocked ? Colors.DarkRed : Colors.DarkGray),
                                    Width = 25,
                                    Content = new Image
                                                  {
                                                      Source =
                                                          new BitmapImage(new Uri(uriName, UriKind.RelativeOrAbsolute)),
                                                      Width = 12,
                                                      Height = 12,
                                                      Margin = new Thickness(3, 0, 0, 0),
                                                      HorizontalAlignment = HorizontalAlignment.Left
                                                  },
                                    ToolTip = "Lock/Unlock the current property"
                                };
                image.Click += ImageClick;

                Grid.SetColumn(image, 1);
                Grid.SetRow(image, 0);
                grid.Children.Add(image);
            }
            parentControl.Children.Add(grid);

            _textBox.KeyDown += TextBoxKeyDown;
            UpdateFieldValue();
        }

        private void ImageClick(object sender, RoutedEventArgs e)
        {
            if (OnLockClicked != null)
                OnLockClicked(!_isLocked);
        }

        public override void Focus()
        {
            _textBox.Focus();
        }

        private void UpdateFieldValue()
        {
            object result = null;
            OnGetValue(ref result);
            _value = (double) result;
            var newText = String.Format("{0:0.##}", _value);
            var text = _textBox.Text;
            if (text == newText) return;
            _textBox.Text = newText;
            _textBox.ToolTip = "Value: " + newText;
        }


        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
                return;

            ApplyValue();
        }

        private void ApplyValue()
        {
            if (OnSetValue == null)
                return;
            var text = _textBox.Text;
            double value;
            if (string.IsNullOrEmpty(text))
                value = 0;
            else
            {
                try
                {
                    value = BooEval.GetDouble(text);
                }
                catch (Exception)
                {
                    value = 0;
                }
            }
            if (Math.Abs(_value - value) > 1e-12)
                OnSetValue(value);
        }

        public int SetTabOrder(int tabIndex)
        {
            _textBox.TabIndex = tabIndex;
            return 1;
        }
    }
}