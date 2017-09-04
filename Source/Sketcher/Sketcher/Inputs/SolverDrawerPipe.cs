
using Extensions.TreeData.AttributeInterpreter;
using System;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Library;
using Naro.Infrastructure.Library.Geometry;
using Naro.Sketcher.Constants;
using Naro.Solver.DataHelper;
using Naro.Solver.Rules;
using OCNaroWrappers;

namespace Naro.Sketcher.Inputs
{
    public class SolverDrawerPipe : PipeBase
    {
        private Solver.Solver _solver;
        private SolverDrawer _solverDrawer;
        private OCAIS2D_InteractiveContext _context2d;
        private OCV2d_View _view2d;

        public SolverDrawerPipe(OCAIS2D_InteractiveContext context2d, OCV2d_View view2d, Solver.Solver solver, SolverDrawer solverDrawer) : base(ActionNames.SolverDrawerPipe)
        {
            _solver = solver;
            _solverDrawer = solverDrawer;
            _context2d = context2d;
            _view2d = view2d;
        }

        protected override void SourceOnData(object data)
        {
            var mouseData = data as Mouse3dPosition;

            // Pass the coordinates through the solver
            // Check if there are any magic points around
            Double x = mouseData.Point.X(), y = mouseData.Point.Y();
            var geometry = _solver.GetInterestingCloseGeometry(new OCgp_Pnt(x, y, 0));
            if (geometry.Count > 0)
            {
                OCgp_Pnt point = geometry[0].NaroNode.Children[0].Get<GeometryInterpreter>().Value;
                x = point.X();
                y = point.Y();

                // Display the magic point
                MagicPointType magicPointType = geometry[0].MagicPointType;
                if (_solverDrawer.Show(_context2d, magicPointType, x, y, 0))
                {
                    // It returns true if the view needs update
                    _view2d.Update();
                }
            }
            else
            {
                // Hide the magic point
                if (_solverDrawer.Show(_context2d, MagicPointType.None, mouseData.Point.X(), mouseData.Point.Y(), mouseData.Point.Z()))
                {
                    _view2d.Update();
                }
            }

            // Notiffy listeners
            AddData(new Mouse3dPosition(new OCgp_Pnt(x, y, 0), mouseData.IsMouseDown));
        }

        public override void OnNotification(string objectName, Object data)
        {
            var shape = data as Shape2d;

            if (shape != null)
            {
                NodeHelper.AddShape(_solver.Geometry, shape);
            }
        }
    }
}
