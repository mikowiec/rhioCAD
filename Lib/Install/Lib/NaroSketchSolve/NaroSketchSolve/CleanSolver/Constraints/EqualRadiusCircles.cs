namespace CleanSolver.Constraints
{
    internal class EqualRadiusCircles : ConstraintBase
    {
        public override double Calc()
        {
            var temp = circle1.Radius.Value - circle2.Radius.Value;
            return temp*temp;
        }
    }
}