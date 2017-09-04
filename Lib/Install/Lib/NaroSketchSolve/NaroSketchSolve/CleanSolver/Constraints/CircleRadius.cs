namespace CleanSolver.Constraints
{
    internal class CircleRadius : ConstraintBase
    {
        public override double Calc()
        {
            return (circle1.Radius.Value - Radius)*(circle1.Radius.Value - Radius);
        }
    }
}