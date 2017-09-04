#region Usings

using System;
using System.IO;
using System.Windows;
using Application = System.Windows.Forms.Application;

#endregion

namespace TestBuilderPlugin.View
{
    /// <summary>
    ///   Interaction logic for BooHelpWindow.xaml
    /// </summary>
    public partial class BooHelpWindow
    {
        public BooHelpWindow()
        {
            InitializeComponent();

            var currentDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            WebBrowser.Source = new Uri(currentDirectory + "/Help/Boo/index.html");
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            if (WebBrowser.CanGoBack)
                WebBrowser.GoBack();
            else return;
        }

        private void ForwardButtonClick(object sender, RoutedEventArgs e)
        {
            if (WebBrowser.CanGoForward)
                WebBrowser.GoForward();
            else return;
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}