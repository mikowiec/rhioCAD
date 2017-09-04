#region Usings

using System.Drawing;
using NaroConstants.Names;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.TopoDS;
using OccCode;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace Naro.Infrastructure.Interface.GeomHelpers
{
    public static class GeometricObjectUtils
    {
        public static bool DrawMarkerEdge(Document document, Point3D firstPoint, Point3D secondPoint, Color color)
        {
            var builder = new NodeBuilder(document, FunctionNames.SolverLineMarker);
            builder[0].TransformedPoint3D = firstPoint;
            builder[1].TransformedPoint3D = secondPoint;

            builder.Color = color;
            return builder.ExecuteFunction();
        }

        public static bool DrawMarkerEdge(TopoDSEdge edge, Document document, Color color)
        {
            Point3D? firstPoint;
            Point3D? lastPoint;
            GeomUtils.EdgeRange(edge, out firstPoint, out lastPoint);
            if (firstPoint == null || lastPoint == null) return false;
            var first = (Point3D) firstPoint;
            var last = (Point3D) lastPoint;

            return DrawMarkerEdge(document, first, last, color);
        }

        public static bool DrawMarkerPoint(Document document, Point3D point, GeometryType geometryType)
        {
            var builder = new NodeBuilder(document, FunctionNames.SolverPointMarker);
            builder[0].TransformedPoint3D = point;
            builder[1].Real = 1.3;
            builder[2].Integer = (int) AspectTypeOfMarker.Aspect_TOM_BALL;
            switch (geometryType)
            {
                case GeometryType.EndPoint:
                    builder.Color = Color.Red;
                    break;
                case GeometryType.MidPoint:
                    builder.Color = Color.BlueViolet;
                    break;
                default:
                    builder.Color = Color.Black;
                    break;
            }
            return builder.ExecuteFunction();
        }
    }
}