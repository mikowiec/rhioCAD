#region Usings

using System.Windows;
using System.Windows.Input;
using BooEvaluator.Boo;
using log4net;

#endregion

namespace PartModellingUi.Views.Tools
{
    /// <summary>
    ///   Lógica de interacción para ArrayPatternWindow.xaml
    /// </summary>
    public partial class ArrayPatternWindow
    {
        #region Delegates

        public delegate void ValueChangeEvent();

        #endregion

        private static readonly ILog Log = LogManager.GetLogger("NaroCad");
        private readonly string _dialogTitle;

        public ValueChangeEvent OnDialogClosed;
        public ValueChangeEvent OnValueChange;

        public ArrayPatternWindow(string dialogTitle)
        {
            _dialogTitle = dialogTitle;

            InitializeComponent();

            AddDefaultValues();
        }

        public int Rows { get; set; }
        public int Colomns { get; set; }
        public double RowDistance { get; set; }
        public double ColomnDistance { get; set; }
        public int ReverseRows { get; set; }
        public int ReverseColomns { get; set; }

        public bool Result { get; set; }

        private void AddDefaultValues()
        {
            ReverseRows = 1;
            ReverseColomns = 1;
            Rows = 2;
            Colomns = 3;
            RowDistance = 10;
            ColomnDistance = 10;
            textBoxRows.Text = Rows.ToString();
            textBoxColomns.Text = Colomns.ToString();
            textBoxRowDistance.Text = RowDistance.ToString();
            textBoxColomnDistance.Text = ColomnDistance.ToString();
        }

        private void RowsTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            int newNumber;
            try
            {
                newNumber = BooEval.GetInt32(textBoxRows.Text);
            }
            catch
            {
                return;
            }
            Rows = newNumber;
            Preview();
        }

        private void ColomnsTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            int newNumber;
            try
            {
                newNumber = BooEval.GetInt32(textBoxColomns.Text);
            }
            catch
            {
                return;
            }
            Colomns = newNumber;
            Preview();
        }

        private void RowDistanceTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            double newNumber;
            var newTextBoxValue = textBoxRowDistance.Text.Replace(',', '.');
            try
            {
                newNumber = BooEval.GetDouble(newTextBoxValue);
            }
            catch
            {
                return;
            }
            RowDistance = newNumber;
            Preview();
        }

        private void ColomnDistanceTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            double newNumber;
            var newTextBoxValue = textBoxColomnDistance.Text.Replace(',', '.');
            try
            {
                newNumber = BooEval.GetDouble(newTextBoxValue);
            }
            catch
            {
                return;
            }
            ColomnDistance = newNumber;
            Preview();
        }

        private void Preview()
        {
            if (OnValueChange != null) OnValueChange();
        }

        private void OkButtonExecuted(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing OK button from Array Pattern. The parameters are: " + "Number of Rows->" + Rows +
                     " ,Distance between rows->" + RowDistance + " ,Number of Colomns->" + Colomns +
                     " ,Distance between colomns->" + ColomnDistance);
            NotifyValueChanged();
            Result = true;
            NotifyDialogClosed();
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

        private void CancelButtonExecuted(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Cancel button from Array Pattern window");
            Result = false;
            NotifyDialogClosed();
            Close();
        }

        private void ReverseRowDirectionClicked(object sender, RoutedEventArgs e)
        {
            ReverseRows = -1*ReverseRows;
            if (OnValueChange != null) OnValueChange();
        }

        private void ReverseColomnDirectionClicked(object sender, RoutedEventArgs e)
        {
            ReverseColomns = -1*ReverseColomns;
            if (OnValueChange != null) OnValueChange();
        }
    }
}