#region Usings

//using CleanSolver.SolverSystem;

#endregion

namespace ConstraintsModule.Constraints
{
    internal class P2LDistance : ConstraintBase
    {
        public override double Calc()
        {
            var dx = L1.P2.X.Value - L1.P1.X.Value;
            var dy = L1.P2.Y.Value - L1.P1.Y.Value;

            var t = -(L1.P1.X.Value*dx - P1.X.Value*dx + L1.P1.Y.Value*dy - P1.Y.Value*dy)/(dx*dx + dy*dy);
            var xint = L1.P1.X.Value + dx*t;
            var yint = L1.P1.Y.Value + dy*t;
            var temp = Utils.Hypot((P1.X.Value - xint), (P1.Y.Value - yint)) - Distance;
            return temp*temp/10;
        }
    }
}