
using System.Collections.Generic;
using OCNaroWrappers;
using System;
using Naro.Infrastructure.Library.Constants;

namespace Naro.Infrastructure.Library.Geometry
{
    /// <summary>
    /// Description of Line2D.
    /// </summary>
    public class Line2D : Shape2d
    {
        private PolylineMarker2D _startMarker, _endMarker;
        private OCGraphic2d_Array1OfVertex _array1OfVertex = new OCGraphic2d_Array1OfVertex(1, 2);
        private OCGraphic2d_Polyline _polyline;

        public Line2D(OCAIS2D_InteractiveContext context, Double xPos, Double yPos, Double xEndPos, Double yEndPos)
        {
            base.SetContext(context);

            SetEndpoints(xPos, yPos, xEndPos, yEndPos);
        }

        /// <summary>
        /// The endpoints of the line can be set to other coordinates.
        /// </summary>
        public void SetEndpoints(Double xPos, Double yPos, Double xEndPos, Double yEndPos)
        {
            OCAIS2D_InteractiveContext context = GetContext();

            // Create the 2 markers for the end of the segment
            _startMarker = new PolylineMarker2D(context, xPos, yPos, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);
            _endMarker = new PolylineMarker2D(context, xEndPos, yEndPos, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);

            // Store the line attributes
            _array1OfVertex.SetValue(1, new OCGraphic2d_Vertex(xPos, yPos));
            _array1OfVertex.SetValue(2, new OCGraphic2d_Vertex(xEndPos, yEndPos));

            BuildPolyline();
        }

        public override List<OCgp_Pnt> GetMagicPoints()
        {
            if (_array1OfVertex.Length() == 2)
            {
                List<OCgp_Pnt> list = new List<OCgp_Pnt>();

                list.Add(new OCgp_Pnt(_array1OfVertex.Value(1).X(), _array1OfVertex.Value(1).Y(), 0));
                list.Add(new OCgp_Pnt(_array1OfVertex.Value(2).X(), _array1OfVertex.Value(2).Y(), 0));

                return list;
            }

            return null;
        }

        /// <summary>
        /// When the line is selected the markers are shown.
        /// </summary>
        public override void Select()
        {
            _startMarker.Display(true);
            _endMarker.Display(true);
        }

        /// <summary>
        /// Deselect the markers when the line is deselected.
        /// </summary>
        public override void Deselect()
        {
            // Disable dragging
            _activeMarker = null;

            // Hide the markers
            _startMarker.Hide(true);
            _endMarker.Hide(true);
        }

        /// <summary>
        /// Returns true if the mouse located at this position can drag the object.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool CanDrag(Double x, Double y)
        {
            if (_startMarker.Contains(x, y) || _endMarker.Contains(x, y))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Called when a dragging operation starts.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public override void StartDragging(Double x, Double y)
        {
            base.StartDragging(x, y);

            _activeMarker = null;

            if (_startMarker.Contains(x, y))
            {
                _activeMarker = _startMarker;
            }
            else if (_endMarker.Contains(x, y))
            {
                _activeMarker = _endMarker;
            }
        }

        /// <summary>
        /// Called when the shape is dragged with the mouse. Only dragging the markers is allowed.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public override void MouseDrag(Double x, Double y)
        {
            if (_activeMarker == null)
            {
                return;
            }

            _activeMarker.SetPosition(x, y);

            if (_activeMarker == _startMarker)
            {
                _array1OfVertex.SetValue(1, new OCGraphic2d_Vertex(x, y));
            }
            else if (_activeMarker == _endMarker)
            {
                _array1OfVertex.SetValue(2, new OCGraphic2d_Vertex(x, y));
            }

            // Rebuild the polyline with the neww coordinates
            BuildPolyline();
            // Display the new polyline
            Display(true);
        }

        /// <summary>
        /// Called when the dragging operation ends.
        /// </summary>
        public override void EndDragging()
        {
            base.EndDragging();

            _activeMarker = null;
        }

        /// <summary>
        /// Used to retrieve the vertexes of the line.
        /// </summary>
        /// <param name="vertexArray"></param>
        public void GetVertexes(OCGraphic2d_Array1OfVertex vertexArray)
        {
            int arrLen = _array1OfVertex.Length();
            int vertexLen = vertexArray.Length();
            if (arrLen == vertexLen)
            {
                for (int i = 1; i <= arrLen; i++)
                {
                    vertexArray.SetValue(i, new OCGraphic2d_Vertex(_array1OfVertex.Value(i).X(), _array1OfVertex.Value(i).Y()));
                }
            }
        }

        /// <summary>
        /// Build the graphic polyline.
        /// </summary>
        private void BuildPolyline()
        {
            // If there is already a polyline built remove the previous polyline
            if (_polyline != null)
            {
                this.RemovePrimitive(_polyline);
            }

            // Add the new polyline in the representation
            _polyline = new OCGraphic2d_Polyline(this, _array1OfVertex);
            _polyline.SetColorIndex(1);
            _polyline.SetWidthIndex(1);
            _polyline.SetTypeIndex(1);
        }
    }
}
