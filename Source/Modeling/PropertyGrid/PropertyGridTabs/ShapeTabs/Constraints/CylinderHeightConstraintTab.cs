#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class CylinderHeightConstraintTab : OneDoubleValueConstraintTab
    {
        public CylinderHeightConstraintTab()
            : base(PropertyDescriptorsResources.Cylinder_Height_Constraint, PropertyDescriptorsResources.Height)
        {
        }
    }
}