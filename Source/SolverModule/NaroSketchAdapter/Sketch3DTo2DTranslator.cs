#region Usings

using ConstraintsModule.Primitives;
using NaroCppCore.Occ.gp;
using OccCode;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace NaroSketchAdapter
{
    public class Sketch3DTo2DTranslator
    {
        private readonly Axis _normalOnSketch;


        private Point _origin;
        private Point3D _originPos;

        public Sketch3DTo2DTranslator(Axis normalOnSketch)
        {
            _normalOnSketch = normalOnSketch;
        }

        public Point Origin
        {
            private get { return _origin; }
            set
            {
                _origin = value;
                if (value != null)
                    _originPos = new Point3D(_origin.X.Value, _origin.Y.Value, 0);
            }
        }

        public Point3D Translate(Point3D coordinate)
        {
            var result = Translate(_normalOnSketch, coordinate);

            return result;
        }

        public Point3D ConvertToGlobal(Point3D coordinate)
        {
            var result = ConvertToGlobal(_normalOnSketch, coordinate);
            if (Origin != null)
            {
                var origin = new Point3D(Origin.X.Value, Origin.Y.Value, 0);
                origin = origin.SubstractCoordinate(_originPos);
                result = result.AddCoordinate(origin);
                return result;
            }
            return result;
        }

        public static Point3D Translate(Axis normalOnSketch, Point3D coordinate)
        {
            var sketchPlane = new gpPln(normalOnSketch.Location.GpPnt,
                                           new gpDir(normalOnSketch.Direction.GpPnt.XYZ));
            var projectionPoint = GeomUtils.ProjectPointOnPlane(coordinate.GpPnt, sketchPlane, Precision.Confusion);
            return new Point3D(projectionPoint);
        }

        public static Point3D ConvertToGlobal(Axis normalOnSketch, Point3D coordinate)
        {
            var normal = new gpAx2();
            normal.Axis = normalOnSketch.GpAxis;
            return new Point3D(GeomUtils.Point2DTo3D(normal, new gpPnt2d(coordinate.X, coordinate.Y)));
        }
    }
}