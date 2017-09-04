#region Usings

using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Tools
{
    /// <summary>
    ///   Description of FilletTab.
    /// </summary>
    public class FilletTab : GridTabBase
    {
        private DoublePropertyTabItem _internalRadiusProperty;

        public FilletTab()
            : base(PropertyDescriptorsResources.TitleTabFillet)
        {
        }

        protected override void BuildInterface()
        {
            _internalRadiusProperty = new DoublePropertyTabItem();
            _internalRadiusProperty.OnSetValue += SetInternalRadius;
            _internalRadiusProperty.OnGetValue += GetInternalRadius;
            PropertyListGenerator.AddProperty("Radius", _internalRadiusProperty);
        }

        private void GetInternalRadius(ref object resultvalue)
        {
            resultvalue = Builder[2].Real;
        }

        private void SetInternalRadius(object data)
        {
            BeginUpdate();
            Builder[2].Real = (double) data;
            EndVisualUpdate("Fillet angle changed");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _internalRadiusProperty.SetTabOrder(tabIndex);
        }
    }
}