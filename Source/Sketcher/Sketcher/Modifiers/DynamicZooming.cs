
using System.Windows.Forms;

namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Zooms the view dynamically with a zoom factor related to the mouse move.
	/// </summary>
    public class DynamicZooming : HandlingAction2d
	{
		int _xMax, _yMax;

        public DynamicZooming() : base("DynamicZooming2d")
        {
        }

		public override void MouseDownHandler(object sender, MouseEventArgs e)
		{
            _xMax = e.X;
            _yMax = e.Y;
		}

		public override void MouseMoveHandler(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left)
            {
                View2d.Zoom(_xMax, _yMax, e.X, e.Y, 0.005);
                _xMax = e.X;
                _yMax = e.Y;
            }
		}
	}
}
