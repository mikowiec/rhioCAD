namespace CleanSolver.Constraints
{
    internal class Colinear : ConstraintBase
    {
        public override double Calc()
        {
            var error = 0.0;
            var dx = L1.P2.X.Value - L1.P1.X.Value;
            var dy = L1.P2.Y.Value - L1.P1.Y.Value;

            var m = dy/dx;
            var n = dx/dy;
            // Calculate the error between the expected intersection point
            // and the true point of the second lines two end points on the
            // first line
            if (m <= 1 && m > -1)
            {
                //Calculate the expected y point given the x coordinate of the point
                var ey = L1.P1.Y.Value + m*(L2.P1.X.Value - L1.P1.X.Value);
                error += (ey - L2.P1.Y.Value)*(ey - L2.P1.Y.Value);

                ey = L1.P1.Y.Value + m*(L2.P2.X.Value - L1.P1.X.Value);
                error += (ey - L2.P2.Y.Value)*(ey - L2.P2.Y.Value);
            }
            else
            {
                //Calculate the expected x point given the y coordinate of the point
                var ex = L1.P1.X.Value + n*(L2.P1.Y.Value - L1.P1.Y.Value);
                error += (ex - L2.P1.X.Value)*(ex - L2.P1.X.Value);

                ex = L1.P1.X.Value + n*(L2.P2.Y.Value - L1.P1.Y.Value);
                error += (ex - L2.P2.X.Value)*(ex - L2.P2.X.Value);
            }
            return error;
        }
    }
}