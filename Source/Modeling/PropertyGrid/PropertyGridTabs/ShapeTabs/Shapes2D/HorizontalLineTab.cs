#region Usings

using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes2D
{
    /// <summary>
    ///   Description of HorizontalLineTab.
    /// </summary>
    public class HorizontalLineTab : GridTabBase
    {
        private DoublePropertyTabItem _lengthProperty;

        public HorizontalLineTab()
            : base(PropertyDescriptorsResources.TabTitleHorizontalLine)
        {
        }

        protected override void BuildInterface()
        {
            _lengthProperty = new DoublePropertyTabItem();
            _lengthProperty.OnSetValue += SetYValue;
            _lengthProperty.OnGetValue += GetYValue;
            PropertyListGenerator.AddProperty(PropertyDescriptorsResources.HorizontalLineTab_Y, _lengthProperty);
        }

        private void GetYValue(ref object resultvalue)
        {
            resultvalue = Builder[0].TransformedPoint3D.Y;
        }

        private void SetYValue(object data)
        {
            BeginUpdate();
            var point = Builder[0].TransformedPoint3D;
            point.Y = (double) data;
            Builder[0].TransformedPoint3D = point;
            EndVisualUpdate("Updated Y coordinate");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _lengthProperty.SetTabOrder(tabIndex);
        }
    }
}