
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
	/// Line drawing action.
	/// </summary>
    public class DrawLine : DrawingAction2d
	{
        Node _label;
        Line2D _line;
	    private bool _previousMouseDown = false;
        protected OCgp_Ax2 Ax2 { get; set; }

        public DrawLine() : base("DrawLine2D")
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
            if (_line != null)
            {
                Context2d.Erase(_line, true, false);
            }

            _points.Clear();
        }

        private void OnMouseClick3dAction(Mouse3dPosition point)
        {
            if (point.IsMouseDown == false)
            {
                AddToPointList(point.Point);
            }
            _label = null;

            // Finished building the line
            if (_points.Count >= 2)
            {
                // Remove the realtime drawn line
                Context2d.Erase(_line, true, false);

                // Build the final line translated to the drawing plane
                var line = new Line2D(Context2d, _points[0].X(), _points[0].Y(), _points[1].X(), _points[1].Y());

                // Add the line to the OCAF data hierarchy and also display it
                _document.Transact();

                // Save the new shape into the Ocaf data structure
                int result = AddToOcaf(line, Ax2);

                // Attach an integer attribute to L to memorize it's not displayed
                _label.Update<IntegerInterpreter>().Value = (int)OcafObjectVisibility.ToBeDisplayed;

                _document.Commit("Draw line");
                line.Display(true);

                // Inform the listeners that a new shape was generated
                Inputs[ActionNames.SolverDrawerPipe].OnNotification("Draw Line", line);
                Inputs[ActionNames.EditDetectionPipe].OnNotification("Draw Line", line);

                // Clear the list and get ready for drawing a new line
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

            // Build/regenerate the line with the new coordinates
            if (_line == null)
            {
                _line = new Line2D(Context2d, xMin, yMin, point.Point.X(), point.Point.Y());
            }
            else
            {
                _line.SetEndpoints(xMin, yMin, point.Point.X(), point.Point.Y());
            }

            _line.Display(true);
        }
	
		/// <summary>
		/// Adds a Line2D to the OCAF tree
		/// </summary>
		/// <param name="line"></param>
		/// <param name="ax2"></param>
		/// <returns></returns>
        private int AddToOcaf(Line2D line, OCgp_Ax2 ax2)
        {
            OCGraphic2d_Array1OfVertex vertexArray = new OCGraphic2d_Array1OfVertex(1, 2);
            line.GetVertexes(vertexArray);

            Node mainLabel = _document.Root;

            _label = mainLabel.AddNewChild();
            return UpdateLinePosition(_label, ax2, vertexArray);
        }

		int UpdateLinePosition(Node L, OCgp_Ax2 ax2, OCGraphic2d_Array1OfVertex vertexArray)
		{
			L.Update<StringInterpreter>().Value = DisplayedShapeNames.Line;

			var lineDriver = L.Update<FunctionInterpreter>();
			lineDriver.Name = "Line";
            lineDriver.BeginUpdate();

			// Create the data structure : Set the dimensions, position and name attributes
			OCgp_Pnt point1 = GeomUtils.VertexToPnt(vertexArray.Value(1), ax2);
			lineDriver.Dependency.Child(1).Geometry = point1;

			OCgp_Pnt point2 = GeomUtils.VertexToPnt(vertexArray.Value(2), ax2);
			lineDriver.Dependency.Child(2).Geometry = point2;
			
			if (lineDriver.Execute() != 0) 
			{
				// TODO: Handle the error
			}
			return 0;
		}
	}
}
