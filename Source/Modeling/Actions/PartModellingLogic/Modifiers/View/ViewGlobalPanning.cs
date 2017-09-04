#region Usings

using NaroBasicPipes.Actions;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.View
{
    /// <summary>
    ///   Places the visible viewed area at the mouse position.
    /// </summary>
    public class ViewGlobalPanning : HandlingAction3D
    {
        public ViewGlobalPanning() : base(ModifierNames.ViewGlobalPanning)
        {
        }

        protected override void MouseUpHandler(int x, int y)
        {
            var scaleFactor = View.Scale;
            View.Place(x, y, 1);
            View.Scale = scaleFactor;
        }
    }
}