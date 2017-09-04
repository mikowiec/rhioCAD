#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class PointOnArc : ConstraintBase
    {
        public override double Calc()
        {
            var rad1 = SolverUtils.Hypot(arc1.Center.X.Value - P1.X.Value, arc1.Center.Y.Value - P1.Y.Value);
            var rad2 = SolverUtils.Hypot(arc1.Center.X.Value - arc1.StartX, arc1.Center.Y.Value - arc1.StartX);
            //Compare this radius to the radius of the circle, return the error squared
            var temp = rad1 - rad2;
            return temp*temp;
        }
    }
}