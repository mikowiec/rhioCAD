#region Usings

using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Tools
{
    /// <summary>
    ///   Description of Revolve.
    /// </summary>
    public class RevolveTab : GridTabBase
    {
        private DoublePropertyTabItem _angleProperty;

        public RevolveTab()
            : base(PropertyDescriptorsResources.TitleTabRevolve)
        {
        }

        protected override void BuildInterface()
        {
            _angleProperty = new DoublePropertyTabItem();
            _angleProperty.OnSetValue += SetInternalRadius;
            _angleProperty.OnGetValue += GetInternalRadius;
            PropertyListGenerator.AddProperty("Radius", _angleProperty);
        }

        private void GetInternalRadius(ref object resultvalue)
        {
            resultvalue = Builder[2].Real;
        }

        private void SetInternalRadius(object data)
        {
            BeginUpdate();
            Builder[2].Real = (double) data;
            EndVisualUpdate("Updated radius");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _angleProperty.SetTabOrder(tabIndex);
        }
    }
}