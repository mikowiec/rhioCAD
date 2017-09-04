
using System.Collections.Generic;
using OCNaroWrappers;
using System;
using Naro.Infrastructure.Library.Constants;

namespace Naro.Infrastructure.Library.Geometry
{
    /// <summary>
    /// Description of Ellipse2D.
    /// </summary>
    public class Ellipse2D : Shape2d
    {
        private Double _centerX, _centerY, _majorRadius, _minorRadius, _angle;
        private PolylineMarker2D _leftMarker, _rightMarker, _topMarker, _bottomMarker;
        private OCGraphic2d_Ellips _ellipse;

        public Ellipse2D(OCAIS2D_InteractiveContext context, Double xPos, Double yPos, Double majorRadius, Double minorRadius, Double angle)
        {
            base.SetContext(context);

            SetProperties(xPos, yPos, majorRadius, minorRadius, angle);
        }

        public void SetProperties(Double xPos, Double yPos, Double majorRadius, Double minorRadius, Double angle)
        {
            OCAIS2D_InteractiveContext context = GetContext();

            _centerX = xPos;
            _centerY = yPos;
            _majorRadius = majorRadius;
            _minorRadius = minorRadius;
            _angle = angle;

            // The OCC requires the minor radius to be higher than 0
            if ((majorRadius < 0.01) || (minorRadius < 0.01))
            {
                return;
            }

            // The OCC ellipse requires the minor radius to be smaller than the major radius
            if (minorRadius > majorRadius)
            {
                return;
            }

            // Build the markers
            _leftMarker = new PolylineMarker2D(context, 0, 0, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);
            _rightMarker = new PolylineMarker2D(context, 0, 0, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);
            _topMarker = new PolylineMarker2D(context, 0, 0, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);
            _bottomMarker = new PolylineMarker2D(context, 0, 0, GeometryConstants.MarkerWidth, GeometryConstants.MarkerWidth);

            // Compute the shape and the markers
            BuildEllipse();

        }

        public override List<OCgp_Pnt> GetMagicPoints()
        {
            return null;
        }

        /// <summary>
        /// When the line is selected the markers are shown.
        /// </summary>
        public override void Select()
        {
            _leftMarker.Display(true);
            _rightMarker.Display(true);
            _topMarker.Display(true);
            _bottomMarker.Display(true);
        }

        /// <summary>
        /// Deselect the markers when the line is deselected.
        /// </summary>
        public override void Deselect()
        {
            // Disable dragging
            _activeMarker = null;

            // Hide the markers
            _leftMarker.Hide(true);
            _rightMarker.Hide(true);
            _topMarker.Hide(true);
            _bottomMarker.Hide(true);
        }

        /// <summary>
        /// Returns true if the mouse located at this position can drag the object.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool CanDrag(Double x, Double y)
        {
            if (_leftMarker.Contains(x, y) || _rightMarker.Contains(x, y) || _topMarker.Contains(x, y) || _bottomMarker.Contains(x, y))
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

            if (_leftMarker.Contains(x, y))
            {
                _activeMarker = _leftMarker;
            }
            else if (_rightMarker.Contains(x, y))
            {
                _activeMarker = _rightMarker;
            }
            else if (_topMarker.Contains(x, y))
            {
                _activeMarker = _topMarker;
            }
            else if (_bottomMarker.Contains(x, y))
            {
                _activeMarker = _bottomMarker;
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

            if (_activeMarker == _leftMarker)
            {
                _majorRadius = Math.Abs(x - _centerX);
            }
            else if (_activeMarker == _rightMarker)
            {
                _majorRadius = Math.Abs(_centerX - x);
            }
            else if (_activeMarker == _topMarker)
            {
                _minorRadius = Math.Abs(y - _centerY);
            }
            else if (_activeMarker == _bottomMarker)
            {
                _minorRadius = Math.Abs(_centerY - y);
            }

            // Rebuild the polyline with the new coordinates
            BuildEllipse();
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
        /// Returns the center of the ellipse.
        /// </summary>
        /// <returns></returns>
        public OCGraphic2d_Vertex GetEllipseCenter()
        {
            return new OCGraphic2d_Vertex(_centerX, _centerY);
        }

        public Double GetMajorRadius()
        {
            return _majorRadius;
        }

        public Double GetMinorRadius()
        {
            return _minorRadius;
        }

        public Double GetAngle()
        {
            return _angle;
        }

        /// <summary>
        /// Builds the ellipse and the ellipse markers.
        /// </summary>
        private void BuildEllipse()
        {
            // If there is already an ellipse built remove the previous ellipse
            if (_ellipse != null)
            {
                this.RemovePrimitive(_ellipse);
            }

            // Add the polyline in the representation, for all modes
            _ellipse = new OCGraphic2d_Ellips(this, _centerX, _centerY, _majorRadius, _minorRadius, _angle);
            _ellipse.SetColorIndex(1);
            _ellipse.SetWidthIndex(1);
            _ellipse.SetTypeIndex(1);

            // Position the markers
            _leftMarker.SetPosition(_centerX - _majorRadius, _centerY);
            _rightMarker.SetPosition(_centerX + _majorRadius, _centerY);
            _topMarker.SetPosition(_centerX, _centerY + _minorRadius);
            _bottomMarker.SetPosition(_centerX, _centerY - _minorRadius);
        }
    }
}
