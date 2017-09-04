#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Interface.Views;
using NaroConstants.Names;
using NaroPipes.Constants;

#endregion

namespace PartModellingUi.Layout
{
    /// <summary>
    ///   Interaction logic for HelpView.xaml
    /// </summary>
    public partial class HelpView : IHelpView
    {
        private readonly SortedDictionary<string, string> _urlList = new SortedDictionary<string, string>();

        public HelpView()
        {
            InitializeComponent();
            IntializeRedirecting();
        }

        #region IHelpView Members

        public void ShowHelp(string modifier)
        {
            string baseFileName;
            if (!_urlList.TryGetValue(modifier, out baseFileName))
                baseFileName = modifier;
            var fullName = BuildFileName(baseFileName);
            Navigate(fullName);
        }

        #endregion

        private static string BuildFileName(string fileNameBase)
        {
            return NaroAppConstantNames.InstallDirectory + "\\Help\\" + fileNameBase + ".html";
        }

        private void Navigate(string fullName)
        {
            if (File.Exists(fullName))
                webBrowser.Navigate(new Uri(fullName));
        }

        private void IntializeRedirecting()
        {
            _urlList.Add(ModifierNames.AngleDraft, "AngleDraft");
            _urlList.Add(ModifierNames.AngleDraftEnhanced, "AngleDraft");

            _urlList.Add(ModifierNames.HiddenOn, "hidden");
            _urlList.Add(ModifierNames.HiddenOff, "hidden");

            ShowHelp(ModifierNames.None);
        }
    }
}