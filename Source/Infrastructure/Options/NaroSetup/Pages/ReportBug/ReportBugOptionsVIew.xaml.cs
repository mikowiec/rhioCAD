#region Usings

using System.Diagnostics;
using System.Windows.Navigation;

#endregion

namespace NaroSetup.Pages.ReportBug
{
    /// <summary>
    ///   Interaction logic for ReportBugOptionsVIew.xaml
    /// </summary>
    public partial class ReportBugOptionsVIew
    {
        public ReportBugOptionsVIew()
        {
            InitializeComponent();
        }

        private void HyperlinkRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}