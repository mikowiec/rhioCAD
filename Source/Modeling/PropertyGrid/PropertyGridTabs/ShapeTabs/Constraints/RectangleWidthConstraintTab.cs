#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class RectangleWidthConstraintTab : OneDoubleValueConstraintTab
    {
        public RectangleWidthConstraintTab()
            : base(PropertyDescriptorsResources.Rectangle_Width_Constraint, PropertyDescriptorsResources.Width)
        {
        }
    }
}