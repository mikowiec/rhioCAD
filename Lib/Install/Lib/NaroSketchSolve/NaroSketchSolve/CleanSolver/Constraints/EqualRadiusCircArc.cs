#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class EqualRadiusCircArc : ConstraintBase
    {
        public override double Calc()
        {
            var rad1 = SolverUtils.Hypot(arc1.Center.X.Value - arc1.StartX, arc1.Center.Y.Value - arc1.StartY);
            var temp = rad1 - circle1.Radius.Value;
            return temp*temp;
        }
    }
}