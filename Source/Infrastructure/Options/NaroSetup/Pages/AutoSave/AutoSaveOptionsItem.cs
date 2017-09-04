#region Usings

using System.Windows;
using System.Windows.Controls;
using NaroConstants.Names;

#endregion

namespace NaroSetup.Pages.AutoSave
{
    /// <summary>
    ///   Description of AutoSaveOptionsItem.
    /// </summary>
    public class AutoSaveOptionsItem : OptionsItem
    {
        private AutoSaveOptionsView _autoSaveOptionsView;

        public AutoSaveOptionsItem()
            : base(OptionSectionNames.AutoSavePageTitle, "Auto Save", "Auto Save Options")
        {
        }

        protected override Control PopulateChild()
        {
            _autoSaveOptionsView = new AutoSaveOptionsView();
            var result = _autoSaveOptionsView;
            result.cbxAutoSave.IsChecked = Data.GetBoolValue(0);
            result.cbxAutoSave.Click += CbxAutoSaveClick;
            return result;
        }

        public override void OnUpdateData()
        {
            if (_autoSaveOptionsView == null) return;
            _autoSaveOptionsView.cbxAutoSave.IsChecked = Data.GetBoolValue(0);
        }

        public override void DefaultValues()
        {
            Data.SetValue(0, true);
        }

        private void CbxAutoSaveClick(object sender, RoutedEventArgs e)
        {
            Data.SetValue(0, _autoSaveOptionsView.cbxAutoSave.IsChecked ?? false);
        }
    }
}