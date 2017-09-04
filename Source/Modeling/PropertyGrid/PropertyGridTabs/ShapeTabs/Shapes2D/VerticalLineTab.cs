#region Usings

using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes2D
{
    public class VerticalLineTab : GridTabBase
    {
        private DoublePropertyTabItem _lengthProperty;

        public VerticalLineTab()
            : base(PropertyDescriptorsResources.TabTitleVerticalLine)
        {
        }

        protected override void BuildInterface()
        {
            _lengthProperty = new DoublePropertyTabItem();
            _lengthProperty.OnSetValue += SetYValue;
            _lengthProperty.OnGetValue += GetYValue;
            PropertyListGenerator.AddProperty(PropertyDescriptorsResources.VerticalLineTab_X, _lengthProperty);
        }

        private void GetYValue(ref object resultvalue)
        {
            resultvalue = Builder[0].TransformedPoint3D.X;
        }

        private void SetYValue(object data)
        {
            BeginUpdate();
            var point = Builder[0].TransformedPoint3D;
            point.X = (double) data;
            Builder[0].TransformedPoint3D = point;
            EndVisualUpdate("Updated X coordinate");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _lengthProperty.SetTabOrder(tabIndex);
        }
    }
}