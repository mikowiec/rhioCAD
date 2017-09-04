#region Usings

using System;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.GC;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Utils
{
    public static class DimensionUtils
    {
        /// <summary>
        ///   Builds a diameter dimension on a circle like edge
        /// </summary>
        private const double ArrowSize = 0.8;

        private static AISInteractiveObject BuildCircleDimension(TopoDSShape referenceShape, gpPnt textLocation)
        {
            var edge = TopoDS.Edge(referenceShape);
            var curve = new BRepAdaptorCurve(edge);
            if (curve.GetType != GeomAbsCurveType.GeomAbs_Circle)
            {
                return null;
            }

            // For a circle use a diameter dimension
            var circle = curve.Circle;
            var diameter = 2.0*circle.Radius;
            var text = new TCollectionExtendedString(String.Format("{0:0.00}", diameter));
            var rd = new AISDiameterDimension(referenceShape, diameter, text, textLocation,
                                                 DsgPrsArrowSide.DsgPrs_AS_BOTHAR, true, ArrowSize);
            rd.SetColor(QuantityNameOfColor.Quantity_NOC_RED);
            return rd;
        }


        /// <summary>
        ///   Detects the referenced shape type and generates an appropiate
        ///   dimension for it
        /// </summary>
        public static AISInteractiveObject CreateDependency(TopoDSShape referenceShape, gpPnt textLocation, DsgPrsArrowSide arrowType, bool isOffset = false, gpPnt offset = null)
        {
            if (referenceShape ==  null || referenceShape.ShapeType != TopAbsShapeEnum.TopAbs_EDGE)
            {
                return null;
            }

            var curve = new BRepAdaptorCurve(TopoDS.Edge(referenceShape));
            if (curve.GetType == GeomAbsCurveType.GeomAbs_Circle)
            {
                return BuildCircleDimension(referenceShape, textLocation);
            }
            return curve.GetType == GeomAbsCurveType.GeomAbs_Line
                       ? BuildLineDimension(TopoDS.Edge(referenceShape), textLocation, null, arrowType, isOffset, offset)
                       : null;
        }

        /// <summary>
        ///   Builds a dimension on an edge of type Line
        /// </summary>
        private static AISInteractiveObject BuildLineDimension(TopoDSEdge edge, gpPnt textLocation,
                                                                  GeomPlane dimensionPlane, DsgPrsArrowSide arrowType, bool isOffset, gpPnt offset)
        {
            var curve = new BRepAdaptorCurve(edge);
            if (curve.GetType != GeomAbsCurveType.GeomAbs_Line)
            {
                return null;
            }

            // For a line use a length dimension
            var line = curve.Line;
            if (line.Distance(textLocation) < Precision.Confusion)
            {
                textLocation.X = (textLocation.X + 0.01);
            }
            var firstPoint = curve.Value(curve.FirstParameter);
            var lastPoint = curve.Value(curve.LastParameter);
            var plane = dimensionPlane;
            if (plane == null)
            {
                var mkPlane = new GCMakePlane(firstPoint, lastPoint, textLocation);
                plane = mkPlane.Value;
            }
            var length = firstPoint.Distance(lastPoint);
            return length < 1e-12
                       ? null
                       : GeomUtils.BuildLengthDimension(firstPoint, lastPoint, plane, textLocation,
                                                        arrowType, ArrowSize, 0.2, isOffset, offset);
        }

        /// <summary>
        ///   Builds a dimension on an edge of type Line
        /// </summary>
        public static AISInteractiveObject BuildLineDimension(NodeBuilder lineTwoPoints, gpPnt textLocation,
                                                                   DsgPrsArrowSide arrowType, bool isOffset, gpPnt offset)
        {

            var point1 = lineTwoPoints[0].RefTransformedPoint3D;
            var point2 = lineTwoPoints[1].RefTransformedPoint3D;

            var length = point1.GpPnt.Distance(point2.GpPnt);
            Console.WriteLine(lineTwoPoints.ShapeName);
               
            var mkPlane = new GCMakePlane(point1.GpPnt, point2.GpPnt, textLocation);
            var plane = mkPlane.Value;
            
            return length < 1e-12
                       ? null
                       : GeomUtils.BuildLengthDimension(point1.GpPnt, point2.GpPnt, plane, textLocation,
                                                        arrowType, ArrowSize, 0.2, isOffset, offset);
        }

        public static Point3D ComputeMiddlePointPosition(TopoDSShape wire)
        {
            var firstPoint =
                new Point3D(
                    ShapeUtils.ConvertShapeToPoint(ShapeUtils.ExtractSubShape(wire, 1, TopAbsShapeEnum.TopAbs_VERTEX)));
            var secondPoint =
                new Point3D(
                    ShapeUtils.ConvertShapeToPoint(ShapeUtils.ExtractSubShape(wire, 2, TopAbsShapeEnum.TopAbs_VERTEX)));
            return ComputeMiddlePoint(firstPoint, secondPoint);
        }

        public static Point3D ComputeMiddlePoint(Point3D firstPoint, Point3D secondPoint)
        {
            var midPoint = new Point3D(
                (firstPoint.X + secondPoint.X)/2,
                (firstPoint.Y + secondPoint.Y)/2,
                (firstPoint.Z + secondPoint.Z)/2);
            return midPoint;
        }

        public static Point3D ComputeMiddlePointPosition(Node rectangleNode, int wireIndex)
        {
            return
                ComputeMiddlePointPosition(ShapeUtils.ExtractSubShape(rectangleNode, wireIndex,
                                                                      TopAbsShapeEnum.TopAbs_EDGE));
        }
    }
}