#region Usings

using NaroBasicPipes.Actions;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.View
{
    /// <summary>
    ///   The view is rotated being dragged by the mouse
    /// </summary>
    public class DynamicRotation : HandlingAction3D
    {
        public DynamicRotation() : base(ModifierNames.DynamicRotation)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();

            Viewer.DeactivateGrid();
            Viewer.DisplayPrivilegedPlane(false, 1);
        }

        protected override void MouseDownHandler(int x, int y)
        {
            View.StartRotation(x, y, 0.0);
        }

        protected override void MouseMoveHandler(int x, int y, bool mouseDown)
        {
            if (mouseDown)
            {
                View.Rotation(x, y);
            }
        }
    }
}