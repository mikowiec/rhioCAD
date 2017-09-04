#region Usings

using System.Collections.Generic;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;

#endregion

namespace NaroSketchAdapter.Rules
{
    public abstract class RuleBase : IRuleBase
    {
        private readonly GeometricSolver _solver;

        protected RuleBase(GeometricSolver solver)
        {
            _solver = solver;
            Enabled = true;
        }

        protected List<SolverGeometricObject> Geometry
        {
            get { return _solver.Geometry; }
            set { _solver.Geometry = value; }
        }

        protected List<SolverGeometricObject> LastGeometry
        {
            get { return _solver.LastGeometry; }
            set { _solver.LastGeometry = value; }
        }
    }
}