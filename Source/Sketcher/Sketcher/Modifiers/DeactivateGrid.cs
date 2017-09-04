
namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Description of DeactivateGrid.
	/// </summary>
	public class DeactivateGrid : HandlingAction2d
	{
		public DeactivateGrid() : base("DeactivateGrid2d")
		{
		}
		
		public override void OnActivate()
		{
			Viewer2d.DeactivateGrid();
		}
	}
}
