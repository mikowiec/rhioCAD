namespace CleanSolver.Constraints
{
    internal class PointOnLine : ConstraintBase
    {
        public override double Calc()
        {
            var dx = L1.P2.X.Value - L1.P1.X.Value;
            var dy = L1.P2.Y.Value - L1.P1.Y.Value;

            var m = dy/dx; //Slope
            var n = dx/dy; //1/Slope

            if (m <= 1 && m >= -1)
            {
                //Calculate the expected y point given the x coordinate of the point
                var ey = L1.P1.Y.Value + m*(P1.X.Value - L1.P1.X.Value);
                return (ey - P1.Y.Value)*(ey - P1.Y.Value);
            }
            //Calculate the expected x point given the y coordinate of the point
            var ex = L1.P1.X.Value + n*(P1.Y.Value - L1.P1.Y.Value);
            return (ex - P1.X.Value)*(ex - P1.X.Value);
        }
    }
}