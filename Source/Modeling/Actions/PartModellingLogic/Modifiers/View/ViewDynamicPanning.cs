#region Usings

using NaroBasicPipes.Actions;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.View
{
    /// <summary>
    ///   Used by the user to move the visible viewed area.
    /// </summary>
    public class ViewDynamicPanning : HandlingAction3D
    {
        private int _xMax, _yMax;

        public ViewDynamicPanning()
            : base(ModifierNames.ViewDynamicPanning)
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
                return;
            View.Pan(x - _xMax, _yMax - y, 1);
            _xMax = x;
            _yMax = y;
        }
    }
}