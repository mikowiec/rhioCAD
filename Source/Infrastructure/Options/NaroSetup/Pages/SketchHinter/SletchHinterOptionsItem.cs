#region Usings

using System;
using System.Windows.Controls;
using Extensions.Wpf;
using NaroConstants.Names;

#endregion

namespace NaroSetup.Pages.SketchHinter
{
    internal class SletchHinterOptionsItem : OptionsItem
    {
        private SketchHinterOptionsView _autoSaveOptionsView;

        public SletchHinterOptionsItem()
            : base(OptionSectionNames.SketchHinterPageTitle, "Sketch Hinter", "Sensitivity Values")
        {
        }

        protected override Control PopulateChild()
        {
            _autoSaveOptionsView = new SketchHinterOptionsView();
            var result = _autoSaveOptionsView;
            result.PointPrecision.ValueChanged += OnValueChanged;
            result.AnglePrecision.ValueChanged += OnValueChanged;
            return result;
        }

        private void OnValueChanged()
        {
            var result = _autoSaveOptionsView;
            Data.SetValue(0, result.PointPrecision.Value);
            Data.SetValue(1, result.AnglePrecision.Value);
        }

        public override void OnUpdateData()
        {
            if (_autoSaveOptionsView == null) return;
            var result = _autoSaveOptionsView;
            result.PointPrecision.Value = Data.GetDoubleValue(0);
            result.AnglePrecision.Value = Data.GetDoubleValue(1);
        }

        public override void DefaultValues()
        {
            Data.SetValue(0, 1.0);
            Data.SetValue(1, 1.0);
        }
    }
}