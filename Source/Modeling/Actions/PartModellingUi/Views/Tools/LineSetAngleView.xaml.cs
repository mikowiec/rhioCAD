#region Usings

using System.Globalization;
using System.Windows;
using System.Windows.Input;
using BooEvaluator.Boo;

#endregion

namespace PartModellingUi.Views.Tools
{
    /// <summary>
    ///   Lógica de interacción para LineSetAngleView.xaml
    /// </summary>
    public partial class LineSetAngleView
    {
        #region Delegates

        public delegate void OnChanged();

        public delegate void OnClosed();

        #endregion

        public OnChanged Changed;
        public OnClosed Closed;

        public LineSetAngleView(double angle)
        {
            InitializeComponent();
            sliderAngle.Value = angle;
            UpdateAngle(angle);
            txtAngle.KeyUp += TbxAngularPrecTextChanged;
            cbxInvertBase.Checked += CbxInvertBaseChecked;
            sliderAngle.ValueChanged += SliderValueChanged;
        }

        public double Angle { get; set; }
        public bool ReversedBase { get; set; }
        public bool AcceptResult { get; set; }

        private void SliderValueChanged(object sender,
                                        RoutedPropertyChangedEventArgs<double> routedPropertyChangedEventArgs)
        {
            var angle = sliderAngle.Value;
            UpdateAngle(angle);
        }

        private void UpdateAngle(double angle)
        {
            Angle = angle;
            txtAngle.Text = string.Format(CultureInfo.InvariantCulture, "{0,00}", Angle);

            NotifyChanged();
        }

        private void CbxInvertBaseChecked(object sender, RoutedEventArgs e)
        {
            ReversedBase = cbxInvertBase.IsChecked ?? false;
            NotifyChanged();
        }

        private void TbxAngularPrecTextChanged(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.Key != Key.Enter) return;
            Angle = BooEval.GetDouble(txtAngle.Text);
            sliderAngle.Value = Angle;
            NotifyChanged();
        }

        private void NotifyChanged()
        {
            if (Changed != null) Changed();
        }

        private void DoneButtonClick(object sender, RoutedEventArgs e)
        {
            AcceptResult = true;
            if (Closed != null) Closed();
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            AcceptResult = false;
            if (Closed != null) Closed();
        }
    }
}