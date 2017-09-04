using System;
using System.Collections.Generic;
using OCNaroWrappers;
using Naro.Infrastructure.Library.Constants;

namespace Naro.Infrastructure.Library.Geometry
{
    public class Rectangle2D : Shape2d
    {
        private Double _leftBottomX, _leftBottomY, _leftTopY, _rightBottomX, _angle;
        private OCGraphic2d_Array1OfVertex _array1OfVertex = new OCGraphic2d_Array1OfVertex(1, 5);
        private OCGraphic2d_Polyline _polyline;
        private PolylineMarker2D _leftBottomMarker, _leftTopMarker, _rightTopMarker, _rightBottomMarker;

        public Double BottomLeftX
        {
            get { return _array1OfVertex.Value(1).X(); }
        }
        public Double BottomLeftY
        {
            get { return _array1OfVertex.Value(1).Y(); }
        }
        public Double TopLeftX
        {
            get { return _array1OfVertex.Value(2).X(); }
        }
        public Double TopLeftY
        {
            get { return _array1OfVertex.Value(2).Y(); }
        }
        public Double TopRightX
        {
            get { return _array1OfVertex.Value(3).X(); }
        }
        public Double TopRightY
        {
            get { return _array1OfVertex.Value(3).Y(); }
        }
        public Double BottomRightX
        {
            get { return _array1OfVertex.Value(4).X(); }
        }
        public Double BottomRightY
        {
            get { return _array1OfVertex.Value(4).Y(); }
        }

        public Rectangle2D(OCAIS2D_InteractiveContext context, Double xPos, Double yPos, Double width, Double height, Double angle)
        {
            base.SetContext(context);

            SetEndpoints(xPos, yPos, width, height, angle);
        }

        /// <summary>
        /// The endpoints of the rectangle can be set to other coordinates.
        /// </summary>
        public void SetEndpoints(Double xPos, Double yPos, Double width, Double height, Double angle)
        {
            OCAIS2D_InteractiveContext context = GetContext();

            // Store internally the parameters passed to the constructor
            _leftBottomX = xPos;
            _leftBottomY = yPos;
            _rightBottomX = _leftBottomX + width;
            _leftTopY = _leftBottomY + height;
            _angle = angle;

            // Build the markers
            _leftBottomMarker = new PolylineMarker2D(context, 0, 0, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);
            _leftTopMarker = new PolylineMarker2D(context, 0, 0, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);
            _rightTopMarker = new PolylineMarker2D(context, 0, 0, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);
            _rightBottomMarker = new PolylineMarker2D(context, 0, 0, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);

            // Build the shape, calculate the vertexes using the internally stored parameters and position the markers
            BuildPolyline();
        }

        public override List<OCgp_Pnt> GetMagicPoints()
        {
            List<OCgp_Pnt> list = new List<OCgp_Pnt>();

            list.Add(new OCgp_Pnt(BottomLeftX, BottomLeftY, 0));
            list.Add(new OCgp_Pnt(TopLeftX, TopLeftY, 0));
            list.Add(new OCgp_Pnt(TopRightX, TopRightY, 0));
            list.Add(new OCgp_Pnt(BottomRightX, BottomRightY, 0));
            list.Add(new OCgp_Pnt(BottomLeftX, BottomLeftY, 0));

            return list;
        }

        /// <summary>
        /// When the line is selected the markers are shown.
        /// </summary>
        public override void Select()
        {
            _leftBottomMarker.Display(true);
            _leftTopMarker.Display(true);
            _rightTopMarker.Display(true);
            _rightBottomMarker.Display(true);
        }

        /// <summary>
        /// Deselect the markers when the line is deselected.
        /// </summary>
        public override void Deselect()
        {
            // Disable dragging
            _activeMarker = null;

            // Hide the markers
            _leftBottomMarker.Hide(true);
            _leftTopMarker.Hide(true);
            _rightTopMarker.Hide(true);
            _rightBottomMarker.Hide(true);
        }

