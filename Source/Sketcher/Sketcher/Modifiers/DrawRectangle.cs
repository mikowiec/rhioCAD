
using Extensions.TreeData.AttributeInterpreter;
using System;
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
	/// Rectangle drawing action.
	/// </summary>
	public class DrawRectangle : DrawingAction2d
	{
        Rectangle2D _rectangle;
        Node L;
        private bool _previousMouseDown = false;
        protected OCgp_Ax2 Ax2 { get; set; }

        public DrawRectangle() : base("DrawRectangle2D")
		{
            RegisterInput(ActionNames.WorkingPlaneInput);
        }

        protected override void OnReceiveInputData(string inputName, object data)
        {
            if (inputName == ActionNames.WorkingPlaneInput)
            {
                Ax2 = data as OCgp_Ax2;
            }
            else
            {
                base.OnReceiveInputData(inputName, data);
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
            if (_rectangle != null)
            {
                Context2d.Erase(_rectangle, true, false);
            }

            _points.Clear();
        }

        private void OnMouseClick3dAction(Mouse3dPosition point)
        {
            if (point.IsMouseDown == false)
            {
                AddToPointList(point.Point);
            }

            // Finished building the rectangle
            if (_points.Count >= 2)
            {
                // Remove the realtime drawn rectangle
                Context2d.Erase(_rectangle, true, false);

                // Build the final rectangle from the two coordinates
                var rectangle = new Rectangle2D(Context2d, _points[0].X(), _points[0].Y(), _points[1].X() - _points[0].X(), _points[1].Y() - _points[0].Y(), 0);

                // Add the rectangle to the OCAF data hierarchy and also display it
                _document.Transact();

                // Save the new shape into the Ocaf data structure
                L = AddToOcaf(rectangle, Ax2);

                // Attach an integer attribute to L to memorize it's not displayed
                L.Update<IntegerInterpreter>().Value = (int)OcafObjectVisibility.ToBeDisplayed;

                _document.Commit("Draw rectangle");
                rectangle.Display(true);

                // Inform the listeners that a new shape was generated
                Inputs[ActionNames.SolverDrawerPipe].OnNotification("Draw Rectangle", rectangle);
                Inputs[ActionNames.EditDetectionPipe].OnNotification("Draw Rectangle", rectangle);

                // Clear the list and get ready for drawing a new rectangle
                _points.Clear();
            }
		}

        private void OnMouseMove3dAction(Mouse3dPosition point)
		{
            if (_points.Count != 1)
            {
                return;
            }

            Double xMin = _points[0].X();
            Double yMin = _points[0].Y();

            // Build/regenerate the rectangle with the new coordinates
            if (_rectangle == null)
            {
                _rectangle = new Rectangle2D(Context2d, xMin, yMin, point.Point.X() - xMin, point.Point.Y() - yMin, 0);
            }
            else
            {
                _rectangle.SetEndpoints(xMin, yMin, point.Point.X() - xMin, point.Point.Y() - yMin, 0);
            }

            _rectangle.Display(true);
		}
		
		private Node AddToOcaf(Rectangle2D rectangle, OCgp_Ax2 ax2)
		{
			Node mainLabel = _document.Root;
			Node L = mainLabel.AddNewChild();

			double x1 = rectangle.BottomLeftX;
			double y1 = rectangle.BottomLeftY;
			double x2 = rectangle.TopLeftX;
			double y2 = rectangle.TopLeftY;
			double x3 = rectangle.BottomRightX;
			double y3 = rectangle.BottomRightY;
			

			SetLabelPosition(ax2, L, x1, y1, x2, y2, x3, y3);
			
			return L;
		}

		int SetLabelPosition(OCgp_Ax2 ax2, Node L, double x1, double y1, double x2, double y2, double x3, double y3)
		{
			L.Update<StringInterpreter>().Value = DisplayedShapeNames.Rectangle;

			// Instanciate a TFunction_Function attribute connected to the current Rectangle driver
			// and attach it to the data structure as an attribute of the Rectangle Label
			
			FunctionInterpreter rectangleDriver = L.Update<FunctionInterpreter>(); 
			rectangleDriver.Name = "Rectangle";
            rectangleDriver.BeginUpdate();

			// Create the data structure : Set the dimensions, position and name attributes
			rectangleDriver.Dependency.Child(1).Geometry = GeomUtils.VertexToPnt(new OCGraphic2d_Vertex(x1, y1), ax2);
			rectangleDriver.Dependency.Child(2).Geometry = GeomUtils.VertexToPnt(new OCGraphic2d_Vertex(x2, y2), ax2); 
			rectangleDriver.Dependency.Child(3).Geometry = GeomUtils.VertexToPnt(new OCGraphic2d_Vertex(x3, y3), ax2); 


			if (rectangleDriver.Execute() != 0) {
				// TODO : handle the error
			}
			return 0;
		}
	}
}
