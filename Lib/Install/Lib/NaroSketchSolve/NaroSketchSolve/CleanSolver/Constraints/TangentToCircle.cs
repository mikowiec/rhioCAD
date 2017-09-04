#region Usings

using CleanSolver.SolverSystem;

#endregion

namespace CleanSolver.Constraints
{
    internal class TangentToCircle : ConstraintBase
    {
        public override double Calc()
        {
            var dx = L1.P2.X.Value - L1.P1.X.Value;
            var dy = L1.P2.Y.Value - L1.P1.Y.Value;
            var hyp = SolverUtils.Hypot(dx, dy);
            //Calculate the expected tangent intersection points
            var rpx = circle1.Center.X.Value - dy/hyp*circle1.Radius.Value;
            var rpy = circle1.Center.Y.Value + dx/hyp*circle1.Radius.Value;
            var rpxN = circle1.Center.X.Value + dy/hyp*circle1.Radius.Value;
            var rpyN = circle1.Center.Y.Value - dx/hyp*circle1.Radius.Value;

            var error1 = (-dy*rpx + dx*rpy + (L1.P1.X.Value*L1.P2.Y.Value - L1.P2.X.Value*L1.P1.Y.Value))/hyp;
            var error2 = (-dy*rpxN + dx*rpyN + (L1.P1.X.Value*L1.P2.Y.Value - L1.P2.X.Value*L1.P1.Y.Value))/hyp;
            error1 = error1*error1;
            error2 = error2*error2;
            var error = 0.0;
            if (error1 < error2) error += error1;
            else error += error2;
            return error;
        }
    }
}