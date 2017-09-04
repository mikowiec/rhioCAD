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
    ///   Description of TorusTab.
    /// </summary>
    public class TorusTab : GridTabBase
    {
        private DoublePropertyTabItem _externalRadiusProperty;
        private DoublePropertyTabItem _internalRadiusProperty;

        public TorusTab()
            : base(PropertyDescriptorsResources.TitleTabTorus)
        {
        }


        protected override void BuildInterface()
        {
            _internalRadiusProperty = new DoublePropertyTabItem();
            _internalRadiusProperty.OnSetValue += SetInternalRadius;
            _internalRadiusProperty.OnGetValue += GetInternalRadius;
            //_internalRadiusProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                         FunctionNames.
            //                                                                             TorusMinorRangeConstraint));
            //_internalRadiusProperty.OnLockClicked += InternalRadiusLocked;
            PropertyListGenerator.AddProperty("Internal radius", _internalRadiusProperty);

            _externalRadiusProperty = new DoublePropertyTabItem();
            _externalRadiusProperty.OnSetValue += SetExternalRadius;
            _externalRadiusProperty.OnGetValue += GetEternalRadius;
            //_externalRadiusProperty.OnLockClicked += ExternalRadiusLocked;
            //_externalRadiusProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                         FunctionNames.
            //                                                                             TorusMajorRangeConstraint));
            PropertyListGenerator.AddProperty("External radius", _externalRadiusProperty);
        }

        private void ExternalRadiusLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.TorusMinorRangeConstraint, 1);
        }

        private void InternalRadiusLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.TorusMajorRangeConstraint, 2);
        }

        private void GetEternalRadius(ref object resultvalue)
        {
            resultvalue = Builder[2].Real;
        }

        private void SetExternalRadius(object data)
        {
            BeginUpdate();
            Builder[2].Real = (double) data;
            EndVisualUpdate("Updated length");
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
            TabChildCount = TabChildCount + _internalRadiusProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _externalRadiusProperty.SetTabOrder(tabIndex);
        }
    }
}