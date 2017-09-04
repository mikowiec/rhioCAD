
using System;
using System.Collections.Generic;
using OCNaroWrappers;
using Naro.Infrastructure.Interface;

namespace Naro.Infrastructure.Library.Geometry
{
    public class Shape2d : OCAIS2D_InteractiveObject
    {
        protected PolylineMarker2D _activeMarker;

        public void Display(bool updateViewer)
        {
            OCAIS2D_InteractiveContext context2d = GetContext();
            if (context2d.IsDisplayed(this))
            {
                context2d.Redisplay(this, updateViewer, false);
            }
            else
            {
                context2d.Display(this, updateViewer);
            }
        }

        /// <summary>
        /// Returns true if the shape is having a dragging operation activated on it
        /// </summary>
        public bool IsDragging
        {
            get; set;
        }

        /// <summary>
        /// Called when a shape is selected by the user. Used to add selection drawing helpers.
        /// </summary>
        public virtual void Select()
        {
        }

        /// <summary>
        /// Called when the object is deselected. Used to disable helpers.
        /// </summary>
        public virtual void Deselect()
        {
        }

        /// <summary>
        /// Called when a vertex is dragged.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void MouseDrag(Double x, Double y)
        {
        }

        /// <summary>
        /// Returns true is the mouse located at this position can drag the object.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public virtual bool CanDrag(Double x, Double y)
        {
            return false;
        }

        /// <summary>
        /// Called when an dragging opration starts.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void StartDragging(Double x, Double y)
        {
            IsDragging = true;
        }

        /// <summary>
        /// Called when the dragging operation ends.
        /// </summary>
        public virtual void EndDragging()
        {
            IsDragging = false;
        }

        /// <summary>
        /// Returns a list with the shape magic points.
        /// </summary>
        /// <returns></returns>
        public virtual List<OCgp_Pnt> GetMagicPoints()
        {
            return null;
        }
    }
}
