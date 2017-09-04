#region Usings

using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Utils;

#endregion

namespace PropertyGridTabs.ShapeTabs.Tools
{
    public class Fillet2DTab : GridTabBase
    {
        private DoublePropertyTabItem _internalRadiusProperty;

        public Fillet2DTab()
            : base(PropertyDescriptorsResources.Fillet2D)
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
            resultvalue = Builder[1].Real;
        }

        private void SetInternalRadius(object data)
        {
            BeginUpdate();
            Builder[1].Real = (double) data;
            NodeBuilderUtils.UpdateSketchesOnFaces(new NodeBuilder(Parent));
            EndVisualUpdate("Fillet 2D radius changed");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _internalRadiusProperty.SetTabOrder(tabIndex);
        }
    }
}