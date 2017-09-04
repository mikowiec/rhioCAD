#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.BRepAlgoAPI;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.BRepCheck;
using NaroCppCore.Occ.BRepClass3d;
using NaroCppCore.Occ.BRepExtrema;
using NaroCppCore.Occ.BRepGProp;
using NaroCppCore.Occ.BRepOffsetAPI;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.ElSLib;
using NaroCppCore.Occ.Extrema;
using NaroCppCore.Occ.GC;
using NaroCppCore.Occ.GProp;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAPI;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.GeomAdaptor;
using NaroCppCore.Occ.Graphic2d;
using NaroCppCore.Occ.IntAna;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.ProjLib;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopExp;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.TopTools;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.gp;
using log4net;

using TreeData.AttributeInterpreter;
using TreeData.NaroData;
//using NaroCppCore.Occ.BRepExtrema;

#endregion

namespace OccCode
{
    public static class GeomUtils
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (GeomUtils));

        /// <summary>
        ///   Converts degrees to radians
        /// </summary>
        public static double DegreesToRadians(double angleInDegrees)
        {
            var minimalAngle = angleInDegrees;
            if (angleInDegrees > 360)
                minimalAngle = angleInDegrees%360;
            if (minimalAngle < 0)
                minimalAngle = Math.Abs(minimalAngle);
            return minimalAngle / 180.0 * Math.PI;
        }

        public static double RadiansToDegrees(double angleInRadians)
        {
            return angleInRadians*180.0/Math.PI;
        }

        public static double CartesianToPolar(Point3D p)
        {
            const double div = Math.PI/2.0;

            if (Math.Abs(p.X) < 0.000005)
            {
                if (p.Y > 0.0)
                    return div;
                if (p.Y < 0.0)
                    return 3*div; // or angle = -div;
                return 0.0; // when X = 0 and Y = 0
            }
            var x = Math.Abs(p.X);
            var y = Math.Abs(p.Y);
            var angle = Math.Atan(y/x);
            if (p.X < 0)
            {
                if (p.Y > 0)
                    angle = 2*div - angle;
                else
                    angle = 2*div + angle;
            }
            else
            {
                if (p.Y < 0)
                    angle = 4*div - angle;
            }

            return angle;
        }


        public static gpAx2 ExtractSketchNormal(Node sketchNode)
        {
            var sketchAx2 = new gpAx2();
            if (sketchNode.Children[1].Get<Axis3DInterpreter>() != null)
            {
                sketchAx2.Axis = (sketchNode.Children[1].Get<Axis3DInterpreter>().Axis.GpAxis);
            }
            else
            {
                sketchAx2.Axis = (new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 0, 1)));
            }
            return sketchAx2;
        }

        /// <summary>
        /// </summary>
        /// <param name = "lineNode">line node should be a compatible with line node</param>
        public static gpAx1 ExtractLineAxis(Node lineNode)
        {
            Point3D? firstPointRef = null, lastPointRef = null;
            GetExtremasPoints(lineNode, ref firstPointRef, ref lastPointRef);
            if ((firstPointRef ?? lastPointRef) == null)
                return null;
            if (firstPointRef == null)
                return null;
            if (lastPointRef == null)
                return null;
            var point1 = (Point3D) firstPointRef;
            var point2 = (Point3D) lastPointRef;
            return ExtractAxisFromTwoPoints(point1.GpPnt, point2.GpPnt);
        }


        public static gpAx1 ExtractAxisFromTwoPoints(gpPnt point1, gpPnt point2)
        {
            var result = new gpAx1(
                point1,
                new gpDir(
                    new gpVec(point1, point2)));
            return result;
        }


        /// <summary>
        ///   Calculates the vertex 2 and 4 of a rectangle knowing the vertexes 1,3.
        ///   Also the normal to plane is passed as parameter.
        ///   vertex2------vertex3
        ///   vertex1------vertex4
        /// </summary>
        public static void CalculateRectangleVertexes(gpPnt firstPoint, gpPnt thirdPoint, gpDir direction,
                                                      ref gpPnt secondPoint, ref gpPnt fourthPoint)
        {
            // Projects the 2 points into 2D
            var rectanglePlane = new gpPln(new gpAx3(firstPoint, direction));
            var firstPoint2D = ProjLib.Project(rectanglePlane, firstPoint);
            var thirdPoint2D = ProjLib.Project(rectanglePlane, thirdPoint);

            // Calculate the other 2 rectangle points and convert them back to 3D
            var secondPoint2D = new gpPnt2d(firstPoint2D.X, thirdPoint2D.Y);
            var fourthPoint2D = new gpPnt2d(thirdPoint2D.X, firstPoint2D.Y);

            secondPoint = ElSLib.Value(secondPoint2D.X, secondPoint2D.Y, rectanglePlane);
            fourthPoint = ElSLib.Value(fourthPoint2D.X, fourthPoint2D.Y, rectanglePlane);
        }

        /// <summary>
        ///   Calculates the vertex 2 and 4 of a rectangle knowing the vertexes 1,3.
        ///   Also the normal to plane is passed as parameter.
        ///   vertex2------vertex3
        ///   vertex1------vertex4
        /// </summary>
        public static void CalculateRectangleVertexes(gpPnt firstPoint, gpPnt secondPoint, gpPnt thirdPoint,
                                                      ref gpPnt fourthPoint)
        {
            fourthPoint = new gpPnt();
            fourthPoint.X = (firstPoint.X + thirdPoint.X - secondPoint.X);
            fourthPoint.Y = (firstPoint.Y + thirdPoint.Y - secondPoint.Y);
            fourthPoint.Z = (firstPoint.Z + thirdPoint.Z - secondPoint.Z);
        }

        /// <summary>
        ///   Calculates the rectangle vertex 3 knowing the vertex 1, 2 and width.
        ///   Also the normal to plane is passed as parameter.
        ///   vertex2------vertex3
        ///   vertex1------vertex4
        /// </summary>
        public static gpPnt CalculateRectangleVertex3(gpPnt firstPoint, gpPnt secondPoint, gpDir direction,
                                                         double width)
        {
            // Projects the 2 points into 2D
            var rectanglePlane = new gpPln(new gpAx3(firstPoint, direction));
            var firstPoint2D = ProjLib.Project(rectanglePlane, firstPoint);
            var secondPoint2D = ProjLib.Project(rectanglePlane, secondPoint);

            var thirdPoint2D = new gpPnt2d(firstPoint2D.X + width, secondPoint2D.Y);

            return ElSLib.Value(thirdPoint2D.X, thirdPoint2D.Y, rectanglePlane);
        }

        /// <summary>
        ///   Searches for the first and last point of a wire.
        /// </summary>
        public static void WireRange(TopoDSWire wire, out Point3D? first, out Point3D? last)
        {
            var firstV = new TopoDSVertex();
            var lastV = new TopoDSVertex();
            TopExp.Vertices(wire, firstV, lastV);
            first = new Point3D(BRepTool.Pnt(firstV));
            last = new Point3D(BRepTool.Pnt(lastV));
        }

        public static void EdgeRange(TopoDSEdge wire, out Point3D? firstPoint, out Point3D? lastPoint)
        {
            var firstV = new TopoDSVertex();
            var lastV = new TopoDSVertex();
            TopExp.Vertices(wire, firstV, lastV, true);
            firstPoint = new Point3D(BRepTool.Pnt(firstV));
            lastPoint = new Point3D(BRepTool.Pnt(lastV));
        }

        /// <summary>
        ///   Builds a translation transformation from point1 to point2
        /// </summary>
        public static gpTrsf BuildTranslation(Point3D point1, Point3D point2)
        {
            var vector = new gpVec(point1.GpPnt, point2.GpPnt);
            var transformation = new gpTrsf();
            transformation.SetTranslation(vector);
            return transformation;
        }

        /// <summary>
        ///   Builds a translation transformation from point1 to point2
        /// </summary>
        public static gpTrsf BuildRotation(gpAx1 axis, double angle)
        {
            var transformation = new gpTrsf();
            transformation.SetRotation(axis, angle);
            return transformation;
        }

        /// <summary>
        ///   Builds a translation transformation from point1 passing a vector
        /// </summary>
        public static Point3D BuildTranslation(Point3D point1, gpVec vector)
        {
            var transformation = new gpTrsf();
            transformation.SetTranslation(vector);
            return new Point3D(point1.GpPnt.Transformed(transformation));
        }

        public static gpPnt VertexToPnt(Graphic2dVertex vertex2D, gpAx2 ax2)
        {
            // Code taken from ElcLib, TODO: wrap ElcLib
            var pnt2D = new gpPnt2d(vertex2D.X, vertex2D.Y);
            return Point2DTo3D(ax2, pnt2D);
        }

        public static gpPnt Point2DTo3D(gpAx2 ax2, gpPnt2d pnt2D)
        {
            var vxy = ax2.XDirection.XYZ;
            vxy.SetLinearForm(pnt2D.X, vxy, pnt2D.Y, ax2.YDirection.XYZ, ax2.Location.XYZ);

            return new gpPnt(vxy);
        }

        public static Point3D Point2DTo3D(gpAx2 ax2, double X, double Y)
        {
            var vxy = ax2.XDirection.XYZ;
            vxy.SetLinearForm(X, vxy, Y, ax2.YDirection.XYZ, ax2.Location.XYZ);

            return new Point3D(new gpPnt(vxy));
        }

        public static gpPnt2d Point3DTo2D(gpAx2 ax2, Point3D point)
        {
            var pointPlane = new gpPln(new gpAx3(ax2));
            var point2D = ProjLib.Project(pointPlane, point.GpPnt);

            return point2D;
        }


        public static Point3D Point2DTo3D(gpAx2 ax2, Point3D pnt2D)
        {
            var vxy = ax2.XDirection.XYZ;
            vxy.SetLinearForm(pnt2D.X, vxy, pnt2D.Y, ax2.YDirection.XYZ, ax2.Location.XYZ);

            return new Point3D(new gpPnt(vxy));
        }

        /// <summary>
        ///   Returns true if two shapes intersect.
        /// </summary>
        public static bool ShapesIntersect(TopoDSShape shape1, TopoDSShape shape2)
        {
            BRepAlgoAPICommon cut;
            try
            {
                cut = new BRepAlgoAPICommon(shape1, shape2);
                var shapeCommon = cut.Shape;

                if ((shapeCommon != null) && (!shapeCommon.IsNull))
                {
                    // Check if the shape is empty by iterating edges
                    var faceExplorer = new TopExpExplorer();
                    faceExplorer.Init(shapeCommon, TopAbsShapeEnum.TopAbs_FACE, TopAbsShapeEnum.TopAbs_SHAPE);

                    return faceExplorer.More;
                }
            }
            catch (Exception ex)
            {
                Log.Info("Exception on: ShapesIntersect: " + ex.Message);
            }

            return false;
        }

        /// <summary>
        ///   Offsets wires from a Face
        /// </summary>
        public static TopoDSShape GenerateWireListOffset(IEnumerable<TopoDSWire> wires, double offsetLength)
        {
            var offset = new BRepOffsetAPIMakeOffset();
            offset.Init(GeomAbsJoinType.GeomAbs_Arc);
            //var wires = GeomUtils.ExtractWires(originalShape);
            var makeWire = new BRepBuilderAPIMakeWire();
            foreach (var wire in wires)
            {
                makeWire.Add(wire);
            }
            try
            {
                offset.AddWire(makeWire.Wire);
                offset.Perform(offsetLength, 0.0);
                if (offset.IsDone)
                    return offset.Shape;
            }
            catch (Exception ex)
            {
                Log.Info("Exception on: GenerateWireListOffset: " + ex.Message);
            }

            return null;
        }

        /// <summary>
        ///   Offsets wires from a set of wires
        /// </summary>
        public static TopoDSShape GenerateFaceOffset(TopoDSFace face, double offsetLength)
        {
            var offset = new BRepOffsetAPIMakeOffset();
            face.Orientation(TopAbsOrientation.TopAbs_FORWARD);
            offset.Init(face, GeomAbsJoinType.GeomAbs_Arc);
            offset.Perform(offsetLength, 0.0);
            return offset.IsDone ? offset.Shape : null;
        }

        public static gpAx1 ExtractAxis(TopoDSShape axis)
        {
            var line = new TopExpExplorer();
            line.Init(axis, TopAbsShapeEnum.TopAbs_VERTEX, TopAbsShapeEnum.TopAbs_SHAPE);
            var v1 = new Point3D(BRepTool.Pnt(TopoDS.Vertex(line.Current)));
            line.Next();
            var v2 = new Point3D(BRepTool.Pnt(TopoDS.Vertex(line.Current)));
            // Protect against coincident points
            gpAx1 ax = null;
            if (!v1.IsEqual(v2))
                ax = new gpAx1(v1.GpPnt, new gpDir(v2.X - v1.X, v2.Y - v1.Y, v2.Z - v1.Z));
            return ax;
        }

        /// <summary>
        ///   Extracts from the shape passed as parameter info about the plane where it is located.
        /// </summary>
        public static gpAx2 ExtractAxis2(TopoDSShape topoShape)
        {
            if (topoShape == null)
                return new gpAx2();

            var ax2 = new gpAx2();

            // Get the Ax2 coordinate system from the selected system
            var explorer = new TopExpExplorer();
            explorer.Init(topoShape, TopAbsShapeEnum.TopAbs_FACE, TopAbsShapeEnum.TopAbs_SHAPE);
            if (explorer.More)
            {
                var face = TopoDS.Face(explorer.Current);

                // Check if the surface is planar
                var plane = ExtractPlane(face);
                if (plane == null)
                    return null;
                var ax1 = plane.Axis;
                ax2.Axis = (ax1);

                return ax2;
            }

            return null;
        }

        /// <summary>
        ///   Extracts the plane in which the shape is located
        /// </summary>
        public static gpPln ExtractPlane(TopoDSShape topoShape)
        {
            if (topoShape == null)
                return null;

            var explorer = new TopExpExplorer();
            explorer.Init(topoShape, TopAbsShapeEnum.TopAbs_FACE, TopAbsShapeEnum.TopAbs_SHAPE);
            if (explorer.More)
            {
                var face = TopoDS.Face(explorer.Current);
                return ExtractPlane(face);
            }

            return null;
        }

        /// <summary>
        ///   Extracts the plane of a Face
        /// </summary>
        public static gpPln ExtractPlane(TopoDSFace face)
        {
            if ((face == null) || (face.IsNull))
                return null;

            var surf = BRepTool.Surface(face);
            // Check if surface is planar
            var aFaceElementAdaptor = new BRepAdaptorSurface(face, true);
            var surfaceType = aFaceElementAdaptor.GetType;
            if (surfaceType != GeomAbsSurfaceType.GeomAbs_Plane)
                return null;
          
            GeomPlane plane = surf.Convert<GeomPlane>();

            return plane.Pln;
        }

        /// <summary>
        ///   Makes a list with all the vertexes of a shape eliminating duplicates.
        /// </summary>
        public static List<Point3D> ExtractPoints(TopoDSShape solidShape)
        {
            var listPoints = new List<Point3D>();
            var vertexList = ExtractVertexes(solidShape);

            if (vertexList.Count <= 0)
                return listPoints;

            foreach (var vertex in vertexList)
            {
                var pnt = new Point3D(BRepTool.Pnt(vertex));
                listPoints.Add(pnt);
            }
            listPoints = SortAndCompactListPoints(listPoints);

            return listPoints;
        }

        /// <summary>
        ///   Makes a list with all the vertexes of a shape.
        /// </summary>
        public static List<TopoDSVertex> ExtractVertexes(TopoDSShape solidShape)
        {
            var listOfVertexes = new List<TopoDSVertex>();
            var vertices = new TopToolsIndexedMapOfShape(1);
            TopExp.MapShapes(solidShape, TopAbsShapeEnum.TopAbs_VERTEX, vertices);
            var verticesCount = vertices.Extent;
            for (var i = 1; i <= verticesCount; i++)
            {
                var vertex = TopoDS.Vertex(vertices.FindKey(i));
                listOfVertexes.Add(vertex);
            }

            return listOfVertexes;
        }

        /// <summary>
        ///   Makes a list with common vertexes of two shapes
        /// </summary>
        public static List<TopoDSVertex> CommonVertexes(TopoDSShape firstShape, TopoDSShape secondShape)
        {
            var commonVertexes = new List<TopoDSVertex>();

            // Extract vertexes from the first list
            var listOfVertex = ExtractVertexes(firstShape);
            if (listOfVertex.Count > 0)
            {
                // Extract verexes fron the second list
                var secondListOfVertex = ExtractVertexes(secondShape);
                if (secondListOfVertex.Count > 0)
                {
                    // Check each vertex from the first list against the vertexes from the second list
                    // and find common vertexes
                    foreach (var vertex in listOfVertex)
                    {
                        var pnt = BRepTool.Pnt(vertex);
                        foreach (var secondVertex in secondListOfVertex)
                        {
                            var secondPnt = BRepTool.Pnt(secondVertex);

                            //if (vertex.IsSame(secondVertex))
                            //{
                            //    commonVertexes.Add(vertex);
                            //}
                            if (pnt.IsEqual(secondPnt, Precision.Confusion))
                                commonVertexes.Add(vertex);
                        }
                    }
                }
            }

            return commonVertexes;
        }

        /// <summary>
        ///   Makes a list with all the faces of a shape.
        /// </summary>
        public static List<TopoDSFace> ExtractFaces(TopoDSShape solidShape)
        {
            var listOfFaces = new List<TopoDSFace>();
            if (solidShape == null)
                return listOfFaces;
            var faces = new TopToolsIndexedMapOfShape(1);
            TopExp.MapShapes(solidShape, TopAbsShapeEnum.TopAbs_FACE, faces);
            var facesCount = faces.Extent;
            for (var i = 1; i <= facesCount; i++)
            {
                var face = TopoDS.Face(faces.FindKey(i));
                listOfFaces.Add(face);
            }

            return listOfFaces;
        }

        /// <summary>
        ///   Makes a list with all the faces of a shap that can be selected to create a sketch/drag.
        /// </summary>
        public static List<TopoDSFace> ExtractSelectableFaces(TopoDSShape solidShape)
        {
            var listOfFaces = new List<TopoDSFace>();
            if (solidShape == null)
                return listOfFaces;
            var faces = new TopToolsIndexedMapOfShape(1);
            TopExp.MapShapes(solidShape, TopAbsShapeEnum.TopAbs_FACE, faces);
            var facesCount = faces.Extent;
            for (var i = 1; i <= facesCount; i++)
            {
                var face = TopoDS.Face(faces.FindKey(i));
                var faceDir = ExtractDirection(face);
                if(faceDir != null)
                    listOfFaces.Add(face);
            }

            return listOfFaces;
        }
     
        /// <summary>
        ///   Makes a list with all the edges of a shape.
        /// </summary>
        public static List<TopoDSEdge> ExtractEdges(TopoDSShape solidShape)
        {
            var listOfEdges = new List<TopoDSEdge>();
            var edges = new TopToolsIndexedMapOfShape(1);
            TopExp.MapShapes(solidShape, TopAbsShapeEnum.TopAbs_EDGE, edges);
            var edgesCount = edges.Extent;
            for (var i = 1; i <= edgesCount; i++)
            {
                var edge = TopoDS.Edge(edges.FindKey(i));
                listOfEdges.Add(edge);
            }

            return listOfEdges;
        }

        /// <summary>
        ///   Extracts the edge from a shape (first if there are more).
        /// </summary>
        public static TopoDSEdge ExtractEdge(TopoDSShape solidShape)
        {
            var listOfEdges = new List<TopoDSEdge>();
            var edges = new TopToolsIndexedMapOfShape(1);
            TopExp.MapShapes(solidShape, TopAbsShapeEnum.TopAbs_EDGE, edges);
            var edgesCount = edges.Extent;
            for (var i = 1; i <= edgesCount; i++)
            {
                var edge = TopoDS.Edge(edges.FindKey(i));
                listOfEdges.Add(edge);
            }

            return listOfEdges.Count > 0 ? listOfEdges.First() : null;
        }

        /// <summary>
        ///   Makes a list with all the wires of a shape.
        /// </summary>
        public static List<TopoDSWire> ExtractWires(TopoDSShape solidShape)
        {
            var listOfWires = new List<TopoDSWire>();
            var wires = new TopToolsIndexedMapOfShape(1);
            TopExp.MapShapes(solidShape, TopAbsShapeEnum.TopAbs_WIRE, wires);
            var wiresCount = wires.Extent;
            for (var i = 1; i <= wiresCount; i++)
            {
                var wire = TopoDS.Wire(wires.FindKey(i));
                listOfWires.Add(wire);
            }

            return listOfWires;
        }

        /// <summary>
        ///   Extract the ShapeType with the number n fromthe node shape
        ///   Example: Extract the edge number 3 from a shape
        /// </summary>
        public static TopoDSShape ExtractShapeType(TopoDSShape solidShape, TopAbsShapeEnum shapeType,
                                                      int shapeNumber)
        {
            var shapes = new TopToolsIndexedMapOfShape(1);
            TopExp.MapShapes(solidShape, shapeType, shapes);
            var shapesCount = shapes.Extent;
            return shapesCount >= shapeNumber ? shapes.FindKey(shapeNumber) : null;
        }

        /// <summary>
        ///   Detects if a face belongs to a shape.
        ///   Returns the face number (the number starts with 1) or 0 if no face found.
        /// </summary>
        private static int DetectFace(TopoDSShape topoShape, TopoDSShape selectedShape)
        {
            // Detect the shape that has the selected face, and build a node
            // that has a reference to that shape
            var baseEx = new TopExpExplorer();
            baseEx.Init(topoShape, TopAbsShapeEnum.TopAbs_FACE, TopAbsShapeEnum.TopAbs_SHAPE);
            var faceNumber = 0;
            while (baseEx.More)
            {
                TopoDSFace face = null;
                try
                {
                    face = TopoDS.Face(baseEx.Current);
                }
                catch (Exception ex)
                {
                    Log.Info("Exception on: DetectFace: " + ex.Message);
                }

                if (face == null)
                    continue;

                if (face.IsEqual(selectedShape))
                    return (faceNumber + 1);
                faceNumber++;

                baseEx.Next();
            }

            return 0;
        }

        /// <summary>
        ///   Detects if an edge belongs to a shape.
        ///   Returns the edge number (the number starts with 1) or 0 if no edge found.
        /// </summary>
        private static int DetectEdge(TopoDSShape topoShape, TopoDSShape selectedShape)
        {
            // Detect the shape that has the selected face, and build a node
            // that has a reference to that shape
            var baseEx = new TopExpExplorer();
            baseEx.Init(topoShape, TopAbsShapeEnum.TopAbs_EDGE, TopAbsShapeEnum.TopAbs_SHAPE);
            var edgeNumber = 0;
            while (baseEx.More)
            {
                TopoDSEdge edge = null;
                try
                {
                    edge = TopoDS.Edge(baseEx.Current);
                }
                catch (Exception ex)
                {
                    Log.Info("Exception on: DetectFace: " + ex.Message);
                }

                if (edge == null)
                    continue;

                if (edge.IsEqual(selectedShape))
                    return (edgeNumber + 1);
                edgeNumber++;

                baseEx.Next();
            }

            return 0;
        }

        /// <summary>
        ///   Detects if an vertex belongs to a shape.
        ///   Returns the edge number (the number starts with 1) or 0 if no edge found.
        /// </summary>
        private static int DetectVertex(TopoDSShape topoShape, TopoDSShape selectedShape)
        {
            // Detect the shape that has the selected face, and build a node
            // that has a reference to that shape
            var baseEx = new TopExpExplorer();
            baseEx.Init(topoShape, TopAbsShapeEnum.TopAbs_VERTEX, TopAbsShapeEnum.TopAbs_SHAPE);
            var vertexNumber = 0;
            while (baseEx.More)
            {
                TopoDSVertex vertex = null;
                try
                {
                    vertex = TopoDS.Vertex(baseEx.Current);
                }
                catch (Exception ex)
                {
                    Log.Info("Exception on: DetectVertex: " + ex.Message);
                }

                if (vertex == null)
                    continue;

                if (vertex.IsEqual(selectedShape))
                    return (vertexNumber + 1);
                vertexNumber++;

                baseEx.Next();
            }

            return 0;
        }

        /// <summary>
        ///   Converts the 2D mouse coordinates into 3D coordinates the point considered in the plane passed as parameter.
        /// </summary>
        public static bool ConvertToPlane(V3dView view, gpPln plane, int xs, int ys, ref double x, ref double y,
                                          ref double z)
        {
            double xv = 0, yv = 0, zv = 0;
            double vx = 0, vy = 0, vz = 0;

            view.Convert(xs, ys, ref xv, ref yv, ref zv);
            view.Proj(ref vx, ref vy, ref vz);

            var aLine = new gpLin(new gpPnt(xv, yv, zv), new gpDir(vx, vy, vz));
            var theIntersection = new IntAnaIntConicQuad(aLine, plane, Precision.Angular);

            if (theIntersection.IsDone)
            {
                if (!theIntersection.IsParallel)
                {
                    if (theIntersection.NbPoints > 0)
                    {
                        var theSolution = new gpPnt(theIntersection.Point(1).Coord());
                        x = theSolution.X;
                        y = theSolution.Y;
                        z = theSolution.Z;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        ///   Converts a 2D point to a 3D point
        /// </summary>
        public static Point3D ConvertClickToPoint(int xMouse, int yMouse, V3dView aView)
        {
            var planeOfTheView = PlaneOfTheView(aView);
            double x = 0, y = 0, z = 0;
            aView.Convert(xMouse, yMouse, ref x, ref y, ref z);
            var convertedPoint = new gpPnt(x, y, z);
            var convertedPointOnPlane = ProjLib.Project(planeOfTheView, convertedPoint);

            var resultPoint = new Point3D(ElSLib.Value(convertedPointOnPlane.X, convertedPointOnPlane.Y, planeOfTheView));
            return resultPoint;
        }

        /// <summary>
        ///   Calculates the plane of the view
        /// </summary>
        public static gpPln PlaneOfTheView(V3dView aView)
        {
            double xEye = 0, yEye = 0, zEye = 0, xAt = 0, yAt = 0, zAt = 0;
            aView.Eye(ref xEye, ref yEye, ref zEye);
            aView.At(ref xAt, ref yAt, ref zAt);
            var eyePoint = new gpPnt(xEye, yEye, zEye);
            var atPoint = new gpPnt(xAt, yAt, zAt);

            var eyeVector = new gpVec(eyePoint, atPoint);
            var eyeDir = new gpDir(eyeVector);

            var planeOfTheView = new gpPln(atPoint, eyeDir);

            return planeOfTheView;
        }

        /// <summary>
        ///   Detects the selected shape from the context. It looks into the neutral point first and
        ///   then in the open local context.
        /// </summary>
        public static TopoDSShape GetCurrentSelectedShape(AISInteractiveContext context)
        {
            // Search for a selected shape on the Main context
            context.InitCurrent();
            if (context.MoreSelected && (!context.HasOpenedContext)) 
            {
                var selectedInteractive = context.Current;
                TopoDSShape topoShape = null;
                if ((selectedInteractive != null) &&
                    (selectedInteractive.Type == AISKindOfInteractive.AIS_KOI_Shape))
                {
                    AISShape shape = selectedInteractive.Convert<AISShape>();
                    topoShape = shape.Shape;
                }
                return topoShape;
            }
            // Try to see if anything selected in the local context
            context.InitSelected();
            return context.MoreSelected ? context.SelectedShape : null;
        }


        private static TopoDSShape ExtractShapeFromAis(AISInteractiveObject selectedInteractive)
        {
            TopoDSShape topoShape = null;
            if ((selectedInteractive == null) || (selectedInteractive.Type != AISKindOfInteractive.AIS_KOI_Shape))
                return topoShape;
            AISShape shape = selectedInteractive.Convert<AISShape>();
            topoShape = shape.Shape;
            return topoShape;
        }

        /// <summary>
        ///   Makes a list will all the selected shapes. It looks into neutral and also open local context.
        /// </summary>
        public static List<TopoDSShape> GetAllSelectedShapes(AISInteractiveContext context)
        {
            var shapeList = new List<TopoDSShape>();

            // Search for a selected shape on the Main context
            context.InitCurrent();
            while (context.MoreSelected && (!context.HasOpenedContext)) 
            {
                var selectedInteractive = context.Current;
                var topoShape = ExtractShapeFromAis(selectedInteractive);
                if (topoShape != null)
                    shapeList.Add(topoShape);

                context.NextCurrent();
            }

            if (shapeList.Count > 0)
            {
                return shapeList;
            }

            // Try to see if anything selected in the local context
            context.InitSelected();
            while (context.MoreSelected)
            {
                shapeList.Add(context.SelectedShape);
                context.NextSelected();
            }

            return shapeList;
        }

        /// <summary>
        ///   Makes a list will all the detected shapes. It looks into an open local context.
        /// </summary>
        public static List<TopoDSShape> GetAllDetectedShapes(AISInteractiveContext context)
        {
            var shapeList = new List<TopoDSShape>();

            // Search for a selected shape on the local context
            context.InitDetected();
            while (context.MoreDetected && (context.HasOpenedContext))
            {
                var topoShape = context.DetectedShape;
                if ((topoShape != null) && (!topoShape.IsNull))
                    shapeList.Add(topoShape);

                context.NextDetected();
            }

            if (shapeList.Count > 0)
            {
                return shapeList;
            }

            // Try to see if anything selected in the neutral point
            context.InitCurrent();
            while (context.MoreDetected)
            {
                var detectedShape = context.DetectedCurrentShape;
                shapeList.Add(detectedShape);
                context.NextDetected();
            }

            return shapeList;
        }

        /// <summary>
        ///   Detects which interactive object is built from the TopoDS_Shape
        /// </summary>
        public static AISInteractiveObject LocateInteractive(TopoDSShape shape, AISInteractiveContext context)
        {
            var listOfInteractive = new AISListOfInteractive();
            context.DisplayedObjects(listOfInteractive, true);
            while (!listOfInteractive.IsEmpty)
            {
                var aisObject = listOfInteractive.First;
                TopoDSShape topoShape;
                if ((aisObject != null) && (aisObject.Type == AISKindOfInteractive.AIS_KOI_Shape))
                {
                    AISShape aisShape = aisObject.Convert<AISShape>();
                    topoShape = aisShape.Shape;
                    if (topoShape.IsSame(shape))
                        return aisObject;
                }
                listOfInteractive.RemoveFirst();
            }

            return null;
        }

        /// <summary>
        ///   Extracts shape direction
        /// </summary>
        public static gpDir ExtractDirection(TopoDSShape topoShape)
        {
            if (topoShape == null)
                return null;

            // Get the Ax2 coordinate system from the selected system
            var explorer = new TopExpExplorer();
            explorer.Init(topoShape, TopAbsShapeEnum.TopAbs_FACE, TopAbsShapeEnum.TopAbs_SHAPE);
            if (explorer.More)
            {
                var face = TopoDS.Face(explorer.Current);
                return ExtractDirection(face);
            }

            return null;
        }

        /// <summary>
        ///   Extract face direction
        /// </summary>
        public static gpDir ExtractDirection(TopoDSFace face)
        {
            var plane = ExtractPlane(face);
            return plane == null ? null : plane.Axis.Direction.Reversed;
        }

        /// <summary>
        ///   Builds a point located at half distance between two points in space
        /// </summary>
        public static Point3D ComputeMidPoint(Point3D point1, Point3D point2)
        {
            var pointMid = new Point3D((point1.X + point2.X)/2,
                                       (point1.Y + point2.Y)/2,
                                       (point1.Z + point2.Z)/2);
            return pointMid;
        }

        /// <summary>
        ///   Build a plane from 3 points
        /// </summary>
        public static gpPln BuildPlane(Point3D point1, Point3D point2, Point3D point3)
        {
            //// Sample on how to build a plane from 3 points:
            //gpPnt P = new gpPnt(2, 0, -3);
            //gpPnt Q = new gpPnt(1, -1, 6);
            //gpPnt R = new gpPnt(5, 5, 0);
            //// For this we have point P fixed, vectors PQ, PR
            //// The plane parametric equation is r = P + n(PQ) + m(PR)
            //// In our case r= (2,0,-3) +n(-1,-1, 9) +m(3,5,3)
            //gpVec PQ = new gpVec(P, Q);
            //gpVec PR = new gpVec(P, R);

            //// Cross product of the two ditectional vectors;
            //// i.e PQ X PR = (-48, 30, -2)
            //// Hence: -48x + 30y - 2z = R
            //// substitute P to calculate R -> R = -90
            //// Then simplify the equation to get -24x+15y-z=-90
            //PQ.Cross(PR);
            //double A = PQ.X();
            //double B = PQ.Y();
            //double C = PQ.Z();
            //double D = A*P.X() + B*P.Y() + C*P.Z();
            //gpPln plan = new gpPln(A, B, C, D);

            var pq = new gpVec(point1.GpPnt, point2.GpPnt);
            var pr = new gpVec(point1.GpPnt, point3.GpPnt);
            pq.Cross(pr);
            var pqx = pq.X;
            var pqy = pq.Y;
            var pqz = pq.Z;
            var d = pqx*point1.X + pqy*point1.Y + pqz*point1.Z;

            // Build the plane
            var plane = new gpPln(pqx, pqy, pqz, d);
            return plane;
        }

        /// <summary>
        ///   Buils an arc receiving as parameter an axis and two points.
        /// </summary>
        public static GeomTrimmedCurve BuildArc(gpAx1 axis, Point3D p1, Point3D p2, bool sense)
        {
            var arcCenter = axis.Location;
            // Build the circle describing the Arc
            var centerCoord = new gpAx2();
            centerCoord.Axis = (axis);
            var circle = new GeomCircle(centerCoord, arcCenter.Distance(p1.GpPnt));
            try
            {
                if (p1.IsEqual(p2))
                    return null;
                var arc = new GCMakeArcOfCircle(circle.Circ, p1.GpPnt, p2.GpPnt, sense);
                return !arc.IsDone ? null : arc.Value;
            }
            catch (SEHException)
            {
                return null;
            }
        }

        /// <summary>
        ///   Detects if a point is under, contained or above the plane.
        ///   Then it multiplies this value with the distance between the plane and the point.
        /// </summary>
        public static double PointPosition(gpPln plane, gpPnt point)
        {
            if (plane.Distance(point) < 1e-12)
                return 0;

            var height = plane.Distance(point);

            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            plane.Coefficients(ref a, ref b, ref c, ref d);
            var sign = -1;
            if ((a*point.X + b*point.Y + c*point.Z) < -d)
                sign = 1;

            return sign*height;
        }

        /// <summary>
        ///   Fuses a a list of shapes. Mainly targeting the fuse of Face type shapes.
        /// </summary>
        public static TopoDSShape FuseShapeList(List<SceneSelectedEntity> shapes)
        {
            if (shapes.Count <= 0)
                return null;
            if (shapes.Count == 1)
                return shapes[0].Node.Get<TopoDsShapeInterpreter>().Shape;

            var builder = new BRepAlgoAPIFuse(shapes[0].Node.Get<TopoDsShapeInterpreter>().Shape,
                                                 shapes[1].Node.Get<TopoDsShapeInterpreter>().Shape);
            if (!builder.IsDone)
                return null;

            var bigFace = builder.Shape;
            for (var i = 2; i < shapes.Count; i++)
            {
                var face = shapes[i].Node.Get<TopoDsShapeInterpreter>().Shape;
                // Empty shapes are no fused
                if (face.IsNull)
                    continue;
                builder = new BRepAlgoAPIFuse(bigFace, face);
                if (builder.IsDone)
                    bigFace = builder.Shape;
            }

            return bigFace;
        }

        /// <summary>
        ///   Projects a point on an edge.
        ///   Works only on line edges.
        /// </summary>
        public static gpPnt ProjectPointOnEdge(TopoDSShape edge, gpPnt point)
        {
            if (edge.ShapeType != TopAbsShapeEnum.TopAbs_EDGE)
                return null;
            var curve = new BRepAdaptorCurve(TopoDS.Edge(edge));
            if (curve.GetType != GeomAbsCurveType.GeomAbs_Line)
                return null;

          //  curve.Line;
            var projectionPoint = new GeomAPIProjectPointOnCurve(point, curve.Curve.Curve);
            if (projectionPoint.NbPoints > 0)
            {
                var proj = projectionPoint.NearestPoint;
                return proj.IsEqual(point, Precision.Confusion) ? null : proj;
            }

            return null;
        }

        public static gpPnt ProjectPointOnCurve(GeomAdaptorCurve curve, gpPnt point)
        {
            var projectionPoint = new GeomAPIProjectPointOnCurve(point, curve.Curve);
            if (projectionPoint.NbPoints > 0)
            {
                var proj = projectionPoint.NearestPoint;
                return proj.IsEqual(point, Precision.Confusion) ? null : proj;
            }

            return null;
        }

        /// <summary>
        ///   Creates a line from two points and projects a point on it
        /// </summary>
        public static Point3D? ProjectPointOnLine(Point3D firstLinePoint, gpDir lineDirection, Point3D pointToProject)
        {
            // Make a parallel line with this line starting from the initial point
            var projectionLine = new gceMakeLin(firstLinePoint.GpPnt, lineDirection).Value;
            var geomLine = new GeomLine(projectionLine);
            var projectionPoint = new GeomAPIProjectPointOnCurve(pointToProject.GpPnt, geomLine);
            if (projectionPoint.NbPoints > 0)
            {
                return new Point3D(projectionPoint.NearestPoint);
            }

            return null;
        }

        /// <summary>
        ///   Returns the projection of a point on a plane given a precision
        /// </summary>
        public static gpPnt ProjectPointOnPlane(gpPnt point, gpPln plane, double precision)
        {
            var distance = plane.Distance(point);
            if (distance > precision)
            {
                var geomPlane = new GeomPlane(plane);
                var projectionPoint = new GeomAPIProjectPointOnSurf(point, geomPlane, Precision.Confusion,ExtremaExtAlgo.Extrema_ExtAlgo_Grad);
                if (projectionPoint.NbPoints > 0)
                {
                    return projectionPoint.NearestPoint;
                }
            }

            return point;
        }

        public static gpPnt ProjectPointOnPlaneOrthogonal(gpPnt point, gpDir direction, gpPnt pointOnPlane)
        {
            gpPnt newLocation = new gpPnt();
            double x, y, z, a, b, c, d, e, f;
            x = point.X;
            y = point.Y;
            z = point.Z;
            a = pointOnPlane.X;
            b = pointOnPlane.Y;
            c = pointOnPlane.Z;
            d = direction.X;
            e = direction.Y;
            f = direction.Z;

            newLocation.X = x - e * f * (y - b - z + c);
            newLocation.Y = y - f * d * (z - c - x + a);
            newLocation.Z = z - d * e * (x - a - y + b);
            return newLocation;
        }

        /// <summary>
        ///   Calculates a point located on the middle of an edge.
        ///   Implemented for line edges.
        /// </summary>
        public static Point3D? CalculateEdgeMidPoint(TopoDSEdge edge)
        {
            var curve = new BRepAdaptorCurve(edge);
            if (curve.GetType == GeomAbsCurveType.GeomAbs_Line)
            {
                // For a line use a length dimension
              //  curve.Line;
                var firstPoint = new Point3D(curve.Value(curve.FirstParameter));
                var lastPoint = new Point3D(curve.Value(curve.LastParameter));
                return ComputeMidPoint(firstPoint, lastPoint);
            }

            return null;
        }

        /// <summary>
        ///   Calculates the first point of an edge.
        ///   Implemented for line edges.
        /// </summary>
        public static Point3D? CalculateEdgeFirstPoint(TopoDSEdge edge)
        {
            var curve = new BRepAdaptorCurve(edge);
            if (curve.GetType == GeomAbsCurveType.GeomAbs_Line)
            {
                // For a line use a length dimension
             //   curve.Line;
                var firstPoint = new Point3D(curve.Value(curve.FirstParameter));
                return firstPoint;
            }

            return null;
        }

        /// <summary>
        ///   Calculates the last point of an edge.
        ///   Implemented for line edges.
        /// </summary>
        public static Point3D? CalculateEdgeLastPoint(TopoDSEdge edge)
        {
            var curve = new BRepAdaptorCurve(edge);
            if (curve.GetType == GeomAbsCurveType.GeomAbs_Line)
            {
                // For a line use a length dimension
                //curve.Line();
                var lastPoint = new Point3D(curve.Value(curve.LastParameter));
                return lastPoint;
            }

            return null;
        }

        /// <summary>
        ///   Checks wether the point is located on curve
        /// </summary>
        public static bool PointOnCurve(BRepAdaptorCurve edge, Point3D point)
        {
            return false;
        }

        /// <summary>
        ///   Calculates the distance between a point and a face type shape. The distance can be also negative
        ///   distinguishing the "under" position from the "above" position.
        /// </summary>
        public static double CalculateDistance(gpPnt point, TopoDSShape shape)
        {
            double height = 0.0;
            var basePlane = ExtractPlane(shape);
            if (basePlane != null)
            {
                height = PointPosition(basePlane, point);
            }

            return height;
        }


        /// <summary>
        ///   Calculates the distance between a point and a plane. The distance can be also negative
        ///   distinguishing the "under" position from the "above" position.
        /// </summary>
        public static double CalculateDistance(gpPnt point, gpPln plane)
        {
            double height = 0.0;
            height = PointPosition(plane, point);
           
            return height;
        }

        /// <summary>
        ///   Builds an AISLengthDimension Dimension
        /// </summary>
        public static AISLengthDimension BuildLengthDimension(gpPnt lengthFirstPoint, gpPnt lengthSecondPoint,
                                                                 GeomPlane plane, gpPnt textLocation,
                                                                 DsgPrsArrowSide arrowSide, double arrowSize,
                                                                 double transparency, bool isOffset, gpPnt offset)
        {
            var length = lengthFirstPoint.Distance(lengthSecondPoint);
            if (length < 1e-12)
            {
                return null;
            }
            var midpoint = new Point3D();
           
            if (offset != null && Math.Abs(offset.X + offset.Y +offset.Z) > Precision.Confusion)
            {
                midpoint.X = (lengthFirstPoint.X + lengthSecondPoint.X)/2 + offset.X;
                midpoint.Y = (lengthFirstPoint.Y + lengthSecondPoint.Y)/2 + offset.Y;
                midpoint.Z = (lengthFirstPoint.Z + lengthSecondPoint.Z)/2 + offset.Z;
            }
            else
            {
                midpoint = new Point3D(textLocation);
            } 
            var vertex1 = new BRepBuilderAPIMakeVertex(lengthFirstPoint).Vertex;
            var vertex2 = new BRepBuilderAPIMakeVertex(lengthSecondPoint).Vertex;
            var text = new TCollectionExtendedString(String.Format("{0:0.00}", length));
            var ld = new AISLengthDimension(vertex1, vertex2, plane, length, text, midpoint.GpPnt,
                                               arrowSide, AISTypeOfDist.AIS_TOD_Horizontal, arrowSize);
            ld.SetColor(QuantityNameOfColor.Quantity_NOC_RED);
            ld.Transparency = (transparency);
            return ld;
        }


        private static bool GetWireShapeRange(Node shapeNode, ref Point3D? first, ref Point3D? second)
        {
            try
            {
                //// Check shape visibility
                //var visibility = shapeNode.Get<DrawingAttributesInterpreter>();
                //if (visibility == null || visibility.Visibility == ObjectVisibility.Hidden)
                //    return false;

                // Check the shape type to be wire
                var shapeInterpreter = shapeNode.Get<TopoDsShapeInterpreter>();
                if (shapeInterpreter == null)
                    return false;
                var topoShape = shapeInterpreter.Shape;
                if (topoShape == null || topoShape.ShapeType != TopAbsShapeEnum.TopAbs_WIRE)
                    return false;

                // Extract the vertexes
                var wire = TopoDS.Wire(topoShape);
                WireRange(wire, out first, out second);
                if (first == null || second == null)
                    return false;


                // Check for point coincidence
                return !((Point3D) first).IsEqual((Point3D) second);
            }
            catch
            {
                return false;
            }
        }

        public static bool GetExtremasPoints(Node shape, ref Point3D? firstPoint, ref Point3D? secondPoint)
        {
            return GetWireShapeRange(shape, ref firstPoint, ref secondPoint);
        }

        public static bool IsVisible(Node node)
        {
            return node.Set<DrawingAttributesInterpreter>().Visibility != ObjectVisibility.Hidden;
        }


        public static List<int> GetReferencingValues(Node nodeToDelete)
        {
            var root = nodeToDelete.Root;
            var result = new List<int>();
            foreach (var node in root.Children.Values)
            {
                if (Document.NodeReferences(node, nodeToDelete))
                    result.Add(node.Index);
            }
            return result;
        }

        public static List<int> GetImpactedValues(Node nodeToDelete, Node root)
        {
            var toRemove = new List<int> {nodeToDelete.Index};
            var pos = 0;
            while (pos < toRemove.Count)
            {
                var nodeToRemove = toRemove[pos];
                foreach (var node in root.Children.Values)
                {
                    if (Document.NodeReferences(node, root[nodeToRemove]))
                        toRemove.Add(node.Index);
                }
                pos++;
            }
            return toRemove;
        }


        public static TopoDSFace GetFace(SceneSelectedEntity reference)
        {
            if (reference == null)
                return null;
            var topoShape = ShapeUtils.ExtractSubShape(reference);
            if ((topoShape == null) || (topoShape.IsNull))
                return null;
            TopoDSFace face;
            try
            {
                if (topoShape.ShapeType != TopAbsShapeEnum.TopAbs_FACE)
                {
                    return null;
                }
                face = TopoDS.Face(topoShape);
            }
            catch (Exception)
            {
                return null;
            }
            return face;
        }

        public static void ClearDocumentHistory(Document document)
        {
            var steps = document.HistoryCount;
            for (var i = 0; i < steps; i++)
                document.Undo();
        }

        /// <summary>
        ///   Identifies the Node that contains a specified TopoDSShape
        /// </summary>
        public static SceneSelectedEntity IdentifyNode(Node rootLabel, TopoDSShape shape)
        {
            if ((shape == null) || (shape.IsNull))
            {
                return null;
            }

            foreach (var childLabel in rootLabel.Children.Values)
            {
                if (childLabel.Set<DrawingAttributesInterpreter>().Visibility == ObjectVisibility.Hidden)
                {
                    continue;
                }

                var shapeInterpter = childLabel.Get<TopoDsShapeInterpreter>();

                if (shapeInterpter == null)
                {
                    continue;
                }

                var ocafShape = shapeInterpter.Shape;
                if ((ocafShape == null) || (ocafShape.IsNull))
                {
                    continue;
                }

                // Compare the selected shape against the one from the OCAF tree and see if they are the same
                var entity = new SceneSelectedEntity();
                if (ocafShape.IsSame(shape))
                {
                    entity.Node = childLabel;
                    entity.ShapeType = ocafShape.ShapeType;
                    entity.ShapeCount = 1;
                    return entity;
                }

                var subshapeNumber = -1;
                var subshapeType = shape.ShapeType;
                // Try to find a face or an adge
                switch (subshapeType)
                {
                    case TopAbsShapeEnum.TopAbs_FACE:
                        subshapeNumber = DetectFace(ocafShape, shape);
                        break;
                    case TopAbsShapeEnum.TopAbs_EDGE:
                        subshapeNumber = DetectEdge(ocafShape, shape);
                        break;
                    case TopAbsShapeEnum.TopAbs_VERTEX:
                        subshapeNumber = DetectVertex(ocafShape, shape);
                        break;
                }
                if (subshapeNumber <= 0) continue;
                entity.Node = childLabel;
                entity.ShapeType = subshapeType;
                entity.ShapeCount = subshapeNumber;
                return entity;
            }

            return null;
        }


        /// <summary>
        ///   Makes a list will all the selected shapes. It looks into neutral and also open local context.
        /// </summary>
        public static List<AISInteractiveObject> GetAiSelectedShapes(AISInteractiveContext context)
        {
            var shapeList = new List<AISInteractiveObject>();

            // Search for a selected shape on the Main context
            context.InitCurrent();
            while ((context.MoreSelected) && (!context.HasOpenedContext)) 
            {
                var selectedInteractive = context.Current;
                shapeList.Add(selectedInteractive);

                context.NextCurrent();
            }
            return shapeList;
        }

        public static List<Point3D> SortAndCompactListPoints(IEnumerable<Point3D> points)
        {
            var dictionary = new SortedDictionary<Point3D, int>(new PointComparer());
            foreach (var actualPoint in points)
                dictionary[actualPoint] = 0;
            return new List<Point3D>(dictionary.Keys);
        }

        public static List<Point3D> CompactList(IEnumerable<Point3D> points)
        {
            var result = new List<Point3D>();
            foreach (var point3D in points)
            {
                var exists = false;
                foreach (var d in result)
                {
                    if (!point3D.IsEqual(d)) continue;
                    exists = true;
                    break;
                }
                if (!exists)
                    result.Add(point3D);
            }
            return result;
        }

        public static bool CheckShape(TopoDSShape shape)
        {
            try
            {
                var anAna = new BRepCheckAnalyzer(shape, true);
                return anAna.IsValid();
            }
            catch
            {
                return false;
            }
        }

        public static TopAbsState ClassifyPointVersusSolid(TopoDSShape solidShape, gpPnt point)
        {
            var classifier = new BRepClass3dSolidClassifier(solidShape);
            classifier.Perform(point, Precision.Confusion);
            return classifier.State;
        }

        public static TopoDSFace MakeFace(IEnumerable<TopoDSWire> wireList)
        {
            var mkWire = new BRepBuilderAPIMakeWire();
            foreach (var wire in wireList)
                mkWire.Add(wire);

            if (mkWire.IsDone)
            {
                var wireProfile = mkWire.Wire;
                if (!wireProfile.IsNull)
                {
                    var faceProfile = new BRepBuilderAPIMakeFace(wireProfile, false).Face;
                    if (!faceProfile.IsNull)
                    {
                        return faceProfile;
                    }
                }
            }

            return null;
        }

        public static TopoDSShape MakeCylinder(gpAx1 centerAxis, double radius, double height, double angle)
        {
            var axis = new gpAx2();
            axis.Axis = (centerAxis);
            var cylinderShape = new BRepPrimAPIMakeCylinder(axis, radius, height, angle);
            return cylinderShape.Shape;
        }

        public static TopoDSShape MakeCone(gpAx1 centerAxis, double radius1, double radius2, double height,
                                              double angle)
        {
            var axis = new gpAx2();
            axis.Axis=(centerAxis);
            var cylinderShape = new BRepPrimAPIMakeCone(axis, radius1, radius2, height, angle);
            return cylinderShape.Shape;
        }

        public static Point3D ExtractGravityCenter(TopoDSShape shape)
        {
            if (shape == null || shape.IsNull) return new Point3D();

            var props = new GPropGProps();
            var massCenter = new gpPnt(0, 0, 0);
            switch (shape.ShapeType)
            {
                case TopAbsShapeEnum.TopAbs_COMPOUND:
                case TopAbsShapeEnum.TopAbs_COMPSOLID:
                case TopAbsShapeEnum.TopAbs_SOLID:
                    BRepGProp.VolumeProperties(shape, props, false);
                    massCenter = props.CentreOfMass;
                    break;
                case TopAbsShapeEnum.TopAbs_FACE:
                case TopAbsShapeEnum.TopAbs_SHELL:
                    BRepGProp.SurfaceProperties(shape, props);
                    massCenter = props.CentreOfMass;
                    break;
                case TopAbsShapeEnum.TopAbs_WIRE:
                    BRepGProp.LinearProperties(shape, props);
                    massCenter = props.CentreOfMass;
                    break;
                case TopAbsShapeEnum.TopAbs_VERTEX:
                    {
                        var location = new gpPnt(0, 0, 0);
                        var finalLocation = location.Transformed(shape.Location().Transformation);
                        return new Point3D(finalLocation);
                    }
            }

            return new Point3D(massCenter);
        }

        public static double GetFaceArea(TopoDSShape shape)
        {
            var props = new GPropGProps();
            BRepGProp.SurfaceProperties(shape, props);
            var area = props.Mass;
            return area;
        }

        public static double GetSolidVolume(TopoDSShape shape)
        {
            var props = new GPropGProps();
            BRepGProp.VolumeProperties(shape, props, true);
            var volume = props.Mass;
            return volume;
        }

        public static TopoDSWire BuildLine(Point3D firstPoint, Point3D secondPoint)
        {
            var aEdge = new BRepBuilderAPIMakeEdge(firstPoint.GpPnt, secondPoint.GpPnt).Edge;
            return new BRepBuilderAPIMakeWire(aEdge).Wire;
        }




        /// <summary>
        ///   Trapezoid sample:
        ///   D ---- C
        ///   ------------
        ///   A ---D'-----C'---- B
        /// </summary>
        public static Point3D GetLastTrapezoidPoint(Point3D pointA, Point3D pointB, Point3D pointC)
        {
            if (pointA.IsEqual(pointB))
                return pointC;
            var cPointProjection = ProjectPointOnLine(pointA, new gpDir(new gpVec(pointA.GpPnt, pointB.GpPnt)),
                                                      pointC);
            if (cPointProjection == null)
                return new Point3D();
            var pointCPrime = cPointProjection.Value;
            // Make a C'B transformaiton and apply it on A to find out the D'
            var translation = BuildTranslation(pointCPrime, pointB);
            var pointDPrime = new Point3D(pointA.GpPnt.Transformed(translation));

            // Calculate the foruth rectangle verted: the D point
            var pointD = new gpPnt(0, 0, 0);
            CalculateRectangleVertexes(pointDPrime.GpPnt, pointCPrime.GpPnt, pointC.GpPnt, ref pointD);
            return new Point3D(pointD);
        }

        public static double BetweenValue(double a, double b, double theta)
        {
            return a*(1 - theta) + b*theta;
        }

        public static Point3D BetweenValue(Point3D a, Point3D b, double theta)
        {
            return new Point3D(
                BetweenValue(a.X, b.X, theta),
                BetweenValue(a.Y, b.Y, theta),
                BetweenValue(a.Z, b.Z, theta)
                );
        }

        public static Point3D GetParallelPointOnDistance(Point3D a, Point3D b, Point3D c, double distance)
        {
            var d = a.Distance(b);
            var scaleFactor = distance/d;
            var diffPoint = b.SubstractCoordinate(a);
            var betweenValue = BetweenValue(new Point3D(), diffPoint, scaleFactor);
            return c.AddCoordinate(betweenValue);
        }

        /// <summary>
        ///   Calculates the intersection point between two edges
        /// </summary>
        public static List<Point3D> IntersectionPoints(TopoDSEdge edge1, TopoDSEdge edge2)
        {
            var intersectionPoints = new List<Point3D>();
            if (edge1.IsSame(edge2))
                return intersectionPoints;

            var extrema = new BRepExtremaExtCC();
            extrema.Initialize(edge1);
            extrema.Perform(edge2);
            if (extrema.IsParallel)
                return intersectionPoints;
            if (!extrema.IsDone)
                return intersectionPoints;
            if (extrema.NbExt <= 0)
                return intersectionPoints;
            for (var index = 1; index <= extrema.NbExt; index++)
            {
                var point = new Point3D(extrema.PointOnE1(index));
                if (PointIsOnEdge(edge1, point))
                    intersectionPoints.Add(point);
            }

            return RemoveDuplicates(intersectionPoints);
        }

        private static List<Point3D> RemoveDuplicates(List<Point3D> pointslist)
        {
            var uniquePoints = new List<Point3D>();
            foreach(var point in pointslist)
            {
                if(!uniquePoints.Any(uniquePoint => uniquePoint.IsEqual(point)))
                    uniquePoints.Add(point);
            }
            return uniquePoints;
        }

        public static bool PointIsOnEdge(TopoDSEdge edge, Point3D point)
        {
            GeomCurve curve;
            double first = 0;
            double last = 0;
            //unsafe
            {
                 curve = BRepTool.Curve(edge, ref first,ref last);
            }
            ExtremaExtPC extrema2;

            try
            {
                var adaptor = new GeomAdaptorCurve(curve);
                extrema2 = new ExtremaExtPC(point.GpPnt, adaptor, Precision.Confusion);
            }
            catch (Exception)
            {
                return false;
            }

            if (!extrema2.IsDone) return false;
            if (extrema2.SquareDistance(1) < Precision.Confusion)
            {
                return true;
            }
            return false;
        }

        public static double LineSlope(Point3D P1, Point3D P2)
        {
            if (Math.Abs(P2.X - P1.X) > 0.0001)
                return (P2.Y - P1.Y) / (P2.X - P1.X);
            return double.PositiveInfinity;
        }

        public static double LineSlope(gpPnt2d p1, gpPnt2d p2)
        {
            if (Math.Abs(p2.X - p1.X) > 0.0001)
                return (p2.Y - p1.Y) / (p2.X - p1.X);
            return double.PositiveInfinity;
        }

        /// <summary>
        ///   Gets the U curve parameter of a point3D
        /// </summary>
        public static double? UParameter(BRepAdaptorCurve curve, TopLocLocation curveLocation, Point3D point)
        {
            var projection = new GeomAPIProjectPointOnCurve(point.GpPnt, curve.Curve.Curve);
            if (projection.NbPoints <= 0)
                return null;
            return projection.LowerDistanceParameter;
        }

        public static List<double> UParameter(BRepAdaptorCurve curve, TopLocLocation curveLocation,
                                              List<Point3D> points)
        {
            var uList = new List<double>();

            foreach (var point in points)
            {
                var uParam = UParameter(curve, curveLocation, point);
                if (uParam == null) continue;
                if (!uList.Contains(uParam.Value))
                    uList.Add(uParam.Value);
            }

            uList.Sort();
            return uList;
        }

        public static List<double> UParameterFill(BRepAdaptorCurve curve, TopLocLocation curveLocation,
                                              List<Point3D> points, Dictionary<double, Point3D> uvalueToPoint, double firstParameter, bool isCircle)
        {
          
            var uList = new List<double>();

            foreach (var point in points)
            {
                var uParam = UParameter(curve, curveLocation, point);
                if (uParam == null) continue;
                if (uParam.Value < firstParameter && Math.Abs(uParam.Value - firstParameter) > Precision.Confusion && !isCircle)
                    uParam += 2*Math.PI;
                if (!uList.Contains(uParam.Value))
                    uList.Add(uParam.Value);
                if(!uvalueToPoint.ContainsKey(uParam.Value))
                    uvalueToPoint.Add(uParam.Value, point);
            }

            uList.Sort();
            return uList;
        }


        public static List<Point3D> IntersectionSolutions(List<TopoDSEdge> trimmingEdge, TopoDSEdge edgeToTrim)
        {
            var intersectionList = new List<Point3D>();
            foreach (var edge in trimmingEdge)
            {
                var intersections = IntersectionPoints(edge, edgeToTrim);
                // any shapes that can be used to generate intersection solutions have less than 4 common points
                if(intersections.Count < 4)
                    foreach (var intersection in intersections)
                    {
                        if (!intersectionList.Any(intPoint => intPoint.Equals(intersection)))
                            intersectionList.Add(intersection);
                    }
            }
            return intersectionList;
        }

      
        public static List<TopoDSEdge> TrimGenericShape(List<TopoDSEdge> trimmingEdges, TopoDSEdge edgeToTrim,
                                               Point3D clickPoint)
        {
            var intersectionPoints = IntersectionSolutions(trimmingEdges, edgeToTrim);
            if (intersectionPoints.Count <= 0)
                return null;

            var curveToTrim = new BRepAdaptorCurve(edgeToTrim);
            var firstParameter = curveToTrim.FirstParameter;
            var lastParameter = curveToTrim.LastParameter;
            var curveLocation = edgeToTrim.Location();

            var intersectionSolutionsU = UParameter(curveToTrim, curveLocation, intersectionPoints);
            if (intersectionSolutionsU.Count <= 0)
                return null;

            if (!intersectionSolutionsU.Contains(firstParameter))
                intersectionSolutionsU.Add(firstParameter);
            if (!intersectionSolutionsU.Contains(lastParameter))
                intersectionSolutionsU.Add(lastParameter);

            if (intersectionSolutionsU.Count < 3)
                return null;

            intersectionSolutionsU.Sort();

            var clickU = UParameter(curveToTrim, curveLocation, clickPoint);
            if (clickU == null)
                return null;
            // TODO: Investigate if intervals can have negative values
            if (Math.Abs(clickU.Value - firstParameter) < Precision.Confusion)
                clickU += 2*Precision.Confusion;
            if (Math.Abs(clickU.Value - lastParameter) < Precision.Confusion)
                clickU -= 2*Precision.Confusion;

            var intervalList = DetectRemainingEdgesIntervals(intersectionSolutionsU, clickU);

            if (curveToTrim.GetType == GeomAbsCurveType.GeomAbs_Ellipse && intervalList.Count > 2
                && Math.Abs(intervalList[intervalList.Count - 1] - 2*Math.PI) < Precision.Confusion)
            {
                intervalList.RemoveAt(intervalList.Count - 1);
            }

            if (curveToTrim.GetType == GeomAbsCurveType.GeomAbs_Ellipse && intervalList.Count > 2
                && Math.Abs(intervalList[0]) < Precision.Confusion)
            {
                intervalList.RemoveAt(0);
            }

            var finalIntervalList = UnifyIntervals(intervalList);

            if(curveToTrim.GetType == GeomAbsCurveType.GeomAbs_Ellipse && finalIntervalList.Count==2 && clickU < finalIntervalList[1])
            {
                finalIntervalList.Reverse();
            }

            var edgesToReturn = new List<TopoDSEdge>();
            for (var i = 0; i < finalIntervalList.Count; i += 2)
            {
                var edgeToAdd =
                    new BRepBuilderAPIMakeEdge(curveToTrim.Curve.Curve, finalIntervalList[i],
                                                  finalIntervalList[i + 1]).Edge;
                edgesToReturn.Add(edgeToAdd);
            }
            return edgesToReturn;
        }

        public static List<double> DetectRemainingEdgesIntervals(List<double> intersectionSolutionsU, double? clickU)
        {
            var intervalList = new List<double>();
            for (var i = 1; i < intersectionSolutionsU.Count; i++)
            {
                var intervalStart = intersectionSolutionsU[i - 1];
                var intervalEnd = intersectionSolutionsU[i];

                if (((clickU.Value > intervalStart) && (clickU.Value < intervalEnd))) continue;
                intervalList.Add(intervalStart);
                intervalList.Add(intervalEnd);
            }
            return intervalList;
        }

        public static List<Point3D> TrimKnownShape(List<TopoDSEdge> trimmingEdges, SceneSelectedEntity wireToTrim,
                                               Point3D clickPoint)
        {
            var edgeToTrim = ExtractEdge(wireToTrim.TargetShape());
            var curveToTrim = new BRepAdaptorCurve(edgeToTrim);
            var curveLocation = edgeToTrim.Location();

            var firstParameter = curveToTrim.FirstParameter;
            var lastParameter = curveToTrim.LastParameter;

            // check if the curve is a circle
            bool isCircle = curveToTrim.GetType == GeomAbsCurveType.GeomAbs_Circle;

            // for circles, the first parameters is 0.0 and the last is 2*Math.PI
            if ((firstParameter > Precision.Confusion) ||
                        (Math.Abs(lastParameter - 2 * Math.PI) > Precision.Confusion))
            {
                isCircle = false;
            }

            if (isCircle)
                return TrimCircle(trimmingEdges, wireToTrim, clickPoint);

            var uvalueToPoint = new Dictionary<double, Point3D>();
            var intersectionPoints = IntersectionSolutions(trimmingEdges, edgeToTrim);
            if (intersectionPoints.Count == 0)
                return null;

            // transform the intersection points to their u-values
            // and save them in the uvalueToPoint list
            var intersectionSolutionsU = UParameterFill(curveToTrim, curveLocation, intersectionPoints, uvalueToPoint, firstParameter, isCircle);
            if (intersectionSolutionsU.Count == 0)
                return null;

            // convert the first and last parameters to their u-values for all shapes except circles
            
            Point3D? firstPoint = null;
            Point3D? secondPoint = null;
            if (!GetExtremasPoints(wireToTrim.Node, ref firstPoint, ref secondPoint))
                return null;

            if (firstPoint == null || secondPoint == null)
                return null;
            if (!uvalueToPoint.ContainsKey(firstParameter))
                uvalueToPoint.Add(firstParameter, firstPoint.Value);
            if (!uvalueToPoint.ContainsKey(lastParameter))
                uvalueToPoint.Add(lastParameter, secondPoint.Value);

            // make sure the first and last parameters are in the intersection solutions list
            if (!intersectionSolutionsU.Contains(firstParameter))
                intersectionSolutionsU.Add(firstParameter);
            if (!intersectionSolutionsU.Contains(lastParameter))
                intersectionSolutionsU.Add(lastParameter);

           // we should always have at least the first and last parameters and one intersection point
                if (intersectionSolutionsU.Count < 3)
                    return null;

            intersectionSolutionsU.Sort();

            for (int i = 0; i < intersectionSolutionsU.Count - 1; i++)
            {
                if (Math.Abs(intersectionSolutionsU[i] - intersectionSolutionsU[i + 1]) < 0.0001)
                {
                    intersectionSolutionsU.RemoveAt(i);
                }
            }
            
            // transform the mouse click to its uvalue and correct the value if it's to close to the extremities
            var clickU = UParameter(curveToTrim, curveLocation, clickPoint);
            if (clickU == null)
                return null;
            // TODO: Investigate if intervals can have negative values
            if (Math.Abs(clickU.Value - firstParameter) < Precision.Confusion)
                clickU += 2 * Precision.Confusion;
            if (Math.Abs(clickU.Value - lastParameter) < Precision.Confusion)
                clickU -= 2 * Precision.Confusion;

            if (clickU - firstParameter < Precision.Confusion)
                clickU += 2 * Math.PI;


            var intervalList = DetectRemainingEdgesIntervals(intersectionSolutionsU, clickU);

            var finalIntervalList = UnifyIntervals(intervalList);

            // create the points list corresponding to the finalIntervalList uvalues
            return finalIntervalList.Select(uvalue => uvalueToPoint[uvalue]).ToList();
        }

        private static List<Point3D> TrimCircle(List<TopoDSEdge> trimmingEdges, SceneSelectedEntity wireToTrim,
                                               Point3D clickPoint)
        {
            var pointsList = new List<Point3D>();
            var edgeToTrim = ExtractEdge(wireToTrim.TargetShape());
            var curveToTrim = new BRepAdaptorCurve(edgeToTrim);
            var curveLocation = edgeToTrim.Location();

            var uvalueToPoint = new Dictionary<double, Point3D>();
            var intersectionPoints = IntersectionSolutions(trimmingEdges, edgeToTrim);
            if (intersectionPoints.Count == 0)
                return null;
            // transform the intersection points to their u-values
            // and save them in the uvalueToPoint list
            var intersectionSolutionsU = UParameterFill(curveToTrim, curveLocation, intersectionPoints, uvalueToPoint, 0.0, true);
            if (intersectionSolutionsU.Count < 2)
                return null;
            // transform the mouse click to its uvalue and correct the value if it's to close to the extremities
            var clickU = UParameter(curveToTrim, curveLocation, clickPoint);

            intersectionSolutionsU.Sort();

            if (clickU < intersectionSolutionsU[0] || clickU > intersectionSolutionsU[intersectionSolutionsU.Count - 1])
            {
                pointsList.Add(uvalueToPoint[intersectionSolutionsU[0]]);
                pointsList.Add(uvalueToPoint[intersectionSolutionsU[intersectionSolutionsU.Count - 1]]);
            }
            else
            {
                for (int i = 1; i < intersectionSolutionsU.Count; i++)
                {
                    if (clickU > intersectionSolutionsU[i - 1] && clickU < intersectionSolutionsU[i])
                    {
                        pointsList.Add(uvalueToPoint[intersectionSolutionsU[i]]);
                        pointsList.Add(uvalueToPoint[intersectionSolutionsU[i - 1]]);
                        break;
                    }
                }
            }

            return pointsList;
        }

        /// <summary>
        ///   Receives an interval list and make Union on it
        ///   [0,1,1,2,2,3] => [0,3]
        /// </summary>
        public static List<double> UnifyIntervals(List<double> intervalList)
        {
            var finalIntervalList = new List<double>();
            foreach (var element in intervalList)
                finalIntervalList.Add(element);
         //   var final = finalIntervalList.Distinct().ToList();
            for (var i = 0; i < intervalList.Count - 1; i++)
            {
                if (Math.Abs(intervalList[i] - intervalList[i + 1]) < Precision.Confusion)
                {
                    if (intervalList.Count % 2 == 0)
                    { finalIntervalList.RemoveAll(val => (Math.Abs(val - intervalList[i]) < Precision.Confusion)); }
                    else
                    {
                        finalIntervalList.Remove(intervalList[i]);
                    }
                }
            }
            return finalIntervalList;
        }

        public static TopoDSVertex Vertex(Point3D point)
        {
            var builder = new BRepBuilder();
            var vertex = new TopoDSVertex();
            builder.MakeVertex(vertex, point.GpPnt, Precision.Confusion);
            return vertex;
        }

        /// <summary>
        ///   Recalculates point c so that ab and ac segments make an "angle" angle.
        ///   The angle is on radians.
        /// </summary>
        public static Point3D GetAnglePointPosition(Point3D b, Point3D a, Point3D c, double angle)
        {
            var vecAB = new gpVec(a.GpPnt, b.GpPnt);
            if (vecAB.Magnitude <= gp.Resolution)
            {
                return c;
            }

            var vecAC = new gpVec(a.GpPnt, c.GpPnt);
            if (vecAC.Magnitude <= gp.Resolution)
            {
                return c;
            }

            var initialAngle = vecAB.Angle(vecAC);
            var normalVector = vecAB.Crossed(vecAC);
            var rotationAxis = new gpAx1(a.GpPnt, new gpDir(normalVector));
            vecAC.Rotate(rotationAxis, angle - initialAngle);

            var transformation = new gpTrsf();
            transformation.SetTranslation(vecAC);
            return new Point3D(a.GpPnt.Transformed(transformation));
        }

        public static gpPnt ProjectPointOnArc(gpAx1 arcCenter, Point3D arcStart, Point3D arcEnd,
                                                 Point3D pointToProject, bool sense)
        {
            if (arcStart.IsEqual(arcEnd))
                return null;

            var arc = BuildArc(arcCenter, arcStart, arcEnd, sense);
            if (arc == null)
                return null;
            var geomCurve = new GeomAdaptorCurve(arc);
            var projection = ProjectPointOnCurve(geomCurve, pointToProject.GpPnt);
            return projection;
        }

        public static gpPnt ProjectPointOnCircle(Point3D circleCenter, Point3D pointOnCircle, Point3D pointToProject)
        {
            var centerAxis = new Axis(circleCenter, new Point3D(0,0,1));
            var centerCoord = new gpAx2();
            centerCoord.Axis = (centerAxis.GpAxis);
            var circle = new GeomCircle(centerCoord, centerCoord.Location.Distance(pointOnCircle.GpPnt));
           
            var geomCurve = new GeomAdaptorCurve(circle);
            var projection = ProjectPointOnCurve(geomCurve, pointToProject.GpPnt);
            return projection;
        }

        public static double GetPointAngle(Point3D point3D, Point3D point3D1, Point3D point3D2)
        {
            try
            {
                var v1 = new gpVec(point3D1.GpPnt, point3D.GpPnt);
                var v2 = new gpVec(point3D1.GpPnt, point3D2.GpPnt);
                if ((v1.Magnitude <= gp.Resolution) || (v2.Magnitude <= gp.Resolution))
                {
                    return 0;
                }
                return v1.Angle(v2);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        ///   Builds an circular arc having as center the centerAxis, as radius the distance from
        ///   center to the first point nd as second point the projection of the second parameter
        ///   point on the circle with the center in centerAxis and radius.
        /// </summary>
        public static TopoDSWire CreateArcWire(gpAx1 centerAxis, Point3D startPoint, Point3D endPoint, bool sense)
        {
            var finalArc = BuildArc(centerAxis, startPoint, endPoint, sense);
            if (finalArc == null)
                return null;
            var edge = new BRepBuilderAPIMakeEdge(finalArc).Edge;
            var wire = new BRepBuilderAPIMakeWire(edge).Wire;
            return wire;
        }

        public static void MakeGradient(string imageName, int imageWidth, int imageHeigth, Color upperColor,
                                        Color bottomColor)
        {
            try
            {
                if (File.Exists(imageName))
                {
                    File.Delete(imageName);
                }
                var gradientResult = new Bitmap(imageWidth, imageHeigth, PixelFormat.Format24bppRgb);
                var linearBrush = new LinearGradientBrush(new PointF(0, 0), new PointF(0, imageHeigth), upperColor,
                                                          bottomColor);
                var graphics = Graphics.FromImage(gradientResult);
                graphics.FillRectangle(linearBrush, 0, 0, imageWidth, imageHeigth);
                gradientResult.Save(imageName);
                graphics.Dispose();
            }
            catch
            {
                Log.Info("Gradient image failed to be created.");
            }
        }

        public static void MakeGradient(int imageWidth, int imageHeigth, Color upperColor, Color bottomColor)
        {
            MakeGradient("background.bmp", imageWidth, imageHeigth, upperColor, bottomColor);
        }

        public static void MakeGradient(string imageName, Color upperColor, Color bottomColor)
        {
            MakeGradient(imageName, 30, 180, upperColor, bottomColor);
        }

        #region Nested type: PointComparer

        public class PointComparer : IComparer<Point3D>
        {
            private static readonly double Confusion = Precision.Confusion;

            #region IComparer<Point3D> Members

            public int Compare(Point3D x, Point3D y)
            {
                if (x.IsEqual(y))
                    return 0;
                return IsGreater(x, y) ? 1 : -1;
            }

            #endregion

            private static bool IsInRange(double val1, double val2)
            {
                return Math.Abs(val2 - val1) < Confusion;
            }

            private static bool? RangeGreater(double valFrom, double valTo)
            {
                if (IsInRange(valFrom, valTo))
                    return null;
                return valFrom > valTo;
            }

            public static bool IsGreater(Point3D pointFrom, Point3D pointTo)
            {
                if (pointFrom.IsEqual(pointTo))
                    return false;
                var result = RangeGreater(pointFrom.X, pointTo.X);
                if (result != null)
                    return (bool) result;
                result = RangeGreater(pointFrom.Y, pointTo.Y);
                if (result != null)
                    return (bool) result;
                result = RangeGreater(pointFrom.Z, pointTo.Z);
                return result != null && (bool) result;
            }
        }

        #endregion


        /// <summary>
        /// Calculates the 2D coordinates for the center of the circumscribed circle 
        /// </summary>
        /// <param name="P1"></param>
        /// <param name="P2"></param>
        /// <param name="P3"></param>
        /// <returns></returns>
        public static gpPnt2d CircleCenter(gpPnt2d A, gpPnt2d B, gpPnt2d C)
        {
            var d = 2*(A.X*(B.Y - C.Y) + B.X*(C.Y - A.Y) + C.X*(A.Y - B.Y));
            var U = ((A.X * A.X + A.Y * A.Y) * (B.Y - C.Y) + (B.X * B.X + B.Y * B.Y) * (C.Y - A.Y) + (C.X * C.X + C.Y * C.Y) * (A.Y - B.Y)) / d;
            var V = ((A.X * A.X + A.Y * A.Y) * (C.X - B.X) + (B.X * B.X + B.Y * B.Y) * (A.X - C.X) + (C.X * C.X + C.Y * C.Y) * (B.X - A.X)) / d;
            return new gpPnt2d(U,V);
        }

        public static Point3D GetClosestPoint(List<Point3D> intersections, Point3D point3D)
        {
            var minDist = double.MaxValue;
            var closestPoint = new Point3D();
            foreach (var point in intersections)
            {
                var dist = point.GpPnt.SquareDistance(point3D.GpPnt);
                if (dist < minDist)
                {
                    minDist = dist;
                    closestPoint = point;
                }
            }
            return closestPoint;
        }

        public static string CleanName(string functionName)
        {
            var result = functionName;
            if (result.Contains("Function"))
               result = result.Replace("Function", string.Empty);
            return result;
        }
    }
}