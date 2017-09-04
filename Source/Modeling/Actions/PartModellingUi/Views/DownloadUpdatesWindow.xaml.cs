#region Usings

using System;
using System.Collections.Generic;
using System.Windows;
using log4net;
using Naro.Infrastructure.Interface.Views.Timers;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroSetup;

#endregion

namespace PartModellingUi.Views
{
    /// <summary>
    ///   Lógica de interacción para ArrayPatternWindow.xaml
    /// </summary>
    public partial class DownloadUpdatesWindow
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");
        private static ActionsGraph _actionGraph;
        private static bool _nightlyDownload;
        private static UIElement _control;

        private bool _choice;

        public DownloadUpdatesWindow(List<string> features, ActionsGraph actionGraph, bool nightlyDownload,
                                     UIElement control)
        {
            _control = control;
            InitializeComponent();
            AddFeatures(features);
            _actionGraph = actionGraph;
            _nightlyDownload = nightlyDownload;
            TimerTaskManager.Instance.AddTask("neverSetup", OnNever);
        }

        public bool Choice
        {
            private set { _choice = value; }
            get { return _choice; }
        }

        private void OnNever(object sender, EventArgs e)
        {
            _control.Dispatcher.BeginInvoke(new Action(delegate { ClickNeverButtonLogic(); }));
        }

        private void ClickNeverButtonLogic()
        {
            Log.Info("After pressing Never button from DownloadUpdates window");
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.Updater);
            optionsSetup.Document.Transact();
            if (_nightlyDownload)
            {
                optionsSection.SetValue(1, false);
                optionsSetup.Document.Commit("Changed options");
            }
            else
            {
                optionsSection.SetValue(0, false);
                optionsSetup.Document.Commit("Changed options");
            }
        }

        private void AddFeatures(List<string> features)
        {
            var firstFeature = true;
            foreach (var feature in features)
            {
                if (!firstFeature)
                {
                    NewFeatures.Text += Environment.NewLine;
                }
                NewFeatures.Text += feature;
                firstFeature = false;
            }
        }

        private void NowButtonClick(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Now button from DownloadUpdates window");
            _choice = true;
            Close();
        }

        private void NextButtonExecuted(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Next time button from DownloadUpdates window");
            Close();
        }

        private void NeverButtonExecuted(object sender, RoutedEventArgs e)
        {
            TimerTaskManager.Instance.StartTimer("neverSetup", 1);
            Close();
        }

        protected void OnClosed(object sender, EventArgs e)
        {
            Log.Info("After pressing Never button from DownloadUpdates window");
            Close();
        }
    }
}