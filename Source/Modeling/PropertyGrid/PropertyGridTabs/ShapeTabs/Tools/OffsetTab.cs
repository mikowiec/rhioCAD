#region Usings

using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Tools
{
    /// <summary>
    ///   Description of OffsetTab.
    /// </summary>
    public class OffsetTab : GridTabBase
    {
        private DoublePropertyTabItem _lengthProperty;

        public OffsetTab()
            : base(PropertyDescriptorsResources.TitleTabOffset)
        {
        }

        protected override void BuildInterface()
        {
            _lengthProperty = new DoublePropertyTabItem();
            _lengthProperty.OnSetValue += SetAngleValue;
            _lengthProperty.OnGetValue += GetAngleValue;
            PropertyListGenerator.AddProperty("Length", _lengthProperty);
        }

        private void GetAngleValue(ref object resultvalue)
        {
            resultvalue = Builder[1].Real;
        }

        private void SetAngleValue(object data)
        {
            BeginUpdate();
            Builder[1].Real = (double) data;
            EndVisualUpdate("Updated length");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _lengthProperty.SetTabOrder(tabIndex);
        }
    }
}