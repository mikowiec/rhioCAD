#region Usings

using System.Windows;
using System.Windows.Controls;
using NaroConstants.Names;

#endregion

namespace NaroSetup.Pages.Updater
{
    internal class UpdateOptionsItem : OptionsItem
    {
        private UpdateOptionsView _view;

        public UpdateOptionsItem()
            : base(OptionSectionNames.Updater, "Update", "Update to latest version")
        {
        }

        protected override Control PopulateChild()
        {
            _view = new UpdateOptionsView();
            _view.cbxUpdatesCheck.Click += CbxUpdatesCheckClick;
            _view.cbxExperimentalCheck.Click += CbxExperimentalCheckClick;
            return _view;
        }

        private void CbxExperimentalCheckClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue(1, _view.cbxExperimentalCheck.IsChecked ?? false);
        }

        private void CbxUpdatesCheckClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue(0, _view.cbxUpdatesCheck.IsChecked ?? false);
        }

        public override void OnUpdateData()
        {
            if (_view == null) return;
            _view.cbxUpdatesCheck.IsChecked = Data.GetBoolValue(0);
            _view.cbxExperimentalCheck.IsChecked = Data.GetBoolValue(1);
        }

        public override void DefaultValues()
        {
            Data.SetValue(0, true);
            Data.SetValue(1, false);
        }
    }
}