#region Usings

using ConstraintsModule.Primitives;

//using SketchSolve.Primitives;
//using TreeData.AttributeInterpreter;

#endregion

namespace ConstraintsModule.Mappings.Shapes
{
    public class PointSolverObjectMapper : ShapeSolverObjectMapping
    {
        public Point Point { get; private set; }

        protected override void MapToSolver()
        {
            //var originalCoordinate = _builder[1].TransformedPoint3D;
            //Point = BuildCoordinate(originalCoordinate);
            //MapSelf(Point);
        }

        protected override void UnmapFromSolver()
        {
            //var point = UnmapSelf<Point>();
            //var translate = _coordinateTranslator.ConvertToGlobal(new Point3D(point.X.Value, point.Y.Value, 0));
            //_builder[1].TransformedPoint3D = translate;
        }
    }
}