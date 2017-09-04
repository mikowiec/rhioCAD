#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class LineLengthConstraintTab : OneDoubleValueConstraintTab
    {
        public LineLengthConstraintTab()
            : base(PropertyDescriptorsResources.Line_Length_Constraint, PropertyDescriptorsResources.Length)
        {
        }
    }
}