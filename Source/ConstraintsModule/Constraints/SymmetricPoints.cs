namespace ConstraintsModule.Constraints
{
    internal class SymmetricPoints : ConstraintBase
    {
        public override double Calc()
        {
            var dx = SymLine.P2.X.Value - SymLine.P1.X.Value;
            var dy = SymLine.P2.Y.Value - SymLine.P1.Y.Value;
            var t = -(dy*P1.X.Value - dx*P1.Y.Value - dy*SymLine.P1.X.Value + dx*SymLine.P1.Y.Value)/(dx*dx + dy*dy);
            var ex = P1.X.Value + dy*t*2;
            var ey = P1.Y.Value - dx*t*2;
            var temp = (ex - P2.X.Value);
            var temp2 = (ey - P2.Y.Value);
            return temp*temp + temp2*temp2;
        }
    }
}