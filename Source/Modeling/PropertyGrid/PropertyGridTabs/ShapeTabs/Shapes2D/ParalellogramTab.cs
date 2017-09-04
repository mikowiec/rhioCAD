#region Usings

using Naro.Infrastructure.Library.Algo;

using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using NaroCppCore.Occ.Precision;

#endregion

namespace PropertyGridTabs.ShapeTabs.Shapes2D
{
    public class ParalellogramTab : GridTabBase
    {
        public ParalellogramTab(string title)
            : base(title)
        {
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
            var dependency = TreeUtils.GetFunctionDependency(Parent);
            return dependency[1].TransformedPoint3D.Distance(dependency[2].TransformedPoint3D);
        }

        private double GetHeight()
        {
            var dependency = TreeUtils.GetFunctionDependency(Parent);
            return dependency[0].TransformedPoint3D.Distance(dependency[1].TransformedPoint3D);
        }

        /// <summary>
        ///   Sets the width of the rectangle shape. The vertex coordinates are recalculated and saved in the OCAF tree.
        /// </summary>
        private void SetWidth(double width)
        {
            if (width < Precision.Confusion)
                return;
            BeginUpdate();
            TreeUtils.RectangleSetWidth(Parent, width);
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
            TreeUtils.RectangleSetHeight(Parent, height);
            EndVisualUpdate("Changed Height.");
        }

        protected override void BuildInterface()
        {
            var widthProperty = new DoublePropertyTabItem();
            widthProperty.OnSetValue += SetWidthValue;
            widthProperty.OnGetValue += GetWidthValue;
            PropertyListGenerator.AddProperty("Width", widthProperty);

            var lengthProperty = new DoublePropertyTabItem();
            lengthProperty.OnSetValue += SetHeightValue;
            lengthProperty.OnGetValue += GetHeightValue;
            PropertyListGenerator.AddProperty("Length", lengthProperty);
        }
    }
}