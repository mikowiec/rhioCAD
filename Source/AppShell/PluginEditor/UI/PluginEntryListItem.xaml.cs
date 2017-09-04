#region Usings

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

#endregion

namespace PluginEditor.UI
{
    /// <summary>
    ///   Lógica de interacción para PluginEntryListItem.xaml
    /// </summary>
    public partial class PluginEntryListItem
    {
        #region Delegates

        public delegate void OnChanged();

        #endregion

        private const string CloseImgName = "/Resources;component/Resources/close-icon.png";
        private const string AvailableImgName = "/Resources;component/Resources/update-available.png";

        private readonly SortedDictionary<PluginState, string> _imageStates =
            new SortedDictionary<PluginState, string>();

        private readonly PluginDescription _pluginDescription;

        public OnChanged Changed;

        public PluginEntryListItem(PluginDescription pluginDescription)
        {
            _pluginDescription = pluginDescription;
            InitializeComponent();

            MapImageState();
            TextName.Text = _pluginDescription.Name;
            CheckEnabled.IsChecked = _pluginDescription.Enabled;
        }

        public PluginDescription PluginDescription
        {
            get { return _pluginDescription; }
        }

        private void MapImageState()
        {
            _imageStates.Add(PluginState.Available, AvailableImgName);
            _imageStates.Add(PluginState.Removable, CloseImgName);
            UpdateImageState();
        }

        private void UpdateImageState()
        {
            var imageState = _imageStates[_pluginDescription.State];
            SetImage(updateAvailableImg, imageState);
            CheckEnabled.Visibility = _pluginDescription.State == PluginState.Removable
                                          ? Visibility.Visible
                                          : Visibility.Hidden;
        }

        private static void SetImage(Image image, string iconName)
        {
            image.Source = new BitmapImage(new Uri(iconName, UriKind.RelativeOrAbsolute));
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _pluginDescription.State = _pluginDescription.State == PluginState.Removable
                                           ? PluginState.Available
                                           : PluginState.Removable;

            UpdateImageState();
            StateChanged();
        }

        private void StateChanged()
        {
            if (Changed != null)
                Changed();
        }

        private void CheckEnabledClick(object sender, RoutedEventArgs e)
        {
            var checkValue = CheckEnabled.IsChecked ?? false;
            _pluginDescription.Enabled = checkValue;
            StateChanged();
        }
    }
}