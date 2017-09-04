#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class EqualRadiusArcs : ConstraintBase
    {
        public override double Calc()
        {
            var rad1 = SolverUtils.Hypot(arc1.Center.X.Value - arc1.StartX, arc1.Center.Y.Value - arc1.StartY);
            var rad2 = SolverUtils.Hypot(arc2.Center.X.Value - arc2.StartX, arc2.Center.Y.Value - arc2.StartY);
            var temp = rad1 - rad2;
            return temp*temp;
        }
    }
}