#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Extensions.CustomControls
{
    public partial class SearchControl : UserControl
    {
        #region Delegates

        public delegate void TokensChangedEvent();

        #endregion

        public TokensChangedEvent TokensChanged;
        private string _defaultText;

        private bool _searchText;

        public SearchControl()
        {
            InitializeComponent();

            KeyTokens = new List<string>();

            SetSearchText();
        }

        public string DefaultText
        {
            private get { return _defaultText; }
            set
            {
                _defaultText = value;
                SetSearchText();
            }
        }

        private List<string> KeyTokens { get; set; }

        public IEnumerable<string> UpperKeyTokens
        {
            get
            {
                var result = new List<string>();
                foreach (var keyToken in KeyTokens)
                    result.Add(keyToken.ToUpper());
                return result;
            }
        }

        private void SetSearchText()
        {
            textBox1.Text = DefaultText;
            textBox1.Font = new Font("", 10, FontStyle.Italic);
            textBox1.ForeColor = Color.DarkGray;
            textBox1.SelectionLength = 0;
        }

        private void TextBox1TextChanged(object sender, EventArgs e)
        {
            if (!_searchText) return;
            KeyTokens.Clear();
            var words = textBox1.Text.Split(' ');
            foreach (var word in words)
            {
                if (word.Length > 0)
                    KeyTokens.Add(word);
            }
            if (TokensChanged != null)
            {
                TokensChanged();
            }
        }

        private void DoFocusTextSearch()
        {
            _searchText = true;
            if (KeyTokens.Count == 0)
            {
                textBox1.Text = "";
            }
            textBox1.Font = new Font("", 10, FontStyle.Regular);
            textBox1.ForeColor = Color.Black;
        }

        private void TextBox1Enter(object sender, EventArgs e)
        {
            _searchText = true;
            DoFocusTextSearch();
        }

        private void PictureBox1Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}