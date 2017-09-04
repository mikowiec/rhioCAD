
using System.Windows.Forms;
using log4net;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Library.Geometry;
using Naro.Sketcher.Constants;

namespace Naro.Sketcher.Modifiers
{
    /// <summary>
    /// Action that handles the edit mode of Shape2d
    /// </summary>
    public class EditAction : DrawingAction2d
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(EditAction));

        private Shape2d _selectedShape;

        public EditAction() : base("EditShape2d")
        {
            RegisterInput(ActionNames.EditDetectionPipe);
        }

        protected override void OnReceiveInputData(string inputName, object data)
        {
            if (inputName == ActionNames.EditDetectionPipe)
            {
                _selectedShape = data as Shape2d;
            }
            else
            {
                base.OnReceiveInputData(inputName, data);
            }

            // A shape must be selected
            if ((_occMousePosition == null) || (_selectedShape == null))
            {
                return;
            }

            // The input was processed in the base class, just use the coordinates received
            if (inputName == ActionNames.SolverDrawerPipe)
            {
                OnMouseClick3dAction(_occMousePosition);
            }
        }

        private void OnMouseClick3dAction(Mouse3dPosition point)
        {
            if (point.IsMouseDown)
            {
                // Check if a shape dragging is currently executing
                if (_selectedShape.IsDragging)
                {
                    _selectedShape.MouseDrag(point.Point.X(), point.Point.Y());
                    _selectedShape.Display(true);
                }
                else if (_selectedShape.CanDrag(point.Point.X(), point.Point.Y()))
                {
                    // Launch the dragging operation
                    _selectedShape.StartDragging(point.Point.X(), point.Point.Y());
                }
            }
            else
            {
                if (_selectedShape.IsDragging)
                {
                    _selectedShape.EndDragging();
                    Inputs[ActionNames.EditDetectionPipe].OnNotification(PipeConstants.RegenerateSolver);
                }
            }
        }

        public override void OnDeactivate()
        {
            if (_selectedShape != null)
            {
                log.Debug("EditAction deactivate");
                _selectedShape.EndDragging();
                _selectedShape.Deselect();
                _selectedShape = null;
            }
        }

        public override void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (Viewer2d.IsActive())
            {
                View2d.ShowHit(e.X, e.Y);
            }
            if (!Viewer2d.IsActive())
            {
                View2d.EraseHit();
            }

            Context2d.MoveTo(e.X, e.Y, View2d);
        }

        public override void MouseUpHandler(object sender, MouseEventArgs e)
        {
        }

        public override void MouseDownHandler(object sender, MouseEventArgs e)
        {
            Context2d.Select(true);
        }
    }
}
