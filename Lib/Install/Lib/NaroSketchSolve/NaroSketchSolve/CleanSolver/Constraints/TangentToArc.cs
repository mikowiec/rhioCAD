namespace CleanSolver.Constraints
{
    internal class TangentToArc : ConstraintBase
    {
        public override double Calc()
        {
            var dx = L1.P2.X.Value - L1.P1.X.Value;
            var dy = L1.P2.Y.Value - L1.P1.Y.Value;


            var radsq = (arc1.Center.X.Value - arc1.StartX)*(arc1.Center.X.Value - arc1.StartX) +
                        (arc1.Center.Y.Value - arc1.StartY)*(arc1.Center.Y.Value - arc1.StartY);
            var t = -(L1.P1.X.Value*dx - arc1.Center.X.Value*dx + L1.P1.Y.Value*dy - arc1.Center.Y.Value*dy)/(dx*dx + dy*dy);
            var xint = L1.P1.X.Value + dx*t;
            var yint = L1.P1.Y.Value + dy*t;
            var temp = (arc1.Center.X.Value - xint)*(arc1.Center.X.Value - xint) + (arc1.Center.Y.Value - yint)*(arc1.Center.Y.Value - yint) -
                       radsq;
            return temp*temp;
        }
    }
}