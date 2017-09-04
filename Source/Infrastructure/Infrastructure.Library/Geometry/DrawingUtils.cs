
using OCNaroWrappers;

namespace Naro.Infrastructure.Library.Geometry
{
    public class DrawingUtils
    {
        /// <summary>
        /// Builds a dotten line aspect used for representing a selection line aspect.
        /// </summary>
        /// <returns></returns>
        public static OCPrs2d_AspectLine GetSelectionAspectLine()
        {
            OCPrs2d_AspectLine aspect = new OCPrs2d_AspectLine();
            aspect.SetType(OCAspect_TypeOfLine.Aspect_TOL_DOT);
            aspect.SetColor(OCQuantity_NameOfColor.Quantity_NOC_WHITE);
            aspect.SetWidth(OCAspect_WidthOfLine.Aspect_WOL_THIN);
            return aspect;
        }
    }
}
