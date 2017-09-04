#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace NaroSetup.Pages.Welcome
{
    /// <summary>
    ///   Interaction logic for TipsWindow.xaml
    /// </summary>
    public partial class TipsWindow
    {
        private const String TipsRelativePath = "/Wpf/TipsPages/";
        private static readonly string OptionsFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\NaroCAD\options.nxml";
            //Directory.GetCurrentDirectory() + @"\options.nxml";
        private readonly ActionsGraph _actionsGraph;
        private readonly Dictionary<int, string> _urlList = new Dictionary<int, string>();
        private int _currentUrlListvalue;

        public TipsWindow(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
            InitializeComponent();
            IntializeRedirecting();

            ShowHelp(_currentUrlListvalue);

            btnTipsNext.IsEnabled = true;
            btnTipsPrevious.IsEnabled = false;
        }

        #region Singleton Instance Property

        #endregion

        private void IntializeRedirecting()
        {
            var tipsDirectory = NaroAppConstantNames.InstallDirectory + TipsRelativePath;
            var directoryInfo = new DirectoryInfo(tipsDirectory);
            var rgFiles = directoryInfo.GetFiles("*.htm");
            var fileIndex = 0;
            foreach (var file in rgFiles)
            {
                _urlList.Add(fileIndex, file.Name);
                fileIndex++;
            }

            ShowHelp(0);
        }

        private void CbxShowTipsClick(object sender, RoutedEventArgs e)
        {
            if (cbxShowTips.IsChecked == null) return;
            var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            optionsSetup.UpdateSectionNode(OptionSectionNames.WelcomePageTitle).SetValue(0,
                                                                                         cbxShowTips.
                                                                                             IsChecked.
                                                                                             Value);
            optionsSetup.Commit("Changed Options Value");
            optionsSetup.SaveOptions(OptionsFile);
        }

        private void ShowHelp(int modifier)
        {
            if (_urlList.ContainsKey(modifier))
                tipsBrowser.Navigate(new Uri(NaroAppConstantNames.InstallDirectory + TipsRelativePath + _urlList[modifier]));
        }

        private void BtnTipsNextClick(object sender, RoutedEventArgs e)
        {
            ++_currentUrlListvalue;
            if (_urlList.Count == 0 || _currentUrlListvalue >= _urlList.Count) return;
            ShowHelp(_currentUrlListvalue);

            btnTipsNext.IsEnabled = _currentUrlListvalue != _urlList.Count - 1;

            if (_currentUrlListvalue > 0)
                btnTipsPrevious.IsEnabled = true;
        }

        private void BtnTipsPreviousClick(object sender, RoutedEventArgs e)
        {
            if (_currentUrlListvalue > 0)
            {
                ShowHelp(--_currentUrlListvalue);

                if (_currentUrlListvalue == 0)
                {
                    btnTipsPrevious.IsEnabled = false;
                }
            }

            if (_currentUrlListvalue < _urlList.Count - 1)
            {
                btnTipsNext.IsEnabled = true;
            }
        }
    }
}