#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class ConeMinorRadiusConstraintTab : OneDoubleValueConstraintTab
    {
        public ConeMinorRadiusConstraintTab()
            : base(PropertyDescriptorsResources.Cone_Minor_Radius_Constraint, PropertyDescriptorsResources.Major_Radius)
        {
        }
    }
}