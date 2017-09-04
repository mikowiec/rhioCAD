
using OCNaroWrappers;

namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Description of GridPointsHandler.
	/// </summary>
    public class GridPointsHandler : HandlingAction2d
	{
        public GridPointsHandler() : base("GridPoints2d")
        {
        }

	    public override void OnActivate()
		{
            //Viewer2d.SetGridColor(new OCQuantity_Color(OCQuantity_NameOfColor.Quantity_NOC_LIGHTSLATEGRAY), new OCQuantity_Color(OCQuantity_NameOfColor.Quantity_NOC_LIGHTSLATEGRAY));
            Viewer2d.ActivateGrid(OCAspect_GridType.Aspect_GT_Rectangular, OCAspect_GridDrawMode.Aspect_GDM_Points);		
		}
	}
}
