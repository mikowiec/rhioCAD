#region Usings



#endregion

namespace ConstraintsModule.Mappings.Shapes
{
    public class CircleSolverObjectMapper : ShapeSolverObjectMapping
    {
        protected override void MapToSolver()
        {
            //var point0 = MappedReference<Point>(0);
            //var radius = _builder[1].Real;
            //var refRadius = new DoubleRefObject(radius);
            //_parameters.Add(refRadius);
            //var circle = new Circle {Center = point0, Radius = refRadius};
            //MapSelf(circle);
        }

        protected override void UnmapFromSolver()
        {
            //_builder[1].Real = UnmapSelf<Circle>().Radius.Value;
        }
    }
}