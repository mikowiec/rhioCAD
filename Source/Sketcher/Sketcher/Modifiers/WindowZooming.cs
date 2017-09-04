
using Naro.Infrastructure.Interface;
using System;
using Naro.Infrastructure.Library.Geometry;
using Naro.Sketcher.Constants;

namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Makes zoom on an area selected by the user.
	/// </summary>
	public class WindowZooming : DrawingAction2d
	{
        Double _xMin, _yMin, _xMax, _yMax;
        Rectangle2D rectangle;
        private bool _previousMouseDown = false;

        public WindowZooming() : base("WindowZooming2D")
        {
        }

        protected override void OnReceiveInputData(string inputName, object data)
        {
            base.OnReceiveInputData(inputName, data);

            // The input was processed in the base class, just use the coordinates received
            if (inputName == ActionNames.SolverDrawerPipe)
            {
                if (_occMousePosition.IsMouseDown != _previousMouseDown)
                {
                    OnMouseClick3dAction(_occMousePosition);
                }
                else
                {
                    OnMouseMove3dAction(_occMousePosition);
                }

                _previousMouseDown = _occMousePosition.IsMouseDown;
            }
        }

        private void OnMouseClick3dAction(Mouse3dPosition point)
		{
            if (point.IsMouseDown)
            {
                _xMin = point.Point.X();
                _yMin = point.Point.Y();

                // Build the selection rectangle
                rectangle = new Rectangle2D(Context2d, _xMin, _yMin, 1, 1, 0);
                // Set the line type to selection
                rectangle.SetAspect(DrawingUtils.GetSelectionAspectLine());
            }
            else
            {
                _xMax = point.Point.X();
                _yMax = point.Point.Y();

                // Remove the selection rectangle from the view and release it
                Context2d.Erase(rectangle, true, false);
                rectangle = null;

                // Test if the zoom window is greater than a minimal window
                if ((Math.Abs(_xMin - _xMax) > 1) || (Math.Abs(_yMin - _yMax) > 1))
                {
                    // Do the zoom window between Pmin and Pmax
                    int xMin = 0, yMin = 0, xMax = 0, yMax = 0;
                    GeomUtils.TranslateCoordinatesFromOCC(View2d, _xMin, _yMin, ref xMin, ref yMin);
                    GeomUtils.TranslateCoordinatesFromOCC(View2d, _xMax, _yMax, ref xMax, ref yMax);
                    View2d.WindowFit(xMin, yMin, xMax, yMax);
                }

                View2d.Update();
            }
		}

        private void OnMouseMove3dAction(Mouse3dPosition point)
		{
            if (rectangle != null)
		    {
		        rectangle.SetEndpoints(_xMin, _yMin, point.Point.X() - _xMin, point.Point.Y() - _yMin, 0);
		        rectangle.Display(true);
		    }
		}
	}
}
