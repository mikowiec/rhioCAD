
using OCNaroWrappers;

namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Description of CircularGridPointsHandler.
	/// </summary>
    public class CircularGridPointsHandler : HandlingAction2d
	{
        public CircularGridPointsHandler() : base ("CircularGridPoints2d")
	    {
	    }

	    public override void OnActivate()
		{
            //Viewer2d.SetGridColor(new OCQuantity_Color(OCQuantity_NameOfColor.Quantity_NOC_LIGHTSLATEGRAY), new OCQuantity_Color(OCQuantity_NameOfColor.Quantity_NOC_WHITE));
            Viewer2d.ActivateGrid(OCAspect_GridType.Aspect_GT_Circular, OCAspect_GridDrawMode.Aspect_GDM_Points);
		}
	}
}
