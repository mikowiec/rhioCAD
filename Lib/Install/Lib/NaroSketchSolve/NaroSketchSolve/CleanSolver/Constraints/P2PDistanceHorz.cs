namespace CleanSolver.Constraints
{
    internal class P2PDistanceHorz : ConstraintBase
    {
        public override double Calc()
        {
            return (P1.X.Value - P2.X.Value)*(P1.X.Value - P2.X.Value) - Distance*Distance;
        }
    }
}