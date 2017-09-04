
using System;
using OCNaroWrappers;

namespace Naro.Infrastructure.Library.Geometry
{
    public class CircleMarker2D : OCAIS2D_InteractiveObject
    {
        private Double _xPos, _yPos, _radius;
        private OCGraphic2d_Marker _marker;

        public CircleMarker2D(OCAIS2D_InteractiveContext context, double x, double y, double radius)
        {
            base.SetContext(context);

            _xPos = x;
            _yPos = y;
            _radius = radius;
            _marker = new OCGraphic2d_Marker(this, 4, _xPos, _yPos, _radius, _radius, _radius);
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
                
                RemovePrimitive(_marker);
                _marker = new OCGraphic2d_Marker(this, 4, _xPos, _yPos, _radius, _radius, _radius);
            }
        }
    }
}
