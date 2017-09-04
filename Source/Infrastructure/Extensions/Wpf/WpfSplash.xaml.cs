namespace Extensions.Wpf
{
    /// <summary>
    ///   Interaction logic for WpfSplash.xaml
    /// </summary>
    public partial class WpfSplash
    {
        private static WpfSplash _instance;

        public WpfSplash()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   Singleton instance
        /// </summary>
        public static WpfSplash Instance
        {
            get { return _instance ?? (_instance = new WpfSplash()); }
        }
    }
}