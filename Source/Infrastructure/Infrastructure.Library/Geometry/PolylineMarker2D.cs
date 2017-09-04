
using OCNaroWrappers;
using System;

namespace Naro.Infrastructure.Library.Geometry
{
    public class PolylineMarker2D : OCAIS2D_InteractiveObject
    {
        private Double _xPos, _yPos, _halfWidth, _halfHeight;
        private OCGraphic2d_PolylineMarker _marker;
        private OCGraphic2d_Array1OfVertex _markerVertexes = new OCGraphic2d_Array1OfVertex(1, 5);

        public PolylineMarker2D(OCAIS2D_InteractiveContext context, Double xPos, Double yPos, Double width, Double height)
        {
            base.SetContext(context);

            _xPos = xPos;
            _yPos = yPos;
            _halfWidth = width/2;
            _halfHeight = height/2;

            ComputeMarker();
        }

        /// <summary>
        /// Shows the marker.
        /// </summary>
        /// <param name="updateViewer"></param>
        public void Display(bool updateViewer)
        {
            OCAIS2D_InteractiveContext context2d = GetContext();
            context2d.Display(this, updateViewer);
        }

        /// <summary>
        /// Hides the marker.
        /// </summary>
        /// <param name="updateViewer"></param>
        public void Hide(bool updateViewer)
        {
            OCAIS2D_InteractiveContext context2d = GetContext();
            context2d.Erase(this, updateViewer, false);
        }

        /// <summary>
        /// Moves the marker at the specified position.
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        public void SetPosition(Double xPos, Double yPos)
        {
            if (_marker != null)
            {
                _xPos = xPos;
                _yPos = yPos;
                _marker.SetPosition(xPos, yPos);
            }
        }

        /// <summary>
        /// Tests if a point is inside marker.
        /// </summary>
        /// <returns></returns>
        public bool Contains(Double x, Double y)
        {
            Double translatedX = x - _xPos;
            Double translatedY = y - _yPos;

            // Test if it inside marker
            if (((translatedX >= (-_halfWidth)) && (translatedX <= _halfWidth))
                && ((translatedY >= (-_halfHeight)) && (translatedX <= _halfHeight)))
            {
                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Builds the marker polyline.
        /// </summary>
        private void ComputeMarker()
        {
            _markerVertexes.SetValue(1, new OCGraphic2d_Vertex(-_halfWidth, -_halfHeight));
            _markerVertexes.SetValue(2, new OCGraphic2d_Vertex(-_halfWidth, _halfHeight));
            _markerVertexes.SetValue(3, new OCGraphic2d_Vertex(_halfWidth, _halfHeight));
            _markerVertexes.SetValue(4, new OCGraphic2d_Vertex(_halfWidth, -_halfHeight));
            _markerVertexes.SetValue(5, new OCGraphic2d_Vertex(-_halfWidth, -_halfHeight));

            _marker = new OCGraphic2d_PolylineMarker(this, _xPos, _yPos, _markerVertexes);
        }
    }
}
