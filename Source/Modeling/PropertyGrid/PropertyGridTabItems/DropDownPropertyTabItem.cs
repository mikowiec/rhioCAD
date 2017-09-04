#region Usings

using System.Collections.Generic;
using System.Windows.Controls;
using PropertyDescriptorsInterface;

#endregion

namespace PropertyGridTabItems
{
    public class DropDownPropertyTabItem : PropertyTabItemBase
    {
        private readonly List<string> _items;
        private DropDownTemplate _comboBox;
        private bool _disableSelection;

        public DropDownPropertyTabItem(List<string> items)
        {
            _items = items;
        }

        public override void FillControlEvents(DockPanel parentControl)
        {
            _comboBox = new DropDownTemplate();
            parentControl.Children.Add(_comboBox);
            _comboBox.ChangeValueEvent += DropDownSelectedChanged;
            UpdateFieldValue();
        }

        public override void Focus()
        {
            _comboBox.OnFocus();
        }

        private void AddItem(string itemName)
        {
            _comboBox.dropDown.Items.Add(itemName);
        }

        private void UpdateFieldValue()
        {
            object result = null;
            OnGetValue(ref result);
            _comboBox.dropDown.Items.Clear();
            foreach (var item in _items)
                AddItem(item);
            _disableSelection = true;
            _comboBox.SetSelectedIndex((int) result);
            _disableSelection = false;
        }


        private void DropDownSelectedChanged()
        {
            if (OnSetValue == null || _disableSelection)
                return;

            OnSetValue(_comboBox.GetSelectedIndex());
        }

        public int SetTabOrder(int tabIndex)
        {
            _comboBox.TabIndex = tabIndex;
            return 1;
        }

        // public int GetNumberOfChildren()
        // {
        //     return 1;
        // }
    }
}