#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCppCore.Occ.gp;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    public class SolverDataPoint : GeometricObject
    {
        public SolverDataPoint(Point3D point)
        {
            DefaultConstructor();
            Point = point;
        }

        public SolverDataPoint()
        {
            DefaultConstructor();
        }

        public SolverDataPoint(Point3D point, GeometryType type)
        {
            Point = point;
            GeometryType = type;
            Direction = new gpDir();
        }

        public Point3D Point { get; set; }
        public gpDir Direction { get; private set; }

        private void DefaultConstructor()
        {
            Point = new Point3D();
            GeometryType = GeometryType.EndPoint;
            Direction = new gpDir();
        }
    }
}