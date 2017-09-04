using System.Windows;
using System.Windows.Input;
using BooEvaluator.Boo;

namespace NaroUiControls.Values
{
    /// <summary>
    ///   Lógica de interacción para RangeValueSliderControl.xaml
    /// </summary>
    public partial class RangeValueSliderControl
    {
        public RangeValueSliderControl()
        {
            InitializeComponent();
        }

        public delegate void ValueChangedEvent();

        public ValueChangedEvent ValueChanged;
        private double _value;
        private double _min;
        private double _max;

        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                _textBox.Text = _value.ToString();
                _slider.Value = _value;
            }
        }

        public void SetRanges(double min, double max)
        {
            _min = min;
            _max = max;
            _slider.Minimum = min;
            _slider.Maximum = max;
        }

        private void OnValueSet(object sender, RoutedPropertyChangedEventArgs<double> routedPropertyChangedEventArgs)
        {
            Value = _slider.Value;
            _textBox.Text = _slider.Value.ToString();

            NotifyValueChanged();
        }

        private void NotifyValueChanged()
        {
            if (ValueChanged != null)
                ValueChanged();
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            var value = BooEval.GetDouble(_textBox.Text);
            if (value > _max) value = _max;
            if (value < _min) value = _min;
            Value = value;

            _slider.Value = Value;
            NotifyValueChanged();
        }
    }
}