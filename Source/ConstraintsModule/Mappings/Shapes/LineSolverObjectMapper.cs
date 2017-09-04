#region Usings



#endregion

namespace ConstraintsModule.Mappings.Shapes
{
    public class LineSolverObjectMapper : ShapeSolverObjectMapping
    {
        protected override void MapToSolver()
        {
            //var point0 = MappedReference<Point>(0);
            //var point1 = MappedReference<Point>(1);
            //var line = new Line {P1 = point0, P2 = point1};
            //MapSelf(line);
        }

        protected override void UnmapFromSolver()
        {
      /*      var line = UnmapSelf<Line>();
            var translatePoint1 = _coordinateTranslator.ConvertToGlobal(new Point3D(line.P1.X.Value, line.P1.Y.Value, 0));
            var translatePoint2 = _coordinateTranslator.ConvertToGlobal(new Point3D(line.P2.X.Value, line.P2.Y.Value, 0));
            _builder[0].RefTransformedPoint3D = translatePoint1;
            _builder[1].RefTransformedPoint3D = translatePoint2;*/

        }
     
    }
}