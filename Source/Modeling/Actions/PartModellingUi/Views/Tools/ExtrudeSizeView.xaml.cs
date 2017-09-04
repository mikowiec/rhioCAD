#region Usings

using System.Globalization;
using System.Windows;
using System.Windows.Input;
using BooEvaluator.Boo;

#endregion

namespace PartModellingUi.Views.Tools
{
    /// <summary>
    ///   Lógica de interacción para ExtrudeSizeView.xaml
    /// </summary>
    public partial class ExtrudeSizeView
    {
        #region Delegates

        public delegate void OnValueChanged();

        #endregion

        public OnValueChanged ResultAccepted;
        public OnValueChanged ValueChanged;

        private double _extrudeHeight;

        public ExtrudeSizeView(double minimum, double maximum, double globalExtrudeSize)
        {
            InitializeComponent();
            _valueSldier.Minimum = minimum;
            _valueSldier.Maximum = maximum;
            ExtrudeHeight = globalExtrudeSize;
        }

        public bool ResultOperation { get; set; }

        public double ExtrudeHeight
        {
            get { return _extrudeHeight; }
            set
            {
                _extrudeHeight = value;
                _textBox.Text = _extrudeHeight.ToString("0.00", CultureInfo.InvariantCulture);
                _valueSldier.Value = value;
            }
        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            ExtrudeHeight = BooEval.GetDouble(_textBox.Text);
            if (ValueChanged != null)
                ValueChanged();
        }

        private void OkButtonClick(object sender, RoutedEventArgs e)
        {
            ResultOperation = true;
            if (ResultAccepted != null)
                ResultAccepted();
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            ResultOperation = false;
            if (ResultAccepted != null)
                ResultAccepted();
        }

        private void SliderMouseDrag(object sender, MouseEventArgs e)
        {
            var value = _valueSldier.Value;
            _extrudeHeight = value;
            _textBox.Text = _extrudeHeight.ToString("0.00", CultureInfo.InvariantCulture);
            if (ValueChanged != null)
                ValueChanged();
        }
    }
}