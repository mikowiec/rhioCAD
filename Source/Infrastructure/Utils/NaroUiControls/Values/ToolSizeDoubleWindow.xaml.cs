#region Usings

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using BooEvaluator.Boo;
using log4net;

#endregion

namespace PartModellingUi.Views.Tools
{
    /// <summary>
    ///   Lógica de interacción para ToolSizeDoubleWindow.xaml
    /// </summary>
    public partial class ToolSizeDoubleWindow
    {
        #region Fields

        private readonly double _originalValue;
        private int _powerRange;
        private double _prevValue;
        private bool _result;

        #endregion

        #region Constructor

        public ToolSizeDoubleWindow(double originalValue, string title)
        {
            InitializeComponent();

            PowerRange = 2;
            _originalValue = originalValue;
            _prevValue = _originalValue;
            Value = _prevValue;
            Title = title;
        }

        #endregion

        #region Delegates

        public delegate void ValueChangeEvent();

        #endregion

        private static readonly ILog Log = LogManager.GetLogger(typeof (ToolSizeDoubleWindow));

        public ValueChangeEvent OnDialogClosed;
        public ValueChangeEvent OnValueChange;

        public double Value { get; private set; }


        public int PowerRange
        {
            set { _powerRange = value; }
        }

        public bool FailedValue
        {
            set { slider.Background = new SolidColorBrush(value ? Colors.Orange : Colors.Transparent); }
        }

        public bool Result
        {
            get { return _result; }
            private set
            {
                _result = value;
                Close();
                NotifyDialogClosed();
            }
        }

        private void NotifyValueChanged()
        {
            if (OnValueChange != null)
                OnValueChange();
        }

        private void NotifyDialogClosed()
        {
            Log.Info("After pressing OK button from Rotate slider");
            if (OnDialogClosed != null)
                OnDialogClosed();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            UpdateTextBox();
        }

        #region Events

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Result = true;
        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Cancel button from Fillet slider");
            Value = _originalValue;
            Result = false;
        }

        private void UpdateTextBox()
        {
            textBox.Text = Value.ToString("0.000");
            NotifyValueChanged();
        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
                return;
            var textValue = textBox.Text;
            try
            {
                var doubleValue = BooEval.GetDouble(textValue);
                UpdateValue(doubleValue);
            }
            catch
            {
                Value = _prevValue;
            }
        }

        private void UpdateValue(double value)
        {
            Value = value;
            _prevValue = Value;
            UpdateTextBox();
        }

        private void SliderMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
                return;
            UpdatSliderValue();
        }

        private void UpdatSliderValue()
        {
            var sliderValue = slider.Value;
            PowerRange = 5;
            sliderValue = (sliderValue - 0.5)*_powerRange;
            UpdateValue(_originalValue*Math.Pow(10, sliderValue));
        }

        private void SliderMouseUp(object sender, MouseButtonEventArgs e)
        {
            UpdatSliderValue();
        }

        #endregion
    }
}