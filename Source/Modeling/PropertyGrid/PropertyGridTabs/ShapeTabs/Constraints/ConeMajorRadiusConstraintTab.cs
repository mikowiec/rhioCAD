#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class ConeMajorRadiusConstraintTab : OneDoubleValueConstraintTab
    {
        public ConeMajorRadiusConstraintTab()
            : base(PropertyDescriptorsResources.Cone_Major_Radius_Constraint, PropertyDescriptorsResources.Major_Radius)
        {
        }
    }
}