namespace CleanSolver.Constraints
{
    internal class PointOnLineMidpoint : ConstraintBase
    {
        public override double Calc()
        {
            var ex = (L1.P1.X.Value + L1.P2.X.Value)/2;
            var ey = (L1.P1.Y.Value + L1.P2.Y.Value)/2;
            var temp = ex - P1.X.Value;
            var temp2 = ey - P1.Y.Value;
            return temp*temp + temp2*temp2;
        }
    }
}