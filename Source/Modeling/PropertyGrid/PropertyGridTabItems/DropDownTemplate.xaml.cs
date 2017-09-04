#region Usings

using System.Windows;
using System.Windows.Controls;

#endregion

namespace PropertyGridTabItems
{
    /// <summary>
    ///   Interaction logic for DropDownTemplate.xaml
    /// </summary>
    public partial class DropDownTemplate
    {
        #region Delegates

        public delegate void OnChangeValue();

        #endregion

        public OnChangeValue ChangeValueEvent;

        public DropDownTemplate()
        {
            InitializeComponent();
            Margin = new Thickness(26, 0, 7, 0);
        }

        private object Value
        {
            set { dropDown.SelectedItem = value; }
        }

        public void OnFocus()
        {
            dropDown.Focus();
        }

        private void DropDownSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Value = dropDown.SelectedItem;
            ChangeValueEvent();
        }

        public void SetSelectedIndex(int index)
        {
            dropDown.SelectedIndex = index;
        }

        public int GetSelectedIndex()
        {
            return dropDown.SelectedIndex;
        }
    }
}