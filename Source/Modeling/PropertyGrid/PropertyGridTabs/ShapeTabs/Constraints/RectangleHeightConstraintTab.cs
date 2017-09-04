#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class RectangleHeightConstraintTab : OneDoubleValueConstraintTab
    {
        public RectangleHeightConstraintTab()
            : base(PropertyDescriptorsResources.Rectangle_Height_Constraint, PropertyDescriptorsResources.Height)
        {
        }
    }
}