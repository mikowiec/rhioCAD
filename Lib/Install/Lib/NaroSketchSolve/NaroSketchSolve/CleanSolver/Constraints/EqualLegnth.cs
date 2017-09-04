#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class EqualLegnth : ConstraintBase
    {
        public override double Calc()
        {
            var temp = SolverUtils.Hypot(L1.P2.X.Value - L1.P1.X.Value, L1.P2.Y.Value - L1.P1.Y.Value) -
                       SolverUtils.Hypot(L2.P2.X.Value - L2.P1.X.Value, L2.P2.Y.Value - L2.P1.Y.Value);
            return temp*temp;
        }
    }
}