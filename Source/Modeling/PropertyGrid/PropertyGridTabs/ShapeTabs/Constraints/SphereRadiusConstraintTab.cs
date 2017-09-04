#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class SphereRadiusConstraintTab : OneDoubleValueConstraintTab
    {
        public SphereRadiusConstraintTab()
            : base(PropertyDescriptorsResources.Sphere_Radius_Constraint, PropertyDescriptorsResources.Radius)
        {
        }
    }
}