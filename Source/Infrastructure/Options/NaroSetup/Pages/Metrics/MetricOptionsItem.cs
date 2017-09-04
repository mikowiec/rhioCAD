#region Usings

using System.Windows;
using System.Windows.Controls;
using NaroConstants.Names;

#endregion

namespace NaroSetup.Pages.Metrics
{
    public class MetricOptionsItem : OptionsItem
    {
        private MetricsOptionsView _metricsOptionView;

        public MetricOptionsItem()
            : base(OptionSectionNames.MetricsPageTitle, "Metrics", "Metrics Options")
        {
        }

        protected override Control PopulateChild()
        {
            _metricsOptionView = new MetricsOptionsView();
            var result = _metricsOptionView;

            result.lbMetrics.SelectionChanged += LbMetricsSelectionChanged;

            return result;
        }

        public override void OnUpdateData()
        {
            if (_metricsOptionView == null) return;
            var ratio = Data.GetDoubleValue(0);
            _metricsOptionView.lbMetrics.SelectedIndex = MetricsFactory.Instance.GetClosestRatio(ratio);
        }

        private void CbxDefaultMetricsClick(object sender, RoutedEventArgs e)
        {
            if (_metricsOptionView == null) return;
        }

        private void LbMetricsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count <= 0) return;
            Data.SetValue(0, MetricsFactory.Instance.MetricQuotas[_metricsOptionView.lbMetrics.SelectedValue.ToString()]);
        }

        public override void DefaultValues()
        {
            Data.SetValue(0, MetricsFactory.Instance.MetricQuotas["Milimeters"]);
            Data.SetValue(0, true);
        }
    }
}