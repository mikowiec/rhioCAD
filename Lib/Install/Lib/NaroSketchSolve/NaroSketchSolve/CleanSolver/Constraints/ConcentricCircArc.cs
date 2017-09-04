#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class ConcentricCircArc : ConstraintBase
    {
        public override double Calc()
        {
            var temp = SolverUtils.Hypot(arc1.Center.X.Value - circle1.Center.X.Value, arc1.Center.Y.Value - circle1.Center.Y.Value);
            return temp*temp;
        }
    }
}