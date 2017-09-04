
using System.Collections.Generic;
using log4net;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Library.Geometry;
using Naro.Sketcher.Constants;
using Naro.Solver.DataHelper;
using OCNaroWrappers;
using System;

namespace Naro.Sketcher.Inputs
{
    public delegate void ActionActivatedEventHandler(ActionType actionType, bool activate);

    public class EditDetectionPipe : PipeBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(EditDetectionPipe));

        public event ActionActivatedEventHandler ActivateActionHandler;

        private OCAIS2D_InteractiveContext _context2d;
        private List<Shape2d> _drawnShapesList = new List<Shape2d>();
        private Shape2d _selectedShape;
        private Solver.Solver _solver;
        private OCV2d_View _view2d;
        private bool _enableEditDetectionPipe = false;

        public EditDetectionPipe(OCAIS2D_InteractiveContext context2d, OCV2d_View view2d, Solver.Solver solver) : base(ActionNames.EditDetectionPipe)
        {
            _context2d = context2d;
            _solver = solver;
            _view2d = view2d;
        }

        protected override void SourceOnData(object data)
        {
            // Check if the pipe is enabled
            if (!_enableEditDetectionPipe)
            {
                return;
            }

            var mouseData = data as Mouse3dPosition;

            // Filter the mouse events, only mouse down is passing
            if (!mouseData.IsMouseDown)
            {
                return;
            }

            // Filter also the shape dragging
            if (_selectedShape != null)
            {
                if (_selectedShape.CanDrag(mouseData.Point.X(), mouseData.Point.Y()))
                {
                    return;
                }
                if (_selectedShape.IsDragging)
                {
                    return;
                }
            }

            // Retrieve the selected shapes and enable the markers for them
            bool shapeSelected = false;
            _selectedShape = null;
            foreach (Shape2d shape2d in _drawnShapesList)
            {
                int nb = _context2d.NbSelected();
                if (_context2d.IsSelected(shape2d))
                {
                    shape2d.Select();
                    _selectedShape = shape2d;
                    _context2d.AddOrRemoveSelected(shape2d, false);

                    shapeSelected = true;
                }
                else
                {
                    shape2d.Deselect();
                }
                shape2d.EndDragging();
            }

            if (shapeSelected)
            {
                log.Debug("EditDetectionPipe shape selected");

                // Inform the action controller that it can switch to edit mode
                ActivateActionHandler(ActionType.Action2d_EditShape, true);

                // Notify listeners that a new selected shape is found
                AddData(_selectedShape);
            }
            else
            {
                //log.Debug("EditDetectionPipe unselect shape");
                //ActivateActionHandler(ActionType.Action2d_EditShape, false);
            }

            _view2d.Update();
        }

        /// <summary>
        /// The pipe is notified when a new shape is drawn
        /// </summary>
        /// <param name="data"></param>
        public override void OnNotification(string objectName, Object data)
        {
            if (objectName == PipeConstants.EnableDetectionPipe)
            {
                _enableEditDetectionPipe = true;
                log.Debug("EditDetectionPipe enabled");
            }
            else if (objectName == PipeConstants.DisableDetectionPipe)
            {
                _enableEditDetectionPipe = false;
                log.Debug("EditDetectionPipe disabled");
            }
            else if (objectName == PipeConstants.RegenerateSolver)
            {
                RegenerateSolver();
            }
            else
            {
                var shape = data as Shape2d;

                if (shape != null)
                {
                    _drawnShapesList.Add(shape);
                }
            }
        }

        /// <summary>
        /// Clears all the magic points from the solver and fills again the
        /// solver with the new magic ponts
        /// </summary>
        private void RegenerateSolver()
        {
            // Clear the magic points
            _solver.Geometry.Children.Clear();

            // Add the nmagic points from the current geometry
            foreach (Shape2d shape2d in _drawnShapesList)
            {
                NodeHelper.AddShape(_solver.Geometry, shape2d);
            }
        }
    }
}
