#region Usings

using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Input;

#endregion

namespace BooGearPlugin.Views
{
    /// <summary>
    ///   Lógica de interacción para GearProperties.xaml
    /// </summary>
    public partial class GearProperties
    {
        #region Delegates

        public delegate void ValueChangeEvent();

        #endregion

        public ValueChangeEvent OnDialogClosed;
        public ValueChangeEvent OnValueChange;

        public GearProperties(int steps, double extrudeSize)
        {
            InitializeComponent();
            Steps = steps;
            textBoxSteps.Text = Steps.ToString();
            ExtrudeSize = extrudeSize;
            textBoxExtrudeSize.Text = ExtrudeSize.ToString("0.00", CultureInfo.InvariantCulture);
        }

        public bool Executed { get; private set; }
        public int Steps { get; private set; }
        public double ExtrudeSize { get; private set; }

        private void UpdateTextboxValue()
        {
            var text = textBoxSteps.Text;
            var prevValue = Steps;
            try
            {
                Steps = Convert.ToInt32(text);
            }
            catch
            {
                Steps = prevValue;
            }
            text = textBoxExtrudeSize.Text;
            var prevExtrude = ExtrudeSize;
            try
            {
                ExtrudeSize = Convert.ToDouble(text);
            }
            catch
            {
                ExtrudeSize = prevExtrude;
            }
            NotifyValueChanged();
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

        private void OkButtonExecuted(object sender, RoutedEventArgs e)
        {
            UpdateTextboxValue();
            Executed = true;
            Close();
        }

        private void CancelButtonExecuted(object sender, RoutedEventArgs e)
        {
            Executed = false;
            Close();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            UpdateTextboxValue();
        }

        private void WindowClosing(object sender, CancelEventArgs e)
        {
            NotifyDialogClosed();
        }

        private void OnTextBoxChanged(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            UpdateTextboxValue();
        }
    }
}