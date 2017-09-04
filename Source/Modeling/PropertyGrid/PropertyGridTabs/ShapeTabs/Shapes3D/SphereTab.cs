#region Usings

using NaroConstants.Names;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Utils;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes3D
{
    /// <summary>
    ///   Description of Sphere.
    /// </summary>
    public class SphereTab : GridTabBase
    {
        private DoublePropertyTabItem _radiusPropertyItem;

        public SphereTab()
            : base(PropertyDescriptorsResources.TitleTabSphere)
        {
        }

        protected override void BuildInterface()
        {
            _radiusPropertyItem = new DoublePropertyTabItem();
            _radiusPropertyItem.OnSetValue += SetInternalRadius;
            _radiusPropertyItem.OnGetValue += GetInternalRadius;
            //_radiusPropertyItem.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                     FunctionNames.SphereRadiusConstraint));
            //_radiusPropertyItem.OnLockClicked += OnLockClicked;

            PropertyListGenerator.AddProperty("Radius", _radiusPropertyItem);
        }

        private void OnLockClicked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.SphereRadiusConstraint, 1);
        }

        private void GetInternalRadius(ref object resultvalue)
        {
            resultvalue = Builder[1].Real;
        }

        private void SetInternalRadius(object data)
        {
            BeginUpdate();
            Builder[1].Real = (double) data;
            EndVisualUpdate("Updated radius");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _radiusPropertyItem.SetTabOrder(tabIndex);
        }
    }
}