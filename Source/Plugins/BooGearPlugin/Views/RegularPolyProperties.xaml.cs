#region Usings

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

#endregion

namespace BooGearPlugin.Views
{
    /// <summary>
    ///   Lógica de interacción para RegularPolyProperties.xaml
    /// </summary>
    public partial class RegularPolyProperties
    {
        #region Delegates

        public delegate void ValueChangeEvent();

        #endregion

        public ValueChangeEvent OnDialogClosed;
        public ValueChangeEvent OnValueChange;

        public RegularPolyProperties(int steps)
        {
            InitializeComponent();
            Steps = steps;
            textBoxSteps.Text = Steps.ToString();
        }

        public bool Executed { get; private set; }
        public int Steps { get; private set; }

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