
namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Fits the drawn objects into the visiblea viewer area.
	/// </summary>
    public class FitAll : HandlingAction2d
	{		
		public FitAll() : base("FitAll2d")
		{
		}

        public override void OnActivate()
        {
            View2d.Fitall();
        }
	}
}