        /// <summary>
        /// Returns true if the mouse located at this position can drag the object.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool CanDrag(Double x, Double y)
        {
            if (_leftBottomMarker.Contains(x, y) || _leftTopMarker.Contains(x, y) || _rightTopMarker.Contains(x, y) || _rightBottomMarker.Contains(x, y))
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

            if (_leftBottomMarker.Contains(x, y))
            {
                _activeMarker = _leftBottomMarker;
            }
            else if (_leftTopMarker.Contains(x, y))
            {
                _activeMarker = _leftTopMarker;
            }
            else if (_rightTopMarker.Contains(x, y))
            {
                _activeMarker = _rightTopMarker;
            }
            else if (_rightBottomMarker.Contains(x, y))
            {
                _activeMarker = _rightBottomMarker;
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

            if (_activeMarker == _leftBottomMarker)
            {
                _leftBottomX = x;
                _leftBottomY = y;
            }
            else if (_activeMarker == _leftTopMarker)
            {
                _leftBottomX = x;
                _leftTopY = y;
            }
            else if (_activeMarker == _rightTopMarker)
            {
                _rightBottomX = x;
                _leftTopY = y;
            }
            else if (_activeMarker == _rightBottomMarker)
            {
                _rightBottomX = x;
                _leftBottomY = y;
            }

            // Rebuild the polyline with the new coordinates
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
        /// Used to access the rectangle vertexes. The array passed as parameter is filled with the vertexes.
        /// </summary>
        /// <param name="vertexArray"></param>
        public void GetVertexes(OCGraphic2d_Array1OfVertex vertexArray)
        {
            if (_array1OfVertex.Length() == vertexArray.Length())
            {
                //TODO: the loop condition is not <= !?
                for (int i = 1; i < _array1OfVertex.Length(); i++)
                {
                    vertexArray.SetValue(i, new OCGraphic2d_Vertex(_array1OfVertex.Value(i).X(), _array1OfVertex.Value(i).Y()));
                }
            }
        }

        /// <summary>
        /// Calculates the rectangle vertexes. It also builds the vertex markers.
        /// </summary>
        private void BuildPolyline()
        {
            if (_polyline != null)
            {
                this.RemovePrimitive(_polyline);
            }

            Double BottomLeftX = _leftBottomX;
            Double BottomLeftY = _leftBottomY;

            Double BottomRightX = _leftBottomX + (Math.Cos(_angle) * (_rightBottomX - _leftBottomX));
            Double BottomRightY = _leftBottomY + (Math.Sin(_angle) * (_rightBottomX - _leftBottomX));

            Double TopRightX = _leftBottomX + (Math.Cos(_angle) * (_rightBottomX - _leftBottomX)) + (-Math.Sin(_angle) * (_leftTopY - _leftBottomY));
            Double TopRightY = _leftBottomY + (Math.Sin(_angle) * (_rightBottomX - _leftBottomX)) + (Math.Cos(_angle) * (_leftTopY - _leftBottomY));

            Double TopLeftX = _leftBottomX + (-Math.Sin(_angle) * (_leftTopY - _leftBottomY));
            Double TopLeftY = _leftBottomY + (Math.Cos(_angle) * (_leftTopY - _leftBottomY));

            _array1OfVertex.SetValue(1, new OCGraphic2d_Vertex(BottomLeftX, BottomLeftY));
            _array1OfVertex.SetValue(2, new OCGraphic2d_Vertex(TopLeftX, TopLeftY));
            _array1OfVertex.SetValue(3, new OCGraphic2d_Vertex(TopRightX, TopRightY));
            _array1OfVertex.SetValue(4, new OCGraphic2d_Vertex(BottomRightX, BottomRightY));
            _array1OfVertex.SetValue(5, new OCGraphic2d_Vertex(BottomLeftX, BottomLeftY));

            // Add the polyline in the representation, for all modes
            _polyline = new OCGraphic2d_Polyline(this, _array1OfVertex);
            _polyline.SetColorIndex(1);
            _polyline.SetWidthIndex(1);
            _polyline.SetTypeIndex(1);

            // Position the markers
            _leftBottomMarker.SetPosition(BottomLeftX, BottomLeftY);
            _leftTopMarker.SetPosition(TopLeftX, TopLeftY);
            _rightTopMarker.SetPosition(TopRightX, TopRightY);
            _rightBottomMarker.SetPosition(BottomRightX, BottomLeftY);
        }
    }
}
