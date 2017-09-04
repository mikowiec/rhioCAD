namespace CleanSolver.Constraints
{
    internal class P2PDistanceVert : ConstraintBase
    {
        public override double Calc()
        {
            return (P1.Y.Value - P2.Y.Value)*(P1.Y.Value - P2.Y.Value) - Distance*Distance;
        }
    }
}