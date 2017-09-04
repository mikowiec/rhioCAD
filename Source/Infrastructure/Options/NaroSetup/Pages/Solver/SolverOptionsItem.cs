#region Usings

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BooEvaluator.Boo;
using NaroConstants.Names;

#endregion

namespace NaroSetup.Pages.Solver
{
    public class SolverOptionsItem : OptionsItem
    {
        private SolverOptionsView _solverOptionsView;

        public SolverOptionsItem()
            : base(OptionSectionNames.SolverPageTitle, "Hinter", "Sensitivity Options")
        {
        }

        protected override Control PopulateChild()
        {
            _solverOptionsView = new SolverOptionsView();
            var view = _solverOptionsView;

            view.cbxAlignToPoints.Click += CbxAlignToPointsClick;
            view.tbxDistance.KeyUp += TbxDistanceTextChanged;
            view.cbxDetectParallelLines.Click += CbxDetectParallelLinesClick;
            view.tbxAngularPrec.TextChanged += TbxAngularPrecTextChanged;
            view.cbxPlaneMatch.Click += CbxPlaneMatchClick;
            view.cbxEdgeMatch.Click += CbxEdgeMatchClick;
            view.cbxEdgeIntersectionMatch.Click += CbxEdgeIntersectMatchClick;
            view.cbxEdgeContMatch.Click += CbxEdgeContMatchClick;
            view.cbxSameCoordinateMatch.Click += CbxSameCoordinateMatchClick;

            view.cbxHorVerSensitivity.Click += CbxHorVerSensitivityClick;
            view.tbxSensitivityPrecision.TextChanged += TbxSensitivityPrecisionTextChanged;

            view.cbxPolarSensitivity.Click += CbxPolarSensitivityClick;
            view.tbxPolarAngle.TextChanged += TbxPolarAngleTextChanged;
            view.cbxPolarAngle.SelectionChanged += CbxPolarAngleSelectionChanged;

            view.tbxXIncrement.TextChanged += TbxXIncrementOnTextChanged;
            view.tbxYIncrement.TextChanged += TbxYIncrementOnTextChanged;
            view.tbxZIncrement.TextChanged += TbxZIncrementOnTextChanged;
            return view;
        }

        private void TbxZIncrementOnTextChanged(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            Data.SetDouble((int)HinterOptionFields.ZIncrement, _solverOptionsView.tbxZIncrement);
        }

        private void TbxYIncrementOnTextChanged(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            Data.SetDouble((int)HinterOptionFields.YIncrement, _solverOptionsView.tbxYIncrement);
        }

        private void TbxXIncrementOnTextChanged(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            Data.SetDouble((int)HinterOptionFields.XIncrement, _solverOptionsView.tbxXIncrement);
        }

        private void CbxPolarAngleSelectionChanged(object sender, SelectionChangedEventArgs selectionChangedEventArgs)
        {
            var view = _solverOptionsView;
            switch (view.cbxPolarAngle.SelectedIndex)
            {
                case 0:
                    view.tbxPolarAngle.Text = "45.0";
                    break;
                case 1:
                    view.tbxPolarAngle.Text = "30.0";
                    break;
                case 2:
                    view.tbxPolarAngle.Text = "60.0";
                    break;
                case 3:
                    view.tbxPolarAngle.Text = "90.0";
                    break;
            }
        }

        public override void OnUpdateData()
        {
            if (View == null)
                return;
            var result = _solverOptionsView;
            result.cbxAlignToPoints.IsChecked = Data.GetBoolValue((int) HinterOptionFields.PointMatch);
            result.tbxDistance.Text =
                Data.GetDoubleValue((int) HinterOptionFields.PointMatch).ToString(CultureInfo.InvariantCulture);

            result.cbxDetectParallelLines.IsChecked = Data.GetBoolValue((int) HinterOptionFields.ParallelMatch);
            result.tbxAngularPrec.Text =
                Data.GetDoubleValue((int) HinterOptionFields.ParallelMatch).ToString(CultureInfo.InvariantCulture);

            result.cbxPlaneMatch.IsChecked = Data.GetBoolValue((int) HinterOptionFields.PlaneMatch);
            result.cbxEdgeMatch.IsChecked = Data.GetBoolValue((int) HinterOptionFields.EdgeMatch);
            result.cbxEdgeContMatch.IsChecked = Data.GetBoolValue((int) HinterOptionFields.EdgeContinuationMatch);
            result.cbxEdgeIntersectionMatch.IsChecked = Data.GetBoolValue((int) HinterOptionFields.EdgeIntersectionMatch);
            result.cbxSameCoordinateMatch.IsChecked = Data.GetBoolValue((int)HinterOptionFields.SameCoordinateMatch);
            result.cbxHorVerSensitivity.IsChecked = Data.GetBoolValue((int) HinterOptionFields.HorizontalVerticalMatch);
            result.tbxSensitivityPrecision.Text =
                Data.GetDoubleValue((int) HinterOptionFields.HorizontalVerticalMatch).ToString(
                    CultureInfo.InvariantCulture);

            result.cbxPolarSensitivity.IsChecked = Data.GetBoolValue((int) HinterOptionFields.PolarMatch);
            result.tbxPolarAngle.Text =
                Data.GetDoubleValue((int) HinterOptionFields.PolarAngleValue).ToString(CultureInfo.InvariantCulture);

            result.tbxXIncrement.Text = Data.GetDoubleValue((int)HinterOptionFields.XIncrement).ToString(CultureInfo.InvariantCulture);
            result.tbxYIncrement.Text = Data.GetDoubleValue((int)HinterOptionFields.YIncrement).ToString(CultureInfo.InvariantCulture);
            result.tbxZIncrement.Text = Data.GetDoubleValue((int)HinterOptionFields.ZIncrement).ToString(CultureInfo.InvariantCulture);

        }

