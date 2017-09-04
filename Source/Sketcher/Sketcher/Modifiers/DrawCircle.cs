
using Extensions.TreeData.AttributeInterpreter;
using System;
using System.Windows.Forms;
using log4net;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Interface.Constants;
using Naro.Infrastructure.Library.Geometry;
using Naro.Sketcher.Constants;
using OCNaroWrappers;
using TreeData.Functions;
using TreeData.NaroData;

namespace Naro.Sketcher.Modifiers
{
	/// <summary>
	/// Description of DrawCircle.
	/// </summary>
    public class DrawCircle : DrawingAction2d
	{
    	private static readonly ILog log = LogManager.GetLogger(typeof(DrawCircle));

        Node label;
        Ellipse2D _ellipse;
        private bool _previousMouseDown = false;
        protected OCgp_Ax2 Ax2 { get; set; }

        public DrawCircle() : base("DrawCircle2D")
		{
            RegisterInput(ActionNames.WorkingPlaneInput);
        }

        protected override void OnReceiveInputData(string inputName, object data)
        {
        	switch(inputName)
        	{
        		case ActionNames.WorkingPlaneInput:
        			Ax2 = data as OCgp_Ax2;
        			break;
        		default:
        			base.OnReceiveInputData(inputName, data);
        			break;
        	}
            
            // The input was processed in the base class, just use the coordinates received
            if (null == _occMousePosition)
            {
                return;
            }

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

        public override void OnDeactivate()
        {
            base.OnDeactivate();

            // Remove the realtime drawn line
            if (_ellipse != null)
            {
                Context2d.Erase(_ellipse, true, false);
            }

            _points.Clear();
        }

        private void OnMouseClick3dAction(Mouse3dPosition point)
		{
            if (point.IsMouseDown == false)
            {
                AddToPointList(point.Point);
            }

            // Finished building the ellipse
            if (_points.Count < 2)
            {
            	return;
            }

            try
            {
            	double majorRadius = Math.Abs(_points[1].X() - _points[0].X());
                double minorRadius = Math.Abs(_points[1].Y() - _points[0].Y());

                // The OCC requires the minor radius to be higher than 0
                if ((majorRadius < 0.01) || (minorRadius < 0.01))
                {
                    _points.Clear();
                    return;
                }

                // The OCC ellipse requires the minor radius to be smaller than the major radius
                if (minorRadius > majorRadius)
                {
                    double aux = majorRadius;
                    majorRadius = minorRadius;
                    minorRadius = aux;
                }

                // Remove the realtime drawn ellipse
                Context2d.Erase(_ellipse, true, false);

                // Build the shape translated to the drawing plane
                var ellipse = new Ellipse2D(Context2d, _points[0].X(), _points[0].Y(), majorRadius, minorRadius, 0);

                // Add the ellipse to the OCAF data hierarchy and also display it
                _document.Transact();

                // Save the new shape into the Ocaf data structure
                int result = AddToOcaf(ellipse, Ax2);

                // Attach an integer attribute to L to memorize it's not displayed
                label.Update<IntegerInterpreter>().Value = (int)OcafObjectVisibility.ToBeDisplayed;

                _document.Commit("Draw circle");
                ellipse.Display(true);

                // Inform the listeners that a new shape was generated
                Inputs[ActionNames.SolverDrawerPipe].OnNotification("Draw Ellipse", ellipse);
                Inputs[ActionNames.EditDetectionPipe].OnNotification("Draw Ellipse", ellipse);

                // Clear the list and get ready for drawing a new ellipse
                _points.Clear();
            }
            catch(Exception ex)
            {
            	string message = "Logged exception on creating ellipse: " + ex.Message;
            	MessageBox.Show(message);
            	log.Debug(message);
            }
		}

        private void OnMouseMove3dAction(Mouse3dPosition point)
		{
            // Drawing an ellipse realtime needs one point in the list
            if (_points.Count != 1)
            {
                return;
            }

            Double xMin = _points[0].X();
            Double yMin = _points[0].Y();

	    	double majorRadius = Math.Abs(point.Point.X() - xMin);
			double minorRadius = Math.Abs(point.Point.Y() - yMin);

            // The OCC requires the minor radius to be higher than 0
            if ((majorRadius < 0.01) || (minorRadius < 0.01))
            {
                return;
            }

            // The OCC ellipse requires the minor radius to be smaller than the major radius
            if (minorRadius > majorRadius)
            {
                double aux = majorRadius;
                majorRadius = minorRadius;
                minorRadius = aux;
            }

            try
        	{
	            // Build/regenerate the ellipse with the new coordinates
	            if (_ellipse == null)
	            {
	                _ellipse = new Ellipse2D(Context2d, xMin, yMin, majorRadius, minorRadius, 0);
	            }
	            else
	            {
	                _ellipse.SetProperties(xMin, yMin, majorRadius, minorRadius, 0);
	            }
	
	            _ellipse.Display(true);
        	}
        	catch(Exception ex)
        	{
        		string message = "Exception on creating eclipse (logged): " + ex.Message;
            	MessageBox.Show(message);
            	log.Debug(message);
        	}
		}

        /// <summary>
        /// Adds an Ellipse2D to the OCAF tree.
        /// </summary>
        /// <param name="ellipse"></param>
        /// <param name="ax2"></param>
        /// <returns></returns>
        private int AddToOcaf(Ellipse2D ellipse, OCgp_Ax2 ax2)
        {
            Node mainLabel = _document.Root;

            label = mainLabel.AddNewChild();
            return UpdateElipsePosition(label, ellipse, ax2);
        }

        int UpdateElipsePosition(Node label, Ellipse2D ellipse, OCgp_Ax2 ax2)
		{
			label.Update<StringInterpreter>().Value = DisplayedShapeNames.Ellipse;
			FunctionInterpreter elipseFunction = label.Update<FunctionInterpreter>();
			elipseFunction.Name = "Ellipse";
			
			elipseFunction.BeginUpdate();
			// Create the data structure : Set the dimensions, position and name attributes
			elipseFunction.Dependency.Child(1).Geometry = GeomUtils.VertexToPnt(ellipse.GetEllipseCenter(), ax2);
			// Add the major radius
			elipseFunction.Dependency.Child(2).Real= ellipse.GetMajorRadius();
			// Add the minor radius
			elipseFunction.Dependency.Child(3).Real = ellipse.GetMinorRadius();
			// Add angle
			elipseFunction.Dependency.Child(4).Real = ellipse.GetAngle();

			if (elipseFunction.Execute() != 0)
			{
                // TODO: Handle the error
			}

            return 0;
		}
	}
}
