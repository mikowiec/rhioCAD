#region Usings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

#endregion

namespace NaroSetup
{
    public partial class OptionsWindow
    {
        public static readonly string OptionsFile =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\NaroCAD\options.nxml";
            //Directory.GetCurrentDirectory() + @"\options.nxml";

        private readonly Brush _gradient;
        private readonly Brush _gradientHover;
        private readonly SortedDictionary<string, LabelItem> _items = new SortedDictionary<string, LabelItem>();
        private readonly Brush _transparent;
        private string _selectedItem;

        public OptionsWindow()
        {
            InitializeComponent();
            _gradient = new LinearGradientBrush
                            {
                                StartPoint = new Point(0, 0),
                                EndPoint = new Point(0, 1),
                                GradientStops = new GradientStopCollection
                                                    {
                                                        new GradientStop(Colors.White, 0),
                                                        new GradientStop(Colors.LightGray, 0.3),
                                                        new GradientStop(Colors.LightBlue, 1)
                                                    }
                            };
            _gradientHover = new LinearGradientBrush
                                 {
                                     StartPoint = new Point(0, 0),
                                     EndPoint = new Point(0, 1),
                                     GradientStops = new GradientStopCollection
                                                         {
                                                             new GradientStop(Color.FromArgb(255, 127, 200, 230), 0),
                                                             new GradientStop(Color.FromArgb(255, 200, 230, 255), 0.3),
                                                             new GradientStop(Color.FromArgb(255, 127, 200, 230), 1)
                                                         }
                                 };
            OptionsSetup.Instance.Document.Transact();
            _transparent = new SolidColorBrush(Colors.Transparent);
        }

        public void BuildSections(IEnumerable<OptionsItem> items)
        {
            _items.Clear();
            SectionItemsPanel.Children.Clear();
            foreach (var optionsItem in items)
            {
                var labelItem = new LabelItem();
                labelItem.Build(optionsItem);
                _items[optionsItem.Name] = labelItem;
                labelItem.ChangedEvent += OnChanged;
                var label = labelItem.Label;
                label.MouseUp += delegate { SelectedNewItem(labelItem, label); };
                label.MouseMove += delegate
                                       {
                                           label.Background = _selectedItem == labelItem.Item.Name
                                                                  ? _gradient
                                                                  : _gradientHover;
                                           label.FontWeight = _selectedItem == labelItem.Item.Name
                                                                  ? FontWeights.Bold
                                                                  : FontWeights.Normal;
                                       };
                label.MouseLeave += delegate
                                        {
                                            label.Background = _selectedItem == labelItem.Item.Name
                                                                   ? _gradient
                                                                   : _transparent;
                                            label.FontWeight = _selectedItem == labelItem.Item.Name
                                                                   ? FontWeights.Bold
                                                                   : FontWeights.Normal;
                                        };
                SectionItemsPanel.Children.Add(label);
            }
        }

        private void SelectedNewItem(LabelItem labelItem, TextBlock label)
        {
            labelItem.ChangedEvent(labelItem.Item.Name);
            if (!string.IsNullOrEmpty(_selectedItem))
            {
                _items[_selectedItem].Label.Background = _transparent;
                _items[_selectedItem].Label.FontWeight = FontWeights.Normal;
            }
            _selectedItem = labelItem.Item.Name;
            label.Background = _gradient;
        }

        private static void OnChanged(string name)
        {
            OptionsSetup.Instance.ShowOptions(name);
        }


        public void SetHeader(string title, string description)
        {
            labelPageTitle.Text = title;
            labelPageDescription.Text = description;
        }

        internal void PopulateChildView(OptionsItem item)
        {
            _containerPanel.Children.Clear();
            item.BuidView();
            _containerPanel.Children.Add(item.View);
        }

        private void Window1Closing(object sender, CancelEventArgs cancelEventArgs)
        {
            OptionsSetup.Instance.SaveOptions(OptionsFile);
            OptionsSetup.Instance.CleanupView();
        }

        private void SetDefaultsClick(object sender, RoutedEventArgs e)
        {
            OptionsSetup.Instance.SetDefaultOptions();
        }

        private void OnOkClick(object sender, RoutedEventArgs e)
        {
            ApplyChanges();
            Close();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            OptionsSetup.Instance.Document.Revert();
            Close();
        }


        private static void ApplyChanges()
        {
            OptionsSetup.Instance.Commit("Changed Options Value");
            OptionsSetup.Instance.SaveOptions(OptionsFile);
            OptionsSetup.Instance.Document.Transact();
        }

        private void OnApplyClick(object sender, RoutedEventArgs e)
        {
            ApplyChanges();
        }

        #region Nested type: LabelItem

        private class LabelItem
        {
            #region Delegates

            public delegate void OnChangedEvent(string name);

            #endregion

            public OnChangedEvent ChangedEvent;
            public OptionsItem Item { get; private set; }
            public TextBlock Label { get; private set; }

            public void Build(OptionsItem item)
            {
                Item = item;
                Label = new TextBlock
                            {
                                Text = Item.Title,
                                Foreground = Brushes.Black,
                                FontFamily = new FontFamily("Verdana"),
                                FontSize = 11,
                                Padding = new Thickness(30, 2, 0, 2)
                            };
            }
        }

        #endregion
    }
}