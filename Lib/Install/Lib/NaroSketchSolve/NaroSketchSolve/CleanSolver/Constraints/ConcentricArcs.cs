#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class ConcentricArcs : ConstraintBase
    {
        public override double Calc()
        {
            var temp = SolverUtils.Hypot(arc1.Center.X.Value - arc2.Center.X.Value, arc1.Center.X.Value - arc2.Center.Y.Value);
            return temp*temp;
        }
    }
}