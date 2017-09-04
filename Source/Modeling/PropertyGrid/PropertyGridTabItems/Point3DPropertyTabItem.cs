#region Usings

using System.Windows.Controls;
using PropertyDescriptorsInterface;
using TreeData.AttributeInterpreter;

#endregion

namespace PropertyGridTabItems
{
    public class Point3DPropertyTabItem : PropertyTabItemBase
    {
        private Point3DTemplate _textBox;

        public override void FillControlEvents(DockPanel parentControl)
        {
            _textBox = new Point3DTemplate();
            _textBox.ChangeValueEvent += TextBoxTextChanged;
            parentControl.Children.Add(_textBox);
            UpdateFieldValue();
        }

        public override void Focus()
        {
            _textBox.OnFocus();
        }

        private void UpdateFieldValue()
        {
            object result = null;
            OnGetValue(ref result);
            if (result == null)
                return;
            _textBox.Value = (Point3D) result;
        }

        private void TextBoxTextChanged()
        {
            if (OnSetValue == null)
                return;
            OnSetValue(_textBox.Value);
        }

        public int SetTabOrder(int tabIndex)
        {
            _textBox.textBoxX.TabIndex = tabIndex;
            _textBox.textBoxY.TabIndex = tabIndex + 1;
            _textBox.textBoxZ.TabIndex = tabIndex + 2;
            return 3;
        }
    }
}