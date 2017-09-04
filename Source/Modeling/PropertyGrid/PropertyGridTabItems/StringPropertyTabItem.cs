#region Usings

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using PropertyDescriptorsInterface;

#endregion

namespace PropertyGridTabItems
{
    public class StringPropertyTabItem : PropertyTabItemBase
    {
        private TextBox _textBox;
        private string _value;

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

            _textBox = new TextBox
                           {
                               Height = 22,
                               Foreground = new SolidColorBrush(Colors.Black),
                               Margin = new Thickness(26, 0, 7, 0),
                               MaxWidth = 102,
                               MinWidth = 50
                           };
            Grid.SetColumn(_textBox, 0);
            Grid.SetRow(_textBox, 0);
            grid.Children.Add(_textBox);

            _textBox.SetResourceReference(FrameworkElement.StyleProperty, "roundTextBox");

            parentControl.Children.Add(grid);
            _textBox.KeyDown += TextBoxKeyDown;
            _textBox.LostFocus += delegate { ApplyValue(); };
            UpdateFieldValue();
        }

        public int SetTabOrder(int tabIndex)
        {
            _textBox.TabIndex = tabIndex;
            return 1;
        }

        public override void Focus()
        {
            _textBox.Focus();
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

            if (_value != text)
                OnSetValue(text);
        }

        private void UpdateFieldValue()
        {
            object result = null;
            OnGetValue(ref result);
            _value = (string) result;
            var newText = _value;
            var text = _textBox.Text;
            if (text != newText)
            {
                _textBox.Text = newText;
            }
        }
    }
}