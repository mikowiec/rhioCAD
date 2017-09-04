#region Usings

using System;
using NaroConstants.Names;

using PropertyGridTabItems;
using PropertyGridTabs.ShapeTabs.Shapes2D;
using Resources.Modeling;
using ShapeFunctionsInterface.Utils;
using NaroCppCore.Occ.Precision;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes3D
{
    public class BoxTab : RectangleTabBase
    {
        private DoublePropertyTabItem _heightProperty;

        public BoxTab()
            : base(PropertyDescriptorsResources.TabTitleBox)
        {
        }

        protected override void BuildInterface()
        {
            _heightProperty = new DoublePropertyTabItem();
            _heightProperty.OnSetValue += SetHeight;
            _heightProperty.OnGetValue += GetHeight;
            //_heightProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent, FunctionNames.BoxHeightConstraint));
            //_heightProperty.OnLockClicked += OnHeightLocked;

            PropertyListGenerator.AddProperty("Height", _heightProperty);

            base.BuildInterface();
        }

        private void OnHeightLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.BoxHeightConstraint, 2);
        }

        private void SetHeight(object data)
        {
            var height = (double) data;
            if (Math.Abs(height) < Precision.Confusion)
            {
                return;
            }

            BeginUpdate();
            Builder[2].Real = height;
            EndVisualUpdate("Change height to: " + height);
        }

        private void GetHeight(ref object resultvalue)
        {
            resultvalue = Builder[2].Real;
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _heightProperty.SetTabOrder(tabIndex);
        }
    }
}