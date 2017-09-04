#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class CylinderRadiusConstraintTab : OneDoubleValueConstraintTab
    {
        public CylinderRadiusConstraintTab()
            : base(PropertyDescriptorsResources.Cylinder_Radius_Constraint, PropertyDescriptorsResources.Radius)
        {
        }
    }
}