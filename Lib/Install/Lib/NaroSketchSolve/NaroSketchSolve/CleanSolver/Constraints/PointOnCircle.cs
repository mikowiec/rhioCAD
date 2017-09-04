#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class PointOnCircle : ConstraintBase
    {
        public override double Calc()
        {
            //see what the current radius to the point is
            var rad1 = SolverUtils.Hypot(circle1.Center.X.Value - P1.X.Value, circle1.Center.Y.Value - P1.Y.Value);
            //Compare this radius to the radius of the circle, return the error squared
            var temp = rad1 - circle1.Radius.Value;
            return temp*temp;
        }
    }
}
