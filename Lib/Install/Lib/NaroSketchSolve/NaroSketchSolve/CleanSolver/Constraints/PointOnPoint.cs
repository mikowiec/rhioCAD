namespace CleanSolver.Constraints
{
    public class PointOnPoint : ConstraintBase
    {
        public override double Calc()
        {
            return (P1.X.Value - P2.X.Value)*(P1.X.Value - P2.X.Value) + (P1.Y.Value - P2.Y.Value)*(P1.Y.Value - P2.Y.Value);
        }
    }
}
