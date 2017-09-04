#region Usings

using System.Drawing;
using Naro.Infrastructure.Interface.GeomHelpers;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    public class SolverEdgeTwoPointsResult : SolverPreviewObject
    {
        public readonly Point3D SecondPoint;
        private readonly Color _color;

        public SolverEdgeTwoPointsResult(Point3D point, Point3D secondPoint, Color color)
            : base(point)
        {
            SecondPoint = secondPoint;
            _color = color;
            Text = "";
        }

        public SolverEdgeTwoPointsResult(Point3D point, Point3D secondPoint)
            : base(point)
        {
            SecondPoint = secondPoint;
            _color = Color.Black;
            Text = "";
        }

        public override void Preview(Document document)
        {
            GeometricObjectUtils.DrawMarkerPoint(document, Point, GeometryType.MidPoint);
            GeometricObjectUtils.DrawMarkerEdge(document, Point, SecondPoint, _color);
        }
    }
}