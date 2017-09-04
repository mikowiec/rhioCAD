#region Usings

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using NaroConstants.Names;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSetup.Pages.Occ
{
    /// <summary>
    ///   Description of OccOptionsItem.
    /// </summary>
    public class OccOptionsItem : OptionsItem
    {
        private const double DefaultZoomRatio = 0.2;
        private double _actualRatio;
        private OccOptionsView _view;

        public OccOptionsItem()
            : base(OptionSectionNames.Background, "Opencascade", "Customizations of opencascade views")
        {
        }

        protected override Control PopulateChild()
        {
            _view = new OccOptionsView();
            _view.firstCP.SelectedColorChanged += BackgroundSelectedColorChanged;
            _view.secondCp.SelectedColorChanged += SetLowerColor;
            _view.customCP2.SelectedColorChanged += CustomCpSelectedColorChanged2;
            _view.cbAntialiasing.Click += AntialiasingChanged;
            _view._zoomRatioTextBox.KeyUp += OnZoomKeyUp;
            _view._zoomRatioTextBox.Text = _actualRatio < 1e-12 ? DefaultZoomRatio.ToString() : _actualRatio.ToString();
            return _view;
        }

        private void OnZoomKeyUp(object sender, KeyEventArgs e)
        {
            var zoomRatioText = _view._zoomRatioTextBox.Text;
            double ratio;
            try
            {
                ratio = Convert.ToDouble(zoomRatioText);
                _actualRatio = Convert.ToDouble(zoomRatioText);
            }
            catch (Exception)
            {
                return;
            }
            Data.SetValue(3, ratio);
        }

        private void AntialiasingChanged(object sender, RoutedEventArgs e)
        {
            if (_view.cbAntialiasing.IsChecked != null) Data.SetValue(2, _view.cbAntialiasing.IsChecked.Value);
        }

        private void CustomCpSelectedColorChanged2(Color obj)
        {
            Data.SetValue(1, obj);
        }

        private void BackgroundSelectedColorChanged(Color obj)
        {
            var firstColor = obj;
            Data.SetValue(4, firstColor);
        }

        private void SetLowerColor(Color obj)
        {
            var secondColor = obj;
            Data.SetValue(5, secondColor);
        }

        public override void OnUpdateData()
        {
            if (_view == null) return;
            _view.cbAntialiasing.IsChecked = Data.GetBoolValue(2);
            _view._zoomRatioTextBox.Text = Data.GetDoubleValue(3).ToString();

            _view.firstCP.SelectedColor = ShapeUtils.ToWpfColor(Data.GetColorValue(4));
            _view.secondCp.SelectedColor = ShapeUtils.ToWpfColor(Data.GetColorValue(5));
        }

        public override void DefaultValues()
        {
            Data.SetValue(4, System.Drawing.Color.FromArgb(25, 25, 255));
            Data.SetValue(5, System.Drawing.Color.FromArgb(125, 125, 255));
            Data.SetValue(1, System.Drawing.Color.DarkTurquoise);
            Data.SetValue(2, false);
            Data.SetValue(3, DefaultZoomRatio);
            _actualRatio = 0;
        }
    }
}