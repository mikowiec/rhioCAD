namespace CleanSolver.Constraints
{
    public class Horizontal : ConstraintBase
    {
        public override double Calc()
        {
            var ody = L1.P2.Y.Value - L1.P1.Y.Value;

            return ody*ody*1000;
        }
    }
}