#region Usings

using System.Drawing;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.GC;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.PrsMgr;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.TopoDS;

using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using NaroCppCore.Occ.Precision;

#endregion

namespace OccCode
{
    public static class OccShapeCreatorCode
    {
        public static TopoDSShape BuildPoint(Point3D firstPoint)
        {
            return new BRepBuilderAPIMakeVertex(firstPoint.GpPnt).Shape;
        }

        /// <summary>
        ///   Builds a rectangle from 3 points received as parameter
        ///   Rectangle:
        ///   P2--------P3
        ///   P1--------P4
        /// </summary>
        public static TopoDSFace BuildRectangle(Point3D firstPoint, Point3D secondPoint, Point3D thirdPoint)
        {
            var fourth = new gpPnt();
            GeomUtils.CalculateRectangleVertexes(firstPoint.GpPnt, secondPoint.GpPnt, thirdPoint.GpPnt, ref fourth);
            var fourthPoint = new Point3D(fourth);
            // Check for point coincidence
            if (firstPoint.IsEqual(secondPoint) ||
                secondPoint.IsEqual(thirdPoint) ||
                thirdPoint.IsEqual(fourthPoint) ||
                fourthPoint.IsEqual(firstPoint))
            {
                return null;
            }

            var aEdge1 = new BRepBuilderAPIMakeEdge(firstPoint.GpPnt, secondPoint.GpPnt).Edge;
            var aEdge2 = new BRepBuilderAPIMakeEdge(secondPoint.GpPnt, thirdPoint.GpPnt).Edge;
            var aEdge3 = new BRepBuilderAPIMakeEdge(thirdPoint.GpPnt, fourthPoint.GpPnt).Edge;
            var aEdge4 = new BRepBuilderAPIMakeEdge(fourthPoint.GpPnt, firstPoint.GpPnt).Edge;

            var aWire = new BRepBuilderAPIMakeWire(aEdge1, aEdge2, aEdge3, aEdge4).Wire;
            if (aWire.IsNull)
            {
                return null;
            }

            var faceProfile = new BRepBuilderAPIMakeFace(aWire, false).Face;
            return faceProfile.IsNull ? null : faceProfile;
        }

        /// <summary>
        ///   Builds a rectangle from 2 points received as parameter.
        ///   Rectangle:
        ///   P2--------P3
        ///   P1--------P4
        /// </summary>
        /// <param name = "firstPoint"></param>
        /// <param name = "thirdPoint"></param>
        /// <param name = "direction"></param>
        /// <returns></returns>
        public static TopoDSFace BuildRectangle(gpPnt firstPoint, gpPnt thirdPoint, gpDir direction)
        {
            // Check for point coincidence
            if (firstPoint.IsEqual(thirdPoint, Precision.Confusion))
                return null;

            var secondPoint = new gpPnt();
            var fourthPoint = new gpPnt();
            GeomUtils.CalculateRectangleVertexes(firstPoint, thirdPoint, direction, ref secondPoint, ref fourthPoint);
            return BuildRectangle(new Point3D(firstPoint), new Point3D(secondPoint), new Point3D(fourthPoint));
        }

        /// <summary>
        ///   Build a cicle knowing the axis that describe the center (location and direction)
        ///   and also the radius value
        /// </summary>
        public static TopoDSWire CreateWireCircle(gpAx1 centerAxis, double radius)
        {
            var centerCoord = new gpAx2 {Axis = (centerAxis)};
            var circle = new gpCirc(centerCoord, radius);

            var edge = new BRepBuilderAPIMakeEdge(circle).Edge;
            var wire = new BRepBuilderAPIMakeWire(edge).Wire;
            return wire;
        }


        public static TopoDSWire CreateLineWire(Point3D firstPoint, Point3D secondPoint)
        {
            var aEdge = new BRepBuilderAPIMakeEdge(firstPoint.GpPnt, secondPoint.GpPnt).Edge;
            return new BRepBuilderAPIMakeWire(aEdge).Wire;
        }


        /// <summary>
        ///   Build a cicle knowing the axis that describe the center (location and direction)
        ///   and also the radius value
        /// </summary>
        public static TopoDSFace CreateCircle(gpAx1 centerAxis, double radius)
        {
            var wire = CreateWireCircle(centerAxis, radius);
            var face = new BRepBuilderAPIMakeFace(wire, true).Face;
            //face.Locat
            return face;
        }


        public static AISInteractiveObject TextureShape(TopoDSShape shape, string texture, Node node)
        {
            var texturedShape = new AISTexturedShape(shape);
            var textNameWrapper = new TCollectionAsciiString(texture);
            node.Set<ObjectInterpreter>().Data = textNameWrapper;
            texturedShape.TextureFileName = textNameWrapper;
            texturedShape.SetTextureMapOn();
            texturedShape.SetTextureRepeat(false, 1.0, 1.0);
            texturedShape.DisplayMode = 3;
            texturedShape.SetColor(ShapeUtils.GetOccColor(Color.White));

            texturedShape.TypeOfPresentation = (PrsMgrTypeOfPresentation3d.PrsMgr_TOP_AllView);
            return texturedShape;
        }


        public static AISLine BuildDottedLine(AISLine line)
        {
            var drawer = line.Attributes;
            drawer.LineAspect = new Prs3dLineAspect(QuantityNameOfColor.Quantity_NOC_GRAY70,
                                                        AspectTypeOfLine.Aspect_TOL_DOT, 0.5);

            line.UnsetSelectionMode();
            return line;
        }

        public static AISLine BuildDottedLine(GeomLine line)
        {
            var helperLine = new AISLine(line);
            var drawer = helperLine.Attributes;
            drawer.LineAspect = new Prs3dLineAspect(QuantityNameOfColor.Quantity_NOC_GRAY70,
                                                        AspectTypeOfLine.Aspect_TOL_DOT, 0.5);

            helperLine.UnsetSelectionMode();
            return helperLine;
        }


        public static TopoDSShape CreateArcShape(Point3D point1, Point3D point2, Point3D point3)
        {
            if (point1.IsEqual(point2) || point1.IsEqual(point3) || point2.IsEqual(point3))
                return null;

            var line = new gpLin(point1.GpPnt, new gpDir(new gpVec(point1.GpPnt, point2.GpPnt)));
            if (line.Distance(point3.GpPnt) < Precision.Confusion)
                return null;

            var gceCirc = new gceMakeCirc(point1.GpPnt, point2.GpPnt, point3.GpPnt);
            var circle = gceCirc.Value;
            var arc = new GCMakeArcOfCircle(circle, point2.GpPnt, point1.GpPnt, true);
            var curve = arc.Value;
            var edge = new BRepBuilderAPIMakeEdge(curve).Edge;
            var circleWire = new BRepBuilderAPIMakeWire(edge).Wire;
            return circleWire;
        }
    }
}