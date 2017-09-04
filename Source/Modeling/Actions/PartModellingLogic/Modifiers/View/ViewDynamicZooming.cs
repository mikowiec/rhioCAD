#region Usings

using System;
using NaroBasicPipes.Actions;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.View
{
    /// <summary>
    ///   Zooms the view dynamically with a zoom factor related to the mouse move.
    /// </summary>
    public class ViewDynamicZooming : HandlingAction3D
    {
        private int _xMax, _yMax;

        public ViewDynamicZooming()
            : base(ModifierNames.ViewDynamicZooming)
        {
        }

        protected override void MouseDownHandler(int x, int y)
        {
            _xMax = x;
            _yMax = y;
        }

        protected override void MouseMoveHandler(int x, int y, bool mouseDown)
        {
            if (!mouseDown)
            {
                return;
            }
            if (Math.Abs(_xMax - x) > Math.Abs(_yMax - y))
                View.Zoom(0, 0, _xMax - x, 0);
            else View.Zoom(0, 0, _yMax - y, 0);
            _xMax = x;
            _yMax = y;
        }
    }
}