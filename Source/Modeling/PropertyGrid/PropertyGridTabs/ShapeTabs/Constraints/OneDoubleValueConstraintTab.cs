#region Usings

using NaroCppCore.Occ.Precision;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class OneDoubleValueConstraintTab : GridTabBase
    {
        private readonly string _itemTitle;

        protected OneDoubleValueConstraintTab(string title, string itemTitle)
            : base(title)
        {
            _itemTitle = itemTitle;
        }

        protected override void BuildInterface()
        {
            var lengthProperty = new DoublePropertyTabItem();
            lengthProperty.OnSetValue += SetValue;
            lengthProperty.OnGetValue += GetValue;
            PropertyListGenerator.AddProperty(_itemTitle, lengthProperty);
        }

        private void SetValue(object data)
        {
            var value = (double) data;
            if (value < Precision.Confusion)
                return;

            BeginUpdate();
            Builder[1].Real = value;
            Builder.ExecuteFunction();
            EndVisualUpdate("Changed constraint value");
        }

        private void GetValue(ref object data)
        {
            data = Builder[1].Real;
        }
    }
}