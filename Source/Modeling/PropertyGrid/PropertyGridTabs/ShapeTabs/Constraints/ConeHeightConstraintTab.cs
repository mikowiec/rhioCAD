#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class ConeHeightConstraintTab : OneDoubleValueConstraintTab
    {
        public ConeHeightConstraintTab()
            : base(PropertyDescriptorsResources.Cone_Height_Constraint, PropertyDescriptorsResources.Height)
        {
        }
    }
}