        #region Dialog Event Handlers

        private void CbxAlignToPointsClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue((int) HinterOptionFields.PointMatch, _solverOptionsView.cbxAlignToPoints.IsChecked ?? false);
        }

        private void TbxDistanceTextChanged(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.Key != Key.Enter) return;
            var value = BooEval.GetDouble(_solverOptionsView.tbxDistance.Text);
            _solverOptionsView.tbxDistance.Text = value.ToString();
            Data.SetValue((int) HinterOptionFields.PointMatch, value);
        }

        private void CbxDetectParallelLinesClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue((int) HinterOptionFields.ParallelMatch, _solverOptionsView.cbxDetectParallelLines);
        }

        private void TbxAngularPrecTextChanged(object sender, TextChangedEventArgs e)
        {
            Data.SetDouble((int) HinterOptionFields.ParallelMatch, _solverOptionsView.tbxAngularPrec);
        }

        private void CbxPlaneMatchClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue((int) HinterOptionFields.PlaneMatch, _solverOptionsView.cbxPlaneMatch);
        }

        private void CbxEdgeMatchClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue((int) HinterOptionFields.EdgeMatch, _solverOptionsView.cbxEdgeMatch);
        }

        private void CbxSameCoordinateMatchClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue((int)HinterOptionFields.SameCoordinateMatch, _solverOptionsView.cbxSameCoordinateMatch);
        }

        private void CbxEdgeContMatchClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue((int) HinterOptionFields.EdgeContinuationMatch,
                          _solverOptionsView.cbxEdgeContMatch.IsChecked ?? false);
        }


        private void TbxSensitivityPrecisionTextChanged(object sender, TextChangedEventArgs e)
        {
            var value = BooEval.GetDouble(_solverOptionsView.tbxSensitivityPrecision.Text);

            Data.SetValue((int) HinterOptionFields.HorizontalVerticalMatch, value);
        }

        private void CbxHorVerSensitivityClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue((int) HinterOptionFields.HorizontalVerticalMatch,
                          _solverOptionsView.cbxHorVerSensitivity);
        }

        private void TbxPolarAngleTextChanged(object sender, TextChangedEventArgs e)
        {
            var value = BooEval.GetDouble(_solverOptionsView.tbxPolarAngle.Text);
            Data.SetValue((int) HinterOptionFields.PolarAngleValue, value);
        }

        private void CbxPolarSensitivityClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue((int) HinterOptionFields.PolarMatch, _solverOptionsView.cbxPolarSensitivity);
        }

        private void CbxEdgeIntersectMatchClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue((int) HinterOptionFields.EdgeIntersectionMatch,
                          _solverOptionsView.cbxEdgeIntersectionMatch);
        }

        public override void DefaultValues()
        {
            Data.SetValue((int) HinterOptionFields.OrthogonalMatch, true);
            Data.SetValue((int) HinterOptionFields.PointMatch, true);
            Data.SetValue((int) HinterOptionFields.PointMatch, 2.0);
            Data.SetValue((int) HinterOptionFields.ParallelMatch, true);
            Data.SetValue((int) HinterOptionFields.ParallelMatch, 5.0/180*Math.PI);
            Data.SetValue((int) HinterOptionFields.PlaneMatch, true);
            Data.SetValue((int) HinterOptionFields.EdgeMatch, true);
            Data.SetValue((int) HinterOptionFields.EdgeContinuationMatch, true);
            Data.SetValue((int) HinterOptionFields.HorizontalVerticalMatch, true);
            Data.SetValue((int) HinterOptionFields.HorizontalVerticalMatch, 2.0);
            Data.SetValue((int) HinterOptionFields.EdgeIntersectionMatch, false);
            Data.SetValue((int) HinterOptionFields.PolarAngleValue, 45.0);
            Data.SetValue((int) HinterOptionFields.PolarMatch, true);
            Data.SetValue((int)HinterOptionFields.SameCoordinateMatch, true);
            Data.SetValue((int)HinterOptionFields.XIncrement, 0);
            Data.SetValue((int)HinterOptionFields.YIncrement, 0);
            Data.SetValue((int)HinterOptionFields.ZIncrement, 0);
        }

        #endregion
    }
}