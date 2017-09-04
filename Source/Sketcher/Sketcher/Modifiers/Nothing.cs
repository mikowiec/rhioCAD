/*
 * Created by SharpDevelop.
 * User: Ciprian
 * Date: 2/24/2009
 * Time: 7:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using Naro.Infrastructure.Interface;
using System.Windows.Forms;

namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Description of Action2dNothing.
	/// </summary>
	public class Nothing : DrawingAction2d
	{
        public Nothing() : base("ActionNone2D")
		{            
        }

		public override void MouseMoveHandler(object sender, MouseEventArgs e)
		{
	        if (Viewer2d.IsActive())
	        {
		        View2d.ShowHit(e.X, e.Y);
	        }
	        if (!Viewer2d.IsActive())
	        {
		        View2d.EraseHit();
	        }

            Context2d.MoveTo(e.X, e.Y, View2d);
		}

		public override void MouseUpHandler(object sender, MouseEventArgs e)
		{
		}

        public override void MouseDownHandler(object sender, MouseEventArgs e)
        {
            Context2d.Select(true);
        }
	}
}
