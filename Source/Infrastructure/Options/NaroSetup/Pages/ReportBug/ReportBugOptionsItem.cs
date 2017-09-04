#region Usings

using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using ErrorReportCommon;
using NaroConstants.Names;

#endregion

namespace NaroSetup.Pages.ReportBug
{
    /// <summary>
    ///   Description of ReportBugOptionsItem.
    /// </summary>
    public class ReportBugOptionsItem : OptionsItem
    {
        private ReportBugOptionsVIew _reportBugOptionsView;

        public ReportBugOptionsItem()
            : base("ReportBug", "Report Bug", "Report Bug Options")
        {
        }

        protected override Control PopulateChild()
        {
            _reportBugOptionsView = new ReportBugOptionsVIew();
            var result = _reportBugOptionsView;

            result.btnReportABug.Click += BtnReportABugClick;
            result.lnkWebsite.Click += LnkWebsiteClick;
            result.lnkSourceForge.Click += LnkSourceForgeClick;
            result.lnkOpenCascade.Click += LnkOpenCascadeClick;
            result.lnkBlog.Click += LnkBlogClick;
            result.lnkStartTutorial.Click += LnkStartTutorialClick;

            return result;
        }

        private static void BtnReportABugClick(object sender, RoutedEventArgs e)
        {
            StarterUtils.SendBugReport(new ReportingForm());
        }

        private static void LnkWebsiteClick(object sender, RoutedEventArgs e)
        {
            Process.Start(NaroAppConstantNames.Website);
        }

        private static void LnkSourceForgeClick(object sender, RoutedEventArgs e)
        {
            Process.Start(NaroAppConstantNames.BlogWebsite);
        }

        private static void LnkOpenCascadeClick(object sender, RoutedEventArgs e)
        {
            Process.Start(NaroAppConstantNames.OpenCascadeWebSite);
        }

        private static void LnkBlogClick(object sender, RoutedEventArgs e)
        {
            Process.Start(NaroAppConstantNames.BlogWebsite);
        }

        private static void LnkStartTutorialClick(object sender, RoutedEventArgs e)
        {
            Process.Start(NaroAppConstantNames.TutorialFile);
        }
    }
}