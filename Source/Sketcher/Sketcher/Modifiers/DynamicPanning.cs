
using System.Windows.Forms;

namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Used by the user to move the visible viewed area.
	/// </summary>
    public class DynamicPanning : HandlingAction2d
	{
        int _xMax, _yMax;

        public DynamicPanning() : base("DynamicPanning2d")
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
                View2d.Pan(e.X - _xMax, _yMax - e.Y);
                _xMax = e.X;
                _yMax = e.Y;
            }
        }
	}
}
