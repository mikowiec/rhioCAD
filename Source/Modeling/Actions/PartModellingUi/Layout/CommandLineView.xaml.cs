#region Usings

using System.Windows.Controls;
using System.Windows.Input;

#endregion

namespace PartModellingUi.Layout
{
    /// <summary>
    ///   Interaction logic for CommandLineView.xaml
    /// </summary>
    public partial class CommandLineView
    {
        #region Delegates

        public delegate void OnTextEditEvent(string text);

        #endregion

        public OnTextEditEvent OnTextChanged;
        public OnTextEditEvent OnTextEnter;

        public CommandLineView()
        {
            InitializeComponent();
        }

        public TextBox EditTextBox
        {
            get { return editTextBox; }
        }

        public void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter || OnTextEnter == null) return;
            OnTextEnter(editTextBox.Text);
            editTextBox.Text = string.Empty;
        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back || e.Key == Key.Enter)
                return;
            if (OnTextChanged != null)
                OnTextChanged(editTextBox.Text);
        }

        public void SetHintText(string hintText)
        {
            hintLabel.Content = hintText;
        }

        public void SetEditingText(string hintText)
        {
            if (hintText == editTextBox.Text)
                return;
            editTextBox.Text = hintText;
            editTextBox.CaretIndex = hintText.Length;
        }
    }
}