#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroConstants.Names;

using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using Resources.Modeling;
using ShapeFunctionsInterface.Utils;
using NaroCppCore.Occ.Precision;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes2D
{
    public class RectangleTabBase : GridTabBase
    {
        private DoublePropertyTabItem _lengthProperty;
        private DoublePropertyTabItem _widthProperty;

        protected RectangleTabBase(string title)
            : base(title)
        {
        }

        protected override void BuildInterface()
        {
            _widthProperty = new DoublePropertyTabItem();
            _widthProperty.OnSetValue += SetWidthValue;
            _widthProperty.OnGetValue += GetWidthValue;
            //_widthProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                FunctionNames.RectangleWidthConstraint));
            //_widthProperty.OnLockClicked = WidthLocked;
            PropertyListGenerator.AddProperty("Width", _widthProperty);

            _lengthProperty = new DoublePropertyTabItem();
            _lengthProperty.OnSetValue += SetHeightValue;
            _lengthProperty.OnGetValue += GetHeightValue;
            //_lengthProperty.ShowLockImage(NodeBuilderUtils.IsRefencedByShape(Parent,
            //                                                                 FunctionNames.RectangleHeightConstraint));
            //_lengthProperty.OnLockClicked += LengthLocked;
            PropertyListGenerator.AddProperty(PropertyDescriptorsResources.CircleRangeConstraintTab_Length,
                                              _lengthProperty);
        }

        private void LengthLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.RectangleHeightConstraint, GetHeight());
        }

        private void WidthLocked(bool islocked)
        {
            UpdateLock(islocked, FunctionNames.RectangleWidthConstraint, GetWidth());
        }

        private void GetHeightValue(ref object resultvalue)
        {
            resultvalue = GetHeight();
        }

        private void SetHeightValue(object data)
        {
            BeginUpdate();
            SetHeight((double) data);
            EndVisualUpdate("Updated rectangle height");
        }

        private void GetWidthValue(ref object resultvalue)
        {
            resultvalue = GetWidth();
        }

        private void SetWidthValue(object data)
        {
            BeginUpdate();
            SetWidth((double) data);
            EndVisualUpdate("Updated rectangle width");
        }

        private double GetWidth()
        {
            var builder = new NodeBuilder(Parent);
            return TreeUtils.GetWidth(builder);
        }

        private double GetHeight()
        {
            var builder = new NodeBuilder(Parent);
            return TreeUtils.GetHeight(builder);
        }

        /// <summary>
        ///   Sets the width of the rectangle shape. The vertex coordinates are recalculated and saved in the OCAF tree.
        /// </summary>
        private void SetWidth(double width)
        {
            if (width < Precision.Confusion)
                return;
            BeginUpdate();
            TreeUtils.SetWidth(Parent, width);
            EndVisualUpdate("Changed Width.");
        }

        /// <summary>
        ///   Sets the height of the rectangle shape. The vertex coordinates are recalculated and saved in the OCAF tree.
        /// </summary>
        private void SetHeight(double height)
        {
            if (height < Precision.Confusion)
                return;

            BeginUpdate();
            TreeUtils.SetHeight(Parent, height);
            EndVisualUpdate("Changed Height.");
        }

        public override void SetTabOrder(int tabIndex)
        {
            TabChildCount = TabChildCount + _widthProperty.SetTabOrder(tabIndex);
            TabChildCount = TabChildCount + _lengthProperty.SetTabOrder(tabIndex);
        }
    }
}