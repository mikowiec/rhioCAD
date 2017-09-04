namespace CleanSolver.Constraints
{
    public class Vertical : ConstraintBase
    {
        public override double Calc()
        {
            var odx = L1.P2.X.Value - L1.P1.X.Value;
            return odx*odx*1000;
        }
    }
}