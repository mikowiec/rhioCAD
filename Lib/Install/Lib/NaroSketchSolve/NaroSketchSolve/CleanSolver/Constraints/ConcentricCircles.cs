#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class ConcentricCircles : ConstraintBase
    {
        public override double Calc()
        {
            var temp = SolverUtils.Hypot(circle1.Center.X.Value - circle2.Center.X.Value, circle1.Center.Y.Value - circle2.Center.Y.Value);
            return temp*temp;
        }
    }
}