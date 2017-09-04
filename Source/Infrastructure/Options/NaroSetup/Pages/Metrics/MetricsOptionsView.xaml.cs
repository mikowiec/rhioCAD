namespace NaroSetup.Pages.Metrics
{
    /// <summary>
    ///   Interaction logic for MetricsOptionsView.xaml
    /// </summary>
    public partial class MetricsOptionsView
    {
        public MetricsOptionsView()
        {
            InitializeComponent();

            MetricsFactory.Instance.PopulateListBox(lbMetrics);
        }
    }
}