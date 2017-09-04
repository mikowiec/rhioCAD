#region Usings

using System.Windows;
using System.Windows.Controls;
using BooEvaluator.Boo;
using NaroConstants.Names;

#endregion

namespace NaroSetup.Pages.Welcome
{
    /// <summary>
    ///   Description of WelcomeOptionTab.
    /// </summary>
    public class WelcomeOptionsItem : OptionsItem
    {
        private Welcome _view;

        public WelcomeOptionsItem()
            : base(OptionSectionNames.WelcomePageTitle, "Welcome", "How to use Options")
        {
        }

        protected override Control PopulateChild()
        {
            _view = new Welcome();
            _view.cbxEnableTips.Click += CbxEnableTipsChecked;
            _view.cbxEnableContextualToolbar.Click += CbxEnableContextualToolbarChecked;
            _view.cbxEnableTreeViewIcons.Click += CbxEnableTreeViewIconsChecked;
            _view.cbxEnableBooEvaluation.Click += CbxEnableBooEvaluationChecked;
            return _view;
        }

        private void CbxEnableBooEvaluationChecked(object sender, RoutedEventArgs e)
        {
            var value = _view.cbxEnableBooEvaluation.IsChecked ?? false;
            Data.SetValue(3, value);
            BooEval.IsInterpreted = value;
        }

        private void CbxEnableTreeViewIconsChecked(object sender, RoutedEventArgs e)
        {
            Data.SetValue(2, _view.cbxEnableTreeViewIcons.IsChecked ?? false);
        }

        private void CbxEnableContextualToolbarChecked(object sender, RoutedEventArgs e)
        {
            Data.SetValue(1, _view.cbxEnableContextualToolbar.IsChecked ?? false);
        }

        private void CbxEnableTipsChecked(object sender, RoutedEventArgs e)
        {
            Data.SetValue(0, _view.cbxEnableTips.IsChecked ?? false);
        }

        public override void OnUpdateData()
        {
            if (_view == null) return;
            _view.cbxEnableTips.IsChecked = Data.GetBoolValue(0);
            _view.cbxEnableContextualToolbar.IsChecked = Data.GetBoolValue(1);
            _view.cbxEnableTreeViewIcons.IsChecked = Data.GetBoolValue(2);
            _view.cbxEnableBooEvaluation.IsChecked = Data.GetBoolValue(3);
            BooEval.IsInterpreted = Data.GetBoolValue(3);
        }

        public override void DefaultValues()
        {
            Data.SetValue(0, true);
            Data.SetValue(1, true);
            Data.SetValue(2, true);
            Data.SetValue(3, true);
            BooEval.IsInterpreted = true;
        }
    }
}