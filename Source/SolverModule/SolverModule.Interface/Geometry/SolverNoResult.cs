#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    public class SolverNoResult : SolverPreviewObject
    {
        private readonly GeometryType _geometryType;

        public SolverNoResult(Point3D point) : base(point)
        {
        }

        public SolverNoResult(Point3D point, GeometryType geometryType)
            : base(point)
        {
            _geometryType = geometryType;
        }

        public override void Preview(Document document)
        {
            //GeometricObjectUtils.DrawMarkerPoint(document, Point, _geometryType);
        }
    }
}