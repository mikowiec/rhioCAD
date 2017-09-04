#region Usings

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

#endregion

namespace Extensions.Wpf
{
    /// <summary>
    ///   Interaction logic for WpfSearchControl.xaml
    /// </summary>
    public partial class WpfSearchControl
    {
        #region Delegates

        public delegate void TokensChangedEvent();

        #endregion

        private readonly string _searchingText;

        private bool _searchText;

        public WpfSearchControl()
        {
            InitializeComponent();
            KeyTokens = new List<string>();

            _searchingText = "Filter by name...";
            tbxSearch.TextChanged += TbxSearchTextChanged;
            SetSearchText();
        }

        private List<string> KeyTokens { get; set; }

        public List<string> UpperKeyTokens
        {
            get
            {
                var result = new List<string>();
                foreach (var key in KeyTokens)
                {
                    result.Add(key.ToUpper());
                }
                return result;
            }
        }

        private void SetSearchText()
        {
            tbxSearch.Text = _searchingText;
            tbxSearch.FontSize = 10;
            tbxSearch.FontStyle = FontStyles.Italic;
            tbxSearch.Foreground = Brushes.DarkGray;
            tbxSearch.SelectionLength = 0;
        }

        private void TbxSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!_searchText) return;
            KeyTokens.Clear();
            var words = tbxSearch.Text.Split(' ');
            foreach (var word in words)
            {
                if (word.Length > 0)
                    KeyTokens.Add(word);
            }
            if (TokensChanged != null)
                TokensChanged();
        }

        private void DoFocusTextSearch()
        {
            _searchText = true;
            if (KeyTokens.Count == 0)
            {
                tbxSearch.Text = "";
            }
            tbxSearch.FontSize = 10;
            tbxSearch.FontStyle = FontStyles.Normal;
            tbxSearch.Foreground = Brushes.Black;
        }

        public event TokensChangedEvent TokensChanged;

        private void TbxSearchGotFocus(object sender, RoutedEventArgs e)
        {
            _searchText = true;
            DoFocusTextSearch();
        }

        private void TbxSearchLostFocus(object sender, RoutedEventArgs e)
        {
            _searchText = KeyTokens.Count > 0;
            if (!_searchText)
            {
                SetSearchText();
            }
        }

        private void ImageMouseUp(object sender, MouseButtonEventArgs e)
        {
            tbxSearch.Text = string.Empty;
        }
    }
}