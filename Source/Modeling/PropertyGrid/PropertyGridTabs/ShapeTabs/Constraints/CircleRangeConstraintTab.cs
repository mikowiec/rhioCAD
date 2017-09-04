#region Usings

using Resources.Modeling;

#endregion

namespace PropertyGridTabs.ShapeTabs.Constraints
{
    public class CircleRangeConstraintTab : OneDoubleValueConstraintTab
    {
        public CircleRangeConstraintTab()
            : base(
                PropertyDescriptorsResources.TitleTabCircleRangeConstraint,
                PropertyDescriptorsResources.CircleRangeConstraintTab_Length)
        {
        }
    }
}