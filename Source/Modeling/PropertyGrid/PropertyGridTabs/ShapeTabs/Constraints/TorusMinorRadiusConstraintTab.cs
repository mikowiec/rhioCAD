#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class TorusMinorRadiusConstraintTab : OneDoubleValueConstraintTab
    {
        public TorusMinorRadiusConstraintTab()
            : base(PropertyDescriptorsResources.Torus_Minor_Radius_Constraint, PropertyDescriptorsResources.Minor_Radius
                )
        {
        }
    }
}