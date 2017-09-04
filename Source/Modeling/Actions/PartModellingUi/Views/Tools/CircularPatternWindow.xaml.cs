#region Usings

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BooEvaluator.Boo;
using NaroCppCore.Occ.Precision;
using log4net;
#endregion

namespace PartModellingUi.Views.Tools
{
    /// <summary>
    ///   Lógica de interacción para CircularPatternWindow.xaml
    /// </summary>
    public partial class CircularPatternWindow
    {
        #region Delegates

        public delegate void ValueChangeEvent();

        #endregion

        private static readonly ILog Log = LogManager.GetLogger("NaroCad");
        private static double _distancePrecision;
        private readonly string _dialogTitle;

        public ValueChangeEvent OnDialogClosed;
        public ValueChangeEvent OnValueChange;
        private List<ComboBoxItem> _comboItemsList;

        public CircularPatternWindow(string dialogTitle, double length)
        {
            _dialogTitle = dialogTitle;

            InitializeComponent();

            FillComboBoxItems(PatternVariableSelector);
            AddDefaultValues(length);
            _distancePrecision = Precision.Confusion;
        }

        public double Angle { get; set; }
        public double Between { get; set; }
        public double Height { get; set; }
        public int Number { get; set; }
        public int Reverse { get; set; }
        public int CurrentIndex { get; private set; }
        public bool Result { get; set; }

        private void AddDefaultValues(double length)
        {
            Reverse = 1;
            Height = length;
            Angle = 18;
            Number = 10;
            Between = Height/(Number - 1);
            textBoxAngle.Text = Angle.ToString();
            textBoxBetween.Text = Between.ToString();
            textBoxHeight.Text = Height.ToString();
            textBoxNumber.Text = Number.ToString();
        }

        private void FillComboBoxItems(ComboBox comboBox)
        {
            _comboItemsList = new List<ComboBoxItem>();
            var item0 = new ComboBoxItem {Content = "-- Some default values --"};
            var item1 = new ComboBoxItem {Content = "Height, number, angle"};
            var item2 = new ComboBoxItem {Content = "Height, inbetween height, angle"};
            var item3 = new ComboBoxItem {Content = "Inbetween height, number, angle"};
            _comboItemsList.Add(item0);
            _comboItemsList.Add(item1);
            _comboItemsList.Add(item2);
            _comboItemsList.Add(item3);

            foreach (var listItem in _comboItemsList)
            {
                comboBox.Items.Add(listItem);
            }

            comboBox.SelectedIndex = 0;
        }

        private void HeightTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            double newHeight;
            var newTextBoxValue = textBoxHeight.Text.Replace(',', '.');
            try
            {
                newHeight = BooEval.GetDouble(newTextBoxValue);
            }
            catch
            {
                return;
            }
            Height = newHeight;
            Preview();
        }

        private void Preview()
        {
            RecalculateValues();
            if (OnValueChange != null) OnValueChange();
        }

        private void NumberTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            int newNumber;
            try
            {
                newNumber = BooEval.GetInt32(textBoxNumber.Text);
            }
            catch
            {
                return;
            }
            Number = newNumber;
            Preview();
        }

        private void BetweenTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            double newBetween;
            var newTextBoxValue = textBoxBetween.Text.Replace(',', '.');
            try
            {
                newBetween = BooEval.GetDouble(newTextBoxValue);
            }
            catch
            {
                return;
            }
            Between = newBetween;
            Preview();
        }

        private void AngleTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            double newAngle;
            var newTextBoxValue = textBoxAngle.Text.Replace(',', '.');
            try
            {
                newAngle = BooEval.GetDouble(newTextBoxValue);
            }
            catch
            {
                return;
            }
            Angle = newAngle;
            Preview();
        }

        private void ApplyAngleChanges(double value)
        {
            RecalculateValues();
            if (OnValueChange != null) OnValueChange();
        }

        private void OkButtonExecuted(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing OK button from Circular Pattern. The parameters are: " + "Height->" + Height +
                     " ,Number of components->" + Number + " ,Height between components->" + Between + " ,Angle->" +
                     Angle);
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
            Log.Info("After pressing Cancel button from Circular Pattern window");
            Result = false;
            NotifyDialogClosed();
            Close();
        }

        private void ReverseDirectionClicked(object sender, RoutedEventArgs e)
        {
            Reverse = -1*Reverse;
            if (OnValueChange != null) OnValueChange();
        }

        public void RecalculateValues()
        {
            if (CurrentIndex == 1)
            {
                Between = Height/(Number - 1);
            }
            else if (CurrentIndex == 2)
            {
                if (Between < 1e-12 && Height > _distancePrecision)
                {
                    Number = 1;
                    return;
                }
                Number = (int) (Height/Between) + 2;
                if ((Height/Between - (int) (Height/Between)) < _distancePrecision)
                {
                    Number--;
                }
            }
            else if (CurrentIndex == 3)
            {
                Height = (Number - 1)*Between;
            }
        }

        private void PatternVariableSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PatternVariableSelector.SelectedIndex == 0)
            {
                SetAllTextBoxesToHidden();
                CurrentIndex = 0;
            }
            else if (PatternVariableSelector.SelectedIndex == 1)
            {
                RefreshTextBoxes();
                SetAllTextBoxesToVisible();
                textBoxBetween.Visibility = Visibility.Hidden;
                CurrentIndex = 1;
            }
            else if (PatternVariableSelector.SelectedIndex == 2)
            {
                RefreshTextBoxes();
                SetAllTextBoxesToVisible();
                textBoxNumber.Visibility = Visibility.Hidden;
                CurrentIndex = 2;
            }
            else if (PatternVariableSelector.SelectedIndex == 3)
            {
                RefreshTextBoxes();
                SetAllTextBoxesToVisible();
                textBoxHeight.Visibility = Visibility.Hidden;
                CurrentIndex = 3;
            }
        }

        private void RefreshTextBoxes()
        {
            textBoxAngle.Text = Angle.ToString("0.##");
            textBoxBetween.Text = Between.ToString("0.##");
            textBoxHeight.Text = Height.ToString("0.##");
            textBoxNumber.Text = Number.ToString();
        }

        private void SetAllTextBoxesToVisible()
        {
            textBoxAngle.Visibility = Visibility.Visible;
            textBoxBetween.Visibility = Visibility.Visible;
            textBoxHeight.Visibility = Visibility.Visible;
            textBoxNumber.Visibility = Visibility.Visible;
        }

        private void SetAllTextBoxesToHidden()
        {
            textBoxAngle.Visibility = Visibility.Hidden;
            textBoxBetween.Visibility = Visibility.Hidden;
            textBoxHeight.Visibility = Visibility.Hidden;
            textBoxNumber.Visibility = Visibility.Hidden;
        }
    }
}