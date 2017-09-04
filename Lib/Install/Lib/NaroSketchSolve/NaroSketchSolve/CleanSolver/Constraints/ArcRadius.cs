#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class ArcRadius : ConstraintBase
    {
        public override double Calc()
        {
            var rad1 = SolverUtils.Hypot(arc1.Center.X.Value - arc1.StartX, arc1.Center.Y.Value - Arc1StartY);
            var rad2 = SolverUtils.Hypot(arc1.Center.X.Value - arc1.EndX, arc1.Center.Y.Value - arc1.EndY);
            var temp = rad1 - Radius;
            return temp*temp;
        }
    }
}