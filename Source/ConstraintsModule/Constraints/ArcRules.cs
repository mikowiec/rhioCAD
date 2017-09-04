namespace ConstraintsModule.Constraints
{
    public class ArcRules : ConstraintBase
    {
        public override double Calc()
        {
            var a1Endx2 = Arc1.EndX*Arc1.EndX;
            var a1Endy2 = Arc1.EndY*Arc1.EndY;
            var a1Startx2 = Arc1.StartX*Arc1.StartX;
            var a1Starty2 = Arc1.StartY*Arc1.StartY;
            var num = -2*Arc1.Center.X.Value*Arc1.EndX + a1Endx2 - 2*Arc1.Center.Y.Value*Arc1.EndY + a1Endy2 +
                      2*Arc1.Center.X.Value*Arc1.StartX - a1Startx2 + 2*Arc1.Center.Y.Value*Arc1.StartY - a1Starty2;
            return num*num/
                   (4.0*a1Endx2 + a1Endy2 - 2*Arc1.EndX*Arc1.StartX + a1Startx2 - 2*Arc1.EndY*Arc1.StartY + a1Starty2);
        }
    }
}