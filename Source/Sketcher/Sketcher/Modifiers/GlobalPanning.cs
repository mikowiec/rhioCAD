
using System.Windows.Forms;

namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Places the visible viewed area at the mouse position.
	/// </summary>
    public class GlobalPanning : HandlingAction2d
	{
       public GlobalPanning() : base("GlobalPanning2d")
       {
       }

       public override void MouseDownHandler(object sender, MouseEventArgs e)
       {
           View2d.Place(e.X, e.Y, 1);
       }
	}
}
