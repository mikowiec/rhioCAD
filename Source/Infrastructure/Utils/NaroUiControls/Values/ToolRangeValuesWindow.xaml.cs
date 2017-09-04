#region Usings

using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using BooEvaluator.Boo;
using log4net;
using PartModellingUi.Views.Tools;

#endregion

namespace NaroUiControls.Values
{
    /// <summary>
    ///   Lógica de interacción para ToolRangeValuesWindow.xaml
    /// </summary>
    public partial class ToolRangeValuesWindow
    {
        #region Delegates

        public delegate void ValueChangeEvent();

        #endregion

        private static readonly ILog Log = LogManager.GetLogger(typeof (ToolSizeDoubleWindow));

        public ValueChangeEvent OnDialogClosed;
        public ValueChangeEvent OnValueChange;
        private double _prevValue;

        public ToolRangeValuesWindow(double low, double hi, string dialogTitle)
        {
            InitializeComponent();
            SetLimits(low, hi);
            Title = dialogTitle;

            slider.ValueChanged += SetTextboxValue;
        }

        public double Value { get; private set; }

        public bool Result { get; private set; }

        private void SetTextboxValue(object sender,
                                     RoutedPropertyChangedEventArgs<double> routedPropertyChangedEventArgs)
        {
            UpdateValue(slider.Value);
        }

        private void SetLimits(double low, double hi)
        {
            slider.Minimum = low;
            slider.Maximum = hi;
        }

        private void OkButtonExecuted(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing OK button from Rotate slider");
            NotifyValueChanged();
            Result = true;
            Close();
        }

        private void NotifyValueChanged()
        {
            if (OnValueChange != null)
                OnValueChange();
        }

        private void NotifyDialogClosed()
        {
            if (OnDialogClosed != null)
                OnDialogClosed();
        }

        private void SliderMouseUp(object sender, MouseButtonEventArgs e)
        {
            NotifyValueChanged();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            textBox.Text = Value.ToString("0.##");
        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
                return;
            var textValue = textBox.Text;
            try
            {
                var value = BooEval.GetDouble(textValue);
                UpdateValue(value);
                slider.Value = value;
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
            NotifyValueChanged();
        }

        private void SliderMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
                return;
            NotifyValueChanged();
        }

        private void CancelButtonExecuted(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Cancel button from Rotate slider");
            Result = false;
            Close();
        }

        private void WindowClosing(object sender, CancelEventArgs e)
        {
            NotifyDialogClosed();
        }
    }
}