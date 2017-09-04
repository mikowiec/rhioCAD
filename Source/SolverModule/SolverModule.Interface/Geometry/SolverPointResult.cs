#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    public class SolverPointResult : SolverPreviewObject
    {
        private readonly GeometryType _geometryType;
        public int ParentIndex;

        public SolverPointResult(Point3D point) : base(point)
        {
        }

        public SolverPointResult(Point3D point, int parentIndex)
            : base(point)
        {
            ParentIndex = parentIndex;
        }

        public SolverPointResult(Point3D point, GeometryType geometryType)
            : base(point)
        {
            _geometryType = geometryType;
        }

        public SolverPointResult(Point3D point, GeometryType geometryType, int parentIndex)
            : base(point)
        {
            _geometryType = geometryType;
            ParentIndex = parentIndex;
        }

        public override void Preview(Document document)
        {
            GeometricObjectUtils.DrawMarkerPoint(document, Point, _geometryType);
        }
    }
}