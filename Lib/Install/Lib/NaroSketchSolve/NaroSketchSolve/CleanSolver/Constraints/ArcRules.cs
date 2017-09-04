namespace CleanSolver.Constraints
{
    internal class ArcRules : ConstraintBase
    {
        public override double Calc()
        {
            var a1Endx2 = arc1.EndX * arc1.EndX;
            var a1Endy2 = arc1.EndY * arc1.EndY;
            var a1Startx2 = arc1.StartX * arc1.StartX;
            var a1Starty2 = arc1.StartY * arc1.StartY;
            var num = -2*arc1.Center.X.Value * arc1.EndX + a1Endx2 - 2 * arc1.Center.Y.Value * arc1.EndY + a1Endy2 +
                      2*arc1.Center.X.Value * arc1.StartX - a1Startx2 + 2 * arc1.Center.Y.Value * arc1.StartY - a1Starty2;
            return num*num/
                   (4.0*a1Endx2 + a1Endy2 - 2*arc1.EndX * arc1.StartX + a1Startx2 - 2*arc1.EndY * arc1.StartY + a1Starty2);
        }
    }
}