#region Usings

using System.Collections.Generic;
using System.Windows;
using System.Windows.Threading;
using NaroPipes.Actions;

#endregion

namespace PartModellingUi.Views
{
    public static class UpdaterWindowsManager
    {
        public static NotificationWindow DownloadFinishedWindow;
        public static DownloadUpdatesWindow DownloadUpdatesWindow { get; private set; }

        public static void ShowWindow(List<string> features, ActionsGraph _actionGraph, bool nightlyDownload,
                                      UIElement control)
        {
            DownloadUpdatesWindow = new DownloadUpdatesWindow(features, _actionGraph, nightlyDownload, control);
        }

        public static void DownloadWindowLoop()
        {
            DownloadUpdatesWindow.Show();
            Dispatcher.Run();
        }

        public static void ShowDownloadsFinishedWindow(List<string> strings)
        {
            DownloadFinishedWindow = new NotificationWindow(strings);
        }

        public static void DownloadFinishedLoop()
        {
            DownloadFinishedWindow.Show();
            Dispatcher.Run();
        }
    }
}