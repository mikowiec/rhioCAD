#region Usings

using NaroConstants.Names;
using OccCode;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Utils;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes3D
{
    /// <summary>
    ///   Description of CylinderTab.
    /// </summary>
    public class CylinderTab : GridTabBase
    {
        private DoublePropertyTabItem _angleProperty;
        private DoublePropertyTabItem _lengthProperty;
        private DoublePropertyTabItem _radiusProperty;

        public CylinderTab()
            : base(PropertyDescriptorsResources.TitleTabCylinder)
        {
        }

        protected override void BuildInterface()
        {
            _radiusProperty = new DoublePropertyTabItem();
            _radiusProperty.OnSetValue += SetRadius;
            _radiusProperty.OnGetValue += GetRadius;
            //_radiusProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                 FunctionNames.CylinderRadiusConstraint));
            //_radiusProperty.OnLockClicked += OnRadiusLocked;
            PropertyListGenerator.AddProperty("Radius", _radiusProperty);

            _lengthProperty = new DoublePropertyTabItem();
            _lengthProperty.OnSetValue += SetLength;
            _lengthProperty.OnGetValue += GetLength;
            //_lengthProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                 FunctionNames.CylinderHeightConstraint));
            //_lengthProperty.OnLockClicked += OnHeightLocked;
            PropertyListGenerator.AddProperty("Height", _lengthProperty);

            _angleProperty = new DoublePropertyTabItem();
            _angleProperty.OnSetValue += SetAngle;
            _angleProperty.OnGetValue += GetAngle;
            PropertyListGenerator.AddProperty("Angle", _angleProperty);
        }

        private void OnHeightLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.CylinderHeightConstraint, 2);
        }

        private void OnRadiusLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.CylinderRadiusConstraint, 1);
        }

        private void GetAngle(ref object resultvalue)
        {
            resultvalue = GeomUtils.RadiansToDegrees(Builder[3].Real);
        }

        private void SetAngle(object data)
        {
            BeginUpdate();
            Builder[3].Real = GeomUtils.DegreesToRadians((double) data);
            EndVisualUpdate("Updated angle");
        }

        private void GetLength(ref object resultvalue)
        {
            resultvalue = Builder[2].Real;
        }

        private void SetLength(object data)
        {
            BeginUpdate();
            Builder[2].Real = (double) data;
            EndVisualUpdate("Updated length");
        }

        private void GetRadius(ref object resultvalue)
        {
            resultvalue = Builder[1].Real;
        }

        private void SetRadius(object data)
        {
            BeginUpdate();
            Builder[1].Real = (double) data;
            EndVisualUpdate("Updated angle");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _radiusProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _lengthProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _radiusProperty.SetTabOrder(tabIndex);
        }
    }
}