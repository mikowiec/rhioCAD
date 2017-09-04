#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class TorusMajorRadiusConstraintTab : OneDoubleValueConstraintTab
    {
        public TorusMajorRadiusConstraintTab()
            : base(PropertyDescriptorsResources.Torus_Major_Radius, PropertyDescriptorsResources.Major_Radius)
        {
        }
    }
}