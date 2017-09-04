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
    public class ConeTab : GridTabBase
    {
        private DoublePropertyTabItem _baseRadiusProperty;
        private DoublePropertyTabItem _heightConeProperty;
        private DoublePropertyTabItem _heightProperty;
        private DoublePropertyTabItem _topRadiusProperty;

        public ConeTab()
            : base(PropertyDescriptorsResources.TitleTabCone)
        {
        }

        protected override void BuildInterface()
        {
            _baseRadiusProperty = new DoublePropertyTabItem();
            _baseRadiusProperty.OnSetValue += SetBaseRadius;
            _baseRadiusProperty.OnGetValue += GetBaseRadius;
            //_baseRadiusProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                     FunctionNames.ConeMinorRadiusConstraint));
            //_baseRadiusProperty.OnLockClicked += MinorRadiusLocked;
            PropertyListGenerator.AddProperty("Base Radius", _baseRadiusProperty);

            _topRadiusProperty = new DoublePropertyTabItem();
            _topRadiusProperty.OnSetValue += SetTopRadius;
            _topRadiusProperty.OnGetValue += GetTopRadius;
            //_topRadiusProperty.OnLockClicked += TopRadiusLocked;
            //_topRadiusProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                    FunctionNames.ConeMajorRadiusConstraint));

            PropertyListGenerator.AddProperty("Top Radius", _topRadiusProperty);

            _heightConeProperty = new DoublePropertyTabItem();
            _heightConeProperty.OnSetValue += SetConeHeight;
            _heightConeProperty.OnGetValue += GetConeHeight;
            //_heightConeProperty.OnLockClicked += HeightRadiusLocked;
            //_heightConeProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                     FunctionNames.ConeHeightConstraint));
            PropertyListGenerator.AddProperty("Height", _heightConeProperty);

            _heightProperty = new DoublePropertyTabItem();
            _heightProperty.OnSetValue += SetAngle;
            _heightProperty.OnGetValue += GetAngle;
            PropertyListGenerator.AddProperty("Angle", _heightProperty);
        }

        private void HeightRadiusLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.ConeHeightConstraint, 3);
        }

        private void TopRadiusLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.ConeMajorRadiusConstraint, 2);
        }

        private void MinorRadiusLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.ConeMinorRadiusConstraint, 1);
        }

        private void GetAngle(ref object resultvalue)
        {
            resultvalue = GeomUtils.RadiansToDegrees(Builder[4].Real);
        }

        private void SetAngle(object data)
        {
            BeginUpdate();
            Builder[4].Real = GeomUtils.DegreesToRadians((double) data);
            EndVisualUpdate("Updated cone angle");
        }

        private void GetConeHeight(ref object resultvalue)
        {
            resultvalue = Builder[3].Real;
        }

        private void SetConeHeight(object data)
        {
            BeginUpdate();
            Builder[3].Real = (double) data;
            EndVisualUpdate("Updated cone height");
        }

        private void GetTopRadius(ref object resultvalue)
        {
            resultvalue = Builder[2].Real;
        }

        private void SetTopRadius(object data)
        {
            BeginUpdate();
            Builder[2].Real = (double) data;
            EndVisualUpdate("Updated top radius");
        }

        private void GetBaseRadius(ref object resultvalue)
        {
            resultvalue = Builder[1].Real;
        }

        private void SetBaseRadius(object data)
        {
            BeginUpdate();
            Builder[1].Real = (double) data;
            EndVisualUpdate("Updated base radius");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _baseRadiusProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _topRadiusProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _heightConeProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _heightProperty.SetTabOrder(tabIndex);
        }
    }
}